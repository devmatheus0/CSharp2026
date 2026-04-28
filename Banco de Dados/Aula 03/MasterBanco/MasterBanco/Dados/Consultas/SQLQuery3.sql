-- OP READ - LER
/*
SELECT * FROM Contas;
GO 

SELECT Id, Titular, Numero_Da_Conta, Saldo FROM Contas
WHERE Saldo > 1000;
GO

SELECT * FROM Contas 
WHERE Titular LIKE '%Maria%';
GO

SELECT * FROM Contas
WHERE Numero_Da_Conta = 1002
GO


-- Ordenas por saldo do maior p/menor
SELECT * FROM Contas
ORDER BY Saldo DESC 
GO
*/

SELECT COUNT (*) AS TotalContas FROM Contas

-- Ordenas por saldo do menor p/maior
SELECT * FROM Contas
ORDER BY Saldo ASC
GO

-- Soma todos Saldos das contas na tabela 
SELECT SUM (Saldo) AS SaldoTotal FROM Contas

-- Média de saldo nas contas
SELECT AVG (Saldo) AS MediaSaldos FROM Contas
GO