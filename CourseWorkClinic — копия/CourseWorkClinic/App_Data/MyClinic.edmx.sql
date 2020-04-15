
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/23/2019 13:14:33
-- Generated from EDMX file: D:\ВУЗ\IT\Kursach\KursachET\CourseWorkClinic — копия\CourseWorkClinic\App_Data\MyClinic.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Clinic];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_webpages_UsersInRoles_UserProfile]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[webpages_UsersInRoles] DROP CONSTRAINT [FK_webpages_UsersInRoles_UserProfile];
GO
IF OBJECT_ID(N'[dbo].[FK_webpages_UsersInRoles_webpages_Roles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[webpages_UsersInRoles] DROP CONSTRAINT [FK_webpages_UsersInRoles_webpages_Roles];
GO
IF OBJECT_ID(N'[dbo].[FK_Ведут]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Прием] DROP CONSTRAINT [FK_Ведут];
GO
IF OBJECT_ID(N'[dbo].[FK_Владеют]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Врачи] DROP CONSTRAINT [FK_Владеют];
GO
IF OBJECT_ID(N'[dbo].[FK_ВС]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Врачи] DROP CONSTRAINT [FK_ВС];
GO
IF OBJECT_ID(N'[dbo].[FK_Выдают]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Направление] DROP CONSTRAINT [FK_Выдают];
GO
IF OBJECT_ID(N'[dbo].[FK_Дни_в_расписании]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Расписание] DROP CONSTRAINT [FK_Дни_в_расписании];
GO
IF OBJECT_ID(N'[dbo].[FK_Живут]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Пациенты] DROP CONSTRAINT [FK_Живут];
GO
IF OBJECT_ID(N'[dbo].[FK_К_кому_направляется]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Направление] DROP CONSTRAINT [FK_К_кому_направляется];
GO
IF OBJECT_ID(N'[dbo].[FK_Направление_Пациенты]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Направление] DROP CONSTRAINT [FK_Направление_Пациенты];
GO
IF OBJECT_ID(N'[dbo].[FK_Направляет]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Прием] DROP CONSTRAINT [FK_Направляет];
GO
IF OBJECT_ID(N'[dbo].[FK_Посещают]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Прием] DROP CONSTRAINT [FK_Посещают];
GO
IF OBJECT_ID(N'[dbo].[FK_Работают_по_времени]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Расписание] DROP CONSTRAINT [FK_Работают_по_времени];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[UserProfile]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserProfile];
GO
IF OBJECT_ID(N'[dbo].[webpages_Membership]', 'U') IS NOT NULL
    DROP TABLE [dbo].[webpages_Membership];
GO
IF OBJECT_ID(N'[dbo].[webpages_OAuthMembership]', 'U') IS NOT NULL
    DROP TABLE [dbo].[webpages_OAuthMembership];
GO
IF OBJECT_ID(N'[dbo].[webpages_Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[webpages_Roles];
GO
IF OBJECT_ID(N'[dbo].[webpages_UsersInRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[webpages_UsersInRoles];
GO
IF OBJECT_ID(N'[dbo].[Адреса]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Адреса];
GO
IF OBJECT_ID(N'[dbo].[Врачи]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Врачи];
GO
IF OBJECT_ID(N'[dbo].[Дни_недели]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Дни_недели];
GO
IF OBJECT_ID(N'[dbo].[Направление]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Направление];
GO
IF OBJECT_ID(N'[dbo].[Пациенты]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Пациенты];
GO
IF OBJECT_ID(N'[dbo].[Пользователи]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Пользователи];
GO
IF OBJECT_ID(N'[dbo].[Прием]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Прием];
GO
IF OBJECT_ID(N'[dbo].[Расписание]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Расписание];
GO
IF OBJECT_ID(N'[dbo].[Расписание_врачей]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Расписание_врачей];
GO
IF OBJECT_ID(N'[dbo].[Сотрудники]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Сотрудники];
GO
IF OBJECT_ID(N'[dbo].[Специальности]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Специальности];
GO
IF OBJECT_ID(N'[dbo].[Список_врачей]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Список_врачей];
GO
IF OBJECT_ID(N'[dbo].[Таблица участков]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Таблица участков];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'UserProfile'
CREATE TABLE [dbo].[UserProfile] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(56)  NOT NULL
);
GO

-- Creating table 'webpages_Membership'
CREATE TABLE [dbo].[webpages_Membership] (
    [UserId] int  NOT NULL,
    [CreateDate] datetime  NULL,
    [ConfirmationToken] nvarchar(128)  NULL,
    [IsConfirmed] bit  NULL,
    [LastPasswordFailureDate] datetime  NULL,
    [PasswordFailuresSinceLastSuccess] int  NOT NULL,
    [Password] nvarchar(128)  NOT NULL,
    [PasswordChangedDate] datetime  NULL,
    [PasswordSalt] nvarchar(128)  NOT NULL,
    [PasswordVerificationToken] nvarchar(128)  NULL,
    [PasswordVerificationTokenExpirationDate] datetime  NULL
);
GO

-- Creating table 'webpages_OAuthMembership'
CREATE TABLE [dbo].[webpages_OAuthMembership] (
    [Provider] nvarchar(30)  NOT NULL,
    [ProviderUserId] nvarchar(100)  NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'webpages_Roles'
CREATE TABLE [dbo].[webpages_Roles] (
    [RoleId] int IDENTITY(1,1) NOT NULL,
    [RoleName] nvarchar(256)  NOT NULL
);
GO

-- Creating table 'Адреса'
CREATE TABLE [dbo].[Адреса] (
    [Код_адреса] int IDENTITY(1,1) NOT NULL,
    [Улица] varchar(50)  NOT NULL,
    [Дом] float  NOT NULL
);
GO

-- Creating table 'Врачи'
CREATE TABLE [dbo].[Врачи] (
    [ID_врача] uniqueidentifier  NOT NULL,
    [Код_специальности] int  NOT NULL,
    [ID_сотрудника] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Дни_недели'
CREATE TABLE [dbo].[Дни_недели] (
    [Код_дня] int IDENTITY(1,1) NOT NULL,
    [Наименование] varchar(11)  NOT NULL
);
GO

-- Creating table 'Направление'
CREATE TABLE [dbo].[Направление] (
    [C_направления] uniqueidentifier  NOT NULL,
    [ID_врача] uniqueidentifier  NOT NULL,
    [ID_врача_ведущего_прием] uniqueidentifier  NOT NULL,
    [ID_пациента] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Пациенты'
CREATE TABLE [dbo].[Пациенты] (
    [ID_пациента] uniqueidentifier  NOT NULL,
    [C__полиса] varchar(30)  NOT NULL,
    [Фамилия] varchar(50)  NOT NULL,
    [Имя] varchar(50)  NOT NULL,
    [Отчество] varchar(50)  NOT NULL,
    [Дата_рождения] datetime  NOT NULL,
    [Дата_смерти] datetime  NULL,
    [Код_адреса] int  NOT NULL
);
GO

-- Creating table 'Пользователи'
CREATE TABLE [dbo].[Пользователи] (
    [ID_пользователя] uniqueidentifier  NOT NULL,
    [login] varchar(50)  NOT NULL,
    [password] varchar(50)  NOT NULL,
    [role] nvarchar(50)  NOT NULL,
    [Image] varchar(50)  NULL
);
GO

-- Creating table 'Прием'
CREATE TABLE [dbo].[Прием] (
    [ID_приема] uniqueidentifier  NOT NULL,
    [Дата] datetime  NOT NULL,
    [Длительность] float  NULL,
    [Диагноз] varchar(150)  NULL,
    [Рецепт] varchar(800)  NULL,
    [Примечание] varchar(800)  NULL,
    [C__направления] uniqueidentifier  NULL,
    [ID_врача] uniqueidentifier  NOT NULL,
    [ID_пациента] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Процедуры'
CREATE TABLE [dbo].[Процедуры] (
    [Код_процедуры] int IDENTITY(1,1) NOT NULL,
    [Наименование] varchar(100)  NOT NULL,
    [Код_специальности] int  NOT NULL
);
GO

-- Creating table 'Расписание'
CREATE TABLE [dbo].[Расписание] (
    [ID_записи] uniqueidentifier  NOT NULL,
    [Неделя] varchar(5)  NOT NULL,
    [Время_начала] time  NOT NULL,
    [Время_окончания] time  NOT NULL,
    [C__кабинета] int  NOT NULL,
    [ID_врача] uniqueidentifier  NOT NULL,
    [Код_дня] int  NOT NULL
);
GO

-- Creating table 'Расписание_врачей'
CREATE TABLE [dbo].[Расписание_врачей] (
    [Специальность] varchar(50)  NOT NULL,
    [Фамилия] varchar(50)  NOT NULL,
    [Имя] varchar(50)  NOT NULL,
    [Отчество] varchar(50)  NOT NULL,
    [неделя] varchar(5)  NOT NULL,
    [Понедельник] varchar(50)  NULL,
    [Вторник] varchar(50)  NULL,
    [Среда] varchar(50)  NULL,
    [Четверг] varchar(50)  NULL,
    [Пятница] varchar(50)  NULL,
    [Суббота] varchar(50)  NULL,
    [Id_врача] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Сотрудники'
CREATE TABLE [dbo].[Сотрудники] (
    [ID_сотрудника] uniqueidentifier  NOT NULL,
    [Фамилия] varchar(50)  NOT NULL,
    [Имя] varchar(50)  NOT NULL,
    [Отчество] varchar(50)  NOT NULL
);
GO

-- Creating table 'Специальности'
CREATE TABLE [dbo].[Специальности] (
    [Код_специальности] int IDENTITY(1,1) NOT NULL,
    [Наименование] varchar(50)  NOT NULL
);
GO

-- Creating table 'Список_врачей1Set'
CREATE TABLE [dbo].[Список_врачей1Set] (
    [Специальность] varchar(50)  NOT NULL,
    [Код_специальности] int  NOT NULL,
    [Фамилия] varchar(50)  NOT NULL,
    [Имя] varchar(50)  NOT NULL,
    [Отчество] varchar(50)  NOT NULL,
    [Id_врача] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Таблица_участков'
CREATE TABLE [dbo].[Таблица_участков] (
    [C__участка] int IDENTITY(1,1) NOT NULL,
    [ФИО_врача] varchar(1000)  NULL,
    [Адрес] varchar(1000)  NULL
);
GO

-- Creating table 'Участки'
CREATE TABLE [dbo].[Участки] (
    [C_участка] int IDENTITY(1,1) NOT NULL,
    [ID_врача] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'webpages_UsersInRoles'
CREATE TABLE [dbo].[webpages_UsersInRoles] (
    [UserProfile_UserId] int  NOT NULL,
    [webpages_Roles_RoleId] int  NOT NULL
);
GO

-- Creating table 'Адреса_в_участках'
CREATE TABLE [dbo].[Адреса_в_участках] (
    [Адреса_Код_адреса] int  NOT NULL,
    [Участки_C_участка] int  NOT NULL
);
GO

-- Creating table 'Процедуры_в_приеме'
CREATE TABLE [dbo].[Процедуры_в_приеме] (
    [Прием_ID_приема] uniqueidentifier  NOT NULL,
    [Процедуры_Код_процедуры] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [UserId] in table 'UserProfile'
ALTER TABLE [dbo].[UserProfile]
ADD CONSTRAINT [PK_UserProfile]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [UserId] in table 'webpages_Membership'
ALTER TABLE [dbo].[webpages_Membership]
ADD CONSTRAINT [PK_webpages_Membership]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [Provider], [ProviderUserId] in table 'webpages_OAuthMembership'
ALTER TABLE [dbo].[webpages_OAuthMembership]
ADD CONSTRAINT [PK_webpages_OAuthMembership]
    PRIMARY KEY CLUSTERED ([Provider], [ProviderUserId] ASC);
GO

-- Creating primary key on [RoleId] in table 'webpages_Roles'
ALTER TABLE [dbo].[webpages_Roles]
ADD CONSTRAINT [PK_webpages_Roles]
    PRIMARY KEY CLUSTERED ([RoleId] ASC);
GO

-- Creating primary key on [Код_адреса] in table 'Адреса'
ALTER TABLE [dbo].[Адреса]
ADD CONSTRAINT [PK_Адреса]
    PRIMARY KEY CLUSTERED ([Код_адреса] ASC);
GO

-- Creating primary key on [ID_врача] in table 'Врачи'
ALTER TABLE [dbo].[Врачи]
ADD CONSTRAINT [PK_Врачи]
    PRIMARY KEY CLUSTERED ([ID_врача] ASC);
GO

-- Creating primary key on [Код_дня] in table 'Дни_недели'
ALTER TABLE [dbo].[Дни_недели]
ADD CONSTRAINT [PK_Дни_недели]
    PRIMARY KEY CLUSTERED ([Код_дня] ASC);
GO

-- Creating primary key on [C_направления] in table 'Направление'
ALTER TABLE [dbo].[Направление]
ADD CONSTRAINT [PK_Направление]
    PRIMARY KEY CLUSTERED ([C_направления] ASC);
GO

-- Creating primary key on [ID_пациента] in table 'Пациенты'
ALTER TABLE [dbo].[Пациенты]
ADD CONSTRAINT [PK_Пациенты]
    PRIMARY KEY CLUSTERED ([ID_пациента] ASC);
GO

-- Creating primary key on [ID_пользователя] in table 'Пользователи'
ALTER TABLE [dbo].[Пользователи]
ADD CONSTRAINT [PK_Пользователи]
    PRIMARY KEY CLUSTERED ([ID_пользователя] ASC);
GO

-- Creating primary key on [ID_приема] in table 'Прием'
ALTER TABLE [dbo].[Прием]
ADD CONSTRAINT [PK_Прием]
    PRIMARY KEY CLUSTERED ([ID_приема] ASC);
GO

-- Creating primary key on [Код_процедуры] in table 'Процедуры'
ALTER TABLE [dbo].[Процедуры]
ADD CONSTRAINT [PK_Процедуры]
    PRIMARY KEY CLUSTERED ([Код_процедуры] ASC);
GO

-- Creating primary key on [ID_записи] in table 'Расписание'
ALTER TABLE [dbo].[Расписание]
ADD CONSTRAINT [PK_Расписание]
    PRIMARY KEY CLUSTERED ([ID_записи] ASC);
GO

-- Creating primary key on [Специальность], [Фамилия], [Имя], [Отчество], [неделя], [Id_врача] in table 'Расписание_врачей'
ALTER TABLE [dbo].[Расписание_врачей]
ADD CONSTRAINT [PK_Расписание_врачей]
    PRIMARY KEY CLUSTERED ([Специальность], [Фамилия], [Имя], [Отчество], [неделя], [Id_врача] ASC);
GO

-- Creating primary key on [ID_сотрудника] in table 'Сотрудники'
ALTER TABLE [dbo].[Сотрудники]
ADD CONSTRAINT [PK_Сотрудники]
    PRIMARY KEY CLUSTERED ([ID_сотрудника] ASC);
GO

-- Creating primary key on [Код_специальности] in table 'Специальности'
ALTER TABLE [dbo].[Специальности]
ADD CONSTRAINT [PK_Специальности]
    PRIMARY KEY CLUSTERED ([Код_специальности] ASC);
GO

-- Creating primary key on [Специальность], [Код_специальности], [Фамилия], [Имя], [Отчество], [Id_врача] in table 'Список_врачей1Set'
ALTER TABLE [dbo].[Список_врачей1Set]
ADD CONSTRAINT [PK_Список_врачей1Set]
    PRIMARY KEY CLUSTERED ([Специальность], [Код_специальности], [Фамилия], [Имя], [Отчество], [Id_врача] ASC);
GO

-- Creating primary key on [C__участка] in table 'Таблица_участков'
ALTER TABLE [dbo].[Таблица_участков]
ADD CONSTRAINT [PK_Таблица_участков]
    PRIMARY KEY CLUSTERED ([C__участка] ASC);
GO

-- Creating primary key on [C_участка] in table 'Участки'
ALTER TABLE [dbo].[Участки]
ADD CONSTRAINT [PK_Участки]
    PRIMARY KEY CLUSTERED ([C_участка] ASC);
GO

-- Creating primary key on [UserProfile_UserId], [webpages_Roles_RoleId] in table 'webpages_UsersInRoles'
ALTER TABLE [dbo].[webpages_UsersInRoles]
ADD CONSTRAINT [PK_webpages_UsersInRoles]
    PRIMARY KEY CLUSTERED ([UserProfile_UserId], [webpages_Roles_RoleId] ASC);
GO

-- Creating primary key on [Адреса_Код_адреса], [Участки_C_участка] in table 'Адреса_в_участках'
ALTER TABLE [dbo].[Адреса_в_участках]
ADD CONSTRAINT [PK_Адреса_в_участках]
    PRIMARY KEY CLUSTERED ([Адреса_Код_адреса], [Участки_C_участка] ASC);
GO

-- Creating primary key on [Прием_ID_приема], [Процедуры_Код_процедуры] in table 'Процедуры_в_приеме'
ALTER TABLE [dbo].[Процедуры_в_приеме]
ADD CONSTRAINT [PK_Процедуры_в_приеме]
    PRIMARY KEY CLUSTERED ([Прием_ID_приема], [Процедуры_Код_процедуры] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Код_адреса] in table 'Пациенты'
ALTER TABLE [dbo].[Пациенты]
ADD CONSTRAINT [FK_Живут]
    FOREIGN KEY ([Код_адреса])
    REFERENCES [dbo].[Адреса]
        ([Код_адреса])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Живут'
CREATE INDEX [IX_FK_Живут]
ON [dbo].[Пациенты]
    ([Код_адреса]);
GO

-- Creating foreign key on [ID_врача] in table 'Прием'
ALTER TABLE [dbo].[Прием]
ADD CONSTRAINT [FK_Ведут]
    FOREIGN KEY ([ID_врача])
    REFERENCES [dbo].[Врачи]
        ([ID_врача])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Ведут'
CREATE INDEX [IX_FK_Ведут]
ON [dbo].[Прием]
    ([ID_врача]);
GO

-- Creating foreign key on [Код_специальности] in table 'Врачи'
ALTER TABLE [dbo].[Врачи]
ADD CONSTRAINT [FK_Владеют]
    FOREIGN KEY ([Код_специальности])
    REFERENCES [dbo].[Специальности]
        ([Код_специальности])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Владеют'
CREATE INDEX [IX_FK_Владеют]
ON [dbo].[Врачи]
    ([Код_специальности]);
GO

-- Creating foreign key on [ID_сотрудника] in table 'Врачи'
ALTER TABLE [dbo].[Врачи]
ADD CONSTRAINT [FK_ВС]
    FOREIGN KEY ([ID_сотрудника])
    REFERENCES [dbo].[Сотрудники]
        ([ID_сотрудника])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ВС'
CREATE INDEX [IX_FK_ВС]
ON [dbo].[Врачи]
    ([ID_сотрудника]);
GO

-- Creating foreign key on [ID_врача] in table 'Направление'
ALTER TABLE [dbo].[Направление]
ADD CONSTRAINT [FK_Выдают]
    FOREIGN KEY ([ID_врача])
    REFERENCES [dbo].[Врачи]
        ([ID_врача])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Выдают'
CREATE INDEX [IX_FK_Выдают]
ON [dbo].[Направление]
    ([ID_врача]);
GO

-- Creating foreign key on [ID_врача_ведущего_прием] in table 'Направление'
ALTER TABLE [dbo].[Направление]
ADD CONSTRAINT [FK_К_кому_направляется]
    FOREIGN KEY ([ID_врача_ведущего_прием])
    REFERENCES [dbo].[Врачи]
        ([ID_врача])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_К_кому_направляется'
CREATE INDEX [IX_FK_К_кому_направляется]
ON [dbo].[Направление]
    ([ID_врача_ведущего_прием]);
GO

-- Creating foreign key on [ID_врача] in table 'Участки'
ALTER TABLE [dbo].[Участки]
ADD CONSTRAINT [FK_Назначены]
    FOREIGN KEY ([ID_врача])
    REFERENCES [dbo].[Врачи]
        ([ID_врача])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Назначены'
CREATE INDEX [IX_FK_Назначены]
ON [dbo].[Участки]
    ([ID_врача]);
GO

-- Creating foreign key on [ID_врача] in table 'Расписание'
ALTER TABLE [dbo].[Расписание]
ADD CONSTRAINT [FK_Работают_по_времени]
    FOREIGN KEY ([ID_врача])
    REFERENCES [dbo].[Врачи]
        ([ID_врача])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Работают_по_времени'
CREATE INDEX [IX_FK_Работают_по_времени]
ON [dbo].[Расписание]
    ([ID_врача]);
GO

-- Creating foreign key on [Код_дня] in table 'Расписание'
ALTER TABLE [dbo].[Расписание]
ADD CONSTRAINT [FK_Дни_в_расписании]
    FOREIGN KEY ([Код_дня])
    REFERENCES [dbo].[Дни_недели]
        ([Код_дня])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Дни_в_расписании'
CREATE INDEX [IX_FK_Дни_в_расписании]
ON [dbo].[Расписание]
    ([Код_дня]);
GO

-- Creating foreign key on [ID_пациента] in table 'Направление'
ALTER TABLE [dbo].[Направление]
ADD CONSTRAINT [FK_Направление_Пациенты]
    FOREIGN KEY ([ID_пациента])
    REFERENCES [dbo].[Пациенты]
        ([ID_пациента])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Направление_Пациенты'
CREATE INDEX [IX_FK_Направление_Пациенты]
ON [dbo].[Направление]
    ([ID_пациента]);
GO

-- Creating foreign key on [C__направления] in table 'Прием'
ALTER TABLE [dbo].[Прием]
ADD CONSTRAINT [FK_Направляет]
    FOREIGN KEY ([C__направления])
    REFERENCES [dbo].[Направление]
        ([C_направления])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Направляет'
CREATE INDEX [IX_FK_Направляет]
ON [dbo].[Прием]
    ([C__направления]);
GO

-- Creating foreign key on [ID_пациента] in table 'Прием'
ALTER TABLE [dbo].[Прием]
ADD CONSTRAINT [FK_Посещают]
    FOREIGN KEY ([ID_пациента])
    REFERENCES [dbo].[Пациенты]
        ([ID_пациента])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Посещают'
CREATE INDEX [IX_FK_Посещают]
ON [dbo].[Прием]
    ([ID_пациента]);
GO

-- Creating foreign key on [Код_специальности] in table 'Процедуры'
ALTER TABLE [dbo].[Процедуры]
ADD CONSTRAINT [FK_Относятся_к]
    FOREIGN KEY ([Код_специальности])
    REFERENCES [dbo].[Специальности]
        ([Код_специальности])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Относятся_к'
CREATE INDEX [IX_FK_Относятся_к]
ON [dbo].[Процедуры]
    ([Код_специальности]);
GO

-- Creating foreign key on [UserProfile_UserId] in table 'webpages_UsersInRoles'
ALTER TABLE [dbo].[webpages_UsersInRoles]
ADD CONSTRAINT [FK_webpages_UsersInRoles_UserProfile]
    FOREIGN KEY ([UserProfile_UserId])
    REFERENCES [dbo].[UserProfile]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [webpages_Roles_RoleId] in table 'webpages_UsersInRoles'
ALTER TABLE [dbo].[webpages_UsersInRoles]
ADD CONSTRAINT [FK_webpages_UsersInRoles_webpages_Roles]
    FOREIGN KEY ([webpages_Roles_RoleId])
    REFERENCES [dbo].[webpages_Roles]
        ([RoleId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_webpages_UsersInRoles_webpages_Roles'
CREATE INDEX [IX_FK_webpages_UsersInRoles_webpages_Roles]
ON [dbo].[webpages_UsersInRoles]
    ([webpages_Roles_RoleId]);
GO

-- Creating foreign key on [Адреса_Код_адреса] in table 'Адреса_в_участках'
ALTER TABLE [dbo].[Адреса_в_участках]
ADD CONSTRAINT [FK_Адреса_в_участках_Адреса]
    FOREIGN KEY ([Адреса_Код_адреса])
    REFERENCES [dbo].[Адреса]
        ([Код_адреса])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Участки_C_участка] in table 'Адреса_в_участках'
ALTER TABLE [dbo].[Адреса_в_участках]
ADD CONSTRAINT [FK_Адреса_в_участках_Участки]
    FOREIGN KEY ([Участки_C_участка])
    REFERENCES [dbo].[Участки]
        ([C_участка])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Адреса_в_участках_Участки'
CREATE INDEX [IX_FK_Адреса_в_участках_Участки]
ON [dbo].[Адреса_в_участках]
    ([Участки_C_участка]);
GO

-- Creating foreign key on [Прием_ID_приема] in table 'Процедуры_в_приеме'
ALTER TABLE [dbo].[Процедуры_в_приеме]
ADD CONSTRAINT [FK_Процедуры_в_приеме_Прием]
    FOREIGN KEY ([Прием_ID_приема])
    REFERENCES [dbo].[Прием]
        ([ID_приема])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Процедуры_Код_процедуры] in table 'Процедуры_в_приеме'
ALTER TABLE [dbo].[Процедуры_в_приеме]
ADD CONSTRAINT [FK_Процедуры_в_приеме_Процедуры]
    FOREIGN KEY ([Процедуры_Код_процедуры])
    REFERENCES [dbo].[Процедуры]
        ([Код_процедуры])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Процедуры_в_приеме_Процедуры'
CREATE INDEX [IX_FK_Процедуры_в_приеме_Процедуры]
ON [dbo].[Процедуры_в_приеме]
    ([Процедуры_Код_процедуры]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------