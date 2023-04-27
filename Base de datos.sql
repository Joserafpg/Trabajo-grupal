create database Proyecto_Grupal

use Proyecto_Grupal

/*Tabla Usuarios*/
create table Usuarios(
Id_Usuario int IDENTITY (1,1) PRIMARY KEY NOT NULL,
Empleado varchar (20) NOT NULL,
Usuario varchar (10),
Contraseña varchar (10),
AgregarUSER bit,
ModificarUSER bit,
EliminarUSER bit,
ConsultarUSER bit,

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
AgregarINVENTARIO bit,
ConsultarINVENTARIO bit, 
EliminarINVENTARI bit,

)