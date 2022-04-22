use LibreriaInternacional
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE spIngresarUsuario 
	-- Add the parameters for the stored procedure here
	@user varchar,
	@passw varchar,
	@email varchar
AS
BEGIN
	INSERT INTO dbo.Usuarios(usuario,passw,email) values(
	@user,@passw,@email);
END
GO
