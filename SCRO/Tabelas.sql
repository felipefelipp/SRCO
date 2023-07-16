-- Tabelas  

CREATE TABLE [dbo].[Paciente] (
    [PacienteId]    INT           DEFAULT (NEXT VALUE FOR [PacienteSequence]) NOT NULL,
    [ResponsavelId] INT           NULL,
    [Nome]          VARCHAR (100) NOT NULL,
    [Idade]         INT           NOT NULL,
    [CPF]           BIGINT        NOT NULL,
    [RG]            INT           NOT NULL,
    [Celular]       BIGINT        NOT NULL,
    [Telefone]      BIGINT        NULL,
    [Rua]           VARCHAR (100) NOT NULL,
    [Numero]        INT           NOT NULL,
    [Bairro]        VARCHAR (50)  NOT NULL,
    [Municipio]     VARCHAR (50)  NOT NULL,
    [UF]            VARCHAR (2)   NOT NULL,
    [CEP]           INT           NOT NULL,
    [Sexo]          CHAR (1)      NOT NULL,
    [Profissao]     VARCHAR (100) NOT NULL,
    [Email]         VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([PacienteId] ASC)
);

CREATE SEQUENCE [dbo].[PacienteSequence]
    AS BIGINT
    START WITH 0
    INCREMENT BY 1;

CREATE TABLE [dbo].[Responsavel] (
    [IdResponsavel] INT           DEFAULT (NEXT VALUE FOR [ResponsavelSequence]) NOT NULL,
    [Nome]          VARCHAR (100) NOT NULL,
    [Idade]         INT           NOT NULL,
    [CPF]           BIGINT        NOT NULL,
    [RG]            INT           NOT NULL,
    [Celular]       BIGINT        NOT NULL,
    [Email]         VARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([IdResponsavel] ASC)
);

CREATE SEQUENCE [dbo].[ResponsavelSequence]
    AS BIGINT
    START WITH 1
    INCREMENT BY 1;


