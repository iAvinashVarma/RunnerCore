SET ANSI_NULLS ON;
GO

SET QUOTED_IDENTIFIER OFF;
GO

-- Verify that the stored procedure does not already exist.  


IF EXISTS
(
	SELECT *
	FROM sys.objects
	WHERE object_id = OBJECT_ID(N'[dbo].[spGetErrorInfo]') AND 
		  type IN( N'P', N'PC' )
)
BEGIN
	DROP PROCEDURE dbo.spGetErrorInfo;
END;
GO
  
-- Create procedure to retrieve error information.  


CREATE PROCEDURE dbo.spGetErrorInfo
AS
BEGIN
	SELECT ERROR_NUMBER() AS ErrorNumber, ERROR_SEVERITY() AS ErrorSeverity, ERROR_STATE() AS ErrorState, ERROR_PROCEDURE() AS ErrorProcedure, ERROR_LINE() AS ErrorLine, ERROR_MESSAGE() AS ErrorMessage;
END;  
GO