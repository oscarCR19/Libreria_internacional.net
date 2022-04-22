use LibreriaInternacional

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE spObtenerUsuarios 
	-- 
AS
BEGIN
	SELECT * FROM dbo.Usuarios
END
GO
