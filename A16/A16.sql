/*
	CREATE DATABASE A16;
	USE A16;
*/

CREATE TABLE Rasa(
	rasaID int IDENTITY(1,1),
	naziv_rase varchar(50)
);

CREATE TABLE Boja(
	bojaID int IDENTITY(1,1),
	boja varchar(50)
);

CREATE TABLE Pol(
	polID int IDENTITY(1,1),
	pol varchar(10)
);

CREATE TABLE Duzina_Dlake(
	duzina_dlakeID int IDENTITY(1,1),
	duzina varchar(50)
);

CREATE TABLE Vlasnik(
	vlasnikID int IDENTITY(1,1),
	ime varchar(50),
	prezime varchar(70),
	adresa text,
	jmbg varchar(20)
);

CREATE TABLE Pas(
	pasID int IDENTITY(1,1),
	ime varchar(50),
	tezina float,
	duzina_dlakeID int,
	bojaID int,
	rasaID int,
	ostenjen date,
	vlasnikID int,
	polID int
);

CREATE TABLE Kategorija(
	kategorijaID int IDENTITY(1,1),
	naziv varchar(100)
);

CREATE TABLE Izlozba(
	izlozbaID int IDENTITY(1,1),
	mesto varchar(70),
	datum date
);

CREATE TABLE Rezultat(
	izlozbaID int not null,
	kategorijaID int not null,
	pasID int not null,
	rezultat varchar(100),
	napomena text
);
/*Primary keys*/

ALTER TABLE Rasa ADD CONSTRAINT PK_Rasa PRIMARY KEY (rasaID);
ALTER TABLE Boja ADD CONSTRAINT PK_Boja PRIMARY KEY (bojaID);
ALTER TABLE Pol ADD CONSTRAINT PK_Pol PRIMARY KEY (polID);
ALTER TABLE Duzina_Dlake ADD CONSTRAINT PK_Duzina_Dlake PRIMARY KEY (duzina_dlakeID);
ALTER TABLE Vlasnik ADD CONSTRAINT PK_Vlasnik PRIMARY KEY (vlasnikID);
ALTER TABLE Pas ADD CONSTRAINT PK_Pas PRIMARY KEY (pasID);
ALTER TABLE Kategorija ADD CONSTRAINT PK_Kategorija PRIMARY KEY (kategorijaID);
ALTER TABLE Izlozba ADD CONSTRAINT PK_Izlozba PRIMARY KEY (izlozbaID);
ALTER TABLE Rezultat ADD CONSTRAINT PK_Rezultat PRIMARY KEY (izlozbaID,kategorijaID,pasID);

INSERT INTO Rasa VALUES
	('Rasa1'),
	('Rasa2'),
	('Rasa3'),
	('Rasa4'),
	('Rasa5'),
	('Rasa6'),
	('Rasa7'),
	('Rasa8'),
	('Rasa9'),
	('Rasa10');

INSERT INTO Boja VALUES
	('crna'),
	('bela'),
	('zuta'),
	('braon'),
	('crno-bela'),
	('zuto-bela'),
	('braon-bela');

INSERT INTO Pol VALUES
	('musko'),
	('zensko');

INSERT INTO Duzina_Dlake VALUES
	('1cm'),
	('3cm'),
	('5cm'),
	('7cm'),
	('10cm');

INSERT INTO Vlasnik VALUES
	('Vlasnik1','Vlasnik1','Adresa','123456781'),
	('Vlasnik2','Vlasnik2','Adresa','123456782'),
	('Vlasnik3','Vlasnik3','Adresa','123456783'),
	('Vlasnik4','Vlasnik4','Adresa','123456784'),
	('Vlasnik5','Vlasnik5','Adresa','123456785'),
	('Vlasnik6','Vlasnik6','Adresa','123456786'),
	('Vlasnik7','Vlasnik7','Adresa','123456787'),
	('Vlasnik8','Vlasnik8','Adresa','123456788'),
	('Vlasnik9','Vlasnik9','Adresa','123456789'),
	('Vlasnik10','Vlasnik10','Adresa','1234567810'),
	('Vlasnik11','Vlasnik11','Adresa','1234567811'),
	('Vlasnik12','Vlasnik12','Adresa','1234567812'),
	('Vlasnik13','Vlasnik13','Adresa','1234567813'),
	('Vlasnik14','Vlasnik14','Adresa','1234567814'),
	('Vlasnik15','Vlasnik15','Adresa','1234567815'),
	('Vlasnik16','Vlasnik16','Adresa','1234567816'),
	('Vlasnik17','Vlasnik17','Adresa','1234567817'),
	('Vlasnik18','Vlasnik18','Adresa','1234567818'),
	('Vlasnik19','Vlasnik19','Adresa','1234567819'),
	('Vlasnik20','Vlasnik20','Adresa','1234567820'),
	('Vlasnik21','Vlasnik21','Adresa','1234567821'),
	('Vlasnik22','Vlasnik22','Adresa','1234567822'),
	('Vlasnik23','Vlasnik23','Adresa','1234567823'),
	('Vlasnik24','Vlasnik24','Adresa','1234567824'),
	('Vlasnik25','Vlasnik25','Adresa','1234567825'),
	('Vlasnik26','Vlasnik26','Adresa','1234567826'),
	('Vlasnik27','Vlasnik27','Adresa','1234567827'),
	('Vlasnik28','Vlasnik28','Adresa','1234567828'),
	('Vlasnik29','Vlasnik29','Adresa','1234567829'),
	('Vlasnik30','Vlasnik30','Adresa','1234567830'),
	('Vlasnik31','Vlasnik31','Adresa','1234567831'),
	('Vlasnik32','Vlasnik32','Adresa','1234567832'),
	('Vlasnik33','Vlasnik33','Adresa','1234567833'),
	('Vlasnik34','Vlasnik34','Adresa','1234567834'),
	('Vlasnik35','Vlasnik35','Adresa','1234567835'),
	('Vlasnik36','Vlasnik36','Adresa','1234567836'),
	('Vlasnik37','Vlasnik37','Adresa','1234567837'),
	('Vlasnik38','Vlasnik38','Adresa','1234567838'),
	('Vlasnik39','Vlasnik39','Adresa','1234567839'),
	('Vlasnik40','Vlasnik40','Adresa','1234567840'),
	('Vlasnik41','Vlasnik41','Adresa','1234567841'),
	('Vlasnik42','Vlasnik42','Adresa','1234567842'),
	('Vlasnik43','Vlasnik43','Adresa','1234567843'),
	('Vlasnik44','Vlasnik44','Adresa','1234567844'),
	('Vlasnik45','Vlasnik45','Adresa','1234567845'),
	('Vlasnik46','Vlasnik46','Adresa','1234567846'),
	('Vlasnik47','Vlasnik47','Adresa','1234567847'),
	('Vlasnik48','Vlasnik48','Adresa','1234567848'),
	('Vlasnik49','Vlasnik49','Adresa','1234567849'),
	('Vlasnik50','Vlasnik50','Adresa','1234567850'),
	('Vlasnik51','Vlasnik51','Adresa','1234567851'),
	('Vlasnik52','Vlasnik52','Adresa','1234567852'),
	('Vlasnik53','Vlasnik53','Adresa','1234567853'),
	('Vlasnik54','Vlasnik54','Adresa','1234567854'),
	('Vlasnik55','Vlasnik55','Adresa','1234567855'),
	('Vlasnik56','Vlasnik56','Adresa','1234567856'),
	('Vlasnik57','Vlasnik57','Adresa','1234567857'),
	('Vlasnik58','Vlasnik58','Adresa','1234567858'),
	('Vlasnik59','Vlasnik59','Adresa','1234567859'),
	('Vlasnik60','Vlasnik60','Adresa','1234567860'),
	('Vlasnik61','Vlasnik61','Adresa','1234567861'),
	('Vlasnik62','Vlasnik62','Adresa','1234567862'),
	('Vlasnik63','Vlasnik63','Adresa','1234567863'),
	('Vlasnik64','Vlasnik64','Adresa','1234567864'),
	('Vlasnik65','Vlasnik65','Adresa','1234567865'),
	('Vlasnik66','Vlasnik66','Adresa','1234567866'),
	('Vlasnik67','Vlasnik67','Adresa','1234567867'),
	('Vlasnik68','Vlasnik68','Adresa','1234567868'),
	('Vlasnik69','Vlasnik69','Adresa','1234567869'),
	('Vlasnik70','Vlasnik70','Adresa','1234567870');
	
INSERT INTO Pas VALUES
	('Ker1',4.0,3,2,9,'2021.5.27',1,1),
	('Ker2',9.0,4,3,8,'2021.5.26',2,2),
	('Ker3',3.0,4,5,9,'2021.9.25',3,2),
	('Ker4',2.0,3,2,7,'2021.7.21',4,2),
	('Ker5',4.0,2,6,8,'2021.3.14',5,1),
	('Ker6',3.0,3,1,3,'2021.5.9',6,1),
	('Ker7',7.0,1,3,2,'2021.6.22',7,1),
	('Ker8',10.0,5,6,4,'2021.5.29',8,1),
	('Ker9',10.0,4,2,10,'2021.4.17',9,2),
	('Ker10',7.0,2,1,4,'2021.5.20',10,2),
	('Ker11',5.0,3,4,2,'2021.6.18',11,2),
	('Ker12',8.0,1,4,6,'2021.9.20',12,1),
	('Ker13',9.0,4,3,6,'2021.6.25',13,1),
	('Ker14',10.0,1,3,9,'2021.7.18',14,2),
	('Ker15',4.0,1,6,8,'2021.3.7',15,1),
	('Ker16',4.0,4,2,4,'2021.5.21',16,1),
	('Ker17',8.0,2,3,6,'2021.9.3',17,2),
	('Ker18',8.0,5,7,6,'2021.8.22',18,2),
	('Ker19',2.0,5,3,4,'2021.9.17',19,1),
	('Ker20',7.0,5,6,10,'2021.6.1',20,2),
	('Ker21',1.0,1,2,10,'2021.3.1',21,1),
	('Ker22',10.0,5,2,10,'2021.6.7',22,2),
	('Ker23',9.0,2,1,3,'2021.6.26',23,1),
	('Ker24',10.0,2,7,10,'2021.4.24',24,1),
	('Ker25',6.0,3,5,4,'2021.3.6',25,2),
	('Ker26',7.0,4,5,9,'2021.8.12',26,1),
	('Ker27',1.0,3,4,1,'2021.5.24',27,2),
	('Ker28',8.0,5,6,7,'2021.4.13',28,1),
	('Ker29',3.0,5,7,8,'2021.4.2',29,1),
	('Ker30',7.0,3,5,4,'2021.3.28',30,1),
	('Ker31',5.0,4,3,6,'2021.6.27',31,2),
	('Ker32',5.0,5,7,10,'2021.3.11',32,2),
	('Ker33',9.0,5,5,5,'2021.8.14',33,1),
	('Ker34',8.0,3,1,8,'2021.5.23',34,1),
	('Ker35',9.0,2,5,1,'2021.8.17',35,1),
	('Ker36',4.0,4,2,3,'2021.6.9',36,2),
	('Ker37',1.0,1,6,2,'2021.7.18',37,2),
	('Ker38',10.0,2,7,6,'2021.6.23',38,2),
	('Ker39',3.0,1,5,2,'2021.4.15',39,2),
	('Ker40',3.0,1,7,5,'2021.8.18',40,1),
	('Ker41',6.0,2,2,2,'2021.4.19',41,2),
	('Ker42',3.0,4,5,4,'2021.4.17',42,2),
	('Ker43',9.0,2,3,2,'2021.8.16',43,1),
	('Ker44',5.0,2,2,6,'2021.8.5',44,2),
	('Ker45',10.0,5,5,1,'2021.9.10',45,1),
	('Ker46',8.0,2,3,10,'2021.3.1',46,1),
	('Ker47',1.0,5,6,5,'2021.9.20',47,1),
	('Ker48',5.0,5,3,8,'2021.3.12',48,1),
	('Ker49',1.0,2,5,10,'2021.6.26',49,1),
	('Ker50',1.0,1,3,8,'2021.4.17',50,1),
	('Ker51',1.0,4,2,1,'2021.6.2',51,1),
	('Ker52',5.0,5,1,4,'2021.6.12',52,1),
	('Ker53',3.0,5,2,10,'2021.9.9',53,2),
	('Ker54',8.0,4,1,10,'2021.3.21',54,2),
	('Ker55',5.0,4,5,8,'2021.3.9',55,1),
	('Ker56',3.0,3,6,4,'2021.5.20',56,2),
	('Ker57',5.0,1,4,6,'2021.6.27',57,2),
	('Ker58',1.0,2,6,3,'2021.4.12',58,1),
	('Ker59',1.0,2,1,1,'2021.5.13',59,2),
	('Ker60',5.0,2,5,2,'2021.3.28',60,1),
	('Ker61',6.0,3,5,4,'2021.7.3',61,1),
	('Ker62',6.0,4,4,6,'2021.8.6',62,1),
	('Ker63',9.0,5,4,4,'2021.9.7',63,1),
	('Ker64',6.0,1,2,3,'2021.4.19',64,1),
	('Ker65',10.0,3,3,7,'2021.9.23',65,2),
	('Ker66',3.0,4,7,8,'2021.5.27',66,2),
	('Ker67',7.0,3,4,8,'2021.4.20',67,2),
	('Ker68',1.0,1,6,5,'2021.8.27',68,2),
	('Ker69',4.0,2,2,6,'2021.6.9',69,2),
	('Ker70',2.0,5,7,2,'2021.5.23',70,2);

INSERT INTO Kategorija VALUES
	('Kategorija1'),
	('Kategorija2'),
	('Kategorija3'),
	('Kategorija4'),
	('Kategorija5'),
	('Kategorija6'),
	('Kategorija7'),
	('Kategorija8'),
	('Kategorija9'),
	('Kategorija10');

INSERT INTO Izlozba VALUES
	('Mesto1','2022.12.27'),
	('Mesto2','2022.12.27'),
	('Mesto3','2022.12.13'),
	('Mesto4','2022.12.4'),
	('Mesto5','2022.12.13'),
	('Mesto6','2022.12.20'),
	('Mesto7','2022.12.13'),
	('Mesto8','2022.12.14'),
	('Mesto9','2022.12.18'),
	('Mesto10','2022.12.15');

INSERT INTO Rezultat VALUES
	(10,2,70,'rezultat','napomena'),
	(1,6,39,'rezultat','napomena'),
	(6,2,5,'rezultat','napomena'),
	(1,2,6,'rezultat','napomena'),
	(1,7,50,'rezultat','napomena'),
	(1,8,40,'rezultat','napomena'),
	(1,10,14,'rezultat','napomena'),
	(5,3,33,'rezultat','napomena'),
	(10,7,4,'rezultat','napomena'),
	(3,4,10,'rezultat','napomena'),
	(6,1,49,'rezultat','napomena'),
	(6,3,14,'rezultat','napomena'),
	(5,8,36,'rezultat','napomena'),
	(2,2,45,'rezultat','napomena'),
	(10,10,53,'rezultat','napomena'),
	(8,10,23,'rezultat','napomena'),
	(10,4,18,'rezultat','napomena'),
	(2,6,64,'rezultat','napomena'),
	(9,6,39,'rezultat','napomena'),
	(9,5,29,'rezultat','napomena'),
	(9,10,4,'rezultat','napomena'),
	(2,4,20,'rezultat','napomena'),
	(4,6,36,'rezultat','napomena'),
	(1,1,32,'rezultat','napomena'),
	(8,6,43,'rezultat','napomena'),
	(4,8,63,'rezultat','napomena'),
	(7,8,35,'rezultat','napomena'),
	(1,9,13,'rezultat','napomena'),
	(5,8,23,'rezultat','napomena'),
	(8,7,28,'rezultat','napomena'),
	(3,1,47,'rezultat','napomena'),
	(3,6,40,'rezultat','napomena'),
	(6,5,25,'rezultat','napomena'),
	(5,9,60,'rezultat','napomena'),
	(3,8,33,'rezultat','napomena'),
	(10,4,65,'rezultat','napomena'),
	(9,7,28,'rezultat','napomena'),
	(8,10,40,'rezultat','napomena'),
	(6,10,58,'rezultat','napomena'),
	(9,2,49,'rezultat','napomena'),
	(10,8,41,'rezultat','napomena'),
	(10,1,56,'rezultat','napomena'),
	(3,6,34,'rezultat','napomena'),
	(10,7,53,'rezultat','napomena'),
	(1,8,15,'rezultat','napomena'),
	(5,4,55,'rezultat','napomena'),
	(10,10,33,'rezultat','napomena'),
	(2,1,66,'rezultat','napomena'),
	(8,4,34,'rezultat','napomena'),
	(6,6,17,'rezultat','napomena'),
	(7,2,69,'rezultat','napomena'),
	(10,9,44,'rezultat','napomena'),
	(3,2,19,'rezultat','napomena'),
	(2,10,2,'rezultat','napomena'),
	(3,9,42,'rezultat','napomena'),
	(2,10,60,'rezultat','napomena'),
	(6,1,66,'rezultat','napomena'),
	(2,3,8,'rezultat','napomena'),
	(7,7,63,'rezultat','napomena'),
	(7,4,56,'rezultat','napomena'),
	(1,3,19,'rezultat','napomena'),
	(5,8,50,'rezultat','napomena'),
	(9,6,16,'rezultat','napomena'),
	(3,6,8,'rezultat','napomena'),
	(1,5,16,'rezultat','napomena'),
	(3,4,60,'rezultat','napomena'),
	(5,7,64,'rezultat','napomena'),
	(5,3,39,'rezultat','napomena'),
	(10,9,68,'rezultat','napomena'),
	(3,8,41,'rezultat','napomena'),
	(9,5,22,'rezultat','napomena'),
	(7,8,43,'rezultat','napomena'),
	(1,9,8,'rezultat','napomena'),
	(4,7,55,'rezultat','napomena'),
	(6,9,22,'rezultat','napomena'),
	(8,9,21,'rezultat','napomena'),
	(4,1,3,'rezultat','napomena'),
	(7,9,30,'rezultat','napomena'),
	(10,8,17,'rezultat','napomena'),
	(10,8,38,'rezultat','napomena'),
	(9,7,39,'rezultat','napomena'),
	(1,8,43,'rezultat','napomena'),
	(7,7,32,'rezultat','napomena'),
	(5,8,30,'rezultat','napomena'),
	(1,2,16,'rezultat','napomena'),
	(5,3,2,'rezultat','napomena'),
	(10,7,66,'rezultat','napomena'),
	(7,6,11,'rezultat','napomena'),
	(6,9,65,'rezultat','napomena'),
	(1,4,10,'rezultat','napomena'),
	(2,6,50,'rezultat','napomena'),
	(10,3,10,'rezultat','napomena'),
	(1,7,38,'rezultat','napomena'),
	(3,9,36,'rezultat','napomena'),
	(4,7,8,'rezultat','napomena'),
	(8,2,59,'rezultat','napomena'),
	(5,3,49,'rezultat','napomena'),
	(1,6,35,'rezultat','napomena'),
	(2,5,66,'rezultat','napomena'),
	(10,7,13,'rezultat','napomena'),
	(3,4,32,'rezultat','napomena'),
	(2,8,46,'rezultat','napomena'),
	(10,1,24,'rezultat','napomena'),
	(6,5,2,'rezultat','napomena'),
	(9,5,30,'rezultat','napomena'),
	(10,1,50,'rezultat','napomena'),
	(7,1,27,'rezultat','napomena'),
	(2,5,59,'rezultat','napomena'),
	(10,3,40,'rezultat','napomena'),
	(9,2,4,'rezultat','napomena'),
	(1,4,61,'rezultat','napomena'),
	(6,1,9,'rezultat','napomena'),
	(10,5,1,'rezultat','napomena'),
	(2,6,10,'rezultat','napomena'),
	(8,7,59,'rezultat','napomena'),
	(2,1,64,'rezultat','napomena'),
	(4,3,18,'rezultat','napomena'),
	(6,9,15,'rezultat','napomena'),
	(9,7,16,'rezultat','napomena'),
	(5,1,9,'rezultat','napomena'),
	(9,3,14,'rezultat','napomena'),
	(2,2,8,'rezultat','napomena'),
	(4,4,39,'rezultat','napomena'),
	(6,8,22,'rezultat','napomena'),
	(6,3,1,'rezultat','napomena'),
	(2,7,29,'rezultat','napomena'),
	(10,8,57,'rezultat','napomena'),
	(6,7,32,'rezultat','napomena'),
	(5,9,29,'rezultat','napomena'),
	(4,9,46,'rezultat','napomena'),
	(3,10,29,'rezultat','napomena'),
	(5,8,16,'rezultat','napomena'),
	(8,4,43,'rezultat','napomena'),
	(6,10,55,'rezultat','napomena'),
	(6,2,54,'rezultat','napomena'),
	(7,7,1,'rezultat','napomena'),
	(5,8,7,'rezultat','napomena'),
	(5,4,25,'rezultat','napomena'),
	(6,7,65,'rezultat','napomena'),
	(5,2,42,'rezultat','napomena'),
	(9,7,67,'rezultat','napomena'),
	(3,6,16,'rezultat','napomena'),
	(3,4,27,'rezultat','napomena'),
	(4,8,21,'rezultat','napomena'),
	(9,1,28,'rezultat','napomena'),
	(5,7,32,'rezultat','napomena'),
	(3,4,69,'rezultat','napomena'),
	(2,6,59,'rezultat','napomena'),
	(6,1,67,'rezultat','napomena'),
	(1,3,51,'rezultat','napomena'),
	(3,1,69,'rezultat','napomena'),
	(3,9,24,'rezultat','napomena'),
	(7,6,50,'rezultat','napomena'),
	(3,7,19,'rezultat','napomena'),
	(10,8,24,'rezultat','napomena'),
	(10,5,45,'rezultat','napomena'),
	(8,7,5,'rezultat','napomena'),
	(1,2,13,'rezultat','napomena'),
	(6,3,46,'rezultat','napomena'),
	(1,7,53,'rezultat','napomena'),
	(8,4,14,'rezultat','napomena'),
	(2,1,6,'rezultat','napomena'),
	(2,8,39,'rezultat','napomena'),
	(8,8,60,'rezultat','napomena'),
	(8,5,68,'rezultat','napomena'),
	(2,9,18,'rezultat','napomena'),
	(9,1,14,'rezultat','napomena'),
	(4,10,9,'rezultat','napomena'),
	(8,2,34,'rezultat','napomena'),
	(3,1,15,'rezultat','napomena'),
	(10,6,5,'rezultat','napomena'),
	(5,2,15,'rezultat','napomena'),
	(9,1,9,'rezultat','napomena'),
	(8,1,13,'rezultat','napomena'),
	(10,3,58,'rezultat','napomena'),
	(7,3,70,'rezultat','napomena'),
	(5,4,23,'rezultat','napomena'),
	(6,6,30,'rezultat','napomena'),
	(5,1,17,'rezultat','napomena'),
	(9,7,30,'rezultat','napomena'),
	(8,4,33,'rezultat','napomena'),
	(2,8,61,'rezultat','napomena'),
	(4,8,54,'rezultat','napomena'),
	(9,2,21,'rezultat','napomena'),
	(10,1,16,'rezultat','napomena'),
	(8,3,10,'rezultat','napomena'),
	(10,5,32,'rezultat','napomena'),
	(7,9,8,'rezultat','napomena'),
	(10,7,59,'rezultat','napomena'),
	(1,10,29,'rezultat','napomena'),
	(5,8,6,'rezultat','napomena'),
	(8,8,70,'rezultat','napomena'),
	(5,10,70,'rezultat','napomena'),
	(5,3,52,'rezultat','napomena'),
	(3,1,19,'rezultat','napomena'),
	(6,2,45,'rezultat','napomena'),
	(8,1,41,'rezultat','napomena');


/*Foreign keys*/

ALTER TABLE Pas ADD CONSTRAINT FK_Pas_rasaID FOREIGN KEY (rasaID) REFERENCES Rasa(rasaID) ON DELETE CASCADE;
ALTER TABLE Pas ADD CONSTRAINT FK_Pas_bojaID FOREIGN KEY (bojaID) REFERENCES Boja(bojaID) ON DELETE CASCADE;
ALTER TABLE Pas ADD CONSTRAINT FK_Pas_polID FOREIGN KEY (polID) REFERENCES Pol(polID) ON DELETE CASCADE;
ALTER TABLE Pas ADD CONSTRAINT FK_Pas_duzina_dlakeID FOREIGN KEY (duzina_dlakeID) REFERENCES Duzina_Dlake(duzina_dlakeID) ON DELETE CASCADE;
ALTER TABLE Pas ADD CONSTRAINT FK_Pas_duzina_vlasnikID FOREIGN KEY (vlasnikID) REFERENCES Vlasnik(vlasnikID) ON DELETE CASCADE;
ALTER TABLE Rezultat ADD CONSTRAINT FK_Rezultat_izlozbaID FOREIGN KEY (izlozbaID) REFERENCES Izlozba(izlozbaID) ON DELETE CASCADE;
ALTER TABLE Rezultat ADD CONSTRAINT FK_Rezultat_kategorijaID FOREIGN KEY (kategorijaID) REFERENCES Kategorija(kategorijaID) ON DELETE CASCADE;
ALTER TABLE Rezultat ADD CONSTRAINT FK_Rezultat_pasID FOREIGN KEY (pasID) REFERENCES Pas(pasID) ON DELETE CASCADE;

/*Dopuna*/

CREATE TABLE Odgajivac(
	odgajivacID int not null,
	ime varchar(100),
	telefon varchar(20),
	email varchar(20),
	adresa varchar(100),
	drzava varchar(50)
);

ALTER TABLE Odgajivac ADD CONSTRAINT PK_Odgajivac PRIMARY KEY (odgajivacID);
ALTER TABLE Odgajivac ADD CONSTRAINT FK_Odgajivac_OdagajivacID FOREIGN KEY (odgajivacID) REFERENCES Vlasnik(vlasnikID);

ALTER TABLE Rasa ADD napomena text;

/*
	USE master;
	DROP DATABASE A16;
*/