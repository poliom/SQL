USE [SQLMTD]
GO
/****** Object:  Table [dbo].[VehicleType]    Script Date: 05/22/2014 14:28:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_VehicleType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserStatus]    Script Date: 05/22/2014 14:28:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_UserStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 05/22/2014 14:28:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RegistrationNumbers]    Script Date: 05/22/2014 14:28:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegistrationNumbers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](8) NOT NULL,
 CONSTRAINT [PK_RegistrationNumbers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_RegistrationNumbers] UNIQUE NONCLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manifactures]    Script Date: 05/22/2014 14:28:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manifactures](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Manifactures] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Log]    Script Date: 05/22/2014 14:28:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Log](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TableName] [nvarchar](50) NOT NULL,
	[ActionName] [nvarchar](50) NOT NULL,
	[ActionDate] [datetime] NOT NULL,
	[LogData] [nvarchar](max) NULL,
 CONSTRAINT [PK_Log] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[GetRandom]    Script Date: 05/22/2014 14:28:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[GetRandom]
AS
	SELECT RAND()
	GO;
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 05/22/2014 14:28:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[RegistrationCode] [nvarchar](2) NOT NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_Cities] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Owners]    Script Date: 05/22/2014 14:28:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Owners](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](256) NOT NULL,
	[LastName] [nvarchar](256) NOT NULL,
	[UniformCivilNumber] [nvarchar](10) NOT NULL,
	[Address] [nvarchar](1000) NOT NULL,
	[BirthDate] [datetime] NULL,
 CONSTRAINT [PK_Owners] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_Owners] UNIQUE NONCLUSTERED 
(
	[UniformCivilNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Models]    Script Date: 05/22/2014 14:28:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Models](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ManifactureId] [int] NOT NULL,
	[Model] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Models] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[ManifacturesSelectAll]    Script Date: 05/22/2014 14:28:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ManifacturesSelectAll]
AS
	BEGIN
	SELECT
		*
	FROM [dbo].[Manifactures]
	ORDER BY [Name]
	END
GO
/****** Object:  Table [dbo].[Users]    Script Date: 05/22/2014 14:28:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](256) NOT NULL,
	[LastName] [nvarchar](256) NOT NULL,
	[Role] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[CityId] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[CitySelect]    Script Date: 05/22/2014 14:28:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CitySelect]
	@CityId INT
AS
	BEGIN
	SELECT
		*
	FROM [dbo].[Cities]
	WHERE [Id] = @CityId
	END
GO
/****** Object:  StoredProcedure [dbo].[ModelsSelectByManifacture]    Script Date: 05/22/2014 14:28:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModelsSelectByManifacture]
	@Manifacture NVARCHAR(50)
AS
	BEGIN
	SELECT
		*
	FROM [dbo].[Models] M
		INNER JOIN [dbo].[Manifactures] MA ON M.ManifactureId = MA.Id
	WHERE MA.Name = @Manifacture
	ORDER BY M.Model 
	END
GO
/****** Object:  Trigger [Trigg_Delete_Owner]    Script Date: 05/22/2014 14:28:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[Trigg_Delete_Owner]
ON [dbo].[Owners]
AFTER DELETE
AS
	BEGIN
	
	INSERT INTO [dbo].[Log]
	(
		 TableName
		,ActionName
		,ActionDate
		,LogData
	)
	VALUES
	(
		 'Owners'
		,'DELETE'
		,GETDATE()
		,('Deleted owner UCN: ' + (SELECT UniformCivilNumber FROM DELETED))
	)
	
	END
GO
/****** Object:  StoredProcedure [dbo].[OwnerUpdateAddress]    Script Date: 05/22/2014 14:28:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OwnerUpdateAddress]
	 @Address NVARCHAR(1000)
	,@OwnerId INT
AS
	BEGIN
	
	UPDATE [dbo].[Owners]
	SET
		[Address] = @Address
	WHERE Id = @OwnerId
	
	END
GO
/****** Object:  Trigger [Trigg_Insert_Owner]    Script Date: 05/22/2014 14:28:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[Trigg_Insert_Owner]
ON [dbo].[Owners]
FOR INSERT
AS
	BEGIN
	
	INSERT INTO [dbo].[Log]
	(
		 TableName
		,ActionName
		,ActionDate
		,LogData
	)
	VALUES
	(
		 'Owners'
		,'INSERT'
		,GETDATE()
		,('Owner id: ' + (SELECT CONVERT(NVARCHAR(10), [Id]) FROM INSERTED))
	)
	
	END
GO
/****** Object:  Trigger [Trigg_Update_Owner]    Script Date: 05/22/2014 14:28:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[Trigg_Update_Owner]
ON [dbo].[Owners]
AFTER UPDATE
AS
	BEGIN
	
	DECLARE @LOGDATA NVARCHAR(MAX)
	
	SET @LOGDATA = 'Previous address: ' 
	+ (
		SELECT d.[Address]
		FROM DELETED d
	) 
	+ ' New address: ' + (
		SELECT i.[Address]
		FROM INSERTED i
	) + ' Owner id: ' + (
		SELECT CONVERT(NVARCHAR(10), Id)
		FROM INSERTED
	)
	
	INSERT INTO [dbo].[Log]
	(
		 TableName
		,ActionName
		,ActionDate
		,LogData
	)
	VALUES
	(
		 'Owners'
		,'UPDATE'
		,GETDATE()
		,@LOGDATA
	)
	
	END
GO
/****** Object:  StoredProcedure [dbo].[UserInsert]    Script Date: 05/22/2014 14:28:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UserInsert]
	 @Username NVARCHAR(50)
	,@Password NVARCHAR(50)
	,@FirstName NVARCHAR(256)
	,@LastName NVARCHAR(256)
	,@Role INT
	,@Status INT
AS
	BEGIN
	INSERT INTO [dbo].[Users]
	(
		 Username
		,[Password]
		,FirstName
		,LastName
		,[Role]
		,[Status]
	)
	VALUES
	(
		 @Username
		,@Password
		,@FirstName
		,@LastName
		,@Role
		,@Status
	)
	
	SELECT SCOPE_IDENTITY()
	
	END
GO
/****** Object:  Table [dbo].[Vehicles]    Script Date: 05/22/2014 14:28:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ManifactureId] [int] NOT NULL,
	[ModelId] [int] NOT NULL,
	[OwnerId] [int] NOT NULL,
	[RegistrationNumber] [nvarchar](10) NOT NULL,
	[VinNumber] [nvarchar](17) NOT NULL,
	[EngineNumber] [nvarchar](10) NULL,
	[EnginePower] [int] NOT NULL,
	[EngineValume] [int] NOT NULL,
	[FirstRegistrationDate] [datetime] NOT NULL,
	[RegistrationDate] [datetime] NOT NULL,
	[Type] [int] NOT NULL,
 CONSTRAINT [PK_Vehicles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[CheckUniformCivilNumberExists]    Script Date: 05/22/2014 14:28:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CheckUniformCivilNumberExists]
	@UniformCivilNumber NVARCHAR(10)
AS
	BEGIN
		SELECT
			COUNT(*)
		FROM [dbo].[Owners]
		WHERE UniformCivilNumber = @UniformCivilNumber
	END
GO
/****** Object:  StoredProcedure [dbo].[OwnerInsert]    Script Date: 05/22/2014 14:28:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OwnerInsert]
	 @FirstName NVARCHAR(256)
	,@LastName NVARCHAR(256)
	,@UniformCivilNumber NVARCHAR(256)
	,@Address NVARCHAR(1000)
	,@BirthDate DATETIME
AS
	BEGIN
	INSERT INTO [dbo].[Owners]
	(
		 FirstName
		,LastName
		,UniformCivilNumber
		,[Address]
		,[BirthDate]
	)
	VALUES
	(
		 @FirstName
		,@LastName
		,@UniformCivilNumber
		,@Address
		,@BirthDate
	)
	
	SELECT SCOPE_IDENTITY()
	
	END
GO
/****** Object:  StoredProcedure [dbo].[UserSelectByUsernameAndPassword]    Script Date: 05/22/2014 14:28:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UserSelectByUsernameAndPassword]
	 @Username NVARCHAR(50)
	,@Password NVARCHAR(50)
AS
	BEGIN
		SELECT
			*
		FROM Users
		WHERE Username = @Username 
			AND [Password] = @Password
			AND [Status] = 1
	END
GO
/****** Object:  StoredProcedure [dbo].[UserSelectByUsername]    Script Date: 05/22/2014 14:28:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UserSelectByUsername]
	@Username NVARCHAR(50)
AS
	BEGIN
		SELECT
			*
		FROM Users
		WHERE Username = @Username 
	END
GO
/****** Object:  StoredProcedure [dbo].[OwnersAverageAgeSelect]    Script Date: 05/22/2014 14:28:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OwnersAverageAgeSelect]
AS
	BEGIN
	
	DECLARE @YEARNOW INT = DATEPART(YEAR, GETDATE())

	SELECT
		AVG(
			CONVERT(FLOAT, @YEARNOW) - 
			CONVERT(FLOAT, LEFT(CONVERT(NVARCHAR(10), [BirthDate], 120), 4))
		)
	FROM [dbo].[Owners]
	
	END
GO
/****** Object:  StoredProcedure [dbo].[VehicleUpdateOwner]    Script Date: 05/22/2014 14:28:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VehicleUpdateOwner]
	 @OwnerId INT
	,@VehicleId INT
AS
	BEGIN
	
	UPDATE [dbo].[Vehicles]
	SET
		 OwnerId = @OwnerId
		,RegistrationDate = GETDATE()
	WHERE Id = @VehicleId
	
	END
GO
/****** Object:  StoredProcedure [dbo].[VehicleSelectByVinNumber]    Script Date: 05/22/2014 14:28:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VehicleSelectByVinNumber]
	@VinNumber NVARCHAR(17)
AS
	BEGIN
	SELECT
		 V.*
		,O.Id AS OwnerId
		,O.FirstName
		,O.LastName
		,O.UniformCivilNumber
		,O.[Address]
		,O.BirthDate
	FROM [dbo].[Vehicles] V 
		INNER JOIN [dbo].[Owners] O ON V.OwnerId = V.OwnerId
	WHERE V.VinNumber = @VinNumber
	END
GO
/****** Object:  StoredProcedure [dbo].[VehicleSelectByRegistrationNumber]    Script Date: 05/22/2014 14:28:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VehicleSelectByRegistrationNumber]
	@RegistrationNumber NVARCHAR(10)
AS
	BEGIN
	SELECT
		 V.*
		,O.Id AS OwnerId
		,O.FirstName
		,O.LastName
		,O.UniformCivilNumber
		,O.[Address]
		,O.BirthDate
		,M.Name AS ManifactureName
		,MO.Model AS ModelName
	FROM [dbo].[Vehicles] V 
		INNER JOIN [dbo].[Owners] O ON V.OwnerId = V.OwnerId
		INNER JOIN [dbo].[Manifactures] M ON V.ManifactureId = M.Id
		INNER JOIN [dbo].[Models] MO ON V.ModelId = MO.Id
	WHERE V.RegistrationNumber = @RegistrationNumber
	END
GO
/****** Object:  StoredProcedure [dbo].[VehicleSelectAverageYearOfCreationByType]    Script Date: 05/22/2014 14:28:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VehicleSelectAverageYearOfCreationByType]
	@VehicleType INT
AS
	BEGIN
	
	SELECT
	 CAST(AVG(CAST([FirstRegistrationDate] AS FLOAT)) AS DATETIME) 
	FROM [dbo].[Vehicles]
	WHERE [Type] = @VehicleType
	
	END
GO
/****** Object:  StoredProcedure [dbo].[VehiclesCountSelectByType]    Script Date: 05/22/2014 14:28:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VehiclesCountSelectByType]
	@VehicleType INT
AS
	BEGIN
	
	SELECT
		COUNT(Id)
	FROM [dbo].[Vehicles]
	WHERE [Type] = @VehicleType
	
	END
GO
/****** Object:  StoredProcedure [dbo].[OwnerDelete]    Script Date: 05/22/2014 14:28:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OwnerDelete]
	@OwnerId INT
AS
	BEGIN
	
	BEGIN TRANSACTION DELETEOWNER
	
	DECLARE @ErrorCode INT
	
	-- First delete all owner vehicles
	DELETE
	FROM [dbo].[Vehicles]
	WHERE [OwnerId] = @OwnerId
	
	SET @ErrorCode = @@ERROR
	
	IF @ErrorCode <> 0
	BEGIN
		ROLLBACK TRANSACTION DELETEOWNER
		PRINT 'Error deleting owners vehicles: ' + CONVERT(VARCHAR, @ErrorCode)
		RETURN
	END
	
	-- Delete the owner
	DELETE
	FROM [dbo].[Owners]
	WHERE [Id] = @OwnerId
	
	IF @ErrorCode <> 0
	BEGIN
		ROLLBACK TRANSACTION DELETEOWNER
		PRINT 'Error deleting the owner: ' + CONVERT(VARCHAR, @ErrorCode)
		RETURN
	END
	
	COMMIT TRANSACTION DELETEOWNER
	
	SELECT @@ROWCOUNT
	
	END
GO
/****** Object:  UserDefinedFunction [dbo].[GenerateVehicleNumber]    Script Date: 05/22/2014 14:28:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GenerateVehicleNumber]
(
	@FirstCharacters NVARCHAR(2)
)
RETURNS NVARCHAR(8)
AS
	BEGIN
		-- The possible two last characters from the number
		DECLARE @ENDCHARACTERS NVARCHAR(11)
		SET @ENDCHARACTERS = 'юбяемйлнпру'
		
		-- Here the result will be 
		DECLARE @RandomNumber NVARCHAR(8)
		SET @RandomNumber  = @FirstCharacters
		
		-- Current random number
		DECLARE @Random INT
		
		-- Lowest possible random number
		DECLARE @Lower INT
		
		-- Highest possible number
		DECLARE @Upper INT
		
		SET @Lower = 0
		SET @Upper = 10
		
		DECLARE @Continue BIT = 1
		
		WHILE @Continue = 1
		BEGIN
			-- Generate the four digits
			DECLARE @i INT = 0
			WHILE @i < 4
			BEGIN
				SELECT @Random = ROUND(((@Upper - @Lower -1) * (SELECT * FROM [dbo].[GetRandom]) + @Lower), 0)
				SET @RandomNumber = @RandomNumber + CAST(@Random AS NVARCHAR)
				SET @i = @i + 1
			END
			
			SET @Lower = 1
			SET @Upper = 12
			
			-- Generate last two characters
			SET @i = 0
			WHILE @i < 2
			BEGIN
				SELECT @Random = ROUND(((@Upper - @Lower -1) * (SELECT * FROM [dbo].[GetRandom]) + @Lower), 0)
				SET @RandomNumber = @RandomNumber + SUBSTRING(@ENDCHARACTERS, @Random, 1)
				SET @i = @i + 1
			END
			
			IF NOT EXISTS (SELECT * FROM [dbo].[Vehicles] WHERE [RegistrationNumber] = @RandomNumber)
			BEGIN
				SET @Continue = 0
			END
			
		END
		
		RETURN @RandomNumber
	END
GO
/****** Object:  StoredProcedure [dbo].[VehicleInsert]    Script Date: 05/22/2014 14:28:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VehicleInsert]
	 @Manifacture NVARCHAR(50)
	,@Model NVARCHAR(50)
	,@OwnerId INT
	,@RegistrationNumber NVARCHAR(10)
	,@VinNumber NVARCHAR(17)
	,@EngineNumber NVARCHAR(10)
	,@EnginePower INT
	,@EngineValume INT
	,@FirstRegistrationDate DATETIME
	,@RegistrationDate DATETIME
	,@Type INT
AS
	BEGIN
	
	SET XACT_ABORT ON;
	
	BEGIN TRANSACTION Insert_Vehicle
	
	DECLARE @ManifactureId INT;
	DECLARE @ModelId INT;
	
	SET @ManifactureId = (SELECT [Id] FROM [dbo].[Manifactures] WHERE [Name] = @Manifacture)
	SELECT @ModelId = [Id] FROM [dbo].[Models] WHERE [Model] = @Model
	
	IF @ManifactureId IS NULL 
	BEGIN
		PRINT 'This manifacture does not exists'
		ROLLBACK TRANSACTION Insert_Vehicle
		SELECT -1 
		RETURN
	END
	
	IF @ModelId IS NULL 
	BEGIN
		PRINT 'This model does not exists'
		ROLLBACK TRANSACTION Insert_Vehicle
		SELECT -2 
		RETURN
	END
	
	IF @FirstRegistrationDate IS NULL
	BEGIN
		SET @FirstRegistrationDate = @RegistrationDate
	END
	
	INSERT INTO [dbo].[Vehicles]
	(
		 ManifactureId
		,ModelId
		,OwnerId
		,RegistrationNumber
		,VinNumber
		,EngineNumber
		,EnginePower
		,EngineValume
		,FirstRegistrationDate
		,RegistrationDate
		,[Type]
	)
	VALUES
	(
		 @ManifactureId
		,@ModelId
		,@OwnerId
		,@RegistrationNumber
		,@VinNumber
		,@EngineNumber
		,@EnginePower
		,@EngineValume
		,@FirstRegistrationDate
		,@RegistrationDate
		,@Type
	)
	
	COMMIT TRANSACTION Insert_Vehicle
	
	SELECT SCOPE_IDENTITY()
	
	END
GO
/****** Object:  StoredProcedure [dbo].[VehicleDelete]    Script Date: 05/22/2014 14:28:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VehicleDelete]
	@VehicleId INT
AS
	BEGIN
	
	DELETE 
	FROM [dbo].[Vehicles]
	WHERE [Id] = @VehicleId
	
	END
GO
/****** Object:  StoredProcedure [dbo].[VehicleAverageAgeSelectByType]    Script Date: 05/22/2014 14:28:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VehicleAverageAgeSelectByType]
	@VehicleType INT
AS
	BEGIN
	
	DECLARE @YEARNOW INT = DATEPART(YEAR, GETDATE())

	SELECT
		AVG(
			CONVERT(FLOAT, @YEARNOW) - 
			CONVERT(FLOAT, LEFT(CONVERT(NVARCHAR(10), [FirstRegistrationDate], 120), 4))
		)
	FROM [dbo].[Vehicles]
	
	END
GO
/****** Object:  Trigger [Trigg_Update_Vehicles]    Script Date: 05/22/2014 14:28:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[Trigg_Update_Vehicles]
ON [dbo].[Vehicles]
AFTER UPDATE
AS
	BEGIN
	
	DECLARE @LOGDATA NVARCHAR(MAX)
	
	SET @LOGDATA = 'Vehicle Id: ' + (
		SELECT CONVERT(NVARCHAR(10), Id)
		FROM INSERTED
	) + '; Old owner: ' + (
		SELECT CONVERT(NVARCHAR(10), OwnerId)
		FROM DELETED
	) + '; New owner: ' + (
		SELECT CONVERT(NVARCHAR(10), OwnerId)
		FROM INSERTED
	) + '; Old registration number: ' + (
		SELECT RegistrationNumber
		FROM DELETED
	) + '; New registration number: ' + (
		SELECT RegistrationNumber
		FROM INSERTED
	)
	
	INSERT INTO [dbo].[Log]
	(
		 TableName
		,ActionName
		,ActionDate
		,LogData
	)
	VALUES
	(
		 'Vehicles'
		,'UPDATE'
		,GETDATE()
		,@LOGDATA
	)
	
	END
GO
/****** Object:  Trigger [Trigg_Insert_Vehicles]    Script Date: 05/22/2014 14:28:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[Trigg_Insert_Vehicles]
ON [dbo].[Vehicles]
FOR INSERT
AS
	BEGIN
	
	INSERT INTO [dbo].[Log]
	(
		 TableName
		,ActionName
		,ActionDate
		,LogData
	)
	VALUES
	(
		 'Vehicles'
		,'INSERT'
		,GETDATE()
		,('Vehicle id: ' + (SELECT CONVERT(NVARCHAR(10), [Id]) FROM INSERTED))
	)
	
	END
GO
/****** Object:  Trigger [Trigg_Delete_Vehicle]    Script Date: 05/22/2014 14:28:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[Trigg_Delete_Vehicle]
ON [dbo].[Vehicles]
AFTER DELETE
AS
	BEGIN
	
	INSERT INTO [dbo].[Log]
	(
		 TableName
		,ActionName
		,ActionDate
		,LogData
	)
	VALUES
	(
		 'Vehicles'
		,'DELETE'
		,GETDATE()
		,('Deleted vehicle registration number: ' + (SELECT [RegistrationNumber] FROM DELETED))
	)
	
	END
GO
/****** Object:  StoredProcedure [dbo].[OwnerSelectByUCN]    Script Date: 05/22/2014 14:28:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OwnerSelectByUCN]
	@UCN NVARCHAR(10)
AS
	BEGIN
	SELECT
		  O.Id AS OwnerId
		 ,O.FirstName
		 ,O.LastName
		 ,O.UniformCivilNumber
		 ,O.[Address]
		 ,O.BirthDate
		,V.*
		,M.Id AS ManifactureId
		,M.Name AS ManifactureName
		,MO.Id AS ModelId
		,MO.Model AS ModelName
	FROM [dbo].[Owners] O 
		LEFT OUTER JOIN [dbo].[Vehicles] V ON O.Id = V.OwnerId
		LEFT OUTER JOIN [dbo].[Manifactures] M ON V.ManifactureId = M.Id
		LEFT OUTER JOIN [dbo].[Models] MO ON V.ModelId = MO.Id
	WHERE O.UniformCivilNumber = @UCN
	
	END
GO
/****** Object:  StoredProcedure [dbo].[SelectNewVehicleNumber]    Script Date: 05/22/2014 14:28:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectNewVehicleNumber]
	@FirstTwoCharacters NVARCHAR(2)
AS
	BEGIN
		SELECT [dbo].[GenerateVehicleNumber](@FirstTwoCharacters) AS VehicleNumber
	END
GO
/****** Object:  ForeignKey [FK_Models_Manifactures]    Script Date: 05/22/2014 14:28:41 ******/
ALTER TABLE [dbo].[Models]  WITH CHECK ADD  CONSTRAINT [FK_Models_Manifactures] FOREIGN KEY([ManifactureId])
REFERENCES [dbo].[Manifactures] ([Id])
GO
ALTER TABLE [dbo].[Models] CHECK CONSTRAINT [FK_Models_Manifactures]
GO
/****** Object:  ForeignKey [FK_Users_Cities]    Script Date: 05/22/2014 14:28:41 ******/
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Cities] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Cities]
GO
/****** Object:  ForeignKey [FK_Users_Roles]    Script Date: 05/22/2014 14:28:41 ******/
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([Role])
REFERENCES [dbo].[Roles] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
/****** Object:  ForeignKey [FK_Users_UserStatus]    Script Date: 05/22/2014 14:28:41 ******/
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UserStatus] FOREIGN KEY([Status])
REFERENCES [dbo].[UserStatus] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_UserStatus]
GO
/****** Object:  ForeignKey [FK_Vehicles_Manifactures]    Script Date: 05/22/2014 14:28:41 ******/
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK_Vehicles_Manifactures] FOREIGN KEY([ManifactureId])
REFERENCES [dbo].[Manifactures] ([Id])
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK_Vehicles_Manifactures]
GO
/****** Object:  ForeignKey [FK_Vehicles_Models]    Script Date: 05/22/2014 14:28:41 ******/
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK_Vehicles_Models] FOREIGN KEY([ModelId])
REFERENCES [dbo].[Models] ([Id])
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK_Vehicles_Models]
GO
/****** Object:  ForeignKey [FK_Vehicles_Owners]    Script Date: 05/22/2014 14:28:41 ******/
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK_Vehicles_Owners] FOREIGN KEY([OwnerId])
REFERENCES [dbo].[Owners] ([Id])
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK_Vehicles_Owners]
GO
/****** Object:  ForeignKey [FK_Vehicles_VehicleType]    Script Date: 05/22/2014 14:28:41 ******/
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK_Vehicles_VehicleType] FOREIGN KEY([Type])
REFERENCES [dbo].[VehicleType] ([Id])
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK_Vehicles_VehicleType]
GO
/****** Object:  DdlTrigger [Trigg_Safety_Tables_Drop]    Script Date: 05/22/2014 14:28:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [Trigg_Safety_Tables_Drop]
ON DATABASE
FOR DROP_TABLE
AS
	BEGIN
	PRINT 'Trigger safety is on. You can not do this action!'
	ROLLBACK
	END
;
GO
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
DISABLE TRIGGER [Trigg_Safety_Tables_Drop] ON DATABASE
GO
/****** Object:  DdlTrigger [Trigg_Safety_Tables_Drop]    Script Date: 05/22/2014 14:28:42 ******/
Enable Trigger [Trigg_Safety_Tables_Drop] ON Database
GO
