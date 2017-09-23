SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      Michele Wandrei
-- Create Date: 9/21/17
-- Description: Get User
-- Call:		
-- =============================================

CREATE PROCEDURE [Team2].[GetUser]
(
	@user_id INT 
)

AS
BEGIN

SELECT *
FROM Team2.[user]
WHERE user_id = @user_id
	  

END

GO
