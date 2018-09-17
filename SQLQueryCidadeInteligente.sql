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

SELECT * FROM tb_pessoa
SELECT * FROM tb_pessoaDocumento
SELECT * FROM tb_funcionario
SELECT * FROM tb_cliente
