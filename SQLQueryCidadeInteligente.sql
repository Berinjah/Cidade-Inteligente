CREATE DATABASE CidadeInteligente
GO

USE CidadeInteligente

GO
CREATE TABLE tb_pessoa(
	idPessoa int primary key identity (1,1),
	nmPessoa varchar (200),
	dsEndereco varchar (300),
	dsEstadoCivil char (12),
	dtNascimento date,
	dsUf char(2),
	dsCidade varchar(100),
	dsSexo char(1)
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

CREATE TABLE city (
  ID int NOT NULL,
  Name char(35) NOT NULL DEFAULT '',
  CountryCode char(3) NOT NULL DEFAULT '',
  District char(20) NOT NULL DEFAULT '',
  Populacao int NOT NULL DEFAULT '0'
)
GO
--
-- Extraindo dados da tabela `city`
--

INSERT INTO city (ID, Name, CountryCode, District, Populacao) VALUES
(206, 'S�o Paulo', 'BRA', 'SP', 9968485),
(207, 'Rio de Janeiro', 'BRA', 'RJ', 5598953),
(208, 'Salvador', 'BRA', 'BA', 2302832),
(209, 'Belo Horizonte', 'BRA', 'MG', 2139125),
(210, 'Fortaleza', 'BRA', 'CE', 2097757),
(211, 'Bras�lia', 'BRA', 'DF', 1969868),
(212, 'Curitiba', 'BRA', 'PR', 1584232),
(213, 'Recife', 'BRA', 'PE', 1378087),
(214, 'Porto Alegre', 'BRA', 'RS', 1314032),
(215, 'Manaus', 'BRA', 'AM', 1255049),
(216, 'Bel�m', 'BRA', 'PA', 1186926),
(217, 'Guarulhos', 'BRA', 'SP', 1095874),
(218, 'Goi�nia', 'BRA', 'GO', 1056330),
(219, 'Campinas', 'BRA', 'SP', 950043),
(220, 'S�o Gon�alo', 'BRA', 'RJ', 869254),
(221, 'Nova Igua�u', 'BRA', 'RJ', 862225),
(222, 'S�o Lu�s', 'BRA', 'MA', 837588),
(223, 'Macei�', 'BRA', 'AL', 786288),
(224, 'Duque de Caxias', 'BRA', 'RJ', 746758),
(225, 'S�o Bernardo do Campo', 'BRA', 'SP', 723132),
(226, 'Teresina', 'BRA', 'PI', 691942),
(227, 'Natal', 'BRA', 'RN', 688955),
(228, 'Osasco', 'BRA', 'SP', 659604),
(229, 'Campo Grande', 'BRA', 'MT', 649593),
(230, 'Santo Andr�', 'BRA', 'SP', 630073),
(231, 'Jo�o Pessoa', 'BRA', 'PB', 584029),
(232, 'Jaboat�o dos Guararapes', 'BRA', 'PE', 558680),
(233, 'Contagem', 'BRA', 'MG', 520801),
(234, 'S�o Jos� dos Campos', 'BRA', 'SP', 515553),
(235, 'Uberl�ndia', 'BRA', 'MG', 487222),
(236, 'Feira de Santana', 'BRA', 'BA', 479992),
(237, 'Ribeir�o Preto', 'BRA', 'SP', 473276),
(238, 'Sorocaba', 'BRA', 'SP', 466823),
(239, 'Niter�i', 'BRA', 'RJ', 459884),
(240, 'Cuiab�', 'BRA', 'MT', 453813),
(241, 'Juiz de Fora', 'BRA', 'MG', 450288),
(242, 'Aracaju', 'BRA', 'SE', 445555),
(243, 'S�o Jo�o de Meriti', 'BRA', 'RJ', 440052),
(244, 'Londrina', 'BRA', 'PR', 432257),
(245, 'Joinville', 'BRA', 'SC', 428011),
(246, 'Belford Roxo', 'BRA', 'RJ', 425194),
(247, 'Santos', 'BRA', 'SP', 408748),
(248, 'Ananindeua', 'BRA', 'PA', 400940),
(249, 'Campos dos Goytacazes', 'BRA', 'RJ', 398418),
(250, 'Mau�', 'BRA', 'SP', 375055),
(251, 'Carapicu�ba', 'BRA', 'SP', 357552),
(252, 'Olinda', 'BRA', 'PE', 354732),
(253, 'Campina Grande', 'BRA', 'PB', 352497),
(254, 'S�o Jos� do Rio Preto', 'BRA', 'SP', 351944),
(255, 'Caxias do Sul', 'BRA', 'RS', 349581),
(256, 'Moji das Cruzes', 'BRA', 'SP', 339194),
(257, 'Diadema', 'BRA', 'SP', 335078),
(258, 'Aparecida de Goi�nia', 'BRA', 'GO', 324662),
(259, 'Piracicaba', 'BRA', 'SP', 319104),
(260, 'Cariacica', 'BRA', 'ES', 319033),
(261, 'Vila Velha', 'BRA', 'ES', 318758),
(262, 'Pelotas', 'BRA', 'RS', 315415),
(263, 'Bauru', 'BRA', 'SP', 313670),
(264, 'Porto Velho', 'BRA', 'RO', 309750),
(265, 'Serra', 'BRA', 'ES', 302666),
(266, 'Betim', 'BRA', 'MG', 302108),
(267, 'Jund�a�', 'BRA', 'SP', 296127),
(268, 'Canoas', 'BRA', 'RS', 294125),
(269, 'Franca', 'BRA', 'SP', 290139),
(270, 'S�o Vicente', 'BRA', 'SP', 286848),
(271, 'Maring�', 'BRA', 'PR', 286461),
(272, 'Montes Claros', 'BRA', 'MG', 286058),
(273, 'An�polis', 'BRA', 'GO', 282197),
(274, 'Florian�polis', 'BRA', 'SC', 281928),
(275, 'Petr�polis', 'BRA', 'RJ', 279183),
(276, 'Itaquaquecetuba', 'BRA', 'SP', 270874),
(277, 'Vit�ria', 'BRA', 'ES', 270626),
(278, 'Ponta Grossa', 'BRA', 'PR', 268013),
(279, 'Rio Branco', 'BRA', 'AC', 259537),
(280, 'Foz do Igua�u', 'BRA', 'PR', 259425),
(281, 'Macap�', 'BRA', 'AP', 256033),
(282, 'Ilh�us', 'BRA', 'BA', 254970),
(283, 'Vit�ria da Conquista', 'BRA', 'BA', 253587),
(284, 'Uberaba', 'BRA', 'MG', 249225),
(285, 'Paulista', 'BRA', 'PE', 248473),
(286, 'Limeira', 'BRA', 'SP', 245497),
(287, 'Blumenau', 'BRA', 'SC', 244379),
(288, 'Caruaru', 'BRA', 'PE', 244247),
(289, 'Santar�m', 'BRA', 'PA', 241771),
(290, 'Volta Redonda', 'BRA', 'RJ', 240315),
(291, 'Novo Hamburgo', 'BRA', 'RS', 239940),
(292, 'Caucaia', 'BRA', 'CE', 238738),
(293, 'Santa Maria', 'BRA', 'RS', 238473),
(294, 'Cascavel', 'BRA', 'PR', 237510),
(295, 'Guaruj�', 'BRA', 'SP', 237206),
(296, 'Ribeir�o das Neves', 'BRA', 'MG', 232685),
(297, 'Governador Valadares', 'BRA', 'MG', 231724),
(298, 'Taubat�', 'BRA', 'SP', 229130),
(299, 'Imperatriz', 'BRA', 'MA', 224564),
(300, 'Gravata�', 'BRA', 'RS', 223011),
(301, 'Embu', 'BRA', 'SP', 222223),
(302, 'Mossor�', 'BRA', 'RN', 214901),
(303, 'V�rzea Grande', 'BRA', 'MT', 214435),
(304, 'Petrolina', 'BRA', 'PE', 210540),
(305, 'Barueri', 'BRA', 'SP', 208426),
(306, 'Viam�o', 'BRA', 'RS', 207557),
(307, 'Ipatinga', 'BRA', 'MG', 206338),
(308, 'Juazeiro', 'BRA', 'BA', 201073),
(309, 'Juazeiro do Norte', 'BRA', 'CE', 199636),
(310, 'Tabo�o da Serra', 'BRA', 'SP', 197550),
(311, 'S�o Jos� dos Pinhais', 'BRA', 'PR', 196884),
(312, 'Mag�', 'BRA', 'RJ', 196147),
(313, 'Suzano', 'BRA', 'SP', 195434),
(314, 'S�o Leopoldo', 'BRA', 'RS', 189258),
(315, 'Mar�lia', 'BRA', 'SP', 188691),
(316, 'S�o Carlos', 'BRA', 'SP', 187122),
(317, 'Sumar�', 'BRA', 'SP', 186205),
(318, 'Presidente Prudente', 'BRA', 'SP', 185340),
(319, 'Divin�polis', 'BRA', 'MG', 185047),
(320, 'Sete Lagoas', 'BRA', 'MG', 182984),
(321, 'Rio Grande', 'BRA', 'RS', 182222),
(322, 'Itabuna', 'BRA', 'BA', 182148),
(323, 'Jequi�', 'BRA', 'BA', 179128),
(324, 'Arapiraca', 'BRA', 'AL', 178988),
(325, 'Colombo', 'BRA', 'PR', 177764),
(326, 'Americana', 'BRA', 'SP', 177409),
(327, 'Alvorada', 'BRA', 'RS', 175574),
(328, 'Araraquara', 'BRA', 'SP', 174381),
(329, 'Itabora�', 'BRA', 'RJ', 173977),
(330, 'Santa B�rbara d�Oeste', 'BRA', 'SP', 171657),
(331, 'Nova Friburgo', 'BRA', 'RJ', 170697),
(332, 'Jacare�', 'BRA', 'SP', 170356),
(333, 'Ara�atuba', 'BRA', 'SP', 169303),
(334, 'Barra Mansa', 'BRA', 'RJ', 168953),
(335, 'Praia Grande', 'BRA', 'SP', 168434),
(336, 'Marab�', 'BRA', 'PA', 167795),
(337, 'Crici�ma', 'BRA', 'SC', 167661),
(338, 'Boa Vista', 'BRA', 'RR', 167185),
(339, 'Passo Fundo', 'BRA', 'RS', 166343),
(340, 'Dourados', 'BRA', 'MT', 164716),
(341, 'Santa Luzia', 'BRA', 'MG', 164704),
(342, 'Rio Claro', 'BRA', 'SP', 163551),
(343, 'Maracana�', 'BRA', 'CE', 162022),
(344, 'Guarapuava', 'BRA', 'PR', 160510),
(345, 'Rondon�polis', 'BRA', 'MT', 155115),
(346, 'S�o Jos�', 'BRA', 'SC', 155105),
(347, 'Cachoeiro de Itapemirim', 'BRA', 'ES', 155024),
(348, 'Nil�polis', 'BRA', 'RJ', 153383),
(349, 'Itapevi', 'BRA', 'SP', 150664),
(350, 'Cabo de Santo Agostinho', 'BRA', 'PE', 149964),
(351, 'Cama�ari', 'BRA', 'BA', 149146),
(352, 'Sobral', 'BRA', 'CE', 146005),
(353, 'Itaja�', 'BRA', 'SC', 145197),
(354, 'Chapec�', 'BRA', 'SC', 144158),
(355, 'Cotia', 'BRA', 'SP', 140042),
(356, 'Lages', 'BRA', 'SC', 139570),
(357, 'Ferraz de Vasconcelos', 'BRA', 'SP', 139283),
(358, 'Indaiatuba', 'BRA', 'SP', 135968),
(359, 'Hortol�ndia', 'BRA', 'SP', 135755),
(360, 'Caxias', 'BRA', 'MA', 133980),
(361, 'S�o Caetano do Sul', 'BRA', 'SP', 133321),
(362, 'Itu', 'BRA', 'SP', 132736),
(363, 'Nossa Senhora do Socorro', 'BRA', 'SE', 131351),
(364, 'Parna�ba', 'BRA', 'PI', 129756),
(365, 'Po�os de Caldas', 'BRA', 'MG', 129683),
(366, 'Teres�polis', 'BRA', 'RJ', 128079),
(367, 'Barreiras', 'BRA', 'BA', 127801),
(368, 'Castanhal', 'BRA', 'PA', 127634),
(369, 'Alagoinhas', 'BRA', 'BA', 126820),
(370, 'Itapecerica da Serra', 'BRA', 'SP', 126672),
(371, 'Uruguaiana', 'BRA', 'RS', 126305),
(372, 'Paranagu�', 'BRA', 'PR', 126076),
(373, 'Ibirit�', 'BRA', 'MG', 125982),
(374, 'Timon', 'BRA', 'MA', 125812),
(375, 'Luzi�nia', 'BRA', 'GO', 125597),
(376, 'Maca�', 'BRA', 'RJ', 125597),
(377, 'Te�filo Otoni', 'BRA', 'MG', 124489),
(378, 'Moji-Gua�u', 'BRA', 'SP', 123782),
(379, 'Palmas', 'BRA', 'TO', 121919),
(380, 'Pindamonhangaba', 'BRA', 'SP', 121904),
(381, 'Francisco Morato', 'BRA', 'SP', 121197),
(382, 'Bag�', 'BRA', 'RS', 120793),
(383, 'Sapucaia do Sul', 'BRA', 'RS', 120217),
(384, 'Cabo Frio', 'BRA', 'RJ', 119503),
(385, 'Itapetininga', 'BRA', 'SP', 119391),
(386, 'Patos de Minas', 'BRA', 'MG', 119262),
(387, 'Camaragibe', 'BRA', 'PE', 118968),
(388, 'Bragan�a Paulista', 'BRA', 'SP', 116929),
(389, 'Queimados', 'BRA', 'RJ', 115020),
(390, 'Aragua�na', 'BRA', 'TO', 114948),
(391, 'Garanhuns', 'BRA', 'PE', 114603),
(392, 'Vit�ria de Santo Ant�o', 'BRA', 'PE', 113595),
(393, 'Santa Rita', 'BRA', 'PB', 113135),
(394, 'Barbacena', 'BRA', 'MG', 113079),
(395, 'Abaetetuba', 'BRA', 'PA', 111258),
(396, 'Ja�', 'BRA', 'SP', 109965),
(397, 'Lauro de Freitas', 'BRA', 'BA', 109236),
(398, 'Franco da Rocha', 'BRA', 'SP', 108964),
(399, 'Teixeira de Freitas', 'BRA', 'BA', 108441),
(400, 'Varginha', 'BRA', 'MG', 108314),
(401, 'Ribeir�o Pires', 'BRA', 'SP', 108121),
(402, 'Sabar�', 'BRA', 'MG', 107781),
(403, 'Catanduva', 'BRA', 'SP', 107761),
(404, 'Rio Verde', 'BRA', 'GO', 107755),
(405, 'Botucatu', 'BRA', 'SP', 107663),
(406, 'Colatina', 'BRA', 'ES', 107354),
(407, 'Santa Cruz do Sul', 'BRA', 'RS', 106734),
(408, 'Linhares', 'BRA', 'ES', 106278),
(409, 'Apucarana', 'BRA', 'PR', 105114),
(410, 'Barretos', 'BRA', 'SP', 104156),
(411, 'Guaratinguet�', 'BRA', 'SP', 103433),
(412, 'Cachoeirinha', 'BRA', 'RS', 103240),
(413, 'Cod�', 'BRA', 'MA', 103153),
(414, 'Jaragu� do Sul', 'BRA', 'SC', 102580),
(415, 'Cubat�o', 'BRA', 'SP', 102372),
(416, 'Itabira', 'BRA', 'MG', 102217),
(417, 'Itaituba', 'BRA', 'PA', 101320),
(418, 'Araras', 'BRA', 'SP', 101046),
(419, 'Resende', 'BRA', 'RJ', 100627),
(420, 'Atibaia', 'BRA', 'SP', 100356),
(421, 'Pouso Alegre', 'BRA', 'MG', 100028),
(422, 'Toledo', 'BRA', 'PR', 99387),
(423, 'Crato', 'BRA', 'CE', 98965),
(424, 'Passos', 'BRA', 'MG', 98570),
(425, 'Araguari', 'BRA', 'MG', 98399),
(426, 'S�o Jos� de Ribamar', 'BRA', 'MA', 98318),
(427, 'Pinhais', 'BRA', 'PR', 98198),
(428, 'Sert�ozinho', 'BRA', 'SP', 98140),
(429, 'Conselheiro Lafaiete', 'BRA', 'MG', 97507),
(430, 'Paulo Afonso', 'BRA', 'BA', 97291),
(431, 'Angra dos Reis', 'BRA', 'RJ', 96864),
(432, 'Eun�polis', 'BRA', 'BA', 96610),
(433, 'Salto', 'BRA', 'SP', 96348),
(434, 'Ourinhos', 'BRA', 'SP', 96291),
(435, 'Parnamirim', 'BRA', 'RN', 96210),
(436, 'Jacobina', 'BRA', 'BA', 96131),
(437, 'Coronel Fabriciano', 'BRA', 'MG', 95933),
(438, 'Birigui', 'BRA', 'SP', 94685),
(439, 'Tatu�', 'BRA', 'SP', 93897),
(440, 'Ji-PR', 'BRA', 'RO', 93346),
(441, 'Bacabal', 'BRA', 'MA', 93121),
(442, 'Camet�', 'BRA', 'PA', 92779),
(443, 'Gua�ba', 'BRA', 'RS', 92224),
(444, 'S�o Louren�o da Mata', 'BRA', 'PE', 91999),
(445, 'Santana do Livramento', 'BRA', 'RS', 91779),
(446, 'Votorantim', 'BRA', 'SP', 91777),
(447, 'Campo Largo', 'BRA', 'PR', 91203),
(448, 'Patos', 'BRA', 'PB', 90519),
(449, 'Ituiutaba', 'BRA', 'MG', 90507),
(450, 'Corumb�', 'BRA', 'MT', 90111),
(451, 'Palho�a', 'BRA', 'SC', 89465),
(452, 'Barra do Pira�', 'BRA', 'RJ', 89388),
(453, 'Bento Gon�alves', 'BRA', 'RS', 89254),
(454, 'Po�', 'BRA', 'SP', 89236),
(455, '�guas Lindas de GO', 'BRA', 'GO', 89200);
GO

SELECT * FROM tb_pessoa
SELECT * FROM tb_pessoaDocumento
SELECT * FROM tb_funcionario
SELECT * FROM tb_cliente
SELECT * FROM city
GO

CREATE PROCEDURE sp_retornarClientes
AS SELECT idCliente as 'ID do cliente', idPessoa as 'ID da pessoa', dtInclusao as 'Data de inclus�o' FROM tb_cliente
GO

CREATE PROCEDURE sp_retornarFuncionarios
AS SELECT idFuncionario as 'ID do funcion�rio', idPessoa as 'ID da pessoa', nmCargo as 'Cargo', nrSalario as 'Sal�rio', nrRamal as 'Ramal' FROM tb_funcionario
GO

CREATE PROCEDURE sp_retornarPessoas
AS SELECT idPessoa as 'ID da pessoa', nmPessoa as 'Nome completo', dsEndereco as 'Endere�o', dsEstadoCivil as 'Estado Civil', dtNascimento as 'Data de nascimento' FROM tb_pessoa
GO

CREATE PROCEDURE sp_retornarDocumentoPessoa
AS SELECT idPessoaDocumento as 'ID dos documentos pessoais', idPessoa as 'ID da pessoa', nrRg as 'RG', nrCpf as 'CPF', nrReservista as 'Reservista', nrCarteiraTrabalho as 'CTPS', nrCnh as 'CNH' FROM tb_pessoaDocumento
GO

CREATE PROCEDURE sp_inserirCliente
@idPessoa INT,
@dtDataInclusao DATE
AS INSERT INTO tb_cliente values (@idPessoa, @dtDataInclusao)
GO

CREATE PROCEDURE sp_atualizarCliente
@idPessoa INT,
@dtDataInclusao DATE,
@idCliente INT
AS UPDATE tb_cliente SET idPessoa = @idPessoa, dtInclusao = @dtDataInclusao WHERE idCliente = @idCliente
GO

CREATE PROCEDURE sp_inserirPessoa
@nmPessoa varchar (200),
@dsEndereco varchar (300),
@dsEstadoCivil char (12),
@dtNascimento date
AS INSERT INTO tb_pessoa VALUES (@nmPessoa, @dsEndereco, @dsEstadoCivil, @dtNascimento)
GO

CREATE PROCEDURE sp_atualizarPessoa
@idPessoa int,
@nmPessoa varchar (200),
@dsEndereco varchar (300),
@dsEstadoCivil char (12),
@dtNascimento date
AS UPDATE tb_pessoa SET nmPessoa = @nmPessoa, dsEndereco = @dsEndereco, dsEstadoCivil = @dsEstadoCivil, dtNascimento = @dtNascimento WHERE idPessoa = @idPessoa
GO

CREATE PROCEDURE sp_inserirDocumentoPessoa
@idPessoa INT,
@nrRG CHAR(10),
@nrCpf char (12),
@nrReservista char (12),
@nrCarteiraTrabalho char (8),
@nrCnh char (11)
AS INSERT INTO tb_pessoaDocumento VALUES (@idPessoa, @nrRG, @nrCpf, @nrReservista, @nrCarteiraTrabalho, @nrCnh)
GO

CREATE PROCEDURE sp_atualizarDocumentoPessoa
@idPessoa INT,
@nrRG CHAR(10),
@nrCpf char (12),
@nrReservista char (12),
@nrCarteiraTrabalho char (8),
@nrCnh char (11),
@idPessoaDocumento INT
AS UPDATE tb_pessoaDocumento SET idPessoa = @idPessoa, nrRg = @nrRG, nrCpf = @nrCpf, nrReservista = @nrReservista, nrCarteiraTrabalho = @nrCarteiraTrabalho, nrCnh = @nrCnh WHERE idPessoaDocumento = @idPessoaDocumento
GO

CREATE PROCEDURE sp_inserirFuncionario
@idPessoa int,
@nmCargo varchar (100),
@nrSalario float,
@nrRamal char (6)
AS INSERT INTO tb_funcionario values (@idPessoa, @nmCargo, @nrSalario, @nrRamal)
GO

CREATE PROCEDURE sp_atualizarFuncionario
@idFuncionario int,
@idPessoa int,
@nmCargo varchar (100),
@nrSalario float,
@nrRamal char (6)
AS UPDATE tb_funcionario SET idPessoa = @idPessoa, nmCargo = @nmCargo, nrSalario = @nrSalario, nrRamal = @nrRamal WHERE idFuncionario = @idFuncionario
GO

CREATE PROCEDURE sp_retornarCidades
@district varchar (30)
AS SELECT name FROM city WHERE District = @district
GROUP BY name
GO

CREATE PROCEDURE sp_retornarUf
AS SELECT District FROM city GROUP BY District

