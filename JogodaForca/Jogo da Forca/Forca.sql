create database Forcadb;

use forcadb;

create table tb_palavras (
id_palavras int auto_increment primary key,
ds_palavra varchar(50)
);

select count(*) from tb_palavras;

select * from tb_palavras;

insert into tb_palavras (ds_palavra) value ('mar','oceano');

insert into tb_palavras (ds_palavra) values('continente');

update tb_palavras set ds_palavra = 'hardware' where id_palavras =7;


create database dreamdb;

use dreamdb;

create table tb_dream (
id_dream int primary key auto_increment,
tx_dream varchar(50),
ds_dream varchar(250)
);

select * from tb_dream;
