La presente prueba técnica la trabaje con C# 13 y .NET 8.0.3, también para el modelado de datos utilicé Entity Framework. El challengue consisitía en: 

Básicamente la idea es crear una API para mantener una tabla de clientes (ABM de Clientes).  
Los campos son los siguientes:
ID (numérico)
Nombres (alfanumérico)
Apellidos (alfanumérico)
Fecha de nacimiento (fecha)
CUIT (alfanumérico)
Domicilio (alfanumérico)
Teléfono celular (alfanumérico)
Email (alfanumérico)

Para esto se pide que crees una tabla en una base de datos. Los nombres exactos de las columnas serán definidas por vos mismo, al igual que los parámetros de entrada y salida de los métodos de la API.
Se puede usar cualquier motor de base de datos relacional: MS SQL Server, MySQL, PostgreSQL, 
etc... Se tiene que desarrollar la API en el estilo API REST, la cual debe correr en un servidor HTTP. Puede ser en cualquier versión de .Net. o bien en PHP, NodeJS, etc. Los puntos a desarrollar son los siguientes:

1. Crear la tabla y cargar algunos datos de prueba
2. Crear la API y resolver la conexión a la base de datos
3. Implementar los siguientes métodos:

a. GetAll. Obtiene todos los registros de la tabla.
b. Get (ID). Obtiene un registro correspondiente al ID
c. Search. Búsqueda por nombre (caracteres centrales)
d. Insert. Crea un registro nuevo
e. Update. Actualiza un registro

Los endpoints se ejecutarán desde un cliente tipo PostMan, Insomnia o similar.
Extras: Validar la unicidad del campo ID Validar los datos
o Nombres, apellidos, CUIT, teléfono celular, email -> que sean obligatorios
o Que Fecha de nacimiento, Email y CUIT estén correctamente formateados Cualquier mejora propuesta siempre es bienvenida y suma a la evaluación de este challenge. 
Ejemplos:o Registrar un log de errores que se produzcano Realizar alguna documentación detallando el funcionamiento de la API



