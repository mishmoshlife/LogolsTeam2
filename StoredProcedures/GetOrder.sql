SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      Michele Wandrei
-- Create Date: 9/21/17
-- Description: Get Order 
-- Call:		
-- =============================================

CREATE PROCEDURE [Team2].[GetOrder]
(
	@order_id INT
)

AS
BEGIN

SELECT *
FROM Team2.[order]
WHERE order_id = @order_id

END

GO
