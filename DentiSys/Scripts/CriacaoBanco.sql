create Table Procedimento
(
	Id int identity(1,1),
	Titulo nvarchar(100) null,
	TipoDeProcedimento int null, -- de 0 a 9
	Descricao nvarchar(200) null,
	constraint pk_Procedimento primary key (Id)
)

Create Table Plano
(
	Id int identity(1,1),
	Titulo nvarchar(50) null,
	TipoDePlano int null, --De 0 a 5
	Descricao nvarchar(200) null,
	Coberturas nvarchar(200) null,
	DataInicial Datetime null,
	DataFinal DateTime null
	constraint pk_Plano primary key (Id)
)

CREATE TABLE [Endereco]
(
    Id int identity(1,1),
    CEP NVARCHAR(50) NULL,
    Pais NVARCHAR(50) null,
    Estado NVARCHAR(50),
    Rua NVARCHAR(100) NULL,
    Numero NVARCHAR(50) NULL,
    CONSTRAINT pk_Endereco PRIMARY KEY (Id)
)

Create Table Dentista
(
    Id int identity(1,1),
	Nome nvarchar(100) null,
	Sobrenome nvarchar(100) null,
	Idade int null,
	CPF nvarchar(11) null,
	DataDeAniversario Datetime null,
	Email nvarchar(50) null,
	NumeroDeTelefone nvarchar(20) null,
    Especializacao NVARCHAR (200) null,
    NumeroDeRegistro NVARCHAR(50) null,
	IdEndereco int not null,
    Constraint pk_Dentista primary key (Id),
	constraint fk_Dentista_Endereco foreign key (IdEndereco) references Endereco (Id)
)

Create Table Paciente
(
	Id int identity(1,1),
	Nome nvarchar(100) null,
	Sobrenome nvarchar(100) null,
	Idade int null,
	CPF nvarchar(11) null,
	DataDeAniversario Datetime null,
	Email nvarchar(50) null,
	NumeroDeTelefone nvarchar(20) null,
	IdEndereco int not null,
	Constraint pk_Paciente primary key (Id),
	constraint fk_Paciente_Endereco foreign key (IdEndereco) references Endereco (Id)
)

CREATE TABLE [PacientePlano]
(
    IdPlano int identity not null,
    IdPaciente int identity not null,
    PlanoAtivo bit null,
    constraint pk_PacientePlano primary key (IdPlano, IdPaciente),
    constraint fk_PacientePlano_Plano foreign key (IdPlano) references Plano(Id),
    constraint fk_PacientePlano_Paciente foreign key (IdPaciente) references Paciente (Id)
);

CREATE TABLE PacienteProcedimento
(
    IdPaciente int identity not null,
    IdProcedimento int identity not null,
    DataProcedimento DateTime not null,
    ProcedimentoRealizado bit null,
    constraint pk_PacienteProcedimento primary key (IdPaciente, IdProcedimento),
    constraint fk_PacienteProcedimento_Paciente foreign key (IdPaciente) references Paciente (Id),
    constraint fk_PacienteProcedimento_Procedimento foreign key (IdProcedimento) references Procedimento (Id)
);
