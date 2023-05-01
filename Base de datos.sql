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


select * from Usuarios

drop table Usuarios