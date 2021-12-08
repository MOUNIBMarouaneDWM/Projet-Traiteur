Create database Gestion_traiteur
Use Gestion_traiteur
drop database Gestion_traiteur

SET DATEFORMAT dmy;
--table client 

create table Client(
CIN_C varchar(20) primary key,
Nom_C varchar(20) not null,
Prenom_C varchar(20) not null,
Tel varchar(20)not null,
Adresse varchar(100) null,
DateN date not null,
Email varchar(20) unique null,
Mdp_C varchar(20) null)



insert into Client values 
('imm25121','saad', 'Ibrahimi','0665892011','Res Amal app 10','20/12/1993','maroua@gmail.com','AZERTY123')
('BM625121','saad', 'Ibrahimi','0665892011','Res Amal app 10','20/12/1993','marouan1@gmail.com','AZERTY123' ),
('BJ625305','ahmed', 'idrissi','0695210230','Res saad app 10','20/12/1985','marouan2@gmail.com','AZERTY123' ),
('B623015','mohamed', 'jfiri','0690162301','bloc 7 app 16 jamila 2','20/12/1993','marouan3@gmail.com','123456789' )

 select* from Client


--table Traiteur

create table Traiteur(
Id_T int primary key identity,
admin_ varchar(20) not null,
Mdp_T varchar(20) not null)

select * from Traiteur
insert into Traiteur values
('admin','admin')
--table Etat 
drop table Etat
create table Etat(
Id_E int primary key identity,
Etat varchar(20)) 

insert into Etat values ('En attante'),
('annulé'),
('Validé'),
('Terminé')
--table Repas

create table Repas(
Id_R int primary key,
Nom_R varchar(20) not null,
prix money not null
)
alter table repas
alter column  Nom_R varchar(30)
 select * from Repas

 insert into Repas values (1,'Agneau grillé',1200),
(2,'poulet roti',300),
(3,'pastel au poulet',400),
(4,'pastilla fruit de mer',750),
(5,'gateau glacé fraise' ,150),
(6,'gateau glacé au chocolat',150),
(7,'gateau glacé au vanille', 120)
--table evenment 

create table Evenment(
Id_E int primary key,
Nom_E varchar(20)
)
 insert into Evenment values (1,'anniversaire'),
 (2,'marriage')


  select * from Evenment



--table Objet
 
 create table Objet(
 Id_O int primary key ,
 Nom_O  varchar(20) 
 )
 ALter table objet 
 add Quantite int,Prix_O money

 insert into Objet values (1,'Table',125, 100),
(2,'Chaise',1500,10),
(3,'Verre à thé',5000,null),
(4,'Verre d''eau',4885,null),
(5,'assiette',50000,null)

   select * from objet


 --table Commende
 create table Commende(
 Id_Cmd int primary key IDENTITY,
 Repas1 int references Repas(Id_R) null,
 QuantiterR1 int null,
 Repas2 int references Repas(Id_R) null,
 QuantiterR2 int null,
 Repas3 int references Repas(Id_R) null,
 QuantiterR3 int null,
 Date_Cmd Date ,
 Date_D Datetime ,
 Lieux_D varchar(200),
 Prix_TOTAL money,
 CIN_C varchar(20) references Client(CIN_C),
 Etat int references Etat(Id_E),
 Evenment int references Evenment(Id_E),
 Payer varchar(20) 
 )

 select * from Commende
 where 


 insert into Commende values(1,3,2,4,3,5,'11/12/2020 20:22','11/12/2020 20:22','CASA RUE 12 N 2 etag 5',2600,'BJ625305',2,1,'nom')
 select * from Commende
 --table reserver
 drop table  Commende


 create table Reserver  (
 Id_O int references Objet(Id_O),
 id_Cmd int references Commende(id_Cmd) ,
 nbr_O int,
 primary key (Id_O,id_Cmd) )

 insert into Reserver values(2,2,12)
































 --test
 create table test
 (Id_Cmd int primary key,
 dat datetime
 )
 insert into test values(4,'20/07/2003 15:12') 
 select * from test