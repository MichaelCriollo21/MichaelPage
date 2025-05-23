CREATE PROCEDURE sp_createProductos
	@NombreProducto [varchar](50),
	@ImagenProducto [image],
	@PrecioUnitario [decimal](18, 2),
	@Ext [varchar](5)
	AS
BEGIN
    INSERT INTO [CatProductos] (NombreProducto,ImagenProducto,PrecioUnitario,ext)
    VALUES (@NombreProducto, @ImagenProducto,@PrecioUnitario, @Ext);	
END								
GO