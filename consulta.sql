use Proyecto_Grupal

create proc busquedaClienteFacturaPrueba
@numFact varchar(15)
as select Empleado, Cliente, Fecha, Total from FacturaTittle where Id_Factura like @numFact 

go

create proc busquedaDetallePrueba
@numFact varchar(15)
 as select Codigo, Producto,  Size, Precio, Cantidad, Total from Factura where No_Factura like @numFact 




 drop proc busquedaClienteFacturaPrueba
 drop proc busquedaDetallePrueba
 drop proc busquedaClienteFacturaPrueba