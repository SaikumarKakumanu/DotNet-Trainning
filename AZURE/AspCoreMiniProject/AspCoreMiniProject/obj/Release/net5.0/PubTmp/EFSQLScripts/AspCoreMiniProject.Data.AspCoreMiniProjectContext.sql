IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220705055042_ApiCreate')
BEGIN
    CREATE TABLE [Product] (
        [ProductId] int NOT NULL IDENTITY,
        [ProductName] nvarchar(max) NOT NULL,
        [Price] real NOT NULL,
        [Brand] nvarchar(max) NULL,
        [ManufactureDate] nvarchar(max) NULL,
        [ExpirationDate] nvarchar(max) NULL,
        CONSTRAINT [PK_Product] PRIMARY KEY ([ProductId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220705055042_ApiCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220705055042_ApiCreate', N'5.0.17');
END;
GO

COMMIT;
GO

