SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      Michele Wandrei
-- Create Date: 9/21/17
-- Description: Get Product Detail
-- Call:		
-- =============================================

CREATE PROCEDURE [Team2].[GetProduct]
	@product_id int	

AS
BEGIN

SELECT product_id,
	   product_name,
	   [description],
	   imagefile,
	   price
FROM Team2.product
WHERE product_id = @product_id

END

GO
