--Borra las tablas
DROP TABLE ContasPoupanca;

CREATE TABLE	ContasPoupanca(
	codigo INT PRIMARY KEY IDENTITY, 
	nome VARCHAR(100),
	saldo DECIMAL (6 , 2) NOT NULL
);
INSERT INTO ContasPoupanca (nome, saldo)
VALUES ('Francisco', 11.49)

SELECT * FROM ContasPoupanca;
--VARCHAR(100) campo de texto permite hasta 100 caracteres
--DECIMAL numero del tipo real
-- INT inteiro
--IDENTITY para ser auto incrementado la columna, ou seja, primer registro 1, 2, 3
--NOT NULL no permite nulo