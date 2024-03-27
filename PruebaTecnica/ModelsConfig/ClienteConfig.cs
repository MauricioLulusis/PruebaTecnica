using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PruebaTecnica.Models;

namespace WebApiClientes.ModelConfig
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("TB_Cliente");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nombres)
                .IsRequired().
                HasMaxLength(50);

            builder.Property(x => x.Apellidos)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.FechaNacimiento);

            builder.Property(x => x.CUIT)
                .IsRequired()
                .HasMaxLength(13);

            builder.Property(x => x.TelefonoCelular)
                .IsRequired()
            .HasMaxLength(15);

            builder.Property(x => x.Email)
                .IsRequired();
        }
        public static Cliente[] SeedData() => [
            new Cliente()
            {
                Id=1,
                Nombres="Mauricio Nicolás",
                Apellidos= "Lulusis",
                FechaNacimiento= new  DateTime(1999, 6, 1),
                CUIT= "20-41936341-4",
                TelefonoCelular = "3764160290",
                Email="mauricio.lulusis99@gmail.com",
                Domicilio="Calle Sata Catalina 3331"

            },
            new Cliente()
            {
                Id=2,
                Nombres="Nicolas Sebastian",
                Apellidos= "Lopez",
                FechaNacimiento= new DateTime(2004, 12, 27),
                CUIT= "20-45935312-4",
                TelefonoCelular = "376180269",
                Email="nicolas.sebastian@hotmail.com",
                Domicilio="Itaembe Mini 223"
            },
            new Cliente()
            {
                Id=3,
                Nombres="Lucas Rodrigo",
                Apellidos= "Perez",
                FechaNacimiento= new DateTime(2006, 2, 6),
                CUIT= "20-43567034-4",
                TelefonoCelular = "3764120590",
                Email="sebasRodrigo@gmail.com",
                Domicilio="Rivadavia 2332"
            },
            new Cliente()
            {
                Id=4,
                Nombres="Miriam Cristina",
                Apellidos= "Correa",
                FechaNacimiento= new DateTime(1970, 9, 18),
                CUIT= "24-24686668-9",
                TelefonoCelular = "3764178907",
                Email="misamores801@gmail.com",
                Domicilio="Santa Fe 2233"
            },
            new Cliente()
            {
                Id=5,
                Nombres="Martin ",
                Apellidos= "Correa",
                FechaNacimiento= new DateTime(1970,2,12),
                CUIT= "24-37905890-9",
                TelefonoCelular = "3764848435",
                Email="martincorrea899012@gmail.com",
                Domicilio="Centanerio y Monteagudo 2222"

            },
        ];
    }
}