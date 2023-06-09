/*
	CREATE DATABASE A10;
	USE A10;
*/
CREATE TABLE Grad(
	gradID int IDENTITY (1,1) not null,
	grad varchar(50),
	pozivni_broj varchar(30),
	postanski_broj varchar(15),
	broj_stanovnika int 
);

CREATE TABLE Pecaros (
	pecarosID int IDENTITY(1,1) not null,
	ime varchar(50),
	prezime varchar(60),
	adresa varchar(100),
	telefon varchar(20),
	gradID int
);

CREATE TABLE Jezero(
	jezeroID int IDENTITY(1,1) not null,
	naziv varchar(70),
	broj_lokacija int
);

CREATE TABLE Lokacija(
	jezeroID int not null,
	Rbr_lokacije int not null,
	naziv varchar(50),
	beleska text
);

CREATE TABLE Vrsta_Ribe(
	vrstaID int IDENTITY(1,1) not null,
	naziv varchar(50),
	opis text
);

CREATE TABLE Ulov(
	pecarosID int not null,
	Rbr_ulova int not null,
	datum date,
	vreme time,
	vrstaID int,
	tezina float,
	jezeroID int,
	Rbr_lokacije int
);

/*Primary keys*/

ALTER TABLE Grad ADD CONSTRAINT PK_Grad PRIMARY KEY (gradID);
ALTER TABLE Pecaros ADD CONSTRAINT PK_Pecaros PRIMARY KEY (pecarosID);
ALTER TABLE Jezero ADD CONSTRAINT PK_Jezero PRIMARY KEY (jezeroID);
ALTER TABLE Lokacija ADD CONSTRAINT PK_Lokacija PRIMARY KEY (jezeroID, Rbr_lokacije);
ALTER TABLE Vrsta_Ribe ADD CONSTRAINT PK_Vrsta_Ribe PRIMARY KEY (vrstaID);
ALTER TABLE Ulov ADD CONSTRAINT PK_Ulov PRIMARY KEY (pecarosID,Rbr_ulova);


INSERT INTO Grad VALUES
	('Grad1','123456789','12345',13000),
	('Grad2','123456789','12345',29000),
	('Grad3','123456789','12345',4000),
	('Grad4','123456789','12345',29000),
	('Grad5','123456789','12345',6000),
	('Grad6','123456789','12345',3000),
	('Grad7','123456789','12345',23000),
	('Grad8','123456789','12345',5000),
	('Grad9','123456789','12345',10000),
	('Grad10','123456789','12345',24000);

INSERT INTO Pecaros VALUES
	('Pecaros1','Pecaros1','Adresa','12345678',9),
	('Pecaros2','Pecaros2','Adresa','12345678',5),
	('Pecaros3','Pecaros3','Adresa','12345678',4),
	('Pecaros4','Pecaros4','Adresa','12345678',5),
	('Pecaros5','Pecaros5','Adresa','12345678',5),
	('Pecaros6','Pecaros6','Adresa','12345678',3),
	('Pecaros7','Pecaros7','Adresa','12345678',5),
	('Pecaros8','Pecaros8','Adresa','12345678',4),
	('Pecaros9','Pecaros9','Adresa','12345678',8),
	('Pecaros10','Pecaros10','Adresa','12345678',7),
	('Pecaros11','Pecaros11','Adresa','12345678',3),
	('Pecaros12','Pecaros12','Adresa','12345678',6),
	('Pecaros13','Pecaros13','Adresa','12345678',3),
	('Pecaros14','Pecaros14','Adresa','12345678',4),
	('Pecaros15','Pecaros15','Adresa','12345678',8),
	('Pecaros16','Pecaros16','Adresa','12345678',1),
	('Pecaros17','Pecaros17','Adresa','12345678',5),
	('Pecaros18','Pecaros18','Adresa','12345678',5),
	('Pecaros19','Pecaros19','Adresa','12345678',8),
	('Pecaros20','Pecaros20','Adresa','12345678',5),
	('Pecaros21','Pecaros21','Adresa','12345678',9),
	('Pecaros22','Pecaros22','Adresa','12345678',3),
	('Pecaros23','Pecaros23','Adresa','12345678',9),
	('Pecaros24','Pecaros24','Adresa','12345678',5),
	('Pecaros25','Pecaros25','Adresa','12345678',6),
	('Pecaros26','Pecaros26','Adresa','12345678',3),
	('Pecaros27','Pecaros27','Adresa','12345678',9),
	('Pecaros28','Pecaros28','Adresa','12345678',5),
	('Pecaros29','Pecaros29','Adresa','12345678',6),
	('Pecaros30','Pecaros30','Adresa','12345678',7);

INSERT INTO Jezero VALUES
	('Jezero1',2),
	('Jezero2',4),
	('Jezero3',7),
	('Jezero4',3),
	('Jezero5',8),
	('Jezero6',10),
	('Jezero7',9),
	('Jezero8',9),
	('Jezero9',4),
	('Jezero10',8);

INSERT INTO Lokacija VALUES
	( 1,1,'Lokacija1','beleska'),
	( 1,2,'Lokacija2','beleska'),
	( 2,1,'Lokacija1','beleska'),
	( 2,2,'Lokacija2','beleska'),
	( 2,3,'Lokacija3','beleska'),
	( 2,4,'Lokacija4','beleska'),
	( 3,1,'Lokacija1','beleska'),
	( 3,2,'Lokacija2','beleska'),
	( 3,3,'Lokacija3','beleska'),
	( 3,4,'Lokacija4','beleska'),
	( 3,5,'Lokacija5','beleska'),
	( 3,6,'Lokacija6','beleska'),
	( 3,7,'Lokacija7','beleska'),
	( 4,1,'Lokacija1','beleska'),
	( 4,2,'Lokacija2','beleska'),
	( 4,3,'Lokacija3','beleska'),
	( 5,1,'Lokacija1','beleska'),
	( 5,2,'Lokacija2','beleska'),
	( 5,3,'Lokacija3','beleska'),
	( 5,4,'Lokacija4','beleska'),
	( 5,5,'Lokacija5','beleska'),
	( 5,6,'Lokacija6','beleska'),
	( 5,7,'Lokacija7','beleska'),
	( 5,8,'Lokacija8','beleska'),
	( 6,1,'Lokacija1','beleska'),
	( 6,2,'Lokacija2','beleska'),
	( 6,3,'Lokacija3','beleska'),
	( 6,4,'Lokacija4','beleska'),
	( 6,5,'Lokacija5','beleska'),
	( 6,6,'Lokacija6','beleska'),
	( 6,7,'Lokacija7','beleska'),
	( 6,8,'Lokacija8','beleska'),
	( 6,9,'Lokacija9','beleska'),
	( 6,10,'Lokacija10','beleska'),
	( 7,1,'Lokacija1','beleska'),
	( 7,2,'Lokacija2','beleska'),
	( 7,3,'Lokacija3','beleska'),
	( 7,4,'Lokacija4','beleska'),
	( 7,5,'Lokacija5','beleska'),
	( 7,6,'Lokacija6','beleska'),
	( 7,7,'Lokacija7','beleska'),
	( 7,8,'Lokacija8','beleska'),
	( 7,9,'Lokacija9','beleska'),
	( 8,1,'Lokacija1','beleska'),
	( 8,2,'Lokacija2','beleska'),
	( 8,3,'Lokacija3','beleska'),
	( 8,4,'Lokacija4','beleska'),
	( 8,5,'Lokacija5','beleska'),
	( 8,6,'Lokacija6','beleska'),
	( 8,7,'Lokacija7','beleska'),
	( 8,8,'Lokacija8','beleska'),
	( 8,9,'Lokacija9','beleska'),
	( 9,1,'Lokacija1','beleska'),
	( 9,2,'Lokacija2','beleska'),
	( 9,3,'Lokacija3','beleska'),
	( 9,4,'Lokacija4','beleska'),
	( 10,1,'Lokacija1','beleska'),
	( 10,2,'Lokacija2','beleska'),
	( 10,3,'Lokacija3','beleska'),
	( 10,4,'Lokacija4','beleska'),
	( 10,5,'Lokacija5','beleska'),
	( 10,6,'Lokacija6','beleska'),
	( 10,7,'Lokacija7','beleska'),
	( 10,8,'Lokacija8','beleska');

INSERT INTO Vrsta_Ribe VALUES
	('Vrsta1','opis'),
	('Vrsta2','opis'),
	('Vrsta3','opis'),
	('Vrsta4','opis'),
	('Vrsta5','opis'),
	('Vrsta6','opis'),
	('Vrsta7','opis'),
	('Vrsta8','opis'),
	('Vrsta9','opis'),
	('Vrsta10','opis'),
	('Vrsta11','opis'),
	('Vrsta12','opis'),
	('Vrsta13','opis'),
	('Vrsta14','opis'),
	('Vrsta15','opis'),
	('Vrsta16','opis'),
	('Vrsta17','opis'),
	('Vrsta18','opis'),
	('Vrsta19','opis'),
	('Vrsta20','opis'),
	('Vrsta21','opis'),
	('Vrsta22','opis'),
	('Vrsta23','opis'),
	('Vrsta24','opis'),
	('Vrsta25','opis'),
	('Vrsta26','opis'),
	('Vrsta27','opis'),
	('Vrsta28','opis'),
	('Vrsta29','opis'),
	('Vrsta30','opis');

INSERT INTO Ulov VAlUES
	(1,1,'2010.3.28','15:58',5,6,4,2),
	(1,2,'2014.7.7','1:19',23,10,9,2),
	(1,3,'2017.4.19','15:35',1,3,3,2),
	(1,4,'2014.7.19','13:31',30,4,6,2),
	(1,5,'2014.5.16','3:12',7,5,6,2),
	(1,6,'2017.7.8','6:23',2,10,2,2),
	(1,7,'2017.7.9','7:24',10,13,1,2),
	(1,8,'2018.7.6','8:34',26,14,5,2),
	(1,9,'2013.7.17','19:20',18,13,6,2),
	(1,10,'2018.3.23','19:47',29,14,4,2),
	(1,11,'2018.6.20','19:45',30,4,2,2),
	(1,12,'2014.6.5','9:11',1,2,9,2),
	(1,13,'2016.7.26','14:33',27,14,3,2),
	(2,1,'2015.5.8','13:14',8,14,7,2),
	(2,2,'2016.5.2','5:16',25,6,4,2),
	(2,3,'2014.4.20','10:35',19,14,9,2),
	(2,4,'2017.3.2','2:29',29,2,5,2),
	(2,5,'2013.3.3','15:10',18,7,3,2),
	(2,6,'2011.7.8','15:12',25,9,9,2),
	(2,7,'2014.4.1','14:25',27,3,1,2),
	(2,8,'2013.5.22','1:20',28,5,8,2),
	(2,9,'2012.7.24','1:46',22,6,9,2),
	(2,10,'2017.5.7','20:27',9,13,9,2),
	(2,11,'2013.4.16','5:56',15,3,5,2),
	(2,12,'2018.3.7','17:50',13,2,3,2),
	(2,13,'2013.6.11','12:59',19,3,8,2),
	(2,14,'2017.3.22','21:42',11,10,2,2),
	(2,15,'2013.8.18','2:28',4,13,8,2),
	(2,16,'2013.5.3','16:34',21,2,4,2),
	(2,17,'2013.9.13','21:56',13,14,8,2),
	(2,18,'2018.8.12','19:45',8,12,5,2),
	(2,19,'2013.3.10','2:50',1,13,3,2),
	(3,1,'2014.3.19','13:34',10,2,1,2),
	(3,2,'2012.6.20','22:48',6,14,7,2),
	(3,3,'2017.3.19','17:14',4,3,5,2),
	(3,4,'2014.4.11','9:11',19,5,1,2),
	(3,5,'2011.5.12','9:27',9,8,4,2),
	(3,6,'2012.8.12','16:18',19,9,9,2),
	(3,7,'2013.4.1','22:23',18,7,4,2),
	(3,8,'2018.4.29','5:56',24,1,7,2),
	(3,9,'2012.7.23','10:48',19,7,5,2),
	(3,10,'2015.4.13','8:46',14,5,9,2),
	(3,11,'2015.6.1','18:39',11,12,5,2),
	(3,12,'2018.3.14','5:24',9,7,5,2),
	(3,13,'2016.7.14','14:51',7,3,7,2),
	(3,14,'2017.6.12','2:17',4,10,4,2),
	(3,15,'2017.3.17','12:48',8,2,8,2),
	(4,1,'2012.6.23','4:22',7,4,7,2),
	(4,2,'2018.7.1','1:47',3,7,3,2),
	(4,3,'2012.9.3','23:46',13,12,3,2),
	(4,4,'2010.5.7','17:10',23,8,6,2),
	(4,5,'2015.8.18','17:29',17,9,3,2),
	(4,6,'2011.5.6','13:43',13,2,9,2),
	(4,7,'2011.4.14','8:11',28,2,8,2),
	(4,8,'2016.6.5','21:59',17,10,2,2),
	(4,9,'2010.5.14','23:34',22,13,7,2),
	(4,10,'2013.8.25','8:20',8,10,6,2),
	(4,11,'2012.4.18','19:22',6,8,6,2),
	(4,12,'2016.8.29','22:30',21,5,6,2),
	(4,13,'2016.9.14','6:58',4,7,4,2),
	(4,14,'2013.8.29','6:13',23,9,5,2),
	(4,15,'2017.7.19','18:57',28,14,9,2),
	(4,16,'2017.8.9','17:46',29,5,6,2),
	(4,17,'2014.4.19','5:50',13,9,2,2),
	(4,18,'2016.4.14','12:20',10,9,9,2),
	(4,19,'2011.6.5','20:12',17,9,8,2),
	(4,20,'2010.6.11','5:50',24,10,4,2),
	(4,21,'2013.5.23','19:14',13,9,4,2),
	(5,1,'2014.3.23','11:32',21,8,2,2),
	(5,2,'2013.6.6','19:34',18,13,6,2),
	(5,3,'2017.4.8','1:31',10,14,5,2),
	(5,4,'2010.3.26','13:49',26,11,9,2),
	(5,5,'2016.9.16','13:52',10,9,8,2),
	(5,6,'2017.9.14','6:34',19,14,7,2),
	(5,7,'2017.3.7','6:29',11,8,2,2),
	(5,8,'2010.4.12','9:51',1,6,5,2),
	(5,9,'2017.5.1','15:12',12,12,5,2),
	(5,10,'2015.5.7','11:53',23,1,4,2),
	(5,11,'2011.3.20','16:40',16,8,4,2),
	(5,12,'2012.5.15','14:55',6,1,8,2),
	(5,13,'2014.9.12','5:39',10,10,5,2),
	(5,14,'2012.7.19','1:15',3,5,3,2),
	(5,15,'2012.9.8','17:27',23,13,3,2),
	(5,16,'2016.7.9','17:53',7,9,4,2),
	(5,17,'2012.5.28','22:26',25,13,8,2),
	(5,18,'2013.4.11','21:53',16,5,3,2),
	(5,19,'2010.4.11','22:56',11,7,8,2),
	(5,20,'2010.3.13','23:10',30,9,1,2),
	(5,21,'2010.4.20','17:16',12,14,4,2),
	(5,22,'2010.6.9','4:28',1,7,3,2),
	(5,23,'2012.3.20','16:53',21,7,9,2),
	(5,24,'2018.4.27','6:29',27,12,4,2),
	(6,1,'2012.8.18','19:40',4,10,2,2),
	(6,2,'2018.8.14','2:24',13,1,6,2),
	(6,3,'2011.7.28','7:58',7,6,8,2),
	(6,4,'2016.8.29','12:47',1,4,7,2),
	(6,5,'2017.7.3','4:51',14,10,9,2),
	(6,6,'2010.6.28','20:59',28,10,7,2),
	(6,7,'2017.6.8','5:51',5,9,1,2),
	(6,8,'2014.8.4','20:16',5,7,9,2),
	(6,9,'2015.8.6','16:25',27,12,7,2),
	(6,10,'2018.3.8','13:23',17,12,8,2),
	(6,11,'2010.4.18','5:49',1,12,7,2),
	(6,12,'2010.3.21','23:27',26,12,8,2),
	(6,13,'2018.3.7','5:45',30,6,1,2),
	(6,14,'2016.6.7','19:53',2,12,9,2),
	(6,15,'2010.5.23','21:37',8,2,6,2),
	(6,16,'2018.6.20','8:18',26,5,2,2),
	(7,1,'2013.6.8','7:40',2,2,8,2),
	(7,2,'2015.6.7','19:12',26,14,2,2),
	(7,3,'2016.9.1','2:57',11,11,9,2),
	(7,4,'2015.4.7','7:15',25,13,2,2),
	(7,5,'2010.7.14','12:36',19,6,3,2),
	(7,6,'2015.3.28','18:54',23,13,6,2),
	(7,7,'2016.3.12','21:26',3,4,1,2),
	(7,8,'2017.5.19','9:51',25,10,7,2),
	(7,9,'2015.3.23','11:28',14,10,2,2),
	(8,1,'2016.5.27','10:57',30,13,3,2),
	(8,2,'2015.6.1','10:59',27,14,3,2),
	(8,3,'2013.7.5','23:10',13,12,3,2),
	(8,4,'2011.3.25','23:32',8,4,4,2),
	(8,5,'2012.5.17','16:28',20,13,4,2),
	(8,6,'2016.3.8','6:44',11,9,2,2),
	(8,7,'2017.4.28','18:35',5,8,3,2),
	(8,8,'2015.6.8','19:17',28,13,4,2),
	(8,9,'2012.7.5','16:24',10,14,7,2),
	(8,10,'2017.8.8','22:19',18,10,8,2),
	(8,11,'2014.7.6','7:25',16,13,2,2),
	(8,12,'2016.4.3','19:30',3,4,8,2),
	(8,13,'2011.9.28','2:19',29,13,5,2),
	(8,14,'2011.4.29','17:53',19,2,1,2),
	(8,15,'2018.6.9','11:45',17,1,8,2),
	(8,16,'2016.3.28','1:21',5,6,7,2),
	(9,1,'2014.8.9','15:38',19,9,8,2),
	(9,2,'2016.3.4','13:20',8,3,2,2),
	(9,3,'2010.9.29','18:48',3,10,8,2),
	(9,4,'2011.5.5','1:53',8,2,8,2),
	(9,5,'2012.3.12','20:52',12,5,8,2),
	(9,6,'2016.7.29','11:55',8,7,7,2),
	(9,7,'2017.9.5','6:30',28,12,4,2),
	(9,8,'2010.5.13','5:34',18,14,5,2),
	(9,9,'2010.5.8','2:52',9,4,7,2),
	(9,10,'2014.4.2','3:15',6,14,9,2),
	(9,11,'2018.5.7','23:13',25,6,4,2),
	(9,12,'2012.3.24','11:57',5,5,2,2),
	(9,13,'2016.6.13','14:10',13,13,5,2),
	(9,14,'2015.6.21','6:53',21,4,8,2),
	(9,15,'2013.6.9','3:27',30,6,2,2),
	(9,16,'2018.9.22','20:34',25,11,4,2),
	(10,1,'2018.5.18','18:29',27,7,5,2),
	(10,2,'2016.5.17','3:18',14,9,7,2),
	(10,3,'2018.3.12','20:20',24,11,1,2),
	(10,4,'2012.7.3','16:14',1,12,7,2),
	(10,5,'2012.5.29','7:42',4,1,6,2),
	(10,6,'2017.7.19','15:51',3,11,5,2),
	(10,7,'2010.3.17','18:25',18,10,2,2),
	(10,8,'2015.6.15','17:49',25,6,7,2),
	(10,9,'2014.8.24','19:34',11,2,8,2),
	(10,10,'2010.8.1','13:17',4,4,2,2),
	(10,11,'2018.7.17','1:31',2,7,7,2),
	(10,12,'2016.8.19','3:41',10,12,1,2),
	(10,13,'2012.9.3','1:22',28,14,7,2),
	(10,14,'2018.8.23','13:38',3,14,5,2),
	(10,15,'2012.5.23','4:23',11,4,5,2),
	(10,16,'2013.3.3','15:45',1,3,7,2),
	(10,17,'2018.9.8','6:12',7,13,1,2),
	(10,18,'2016.8.4','15:23',28,3,6,2),
	(10,19,'2017.3.25','7:36',22,11,9,2),
	(10,20,'2015.6.20','4:52',10,1,9,2),
	(10,21,'2015.3.19','14:50',22,7,1,2),
	(10,22,'2013.8.14','11:21',20,4,4,2),
	(11,1,'2014.8.17','5:53',6,3,3,2),
	(11,2,'2012.7.15','13:47',5,6,7,2),
	(11,3,'2011.9.6','7:37',25,3,7,2),
	(11,4,'2017.9.22','6:23',22,14,3,2),
	(11,5,'2012.4.12','13:33',22,12,8,2),
	(11,6,'2013.5.15','4:57',15,10,6,2),
	(11,7,'2010.8.1','16:11',5,6,6,2),
	(11,8,'2015.9.12','23:31',29,14,6,2),
	(11,9,'2015.4.10','13:47',26,4,5,2),
	(11,10,'2011.5.25','6:26',1,10,3,2),
	(11,11,'2011.3.6','13:45',9,5,1,2),
	(11,12,'2017.8.28','14:25',24,7,5,2),
	(11,13,'2013.9.16','19:17',4,13,2,2),
	(11,14,'2014.6.15','17:25',6,5,6,2),
	(11,15,'2011.3.24','8:47',14,13,3,2),
	(11,16,'2017.4.22','23:55',21,3,4,2),
	(11,17,'2017.5.25','11:34',28,2,1,2),
	(11,18,'2012.9.3','4:49',18,11,6,2),
	(11,19,'2014.5.11','5:59',4,10,9,2),
	(11,20,'2018.4.27','21:27',28,5,7,2),
	(11,21,'2013.3.25','21:25',26,2,3,2),
	(11,22,'2018.8.3','18:27',23,8,3,2),
	(11,23,'2014.3.15','13:26',29,6,7,2),
	(11,24,'2016.9.14','7:10',8,11,3,2),
	(12,1,'2012.8.20','17:52',10,9,3,2),
	(12,2,'2010.4.8','2:56',18,4,7,2),
	(12,3,'2015.5.7','9:47',14,6,7,2),
	(12,4,'2010.4.12','9:50',8,11,1,2),
	(12,5,'2016.3.2','23:52',18,10,8,2),
	(12,6,'2018.4.7','18:16',21,11,4,2),
	(12,7,'2012.7.13','21:34',29,14,8,2),
	(12,8,'2013.9.19','15:55',7,7,8,2),
	(12,9,'2014.4.9','20:36',9,12,1,2),
	(12,10,'2016.5.14','11:21',20,9,4,2),
	(12,11,'2014.3.4','5:51',25,8,8,2),
	(12,12,'2011.4.18','21:57',2,13,7,2),
	(12,13,'2017.5.8','21:30',27,12,9,2),
	(12,14,'2016.5.6','2:32',14,10,7,2),
	(12,15,'2013.4.5','21:14',8,1,6,2),
	(12,16,'2016.6.21','9:44',29,2,6,2),
	(12,17,'2014.8.19','20:29',22,1,6,2),
	(12,18,'2011.4.14','11:41',14,5,7,2),
	(13,1,'2017.6.22','21:11',18,9,3,2),
	(13,2,'2015.3.27','5:33',10,12,3,2),
	(13,3,'2014.7.20','19:49',10,10,2,2),
	(13,4,'2015.7.28','18:39',2,5,2,2),
	(13,5,'2010.8.24','11:27',24,7,2,2),
	(13,6,'2010.6.24','13:14',13,11,8,2),
	(13,7,'2015.4.3','20:44',26,11,6,2),
	(13,8,'2017.6.9','9:42',25,11,5,2),
	(13,9,'2017.8.5','15:34',11,14,7,2),
	(13,10,'2010.6.23','6:35',4,2,2,2),
	(13,11,'2018.3.4','11:58',13,6,2,2),
	(13,12,'2010.4.19','19:33',4,9,3,2),
	(13,13,'2017.4.21','7:23',4,6,3,2),
	(13,14,'2011.5.23','6:14',15,1,7,2),
	(13,15,'2013.3.13','13:44',10,9,4,2),
	(14,1,'2018.6.7','17:16',9,14,8,2),
	(14,2,'2014.6.8','10:52',28,12,7,2),
	(14,3,'2017.4.20','15:18',3,9,2,2),
	(14,4,'2018.5.11','17:11',17,7,7,2),
	(14,5,'2012.9.9','14:15',19,2,1,2),
	(14,6,'2017.5.17','2:48',9,9,2,2),
	(14,7,'2015.8.27','2:55',24,4,8,2),
	(14,8,'2018.3.22','18:56',8,12,9,2),
	(14,9,'2018.7.4','23:40',8,9,2,2),
	(14,10,'2011.7.24','18:35',18,7,6,2),
	(14,11,'2017.4.4','5:42',13,11,5,2),
	(14,12,'2015.5.20','3:53',10,1,6,2),
	(15,1,'2015.3.6','5:40',18,6,2,2),
	(15,2,'2016.9.7','22:33',12,5,6,2),
	(15,3,'2010.9.23','3:42',10,8,8,2),
	(15,4,'2015.5.6','13:36',10,12,6,2),
	(15,5,'2012.4.27','11:22',14,3,6,2),
	(15,6,'2016.9.28','12:36',18,3,1,2),
	(15,7,'2013.6.23','9:24',14,13,3,2),
	(15,8,'2015.5.18','7:29',25,10,4,2),
	(15,9,'2010.7.21','6:33',27,6,6,2),
	(15,10,'2016.4.11','15:29',1,5,1,2),
	(15,11,'2011.3.7','1:37',14,5,8,2),
	(15,12,'2013.7.26','21:52',27,3,9,2),
	(15,13,'2012.6.13','21:53',29,9,5,2),
	(15,14,'2011.3.19','2:14',8,13,6,2),
	(15,15,'2010.7.5','6:39',20,13,6,2),
	(16,1,'2018.9.25','23:33',24,13,1,2),
	(16,2,'2013.5.25','14:29',5,3,5,2),
	(16,3,'2016.9.13','19:22',22,2,7,2),
	(16,4,'2012.8.8','18:55',12,10,6,2),
	(16,5,'2016.7.28','2:47',15,10,3,2),
	(16,6,'2016.3.20','21:12',1,10,5,2),
	(16,7,'2018.8.24','18:31',25,1,3,2),
	(16,8,'2017.4.20','16:37',4,2,1,2),
	(16,9,'2016.4.24','19:20',5,12,3,2),
	(16,10,'2012.3.2','5:12',6,10,3,2),
	(16,11,'2011.8.24','5:37',28,4,9,2),
	(17,1,'2016.4.18','19:59',24,9,9,2),
	(17,2,'2015.4.25','5:54',8,11,9,2),
	(17,3,'2014.6.10','18:52',6,9,5,2),
	(17,4,'2013.6.23','7:56',16,11,9,2),
	(17,5,'2017.4.15','21:20',15,4,3,2),
	(17,6,'2013.5.13','22:49',4,4,5,2),
	(17,7,'2010.4.1','10:54',6,10,5,2),
	(17,8,'2015.3.12','10:10',11,14,1,2),
	(17,9,'2014.9.10','14:48',27,11,1,2),
	(17,10,'2012.3.11','13:47',20,10,3,2),
	(17,11,'2012.4.8','15:35',12,2,7,2),
	(17,12,'2015.9.8','3:14',25,5,1,2),
	(17,13,'2012.5.15','21:48',20,11,2,2),
	(17,14,'2015.9.5','20:50',4,11,9,2),
	(17,15,'2013.3.4','18:14',10,9,1,2),
	(18,1,'2015.9.24','15:40',29,6,7,2),
	(18,2,'2012.4.13','4:50',16,10,5,2),
	(18,3,'2010.3.17','5:20',27,8,2,2),
	(18,4,'2012.8.29','17:37',30,14,7,2),
	(18,5,'2013.3.4','16:56',16,14,9,2),
	(18,6,'2016.4.16','21:27',25,8,6,2),
	(18,7,'2014.4.29','6:12',27,9,7,2),
	(18,8,'2014.7.11','21:59',22,3,3,2),
	(18,9,'2012.7.23','18:29',1,9,6,2),
	(18,10,'2011.6.14','2:26',19,12,5,2),
	(18,11,'2011.5.7','8:59',23,10,5,2),
	(18,12,'2014.5.5','8:19',2,14,1,2),
	(18,13,'2018.4.19','16:12',25,3,5,2),
	(18,14,'2015.5.3','11:30',17,7,8,2),
	(18,15,'2017.9.22','15:33',26,5,5,2),
	(18,16,'2018.4.9','1:52',8,6,1,2),
	(18,17,'2015.6.3','2:10',5,6,3,2),
	(18,18,'2011.8.20','14:42',7,2,9,2),
	(18,19,'2018.5.16','7:25',12,8,2,2),
	(18,20,'2018.3.20','19:36',6,9,4,2),
	(18,21,'2010.3.26','23:32',11,12,6,2),
	(19,1,'2013.6.21','4:45',26,11,2,2),
	(19,2,'2013.3.16','17:14',24,3,8,2),
	(19,3,'2018.3.26','12:39',24,14,2,2),
	(19,4,'2012.6.19','8:17',15,8,5,2),
	(19,5,'2018.8.26','22:52',30,4,3,2),
	(19,6,'2018.7.6','2:13',20,14,3,2),
	(19,7,'2016.3.15','6:58',4,13,6,2),
	(19,8,'2014.6.25','4:21',14,14,8,2),
	(19,9,'2014.3.24','7:54',9,1,9,2),
	(19,10,'2017.7.18','21:40',28,2,6,2),
	(19,11,'2015.5.19','2:58',10,7,8,2),
	(19,12,'2018.4.14','8:17',4,1,4,2),
	(19,13,'2016.5.16','23:52',20,5,4,2),
	(19,14,'2010.6.12','9:36',30,1,5,2),
	(20,1,'2011.6.25','20:56',28,3,6,2),
	(20,2,'2010.5.19','19:45',24,11,6,2),
	(20,3,'2011.4.10','9:14',25,14,1,2),
	(20,4,'2011.3.12','22:16',8,13,2,2),
	(20,5,'2018.9.29','14:19',18,11,4,2),
	(20,6,'2012.5.25','7:45',19,6,7,2),
	(20,7,'2015.8.11','19:46',5,6,4,2),
	(20,8,'2015.8.18','22:35',9,7,7,2),
	(20,9,'2014.6.25','20:51',6,6,6,2),
	(20,10,'2013.9.2','16:57',20,5,6,2),
	(20,11,'2015.7.9','9:55',4,7,8,2),
	(20,12,'2014.7.29','9:59',26,12,1,2),
	(20,13,'2018.3.25','7:47',16,14,5,2),
	(20,14,'2013.8.11','19:13',21,6,9,2),
	(21,1,'2010.4.26','23:14',25,5,9,2),
	(21,2,'2010.5.7','5:11',18,8,1,2),
	(21,3,'2010.8.25','19:11',26,2,7,2),
	(21,4,'2017.9.4','18:45',23,12,2,2),
	(21,5,'2010.8.29','14:59',3,13,3,2),
	(21,6,'2014.5.21','5:45',8,5,2,2),
	(21,7,'2017.7.2','23:38',4,7,2,2),
	(21,8,'2011.4.4','3:45',18,4,3,2),
	(21,9,'2014.3.4','5:40',30,2,9,2),
	(21,10,'2017.6.9','16:16',28,14,6,2),
	(21,11,'2015.9.28','1:44',26,9,9,2),
	(21,12,'2013.8.13','20:56',23,9,9,2),
	(21,13,'2011.5.21','16:16',6,9,8,2),
	(21,14,'2015.3.4','1:50',25,1,3,2),
	(21,15,'2011.6.14','18:41',7,9,6,2),
	(22,1,'2011.8.23','13:22',1,2,9,2),
	(22,2,'2013.6.21','5:25',14,7,4,2),
	(22,3,'2010.5.18','18:39',5,8,8,2),
	(22,4,'2011.7.12','7:51',11,13,8,2),
	(22,5,'2010.4.29','9:49',9,5,1,2),
	(22,6,'2010.3.14','6:25',3,13,1,2),
	(22,7,'2010.5.15','20:10',27,12,1,2),
	(22,8,'2012.9.11','14:40',25,2,9,2),
	(22,9,'2016.9.3','2:33',3,9,8,2),
	(22,10,'2010.6.22','13:44',9,7,1,2),
	(22,11,'2017.5.8','10:51',2,12,2,2),
	(22,12,'2013.9.2','19:55',24,7,2,2),
	(22,13,'2018.6.17','10:59',25,9,9,2),
	(23,1,'2016.8.16','4:26',10,14,5,2),
	(23,2,'2012.8.10','13:45',6,9,1,2),
	(23,3,'2017.7.15','1:48',28,4,1,2),
	(23,4,'2014.7.6','17:13',3,1,7,2),
	(23,5,'2012.7.4','6:23',3,2,6,2),
	(23,6,'2010.5.19','1:17',20,3,3,2),
	(23,7,'2018.5.4','4:15',28,1,8,2),
	(23,8,'2014.6.19','17:15',9,6,2,2),
	(23,9,'2016.7.7','3:11',12,12,8,2),
	(23,10,'2015.9.28','11:24',8,13,8,2),
	(23,11,'2013.9.23','18:58',26,8,4,2),
	(23,12,'2015.5.22','18:32',11,8,8,2),
	(23,13,'2018.6.8','12:31',4,4,6,2),
	(23,14,'2014.5.17','6:57',18,7,3,2),
	(23,15,'2015.8.10','5:34',20,4,9,2),
	(23,16,'2010.8.15','16:41',2,5,2,2),
	(23,17,'2012.4.16','20:10',12,6,3,2),
	(23,18,'2015.4.8','15:23',10,7,9,2),
	(23,19,'2017.6.4','16:12',10,5,3,2),
	(23,20,'2011.5.12','15:39',18,14,4,2),
	(23,21,'2018.5.28','19:11',20,4,3,2),
	(24,1,'2010.7.9','9:38',20,12,3,2),
	(24,2,'2014.8.5','22:43',5,14,8,2),
	(24,3,'2012.7.20','23:48',22,1,3,2),
	(24,4,'2017.7.27','9:43',30,4,2,2),
	(24,5,'2017.5.2','18:11',27,10,7,2),
	(24,6,'2015.5.3','18:48',15,5,2,2),
	(24,7,'2018.9.22','1:38',9,9,3,2),
	(24,8,'2014.3.16','21:47',13,10,5,2),
	(24,9,'2015.9.3','8:16',8,12,4,2),
	(24,10,'2018.3.11','11:41',9,7,4,2),
	(24,11,'2013.7.13','16:21',7,10,6,2),
	(24,12,'2016.8.7','1:28',23,14,2,2),
	(25,1,'2014.4.25','10:58',3,10,2,2),
	(25,2,'2013.3.17','21:14',21,4,5,2),
	(25,3,'2011.6.2','23:59',10,6,3,2),
	(25,4,'2014.7.12','1:48',2,4,1,2),
	(25,5,'2011.8.3','4:42',29,6,6,2),
	(25,6,'2016.6.26','5:15',21,10,1,2),
	(25,7,'2018.6.7','5:54',8,10,2,2),
	(25,8,'2016.6.28','9:43',20,6,3,2),
	(25,9,'2016.6.22','6:39',3,13,2,2),
	(25,10,'2011.5.6','12:31',7,3,8,2),
	(25,11,'2018.5.2','7:50',2,3,9,2),
	(25,12,'2011.9.12','3:11',30,14,2,2),
	(25,13,'2010.7.13','14:56',12,7,9,2),
	(25,14,'2015.3.1','11:11',5,12,5,2),
	(25,15,'2013.3.14','8:39',4,7,7,2),
	(25,16,'2013.8.3','17:44',23,3,2,2),
	(25,17,'2014.3.13','20:49',18,13,5,2),
	(26,1,'2011.7.23','2:44',27,1,1,2),
	(26,2,'2017.8.26','13:42',16,14,1,2),
	(26,3,'2016.4.4','8:46',7,12,8,2),
	(26,4,'2017.3.28','17:57',23,11,3,2),
	(26,5,'2018.5.14','11:45',20,10,9,2),
	(26,6,'2010.7.24','1:23',21,12,5,2),
	(26,7,'2014.8.3','8:47',7,3,9,2),
	(26,8,'2017.9.7','16:56',9,2,1,2),
	(26,9,'2018.7.18','7:13',15,6,1,2),
	(26,10,'2015.4.8','3:30',25,9,2,2),
	(26,11,'2011.5.7','6:43',14,8,7,2),
	(26,12,'2011.6.18','19:31',30,14,7,2),
	(26,13,'2014.8.1','15:13',17,7,1,2),
	(26,14,'2012.3.21','13:57',4,7,1,2),
	(26,15,'2012.3.15','12:13',27,7,5,2),
	(26,16,'2011.9.3','12:55',19,9,6,2),
	(26,17,'2011.6.17','16:50',29,2,6,2),
	(26,18,'2018.4.27','15:46',29,11,1,2),
	(26,19,'2010.6.14','8:34',15,10,6,2),
	(26,20,'2012.6.16','4:33',29,2,7,2),
	(26,21,'2013.3.11','11:36',25,4,4,2),
	(26,22,'2010.8.17','20:58',25,12,2,2),
	(26,23,'2011.9.13','8:17',8,3,7,2),
	(27,1,'2018.5.10','10:56',5,14,1,2),
	(27,2,'2012.4.20','15:24',17,4,4,2),
	(27,3,'2010.5.19','22:51',20,7,7,2),
	(27,4,'2013.9.15','12:48',16,3,9,2),
	(27,5,'2015.7.17','10:55',29,2,7,2),
	(27,6,'2015.8.22','15:16',16,13,4,2),
	(27,7,'2011.9.2','22:36',25,14,3,2),
	(27,8,'2018.7.1','22:43',15,5,7,2),
	(27,9,'2010.8.29','15:59',26,6,2,2),
	(27,10,'2012.9.11','2:56',26,8,8,2),
	(27,11,'2010.3.10','18:33',8,6,8,2),
	(27,12,'2015.4.15','7:55',5,1,1,2),
	(27,13,'2013.3.18','9:36',8,7,4,2),
	(27,14,'2015.9.19','14:32',28,6,1,2),
	(27,15,'2010.4.25','15:16',17,4,7,2),
	(27,16,'2013.4.29','17:26',5,4,2,2),
	(27,17,'2018.4.19','21:22',6,5,8,2),
	(27,18,'2015.3.6','13:40',25,6,7,2),
	(27,19,'2017.6.7','17:24',12,14,9,2),
	(27,20,'2017.8.29','9:22',22,1,4,2),
	(27,21,'2016.6.19','5:24',15,12,8,2),
	(28,1,'2018.3.4','8:43',5,8,8,2),
	(28,2,'2012.9.26','21:34',26,8,3,2),
	(28,3,'2016.3.13','5:58',19,13,9,2),
	(28,4,'2016.9.3','5:18',14,6,6,2),
	(28,5,'2013.9.10','9:51',17,2,7,2),
	(28,6,'2013.6.29','20:17',17,3,7,2),
	(28,7,'2010.9.16','9:28',21,13,4,2),
	(28,8,'2010.3.17','19:14',12,10,8,2),
	(28,9,'2014.4.16','15:35',6,7,2,2),
	(28,10,'2010.8.23','11:41',2,12,3,2),
	(28,11,'2016.5.4','7:55',2,4,7,2),
	(28,12,'2018.9.9','17:57',10,9,1,2),
	(28,13,'2017.4.12','22:59',18,3,9,2),
	(28,14,'2014.5.10','15:55',15,11,1,2),
	(28,15,'2012.5.4','17:22',12,13,4,2),
	(28,16,'2018.9.20','13:54',23,4,7,2),
	(28,17,'2011.7.17','11:43',27,4,1,2),
	(28,18,'2011.4.24','13:45',20,11,5,2),
	(28,19,'2012.4.12','14:18',27,12,5,2),
	(28,20,'2012.9.1','4:55',20,14,7,2),
	(28,21,'2010.7.15','5:55',9,6,4,2),
	(28,22,'2011.3.15','1:38',10,10,3,2),
	(29,1,'2011.4.20','9:42',17,4,9,2),
	(29,2,'2010.3.21','21:14',6,8,3,2),
	(29,3,'2011.6.2','4:37',18,14,8,2),
	(29,4,'2018.6.4','10:49',28,14,3,2),
	(29,5,'2016.3.22','9:26',10,7,1,2),
	(29,6,'2012.5.25','4:44',16,1,8,2),
	(30,1,'2017.6.26','15:16',17,9,3,2),
	(30,2,'2017.5.5','10:52',4,2,2,2),
	(30,3,'2013.3.2','11:19',28,12,9,2),
	(30,4,'2018.9.7','18:51',5,7,4,2),
	(30,5,'2012.6.29','12:15',19,9,5,2),
	(30,6,'2011.3.15','22:24',22,6,2,2),
	(30,7,'2016.9.8','10:59',13,11,9,2),
	(30,8,'2015.9.20','6:25',26,7,6,2),
	(30,9,'2018.8.4','9:15',20,1,8,2),
	(30,10,'2014.6.9','4:29',26,10,3,2),
	(30,11,'2014.3.2','20:55',2,7,8,2),
	(30,12,'2016.3.26','6:56',13,3,3,2),
	(30,13,'2015.8.2','13:38',1,2,1,2),
	(30,14,'2018.6.27','11:15',18,7,8,2),
	(30,15,'2011.5.21','7:50',20,11,8,2),
	(30,16,'2012.4.19','1:48',26,13,1,2),
	(30,17,'2013.9.17','13:50',5,10,5,2),
	(30,18,'2018.9.27','12:16',1,11,2,2),
	(30,19,'2015.3.2','12:45',27,8,9,2),
	(30,20,'2010.4.8','8:28',3,5,1,2),
	(30,21,'2014.8.3','3:11',29,14,1,2),
	(30,22,'2016.4.12','19:47',9,11,3,2),
	(30,23,'2014.6.12','16:49',12,6,5,2);


	

/*Foreign keys*/

ALTER TABLE Pecaros ADD CONSTRAINT FK_Pecaros_gradID FOREIGN KEY (gradID) REFERENCES Grad(gradID) ON DELETE CASCADE;
ALTER TABLE Lokacija ADD CONSTRAINT FK_Lokacija_jezeroID FOREIGN KEY (jezeroID) REFERENCES Jezero(jezeroID) ON DELETE CASCADE;
ALTER TABLE Ulov ADD CONSTRAINT FK_Ulov_pecarosID FOREIGN KEY (pecarosID) REFERENCES Pecaros(pecarosID) ON DELETE CASCADE;
ALTER TABLE Ulov ADD CONSTRAINT FK_Ulov_jezeroID_Rbr_lokacije FOREIGN KEY (jezeroID, Rbr_lokacije) REFERENCES Lokacija(jezeroID, Rbr_lokacije) ON DELETE CASCADE;
ALTER TABLE Ulov ADD CONSTRAINT FK_Ulov_vrstaID FOREIGN KEY (vrstaID) REFERENCES Vrsta_Ribe(vrstaID) ON DELETE CASCADE;


/*Dopuna*/

CREATE TABLE Oprema(
	opremaID int IDENTITY(1,1) not null,
	stap varchar(50),
	masinica varchar(50),
	najlon varchar(50),
	mamac varchar(50),
	udica varchar(50)
);

ALTER TABLE Oprema ADD CONSTRAINT PK_Oprema PRIMARY KEY (opremaID);

ALTER TABLE Ulov ADD opremaID int ;

ALTER TABLE Ulov ADD CONSTRAINT FK_Ulov_OpremaID FOREIGN KEY (opremaID) REFERENCES Oprema(opremaID) ON DELETE CASCADE;



/*
	USE master;
	DROP DATABASE A10;
*/