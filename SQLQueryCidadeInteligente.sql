CREATE DATABASE CidadeInteligente
GO

USE CidadeInteligente

GO

CREATE TABLE tb_pessoa(
	idPessoa int primary key identity (1,1),
	nmPessoa varchar (200),
	dsEndereco varchar (300),
	dsEstadoCivil char (12),
	dtNascimento date
)
CREATE TABLE tb_pessoaDocumento(
	idPessoaDocumento int primary key identity (1,1),
	idPessoa int foreign key references tb_pessoa (idPessoa),
	nrRg char (10),
	nrCpf char (12),
	nrReservista char (12),
	nrCarteiraTrabalho char (8),
	nrCnh char (11)
)
CREATE TABLE tb_funcionario(
	idFuncionario int primary key identity (1,1),
	idPessoa int foreign key references tb_pessoa (idPessoa),
	nmCargo varchar (100),
	nrSalario float,
	nrRamal char (6)
)
CREATE TABLE tb_cliente(
	idCliente int primary key identity (1,1),
	idPessoa int foreign key references tb_pessoa (idPessoa),
	dtInclusao date
)
GO

SELECT * FROM tb_pessoa
SELECT * FROM tb_pessoaDocumento
SELECT * FROM tb_funcionario
SELECT * FROM tb_cliente
GO

CREATE PROCEDURE sp_retornarClientes
AS SELECT idCliente as 'ID do cliente', idPessoa as 'ID da pessoa', dtInclusao as 'Data de inclusão' FROM tb_cliente
sp_retornarClientes

CREATE PROCEDURE sp_retornarFuncionarios
AS SELECT idFuncionario as 'ID do funcionário', idPessoa as 'ID da pessoa', nmCargo as 'Cargo', nrSalario as 'Salário', nrRamal as 'Ramal' FROM tb_funcionario
sp_retornarFuncionarios

CREATE PROCEDURE sp_retornarPessoas
AS SELECT idPessoa as 'ID da pessoa', nmPessoa as 'Nome completo', dsEndereco as 'Endereço', dsEstadoCivil as 'Estado Civil', dtNascimento as 'Data de nascimento' FROM tb_pessoa
sp_retornarPessoas

CREATE PROCEDURE sp_retornarDocumentoPessoa
AS SELECT idPessoaDocumento as 'ID dos documentos pessoais', idPessoa as 'ID da pessoa', nrRg as 'RG', nrCpf as 'CPF', nrReservista as 'Reservista', nrCarteiraTrabalho as 'CTPS', nrCnh as 'CNH' FROM tb_pessoaDocumento
sp_retornarDocumentoPessoa

CREATE PROCEDURE sp_inserirCliente
@idPessoa INT,
@dtDataInclusao DATE
AS INSERT INTO tb_cliente values (@idPessoa, @dtDataInclusao)

CREATE PROCEDURE sp_atualizarCliente
@idPessoa INT,
@dtDataInclusao DATE,
@idCliente INT
AS UPDATE tb_cliente SET idPessoa = @idPessoa, dtInclusao = @dtDataInclusao WHERE idCliente = @idCliente

CREATE PROCEDURE sp_inserirPessoa
@nmPessoa varchar (200),
@dsEndereco varchar (300),
@dsEstadoCivil char (12),
@dtNascimento date
AS INSERT INTO tb_pessoa VALUES (@nmPessoa, @dsEndereco, @dsEstadoCivil, @dtNascimento)

CREATE PROCEDURE sp_atualizarPessoa
@idPessoa int,
@nmPessoa varchar (200),
@dsEndereco varchar (300),
@dsEstadoCivil char (12),
@dtNascimento date
AS UPDATE tb_pessoa SET nmPessoa = @nmPessoa, dsEndereco = @dsEndereco, dsEstadoCivil = @dsEstadoCivil, dtNascimento = @dtNascimento WHERE idPessoa = @idPessoa

CREATE PROCEDURE sp_inserirDocumentoPessoa
@idPessoa INT,
@nrRG CHAR(10),
@nrCpf char (12),
@nrReservista char (12),
@nrCarteiraTrabalho char (8),
@nrCnh char (11)
AS INSERT INTO tb_pessoaDocumento VALUES (@idPessoa, @nrRG, @nrCpf, @nrReservista, @nrCarteiraTrabalho, @nrCnh)

CREATE PROCEDURE sp_atualizarDocumentoPessoa
@idPessoa INT,
@nrRG CHAR(10),
@nrCpf char (12),
@nrReservista char (12),
@nrCarteiraTrabalho char (8),
@nrCnh char (11),
@idPessoaDocumento INT
AS UPDATE tb_pessoaDocumento SET idPessoa = @idPessoa, nrRg = @nrRG, nrCpf = @nrCpf, nrReservista = @nrReservista, nrCarteiraTrabalho = @nrCarteiraTrabalho, nrCnh = @nrCnh WHERE idPessoaDocumento = @idPessoaDocumento

CREATE PROCEDURE sp_inserirFuncionario
@idPessoa int,
@nmCargo varchar (100),
@nrSalario float,
@nrRamal char (6)
AS INSERT INTO tb_funcionario values (@idPessoa, @nmCargo, @nrSalario, @nrRamal)

CREATE PROCEDURE sp_atualizarFuncionario
@idFuncionario int,
@idPessoa int,
@nmCargo varchar (100),
@nrSalario float,
@nrRamal char (6)
AS UPDATE tb_funcionario SET idPessoa = @idPessoa, nmCargo = @nmCargo, nrSalario = @nrSalario, nrRamal = @nrRamal WHERE idFuncionario = @idFuncionario



