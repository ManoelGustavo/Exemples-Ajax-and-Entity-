CREATE TABLE hospitais(
	id INT PRIMARY KEY IDENTITY(1,1),
	razao_social VARCHAR(100),
	cnpj VARCHAR(100),
	faturamento DECIMAL (10,2),
	particular BIT,
	data_criacao DATETIME2 ,
	registro_ativo BIT
);

INSERT INTO hospitais (razao_social , cnpj , faturamento , particular, data_criacao, registro_ativo)
VALUES ('Santa Isabel' , '8574851247' , 3203.00 , 1 , '2019-06-29' , 1);