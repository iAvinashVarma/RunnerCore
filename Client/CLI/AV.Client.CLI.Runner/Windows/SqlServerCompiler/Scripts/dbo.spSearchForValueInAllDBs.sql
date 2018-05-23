--	STORED PROCEDURE
--		dbo.spSearchForValueInAllDBs
--
--	SYNOPSIS
--		To search a value in all columns, in all tables and in all databases (apart from tempDB, Model and MSDB, these can be modified at Line 30)
--
--	PARAMETERS
--		@inputValueToSearch (Mandatory)
--			* Pass string to search in all databases.
--
--	AUTHORS
--		Avinash Varma Kalidindi
--
--	Tested On
---		SQL Server 2012, SQL Server 2014

SET ANSI_NULLS ON;
GO

SET QUOTED_IDENTIFIER OFF;
GO

IF EXISTS
(
	SELECT [name]
	FROM sys.objects
	WHERE object_id = OBJECT_ID(N'[dbo].[spSearchForValueInAllDBs]') AND 
		  type IN( N'P', N'PC' )
)
BEGIN
	DROP PROC dbo.spSearchForValueInAllDBs;
END;
GO

CREATE PROC dbo.spSearchForValueInAllDBs(
	   @inputValueToSearch sql_variant)
AS
BEGIN
	BEGIN
		BEGIN TRY
			DECLARE @searchInAllDBs nvarchar(100)= 'IF ''?''  NOT IN (''tempDB'',''model'',''msdb'')
		EXEC '+CAST(DB_NAME() AS nvarchar(255))+'.dbo.spSearchForValue "'+CAST(@inputValueToSearch AS nvarchar(255))+'","?"';

			EXEC SP_MSFOREACHDB @searchInAllDBs;
		END TRY
		BEGIN CATCH
			-- Execute error retrieval routine.  
			EXECUTE dbo.spGetErrorInfo;
		END CATCH;
	END;
END;
GO

PRINT 'Stored procedure compiled in "'+CAST(DB_NAME() AS nvarchar(255))+'" DATABASE.';
GO