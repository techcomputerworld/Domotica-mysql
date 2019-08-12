  IF EXISTS(SELECT 1 FROM information_schema.tables 
  WHERE table_name = '
__EFMigrationsHistory' AND table_schema = DATABASE()) 
BEGIN
CREATE TABLE `__EFMigrationsHistory` (
    `MigrationId` varchar(150) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    PRIMARY KEY (`MigrationId`)
);

END;

CREATE TABLE `RoleClaims` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `RoleId` text NULL,
    `ClaimType` text NULL,
    `ClaimValue` text NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Roles` (
    `Id` varchar(60) NOT NULL,
    `Name` text NULL,
    `NormalizedName` text NULL,
    `ConcurrencyStamp` text NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `UserClaims` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `UserId` text NULL,
    `ClaimType` text NULL,
    `ClaimValue` text NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `UserLogins` (
    `LoginProvider` varchar(60) NOT NULL,
    `ProviderKey` varchar(60) NOT NULL,
    `ProviderDisplayName` text NULL,
    `UserId` text NULL,
    PRIMARY KEY (`LoginProvider`, `ProviderKey`)
);

CREATE TABLE `UserRoles` (
    `UserId` varchar(60) NOT NULL,
    `RoleId` varchar(60) NOT NULL,
    PRIMARY KEY (`UserId`, `RoleId`)
);

CREATE TABLE `Users` (
    `Id` varchar(60) NOT NULL,
    `UserName` text NULL,
    `NormalizedUserName` text NULL,
    `Email` text NULL,
    `NormalizedEmail` text NULL,
    `EmailConfirmed` bit NOT NULL,
    `PasswordHash` text NULL,
    `SecurityStamp` text NULL,
    `ConcurrencyStamp` text NULL,
    `PhoneNumber` text NULL,
    `PhoneNumberConfirmed` bit NOT NULL,
    `TwoFactorEnabled` bit NOT NULL,
    `LockoutEnd` timestamp NULL,
    `LockoutEnabled` bit NOT NULL,
    `AccessFailedCount` int NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `UserTokens` (
    `UserId` varchar(60) NOT NULL,
    `LoginProvider` varchar(60) NOT NULL,
    `Name` varchar(60) NULL,
    `Value` text NULL,
    PRIMARY KEY (`UserId`, `LoginProvider`)
);

CREATE TABLE `Usuarios` (
    `ID` int NOT NULL AUTO_INCREMENT,
    `Nombre` text NULL,
    `Apellido` text NULL,
    `DNI` text NULL,
    `Imagen` text NULL,
    `Iduser` text NULL,
    PRIMARY KEY (`ID`)
);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20190327153333_[M1]', '2.2.3-servicing-35854');

