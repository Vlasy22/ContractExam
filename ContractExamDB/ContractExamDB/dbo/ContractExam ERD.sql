CREATE TABLE [Contract] (
  [IDContract] int PRIMARY KEY IDENTITY(1,1),
  [ContractCode] nvarchar(30),
  [IDState] int
)
GO

CREATE TABLE [ContractState] (
  [IDContractState] int PRIMARY KEY,
  [Code] nvarchar(6),
  [Name] nvarchar(20)
)
GO

CREATE TABLE [ContractDate] (
  [IDContractDate] int PRIMARY KEY IDENTITY(1,1),
  [IDContract] int,
  [ContractDateType] int,
  [Date] datetime
)
GO

CREATE TABLE [ContractDateType] (
  [IDContractDateType] int PRIMARY KEY,
  [Code] nvarchar(20),
  [Name] nvarchar(20)
)
GO

CREATE TABLE [ContractPrice] (
  [IDContractPrice] int PRIMARY KEY IDENTITY(1,1),
  [IDContract] int,
  [IDContractPriceType] int,
  [Value] numeric,
  [IDCurrency] int
)
GO

CREATE TABLE [ContractPriceType] (
  [IDContractPriceType] int PRIMARY KEY,
  [Code] nvarchar(20),
  [Name] nvarchar(20)
)
GO

CREATE TABLE [Currency] (
  [IDCurrency] int PRIMARY KEY,
  [Code] nvarchar(3),
  [Name] nvarchar(50)
)
GO

CREATE TABLE [Individual] (
  [IDIndividual] int PRIMARY KEY IDENTITY(1,1),
  [CustomerCode] nvarchar(50),
  [FirstName] nvarchar(100),
  [LastName] nvarchar(100),
  [Gender] nvarchar(12),
  [BirthDate] datetime,
  [NationalID] nvarchar(50)
)
GO

CREATE TABLE [ContractXSubject] (
  [IDContractSubject] int PRIMARY KEY IDENTITY(1,1),
  [IDContract] int,
  [IDIndividual] int,
  [IDSubjectRole] int
)
GO

CREATE TABLE [SubjectRole] (
  [IDSubjectRole] int PRIMARY KEY,
  [Name] nvarchar(10)
)
GO

ALTER TABLE [Contract] ADD FOREIGN KEY ([IDState]) REFERENCES [ContractState] ([IDContractState])
GO

ALTER TABLE [ContractDate] ADD FOREIGN KEY ([ContractDateType]) REFERENCES [ContractDateType] ([IDContractDateType])
GO

ALTER TABLE [ContractPrice] ADD FOREIGN KEY ([IDCurrency]) REFERENCES [Currency] ([IDCurrency])
GO

ALTER TABLE [ContractPrice] ADD FOREIGN KEY ([IDContractPriceType]) REFERENCES [ContractPriceType] ([IDContractPriceType])
GO

ALTER TABLE [ContractXSubject] ADD FOREIGN KEY ([IDIndividual]) REFERENCES [Individual] ([IDIndividual])
GO

ALTER TABLE [ContractXSubject] ADD FOREIGN KEY ([IDSubjectRole]) REFERENCES [SubjectRole] ([IDSubjectRole])
GO

ALTER TABLE [ContractXSubject] ADD FOREIGN KEY ([IDContract]) REFERENCES [Contract] ([IDContract])
GO
