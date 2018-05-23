--	STORED PROCEDURE
--		dbo.spSearchForValue
--
--	SYNOPSIS
--		To search a value in all columns, in all tables and in a specific database.
--
--	PARAMETERS
--		@inputValueToSearch (Mandatory)
--			* Pass string to search in current context database or in given database.
--		@currentDatabaseName (Optional)
--			* Pass database name.
--	AUTHORS
--		* Manoj Varma Chekuri
--		* Avinash Varma Kalidindi
--
--	Tested On
--		SQL Server 2012, SQL Server 2014

SET ANSI_NULLS ON;
GO

SET QUOTED_IDENTIFIER OFF;
GO

IF EXISTS
(
	SELECT [name]
	FROM sys.objects
	WHERE object_id = OBJECT_ID(N'[dbo].[spSearchForValue]') AND 
		  type IN( N'P', N'PC' )
)
BEGIN
	DROP PROC dbo.spSearchForValue;
END;
GO

CREATE PROC dbo.spSearchForValue(
	   @inputValueToSearch sql_variant, @currentDatabaseName nvarchar(128)= NULL, @Debug bit= 0)
AS
BEGIN
	BEGIN TRY
		IF( @currentDatabaseName IS NULL
		  )
		BEGIN
			SET @currentDatabaseName = CAST(DB_NAME() AS nvarchar(128));
		END;
		IF( EXISTS
		  (
			  SELECT name
			  FROM SYS.DATABASES
			  WHERE( '['+name+']' = @currentDatabaseName OR 
					 name = @currentDatabaseName
				   )
		  )
		  )
		BEGIN
			SET NOCOUNT ON;
			CREATE TABLE #tempTableSearchInfo
			( 
						 Search# int IDENTITY, DatabaseName nvarchar(128), TableName nvarchar(128), ColumnName nvarchar(128), Value nvarchar(255)
			);

			BEGIN
				DECLARE @tempTableName nvarchar(128), @tempColumnName nvarchar(128);
				DECLARE @resultValue sql_variant, @queryFirst nvarchar(400), @queryTemp nvarchar(400), @queryCursorFirst nvarchar(400), @queryCursor nvarchar(400);
				DECLARE @cursorColumnName cursor, @cursorColumnValue cursor;

				BEGIN TRY
					SET @queryFirst = 'SELECT COLUMN_NAME, Table_Name FROM ['+@currentDatabaseName+'].INFORMATION_SCHEMA.COLUMNS';
					SET @queryCursorFirst = 'SET @cursor = CURSOR FORWARD_ONLY STATIC FOR '+@queryFirst+' OPEN @cursor;';

					EXEC SYS.SP_EXECUTESQL @queryCursorFirst, N'@cursor CURSOR OUTPUT', @cursorColumnName OUTPUT;

					FETCH NEXT FROM @cursorColumnName INTO @tempColumnName, @tempTableName;
					WHILE @@FETCH_STATUS = 0
					BEGIN
						SET @queryTemp = 'SELECT '+@tempColumnName+' FROM ['+@currentDatabaseName+'].dbo.['+@tempTableName+']';
						SET @queryCursor = 'SET @cursor = CURSOR FORWARD_ONLY STATIC FOR '+@queryTemp+' OPEN @cursor;';

						EXEC SYS.SP_EXECUTESQL @queryCursor, N'@cursor CURSOR OUTPUT', @cursorColumnValue OUTPUT;
						FETCH NEXT FROM @cursorColumnValue INTO @resultValue;

						WHILE @@FETCH_STATUS = 0
						BEGIN
							IF CHARINDEX(CAST(@inputValueToSearch AS nvarchar(255)), CAST(@resultValue AS nvarchar(255))) > 0
							BEGIN
								INSERT INTO #tempTableSearchInfo
								VALUES( @currentDatabaseName, @tempTableName, @tempColumnName, CAST(@resultValue AS nvarchar(255)) );
							END;
							FETCH NEXT FROM @cursorColumnValue INTO @resultValue;
						END;

						CLOSE @cursorColumnValue;
						DEALLOCATE @cursorColumnValue;
						FETCH NEXT FROM @cursorColumnName INTO @tempColumnName, @tempTableName;
					END;

					CLOSE @cursorColumnName;
					DEALLOCATE @cursorColumnName;
				END TRY
				BEGIN CATCH
					PRINT 'Error while fetching information from "'+@currentDatabaseName+'" database';
					DECLARE @errorMessage nvarchar(128)= ERROR_MESSAGE(), @errorSeverity int= ERROR_SEVERITY(), @errorState int= ERROR_STATE();
					RAISERROR(@errorMessage, 10, 1);
				END CATCH;
			END;

			IF
			(
				SELECT COUNT(*)
				FROM #tempTableSearchInfo
			) > 0
			BEGIN
				SELECT *
				FROM #tempTableSearchInfo;
			END;
			ELSE
			BEGIN
				PRINT 'Given value "'+CAST(@inputValueToSearch AS nvarchar(255))+'" is not available in "'+@currentDatabaseName+'" database.';
			END;
			SET NOCOUNT OFF;
		END;
		ELSE
		BEGIN
			PRINT 'Database with name "'+@currentDatabaseName+'" is not available in server "'+@@SERVERNAME+'"';
		END;
	END TRY
	BEGIN CATCH
		-- Execute error retrieval routine.  
		EXECUTE dbo.spGetErrorInfo;
	END CATCH;
END;
GO

PRINT 'Stored procedure compiled in "'+CAST(DB_NAME() AS nvarchar(255))+'" DATABASE.';
GO