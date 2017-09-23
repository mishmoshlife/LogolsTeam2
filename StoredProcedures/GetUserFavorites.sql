SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      Michele Wandrei
-- Create Date: 9/21/17
-- Description: Get User Favorite Products 
-- Call:		
-- =============================================

CREATE PROCEDURE [Team2].[GetUserFavorites]
	@user_id INT

AS
BEGIN

SELECT p.product_id,
	   p.product_name,
	   p.[description],
	   p.imagefile,
	   p.price
FROM user_favorite uf 
INNER JOIN product p
ON uf.product_id = p.product_id
ORDER BY p.product_id asc

END

GO
