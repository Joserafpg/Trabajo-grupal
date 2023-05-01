create database Proyecto_Grupal

use Proyecto_Grupal

/*Tabla Usuarios*/
create table Usuarios(
Id_Usuario int IDENTITY (1,1) PRIMARY KEY NOT NULL,
Empleado varchar (20) NOT NULL,
Usuario varchar (10),
Contraseņa varchar (10),
FormUsuarios bit,
AgregarUSER bit,
ModificarUSER bit,
EliminarUSER bit,
ConsultarUSER bit,

/*Permisos para el formulario Cuentas x cobrar*/
FormCuentasCobrar bit,
AgregarCuentasCobrar bit, 
ModificarCuentascobrar bit,
ConsultarCuentasCobrar bit,
EliminarCuentasCobrar bit,

/*Permisos para el formulario Cuentas x pagar*/
FormCuentasPagar bit,
AgregarCuentasPagar bit, 
ModificarCuentasPagar bit,
ConsultarCuentasPagar bit,
EliminarCuentasPagar bit,

/*Permisos para el formulario Facturas*/
FormFacturas bit,
AgregarFACTURA bit, 
ModificarFACTURA bit,
ConsultarFACTURA bit,
EliminarFACTURA bit,

/*Permisos para el formulario Clientes*/
FormCliente bit,
AgregarCLIENTE bit,
ModificSarCLIENTES bit,
ConsultarCLIENTES bit,
EliminarCLIENTES bit, 

/*Permisos para el formulario Inventario*/
FormInventario bit,
AgregarINVENTARIO bit,
ModificarINVENTARIO bit,
ConsultarINVENTARIO bit, 
EliminarINVENTARI bit,

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




drop table Clientes