SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      Michele Wandrei
-- Create Date: 9/21/17
-- Description: Get Order Items
-- Call:		
-- =============================================

CREATE PROCEDURE [Team2].[GetOrderItems]
(
	@order_id INT
)

AS
BEGIN

SELECT order_item_id, product_id, quantity, item_price_total
FROM Team2.order_item
WHERE order_id = @order_id
ORDER BY order_item_id asc

END

GO
