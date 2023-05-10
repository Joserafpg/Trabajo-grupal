create database Proyecto_Grupal

use Proyecto_Grupal

/*Tabla Usuarios*/
create table Usuarios(
Id_Usuario int IDENTITY (1,1) PRIMARY KEY NOT NULL,
Empleado varchar (50) NOT NULL,
Usuario varchar (10),
Contraseña varchar (10),

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


/*Tabla NuevoInventario*/
create table NuevoInventario(
Codigo int IDENTITY NOT NULL PRIMARY KEY,
Nombre_Mercancia Varchar (50),
Descripcion Varchar (50),
Tipo_Producto Varchar (50),
Docenas bit,
Unidad bit,
Lotes bit,
Cantidad int,
Inv_Minimo int,
Color_Producto Varchar (50),
Precio_Compra varchar (50)
)


/*tabla InvPantalones*/
create table InvPantalones(
Codigo int IDENTITY NOT NULL PRIMARY KEY,
Nombre_Producto Varchar (50),
Descripcion Varchar (50),
Cantidad int,
Inv_Minimo int,
Mercancia_Utilizada varchar (50),
Precio_Venta varchar (50),
Precio_PorMayor varchar (50)
)


select * from Usuarios

drop table Usuarios

drop database Proyecto_Grupal
