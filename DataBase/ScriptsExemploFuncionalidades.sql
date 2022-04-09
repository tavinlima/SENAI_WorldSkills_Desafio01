USE WSTowers

-- A aplicação deverá calcular o resumo das vendas. 
-- Apresentar a região, a somatória de vendas (R$) 
-- e a quantidade vendida por região
SELECT regiao.regiao, SUM(valor) AS 'R$', SUM(quantidade) AS 'Vendas' FROM vendas 
JOIN produto ON vendas.produto = produto.id
JOIN participante ON participante = participante.id 
JOIN cidade ON participante.cidade = cidade.id 
JOIN estado ON cidade.estado = estado.id
JOIN regiao ON estado.regiao = regiao.id
GROUP BY regiao.regiao

-- Apresentar em formato de tabela:
-- Nome do Participante, Cidade, Valor Total comprado de produtos.

SELECT nome, cidade.cidade, SUM(valor) AS 'Valor total comprado' FROM vendas
INNER JOIN produto ON vendas.produto = produto.id
INNER JOIN participante ON vendas.participante = participante.id
INNER JOIN cidade ON participante.cidade = cidade.id
GROUP BY CUBE (participante.nome, cidade.cidade)
ORDER BY(SUM(valor))DESC;

-- Login (metade)
SELECT nome FROM participante
WHERE nome like 'A%' and nome like  '%CONSTATINO' 