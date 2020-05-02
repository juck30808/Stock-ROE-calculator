CREATE TABLE [dbo].[Table] (
    [招式] NVARCHAR (50) NULL,
    [MP] INT           DEFAULT ((0)) NULL,
    [HP] INT           DEFAULT ((0)) NULL,
    [注解] NVARCHAR (50) NULL,
    [屬]  NVARCHAR (50) NULL,
    [倍率] NCHAR (10)    DEFAULT ((1)) NULL,
    [固傷] INT           DEFAULT ((0)) NULL,
    [次數] INT           DEFAULT ((1)) NULL
);

