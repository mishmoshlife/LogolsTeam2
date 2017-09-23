SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      Michele Wandrei
-- Create Date: 9/21/17
-- Description: Add a User Favorite Product
-- Call:		
-- =============================================

CREATE PROCEDURE [Team2].[AddUserFavorite]
(
	@user_id INT,
	@product_id INT 
)

AS
BEGIN

INSERT INTO Team2.user_favorite(user_id, product_id)
VALUES(@user_id, @product_id)
	  

END

GO
