CREATE DATABASE WellMeadowClinic
USE WellMeadowClininc

CREATE TABLE [dbo].[Ward](
	[WardNumber] [int] NOT NULL PRIMARY KEY,
	[Name] [nchar](10) NOT NULL,
	[Location] [nchar](10) NOT NULL,
	[TotalNumberOfBeds] [int] NOT NULL,
	[TelephoneExtensionNumber] [int] NOT NULL
) ON [PRIMARY]

CREATE TABLE [dbo].[Staff](
	[ID] [int] NOT NULL PRIMARY KEY,
	[FirstName] [nchar](10) NOT NULL,
	[LastName] [nchar](10) NOT NULL,
	[Telephone] [nchar](10) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[Gender] [bit] NOT NULL,
	[InsuranceNumber] [int] NOT NULL,
	[CurrentSalary] [int] NOT NULL
) ON [PRIMARY]
