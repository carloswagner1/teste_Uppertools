drop database projeto;
create database projeto;
use projeto;
create table Pessoa(
IdPessoa int primary key not null auto_increment,
nome varchar(80)
);

create table Atividade(
codigoAt varchar(10) primary key not null,
descricao varchar(100)
);

create table TipoEmpresa(
IdTipo int primary key not null auto_increment,
descricao varchar(255)
);

create table Endereco(
IdEndereco int primary key not null auto_increment,
logradouro varchar(255),
bairro varchar(30),
numero int,
complemento varchar(255),
uf char(2),
cep varchar(10),
municipio varchar(20)
);

create table Empresa(
CNPJ varchar(14) primary key not null,
nome varchar(100),
telefone varchar(40),
email varchar(40),
natureza_juridica varchar(50),
fantasia varchar(100),
capital_social decimal(12,2),
situacao varchar(20),
IdTipo int,
codigoAt varchar(10),
IdEndereco int
);

create table atividades_secundarias(
CNPJ varchar(14),
codigoAt varchar(10)
);

create table administracao(
CNPJ varchar(14),
IdPessoa int,
cargo varchar(30)
);

ALTER TABLE Empresa
ADD CONSTRAINT fk_EmpresaTipo
FOREIGN KEY (IdTipo) REFERENCES TipoEmpresa(IdTipo);

ALTER TABLE Empresa
ADD CONSTRAINT fk_EmpresaAtividadePrincipal
FOREIGN KEY (codigoAt) REFERENCES Atividade(codigoAt);

ALTER TABLE Empresa
ADD CONSTRAINT fk_EmpresaEndereco
FOREIGN KEY (IdEndereco) REFERENCES Endereco(IdEndereco);

ALTER TABLE atividades_secundarias
ADD CONSTRAINT pk_EmpresaAtividade
PRIMARY KEY (CNPJ,codigoAt);

ALTER TABLE atividades_secundarias
ADD CONSTRAINT fk_asEmpresa
FOREIGN KEY (CNPJ) REFERENCES Empresa(CNPJ);

ALTER TABLE atividades_secundarias
ADD CONSTRAINT fk_asAtividade
FOREIGN KEY (codigoAt) REFERENCES Atividade(codigoAt);

ALTER TABLE administracao
ADD CONSTRAINT pk_EmpresaPessoa
PRIMARY KEY (CNPJ,IdPessoa);

ALTER TABLE administracao
ADD CONSTRAINT fk_admEmpresa
FOREIGN KEY (CNPJ) REFERENCES Empresa(CNPJ);

ALTER TABLE administracao
ADD CONSTRAINT fk_admPessoa
FOREIGN KEY (IdPessoa) REFERENCES Pessoa(IdPessoa);

INSERT INTO TipoEmpresa values(NULL,"MATRIZ"),(NULL,"FILIAL");

