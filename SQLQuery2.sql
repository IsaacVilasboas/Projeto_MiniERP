create database MiniERP

use MiniERP

create table fornecedores
(
	id integer primary key identity,
	cnpj decimal,
	nome varchar (50)
)
create table produtos
(
	id integer primary key identity,
	nome varchar(50),
	preco integer,
	fk_fornecedores integer,
	foreign key (fk_fornecedores) references fornecedores(id)
)
create table clientes
(
	id integer primary key identity,
	nome varchar (50) not null,
	cpf decimal not null,
)
create table notas
(
	id integer primary key identity,
	Nome_Cliente varchar (50),
	Nome_Produto varchar,
	preco integer,
	fk_produtos integer,
	fk_clientes integer,
	foreign key (fk_produtos)references produtos(id),
	foreign key (fk_clientes) references clientes(id)
)

