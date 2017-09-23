SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      Michele Wandrei
-- Create Date: 9/21/17
-- Description: Return all ingredients for a product
-- Call:		
-- =============================================

CREATE PROCEDURE [Team2].[GetProductIngredients]
	@product_id int = 0

AS
BEGIN

SELECT p.quantity, i.ingredient_name
FROM Team2.product_ingredient p
INNER JOIN Team2.ingredient i
ON p.ingredient_id = i.ingredient_id
WHERE p.product_id = @product_id

END

GO
