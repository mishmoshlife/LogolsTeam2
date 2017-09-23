SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      Michele Wandrei
-- Create Date: 9/21/17
-- Description: Add a User
-- Call:		
-- =============================================

CREATE PROCEDURE [Team2].[AddUser]
(
	@username VARCHAR(40),
	@password VARCHAR(40),
	@first_name VARCHAR(30),
	@last_name VARCHAR(30),
	@email VARCHAR(100),
	@phone VARCHAR(20),
	@date_created DATE 
)

AS
BEGIN

INSERT INTO Team2.[user] (username, [password], first_name, last_name, email, phone, date_created)
VALUES(@username, @password, @first_name, @last_name, @email, @phone, @date_created)
	  

END

GO
