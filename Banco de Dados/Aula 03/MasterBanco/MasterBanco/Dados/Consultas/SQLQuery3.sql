-- OP READ - LER

SELECT * FROM Contas;
GO 

SELECT Id, Titular, Numero_Da_Conta, Saldo FROM Contas
WHERE Saldo > 1000;
GO

SELECT * FROM Contas 
WHERE Titular LIKE '%Maria%';
GO