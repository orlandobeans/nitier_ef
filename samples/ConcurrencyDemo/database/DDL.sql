
-- Concurrency value 'Key' generated by application (see interceptor in data service)
CREATE TABLE [dbo].[ARecord](
    [Id] [bigint] IDENTITY(1,1) NOT NULL,
    [Value] [varchar](50) NOT NULL,
    [Key] [uniqueidentifier] NOT NULL,
    [ChangedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ARecord] PRIMARY KEY ([Id])
)
GO

-- Concurrency value 'Key' generated by database table trigger (default value on insert, trigger on update)
CREATE TABLE [dbo].[BRecord](
    [Id] [bigint] IDENTITY(1,1) NOT NULL,
    [Value] [varchar](50) NOT NULL,
    [Key] [uniqueidentifier] NOT NULL DEFAULT (NEWID()),
    [ChangedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_BRecord] PRIMARY KEY ([Id])
)
GO
CREATE TRIGGER tr_BRecord_UPDATE ON [dbo].[BRecord]
FOR UPDATE 
AS
  UPDATE r
  SET    r.[Key] = NEWID()
  FROM   [dbo].[BRecord] r INNER JOIN inserted u ON r.[Id] = u.[Id]
GO

-- Concurrency value 'Key' generated by database stored procedures
CREATE TABLE [dbo].[CRecord](
    [Id] [bigint] IDENTITY(1,1) NOT NULL,
    [Value] [varchar](50) NOT NULL,
    [Key] [uniqueidentifier] NOT NULL,
    [ChangedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_CRecord] PRIMARY KEY ([Id])
)
GO
CREATE VIEW [dbo].[CRecord_View]
AS
    SELECT [Id], [Value], [Key], [ChangedDate]
    FROM   [dbo].[CRecord]
GO
CREATE PROCEDURE [dbo].[CRecord_Insert] 
    @Value [varchar](50), 
    @ChangedDate [datetime]
AS 
BEGIN
    INSERT INTO [dbo].[CRecord] ([Value], [Key], [ChangedDate])
    VALUES (@Value, NEWID(), @ChangedDate)

    SELECT [Id], [Key]
    FROM   [dbo].[CRecord]
    WHERE  [Id] = SCOPE_IDENTITY()
END 
GO
CREATE PROCEDURE [dbo].[CRecord_Update]
    @Id [bigint], 
    @Value [varchar](50), 
    @ChangedDate [datetime],
    @Key [uniqueidentifier]
AS 
BEGIN
    UPDATE [dbo].[CRecord] 
    SET    [Value] = @Value, 
           [Key] = NEWID(), 
           [ChangedDate] = @ChangedDate
    WHERE  [Id] = @Id AND [Key] = @Key
    
    SELECT [Key]
    FROM   [dbo].[CRecord]
    WHERE  [Id] = @Id
END 
GO
CREATE PROCEDURE [dbo].[CRecord_Delete]
    @Id [bigint]
AS 
BEGIN
    DELETE FROM [dbo].[CRecord] 
    WHERE  [Id] = @Id
END 
GO
