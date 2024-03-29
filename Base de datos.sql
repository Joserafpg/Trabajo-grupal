create database Proyecto_Grupal

use Proyecto_Grupal

/*Tabla Usuarios*/
create table Usuarios(
Id_Usuario int IDENTITY (1,1) PRIMARY KEY NOT NULL,
Empleado varchar (50) NOT NULL,
Usuario varchar (10),
Contraseņa varchar (10),

AgregarUSER bit,
ModificarUSER bit,
EliminarUSER bit,
ConsultarUSER bit,
/*Permisos para el formulario Cuentas x cobrar*/
AgregarCuentasCobrar bit, 
ModificarCuentascobrar bit,
ConsultarCuentasCobrar bit,
EliminarCuentasCobrar bit,
/*Permisos para el formulario Cuentas x pagar*/
AgregarCuentasPagar bit, 
ModificarCuentasPagar bit,
ConsultarCuentasPagar bit,
EliminarCuentasPagar bit,
/*Permisos para el formulario Facturas*/
AgregarFACTURA bit, 
ModificarFACTURA bit,
ConsultarFACTURA bit,
EliminarFACTURA bit,
/*Permisos para el formulario Clientes*/
AgregarCLIENTE bit,
ModificSarCLIENTES bit,
ConsultarCLIENTES bit,
EliminarCLIENTES bit, 
/*Permisos para el formulario Inventario*/
AgregarINVENTARIO bit,
ModificarINVENTARIO bit,
ConsultarINVENTARIO bit, 
EliminarINVENTARIO bit,

FormUser bit,
FormCuentasCobrar bit,
FormCuentasPagar bit,
FormFactura bit,
FormCliente bit,
FormInventario bit
)

/*Tabla Clientes*/
create table Clientes(
ID_Cliente int IDENTITY (1,1) NOT NULL PRIMARY KEY,
Nombre Varchar(15),
Apellido Varchar (50),
Direccion Varchar (50),
Telefono Varchar (50),
Correo varchar (30),
Fecha_de_ingreso datetime
)


/*Tabla NuevoInventario (materia prima)*/
create table NuevoInventario(
Codigo INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
Nombre_Mercancia Varchar (50),
Descripcion Varchar (50),
Tipo_Producto Varchar (50),
Unidad_Medida varchar (50),
Stock INT,
Inv_Minimo INT,
Precio_Compra decimal (38),
Fecha_Ingreso date,
)

/*Tabla MercanciaUtilizada*/
create table MercanciaUtilizada(
Id_Pantalon INT,
Id_Materiales INT,
Nombre varchar (50),
Descripcion varchar (50),
Medida varchar (50),
Precio decimal (38),
Cantidad INT,
SubTotal decimal (38),
)


/*tabla InvPantalones*/
create table InvPantalones(
Codigo INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
Nombre_Producto Varchar (50),
Size varchar (50),
Stock int,
Inv_Minimo varchar (50),
Precio decimal (38),
)

/*Tabla Empleados*/
create table Empleados(
Id_Empleados int IDENTITY (1,1) NOT NULL PRIMARY KEY,
Nombre_Completo varchar (50),
Cedula varchar (50),
Telefono varchar (20),
Direccion varchar (50),
Correo varchar (50),
Fecha_de_nacimiento date,
Masculino bit,
Femenino bit,
Fecha_de_ingreso date,
Sueldo varchar (50),
AFP varchar (50),
SFS varchar (50),
Puesto varchar (50),
)


/*Tabla factura (descripcion)*/
create table Detalles_Factura (
No_Factura INT NOT NULL,
Codigo INT, 
Producto varchar (50), 
Size varchar (50), 
Precio decimal (38), 
Cantidad int,
SubTotal decimal (38),
)

/*Tabla facturaTitulo*/
create table FacturaTittle(
Id_Factura INT IDENTITY (1,1) PRIMARY KEY,
Empleado varchar (50),
Cliente varchar (50),
Fecha datetime,
Total decimal (38),
)















/*Consultas*/
select * from InvPantalones
go

select * from Factura
go

select * from FacturaTittle
go



select * from MercanciaUtilizada
go

select * from InvPantalones
go

select * from NuevoInventario
go

select * from InvPantalones where Nombre_Producto = 'Pantalon Vaquero'



/*Consultas para el software*/

select Tipo_Producto from NuevoInventario

select * from Empleados
SELECT ID_Cliente, Nombre, Apellido, Direccion, Telefono, Correo,Fecha_de_Ingreso FROM Clientes where Nombre like '%{0}%' and Telefono like '%{1}%'

SELECT Stock FROM InvPantalones WHERE Nombre_Producto = @Producto

SELECT TOP 1 Stock FROM InvPantalones ORDER BY Stock DESC

SELECT  Codigo, Nombre_Producto, Size, Stock, Inv_Minimo, Precio FROM InvPantalones

SELECT Empleado, Cliente, Fecha, Total FROM FacturaTittle where Id_Factura like '1' 

SELECT * from Factura where No_Factura = '1'

SELECT * from FacturaTittle where Id_Factura = '2'

select Codigo, Producto, Size, Precio,Cantidad,SubTotal from Factura where No_Factura = 10;


select * from InvPantalones where Nombre_Producto = @nombrexdd





/*Procecimientos para el software*/
CREATE PROCEDURE SP_EMPLEADOCOMBOBOX
AS
SELECT Nombre_Completo FROM Empleados
go

EXEC SP_EMPLEADOCOMBOBOX
GO


CREATE PROCEDURE VALORDEMATERIAPRIMA
AS
SELECT SUM(Stock * Precio_Compra) AS TotalMultiplicacion FROM NuevoInventario;

EXEC VALORDEMATERIAPRIMA
GO

CREATE PROCEDURE VALORDEINVENTARIOPANTS
AS
SELECT SUM(Stock * Precio) AS TotalMultiplicacion FROM InvPantalones;

EXEC VALORDEINVENTARIOPANTS
GO


/*Drops*/

drop table Factura
GO

drop table FacturaTittle
GO

drop table MercanciaUtilizada
GO

drop table NuevoInventario
GO

drop database Proyecto_Grupal
