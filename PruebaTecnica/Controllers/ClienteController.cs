﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Context;
using PruebaTecnica.Models;
using PruebaTecnica.Validadores;

namespace WebApiClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClienteController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            return await _context.Clientes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetCliente(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCliente(int id, Cliente cliente)
        {
            if (!ValidateEmail.Validate(cliente.Email))
            {
                return BadRequest("La dirección de correo electrónico proporcionada no es válida.");
            }

            if (!ValidateCUIT.Validate(cliente.CUIT))
            {
                return BadRequest("El CUIT proporcionado no es válido.");
            }
            if (id != cliente.Id)
            {
                return BadRequest();
            }
            _context.Entry(cliente).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClienteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Cliente>> PostCliente(Cliente cliente)
        {
            if (!ValidateEmail.Validate(cliente.Email))
            {
                return BadRequest("La dirección de correo electrónico proporcionada no es válida.");
            }
            if (!ValidateCUIT.Validate(cliente.CUIT))
            {
                return BadRequest("El CUIT proporcionado no es válido.");
            }
            if (ClienteExists(cliente.Id))
            {
                return Conflict("Ya existe un cliente con el mismo ID.");
            }
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetCliente", new { id = cliente.Id }, cliente);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        private bool ClienteExists(int id)
        {
            return _context.Clientes.Any(e => e.Id == id);
        }
        [HttpGet("Buscar")]
        public async Task<ActionResult<IEnumerable<Cliente>>> BuscarClientes(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return BadRequest("La búsqueda no puede estar vacía.");
            }
            var clientes = await _context.Clientes
                                         .Where(c => c.Nombres.Contains(searchTerm))
                                         .ToListAsync();
            return clientes;
        }
    }
}