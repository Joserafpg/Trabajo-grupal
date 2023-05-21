use Proyecto_Grupal

CREATE PROCEDURE busquedaClienteFacturaPrueba
    @numFact VARCHAR(15)
AS
BEGIN
    SELECT
        ft.Empleado, ft.Cliente, ft.Fecha, ft.Total,
        f.Codigo, f.Producto, f.Size, f.Precio, f.Cantidad, f.SubTotal
    FROM
        FacturaTittle ft
    INNER JOIN
        Factura f ON ft.Id_Factura = f.No_Factura
    WHERE
        ft.Id_Factura LIKE @numFact
END
go

create proc busquedaDetallePrueba
@numFact varchar(15)
 as select Codigo, Producto,  Size, Precio, Cantidad, Total from Factura where No_Factura like @numFact 




 drop proc busquedaClienteFacturaPrueba
 drop proc busquedaDetallePrueba
 drop proc busquedaClienteFacturaPrueba