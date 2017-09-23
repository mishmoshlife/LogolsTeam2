SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      Michele Wandrei
-- Create Date: 9/21/17
-- Description: Create an Order
-- Call:		
-- =============================================

CREATE PROCEDURE [Team2].[addOrder]
(
	@order_date DATETIME2,
	@user_id INT 
)

AS
BEGIN

INSERT INTO Team2.[order] (order_date, user_id)
VALUES (@order_date, @user_id)
	  

END

GO
