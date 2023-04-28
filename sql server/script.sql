-- create
CREATE TABLE cliente (
  Id UNIQUEIDENTIFIER not null primary key default NEWID(),
  name varchar(100) not null,
  cpf varchar(11) not null,
  uf varchar(10) not null
);

select * from cliente c 

CREATE TABLE financiamento (
  Id UNIQUEIDENTIFIER not null primary key default NEWID(),
  cpf varchar(11) not null,
  uf varchar(10) not null,
  tipo_de_financiamento varchar(10) not null,
  valor_total int not null,
  numero_de_parcelas int not null,
  data_do_ultimo_vencimento date not null
);

select * from financiamento 

create table parcela (
  Id UNIQUEIDENTIFIER not null primary key default NEWID(),
  financiamento_Id uniqueidentifier not null FOREIGN KEY REFERENCES financiamento(Id),
  numero int not null,
  valor int not null,
  data_de_vencimento date not null,
  data_de_pagamento date
);

select * from parcela

create table contrato (
	Id uniqueidentifier not null primary key default NEWID(),
	cliente_id uniqueidentifier not null foreign key references cliente(Id),
	financiamento_id uniqueidentifier not null foreign key references financiamento(Id)
);

select * from contrato

create table parcela_do_financiamento (
	id uniqueidentifier not null primary key default NEWID(),
	contrato_id uniqueidentifier not null foreign key references contrato(Id),
	parcela_id uniqueidentifier not null foreign key references parcela(Id)
);

select * from parcela_do_financiamento 

INSERT INTO cliente (name,cpf,uf) VALUES
    ('bruno','30030030030','sp'),
    ('pacheco','38334035861','rj');

INSERT INTO financiamento (cpf,uf,tipo_de_financiamento,valor_total,numero_de_parcelas,data_do_ultimo_vencimento) VALUES
    ('30030030030','sp','direto',1000,5,'2023-09-11');

INSERT INTO contrato (cliente_id,financiamento_id) VALUES
    ('6F3619C2-EC8C-4E04-874C-421F08F2F5DC','68F6070A-5793-4B91-848E-C06BB495545D');

INSERT INTO master.dbo.parcela (financiamento_Id,numero,valor,data_de_vencimento,data_de_pagamento) VALUES
    ('68F6070A-5793-4B91-848E-C06BB495545D',1,100,'2023-05-11','2023-05-11'),
    ('68F6070A-5793-4B91-848E-C06BB495545D',2,100,'2023-06-11','2023-06-11'),
    ('68F6070A-5793-4B91-848E-C06BB495545D',3,100,'2023-07-11',NULL),
    ('68F6070A-5793-4B91-848E-C06BB495545D',4,100,'2023-08-11',NULL),
    ('68F6070A-5793-4B91-848E-C06BB495545D',5,100,'2023-09-11',NULL);

INSERT INTO master.dbo.parcela_do_financiamento (contrato_id,parcela_id) VALUES
    ('C4E1CB7A-5272-46EA-9DBB-A8ACA59249E9','0DE1236F-BA89-4423-9E92-12D3CC697989'),
    ('C4E1CB7A-5272-46EA-9DBB-A8ACA59249E9','5E510AC3-0038-465F-AADB-CE3553AC65E4'),
    ('C4E1CB7A-5272-46EA-9DBB-A8ACA59249E9','F6AD5AC3-5ED2-433E-BEBE-49B34D976AC9'),
    ('C4E1CB7A-5272-46EA-9DBB-A8ACA59249E9','C84954DF-54BF-47E0-B9DE-7BC899B6380F'),
    ('C4E1CB7A-5272-46EA-9DBB-A8ACA59249E9','BA1298B3-576F-49FF-BB1B-A1043FF09041');

// consulta incorreta
select count(*), CAST(ROUND((count(*) * 100.0) / count(tab.Id), 2) AS DECIMAL(5,2)) 
from (
	select cliente.Id 
	from cliente
	join financiamento f 
	on f.cpf = cliente.cpf 
	join parcela
	on parcela.financiamento_Id = f.Id
	where cliente.uf  = 'sp'
) as tab


// consulta incorreta
select top 4 * from
(
select cliente.Id, parcela.data_de_pagamento as data_de_pagamento from cliente
	join financiamento f 
	on f.cpf = cliente.cpf 
	join parcela
	on parcela.financiamento_Id = f.id
where parcela.data_de_vencimento > '2023-05-11' 
) tab
where tab.data_de_pagamento = null




