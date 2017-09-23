SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      Michele Wandrei
-- Create Date: 9/21/17
-- Description: Get All Payment Types 
-- Call:		
-- =============================================

CREATE PROCEDURE [Team2].[GetAllPaymentTypes]


AS
BEGIN

SELECT payment_type
FROM Team2.payment_type
ORDER BY payment_type_id asc

END

GO
