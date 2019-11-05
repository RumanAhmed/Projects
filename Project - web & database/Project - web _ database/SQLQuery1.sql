-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [F_Name] nvarchar(50)  NOT NULL,
    [L_Name] nvarchar(50)  NOT NULL,
    [Drivers_license] nvarchar(10)  NOT NULL,
    [Phone_no] bigint  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [PostCode] nvarchar(7)  NOT NULL,
    [Vehicle_Id] nvarchar(7)  NOT NULL,
    [Hire_Id] int  NOT NULL
);
GO

-- Creating table 'Hires'
CREATE TABLE [dbo].[Hires] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DaysRented] smallint  NOT NULL,
    [FaultFound] nvarchar(3)  NOT NULL,
    [FaultDetails] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Outlets'
CREATE TABLE [dbo].[Outlets] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Location] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Staffs'
CREATE TABLE [dbo].[Staffs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(50)  NOT NULL,
    [LastName] nvarchar(50)  NOT NULL,
    [Gender] nvarchar(6)  NOT NULL,
    [Salary] int  NOT NULL,
    [StreetAddress] nvarchar(max)  NOT NULL,
    [Ni_no] nvarchar(9)  NOT NULL,
    [OutletId] int  NOT NULL
);
GO

-- Creating table 'Vehicles'
CREATE TABLE [dbo].[Vehicles] (
    [Id] nvarchar(7)  NOT NULL,
    [Make] nvarchar(50)  NOT NULL,
    [Model] nvarchar(50)  NOT NULL,
    [Mileage] int  NOT NULL,
    [FuelType] nvarchar(6)  NOT NULL,
    [EngineSize] nvarchar(5)  NOT NULL,
    [OutletId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Hires'
ALTER TABLE [dbo].[Hires]
ADD CONSTRAINT [PK_Hires]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Outlets'
ALTER TABLE [dbo].[Outlets]
ADD CONSTRAINT [PK_Outlets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Staffs'
ALTER TABLE [dbo].[Staffs]
ADD CONSTRAINT [PK_Staffs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Vehicles'
ALTER TABLE [dbo].[Vehicles]
ADD CONSTRAINT [PK_Vehicles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Hire_Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [FK_CustomerHire]
    FOREIGN KEY ([Hire_Id])
    REFERENCES [dbo].[Hires]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerHire'
CREATE INDEX [IX_FK_CustomerHire]
ON [dbo].[Customers]
    ([Hire_Id]);
GO

-- Creating foreign key on [Vehicle_Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [FK_CustomerVehicle]
    FOREIGN KEY ([Vehicle_Id])
    REFERENCES [dbo].[Vehicles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerVehicle'
CREATE INDEX [IX_FK_CustomerVehicle]
ON [dbo].[Customers]
    ([Vehicle_Id]);
GO

-- Creating foreign key on [OutletId] in table 'Staffs'
ALTER TABLE [dbo].[Staffs]
ADD CONSTRAINT [FK_OutletStaff]
    FOREIGN KEY ([OutletId])
    REFERENCES [dbo].[Outlets]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OutletStaff'
CREATE INDEX [IX_FK_OutletStaff]
ON [dbo].[Staffs]
    ([OutletId]);
GO

-- Creating foreign key on [OutletId] in table 'Vehicles'
ALTER TABLE [dbo].[Vehicles]
ADD CONSTRAINT [FK_OutletVehicle]
    FOREIGN KEY ([OutletId])
    REFERENCES [dbo].[Outlets]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OutletVehicle'
CREATE INDEX [IX_FK_OutletVehicle]
ON [dbo].[Vehicles]
    ([OutletId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------