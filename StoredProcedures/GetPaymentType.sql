SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      Michele Wandrei
-- Create Date: 9/21/17
-- Description: Get Payment Type 
-- Call:		
-- =============================================

CREATE PROCEDURE [Team2].[GetPaymentType]
(
	@payment_type_id INT
)

AS
BEGIN

SELECT payment_type
FROM Team2.payment_type
WHERE payment_type_id = @payment_type_id

END

GO
