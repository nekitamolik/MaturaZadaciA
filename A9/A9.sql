/*
	CREATE DATABASE A9;
	USE A9;
*/


CREATE TABLE Drzava(
	drzavaID int IDENTITY(1,1) not null,
	naziv varchar(50)
);

CREATE TABLE Takmicenje(
	takmicenjeID int IDENTITY (1,1) not null,
	naziv varchar(70)
);

CREATE TABLE Grad(
	gradID int IDENTITY(1,1) not null,
	grad varchar(50),
	pozivni_broj varchar(30),
	postanski_broj varchar(30),
	broj_stanovnika int,
	drzavaID int
);

CREATE TABLE Stadion(
	stadionID int IDENTITY(1,1) not null,
	naziv varchar(50),
	adresa varchar(70),
	kapacitet int,
	broj_ulaza int,
	gradID int
);

CREATE TABLE Klub(
	klubID int IDENTITY(1,1) not null,
	naziv varchar(70),
	stadionID int,
	email varchar(30),
	sajt varchar(30),
	ziro_racun varchar(30),
	amblem text
);

CREATE TABLE Utakmica(
	utakmicaID int IDENTITY(1,1) not null,
	datum_igranja date,
	vreme_igranja time,
	takmicenjeID int,
	domacinID int,
	gostID int,
	golova_domacin int,
	golova_gost int
);

/*Primary keys*/

ALTER TABLE Drzava ADD CONSTRAINT PK_Drzava PRIMARY KEY (drzavaID);
ALTER TABLE Takmicenje ADD CONSTRAINT PK_Takmicenje PRIMARY KEY(takmicenjeID);
ALTER TABLE Grad ADD CONSTRAINT PK_Grad PRIMARY KEY (gradID);
ALTER TABLE Stadion ADD CONSTRAINT PK_Stadion PRIMARY KEY (stadionID);
ALTER TABLE Klub ADD CONSTRAINT PK_Klub PRIMARY KEY (klubID);
ALTER TABLE Utakmica ADD CONSTRAINT PK_Utakmica PRIMARY KEY (utakmicaID);

INSERT INTO Drzava VALUES
	('Drzava1'),
	('Drzava2'),
	('Drzava3'),
	('Drzava4'),
	('Drzava5'),
	('Drzava6'),
	('Drzava7'),
	('Drzava8'),
	('Drzava9'),
	('Drzava10');

INSERT INTO Takmicenje VALUES
	('Takmicenje1'),
	('Takmicenje2'),
	('Takmicenje3'),
	('Takmicenje4'),
	('Takmicenje5'),
	('Takmicenje6'),
	('Takmicenje7'),
	('Takmicenje8'),
	('Takmicenje9'),
	('Takmicenje10'),
	('Takmicenje11'),
	('Takmicenje12'),
	('Takmicenje13'),
	('Takmicenje14'),
	('Takmicenje15'),
	('Takmicenje16'),
	('Takmicenje17'),
	('Takmicenje18'),
	('Takmicenje19'),
	('Takmicenje20');

INSERT INTO Grad VALUES
	('Grad1','12341234','12345',31000,1),
	('Grad2','12341234','12345',27000,5),
	('Grad3','12341234','12345',27000,8),
	('Grad4','12341234','12345',35000,5),
	('Grad5','12341234','12345',26000,7),
	('Grad6','12341234','12345',18000,8),
	('Grad7','12341234','12345',41000,6),
	('Grad8','12341234','12345',36000,10),
	('Grad9','12341234','12345',18000,9),
	('Grad10','12341234','12345',21000,6),
	('Grad11','12341234','12345',36000,5),
	('Grad12','12341234','12345',20000,4),
	('Grad13','12341234','12345',33000,7),
	('Grad14','12341234','12345',38000,4),
	('Grad15','12341234','12345',20000,1),
	('Grad16','12341234','12345',20000,5),
	('Grad17','12341234','12345',28000,8),
	('Grad18','12341234','12345',28000,6),
	('Grad19','12341234','12345',36000,3),
	('Grad20','12341234','12345',31000,3);

INSERT INTO Stadion VALUES
	('Stadion1','Adresa',26000,14,12),
	('Stadion2','Adresa',44000,6,13),
	('Stadion3','Adresa',20000,12,9),
	('Stadion4','Adresa',27000,2,14),
	('Stadion5','Adresa',26000,3,3),
	('Stadion6','Adresa',35000,13,17),
	('Stadion7','Adresa',36000,5,13),
	('Stadion8','Adresa',32000,14,6),
	('Stadion9','Adresa',32000,7,4),
	('Stadion10','Adresa',29000,13,4),
	('Stadion11','Adresa',42000,4,12),
	('Stadion12','Adresa',26000,6,4),
	('Stadion13','Adresa',20000,5,9),
	('Stadion14','Adresa',36000,2,11),
	('Stadion15','Adresa',21000,14,4),
	('Stadion16','Adresa',35000,14,6),
	('Stadion17','Adresa',21000,1,3),
	('Stadion18','Adresa',31000,13,11),
	('Stadion19','Adresa',44000,5,16),
	('Stadion20','Adresa',43000,7,17);

INSERT INTO Klub VALUES
	('Klub1',1,'klub@gmail.com','www.klub.com','156456789952','image1.jpg'),
	('Klub2',2,'klub@gmail.com','www.klub.com','156456789952','image2.jpg'),
	('Klub3',13,'klub@gmail.com','www.klub.com','156456789952','image3.jpg'),
	('Klub4',7,'klub@gmail.com','www.klub.com','156456789952','image4.jpg'),
	('Klub5',14,'klub@gmail.com','www.klub.com','156456789952','image5.jpg'),
	('Klub6',19,'klub@gmail.com','www.klub.com','156456789952','image1.jpg'),
	('Klub7',5,'klub@gmail.com','www.klub.com','156456789952','image2.jpg'),
	('Klub8',11,'klub@gmail.com','www.klub.com','156456789952','image3.jpg'),
	('Klub9',10,'klub@gmail.com','www.klub.com','156456789952','image4.jpg'),
	('Klub10',14,'klub@gmail.com','www.klub.com','156456789952','image5.jpg'),
	('Klub11',11,'klub@gmail.com','www.klub.com','156456789952','image1.jpg'),
	('Klub12',15,'klub@gmail.com','www.klub.com','156456789952','image2.jpg'),
	('Klub13',5,'klub@gmail.com','www.klub.com','156456789952','image3.jpg'),
	('Klub14',8,'klub@gmail.com','www.klub.com','156456789952','image4.jpg'),
	('Klub15',11,'klub@gmail.com','www.klub.com','156456789952','image5.jpg'),
	('Klub16',14,'klub@gmail.com','www.klub.com','156456789952','image1.jpg'),
	('Klub17',4,'klub@gmail.com','www.klub.com','156456789952','image2.jpg'),
	('Klub18',12,'klub@gmail.com','www.klub.com','156456789952','image3.jpg'),
	('Klub19',18,'klub@gmail.com','www.klub.com','156456789952','image4.jpg'),
	('Klub20',1,'klub@gmail.com','www.klub.com','156456789952','image5.jpg'),
	('Klub21',8,'klub@gmail.com','www.klub.com','156456789952','image1.jpg'),
	('Klub22',15,'klub@gmail.com','www.klub.com','156456789952','image2.jpg'),
	('Klub23',17,'klub@gmail.com','www.klub.com','156456789952','image3.jpg'),
	('Klub24',10,'klub@gmail.com','www.klub.com','156456789952','image4.jpg'),
	('Klub25',19,'klub@gmail.com','www.klub.com','156456789952','image5.jpg'),
	('Klub26',16,'klub@gmail.com','www.klub.com','156456789952','image1.jpg'),
	('Klub27',20,'klub@gmail.com','www.klub.com','156456789952','image2.jpg'),
	('Klub28',4,'klub@gmail.com','www.klub.com','156456789952','image3.jpg'),
	('Klub29',10,'klub@gmail.com','www.klub.com','156456789952','image4.jpg'),
	('Klub30',1,'klub@gmail.com','www.klub.com','156456789952','image5.jpg'),
	('Klub31',1,'klub@gmail.com','www.klub.com','156456789952','image1.jpg'),
	('Klub32',9,'klub@gmail.com','www.klub.com','156456789952','image2.jpg'),
	('Klub33',7,'klub@gmail.com','www.klub.com','156456789952','image3.jpg'),
	('Klub34',8,'klub@gmail.com','www.klub.com','156456789952','image4.jpg'),
	('Klub35',5,'klub@gmail.com','www.klub.com','156456789952','image5.jpg'),
	('Klub36',18,'klub@gmail.com','www.klub.com','156456789952','image1.jpg'),
	('Klub37',3,'klub@gmail.com','www.klub.com','156456789952','image2.jpg'),
	('Klub38',8,'klub@gmail.com','www.klub.com','156456789952','image3.jpg'),
	('Klub39',15,'klub@gmail.com','www.klub.com','156456789952','image4.jpg'),
	('Klub40',16,'klub@gmail.com','www.klub.com','156456789952','image5.jpg'),
	('Klub41',15,'klub@gmail.com','www.klub.com','156456789952','image1.jpg'),
	('Klub42',6,'klub@gmail.com','www.klub.com','156456789952','image2.jpg'),
	('Klub43',6,'klub@gmail.com','www.klub.com','156456789952','image3.jpg'),
	('Klub44',2,'klub@gmail.com','www.klub.com','156456789952','image4.jpg'),
	('Klub45',8,'klub@gmail.com','www.klub.com','156456789952','image5.jpg'),
	('Klub46',16,'klub@gmail.com','www.klub.com','156456789952','image1.jpg'),
	('Klub47',15,'klub@gmail.com','www.klub.com','156456789952','image2.jpg'),
	('Klub48',9,'klub@gmail.com','www.klub.com','156456789952','image3.jpg'),
	('Klub49',9,'klub@gmail.com','www.klub.com','156456789952','image4.jpg'),
	('Klub50',3,'klub@gmail.com','www.klub.com','156456789952','image5.jpg');

INSERT INTO Utakmica VALUES
	('2021.3.24','21:33',7,13,14,1,0),
	('2016.5.18','20:16',20,26,27,1,3),
	('2015.7.12','18:19',7,10,11,2,0),
	('2015.3.24','18:31',4,49,50,1,2),
	('2012.12.14','20:43',5,49,50,3,3),
	('2011.12.28','17:28',16,14,15,2,2),
	('2018.8.26','20:32',17,8,9,3,3),
	('2011.11.5','18:23',12,23,24,0,0),
	('2018.7.25','21:31',13,18,19,3,2),
	('2017.12.1','19:44',15,31,32,3,1),
	('2011.7.9','19:42',9,22,23,0,1),
	('2014.9.22','17:21',13,33,34,0,2),
	('2021.2.20','17:16',4,14,15,1,1),
	('2011.2.13','21:36',17,9,10,3,0),
	('2012.10.1','21:17',20,15,16,1,1),
	('2017.4.24','20:38',18,50,41,0,0),
	('2018.11.16','20:27',2,8,9,1,0),
	('2013.8.22','17:37',13,29,30,2,3),
	('2013.9.4','17:38',19,39,40,0,2),
	('2013.4.13','19:22',17,32,33,2,2),
	('2020.10.2','20:23',10,42,43,2,1),
	('2015.11.6','17:41',9,44,45,2,2),
	('2010.11.21','21:35',14,22,23,3,2),
	('2016.11.2','21:19',5,1,2,1,0),
	('2016.11.3','21:34',9,28,29,3,1),
	('2014.5.8','21:35',10,12,13,0,2),
	('2017.2.26','18:40',14,38,39,3,3),
	('2016.2.27','18:36',7,10,11,1,3),
	('2017.4.27','19:18',3,22,23,3,0),
	('2021.11.29','19:23',14,26,27,2,3),
	('2014.9.15','19:36',3,35,36,3,3),
	('2019.8.1','18:13',13,35,36,2,0),
	('2019.5.19','18:18',2,32,33,0,2),
	('2019.2.19','17:38',16,21,22,0,1),
	('2016.11.23','19:19',9,20,21,0,0),
	('2020.11.16','20:42',17,31,32,2,3),
	('2011.2.11','18:35',8,29,30,3,2),
	('2014.12.17','20:31',7,10,11,3,2),
	('2019.7.24','20:38',5,44,45,0,0),
	('2020.11.12','18:19',13,41,42,2,1),
	('2020.10.16','17:25',5,44,45,1,3),
	('2014.4.5','17:20',14,14,15,0,3),
	('2018.4.15','21:36',14,8,9,3,1),
	('2011.2.22','20:21',17,2,3,1,3),
	('2018.4.15','19:14',10,17,18,0,1),
	('2011.8.25','17:36',9,42,43,1,0),
	('2015.2.27','19:34',9,48,49,0,3),
	('2010.1.16','21:34',16,36,37,0,0),
	('2019.8.23','21:13',1,19,20,1,2),
	('2011.5.1','18:20',10,32,33,3,2);

/*Foreign keys*/

ALTER TABLE GRAD ADD CONSTRAINT FK_Grad_drzavaID FOREIGN KEY (drzavaID) REFERENCES Drzava(drzavaID) ON DELETE CASCADE;
ALTER TABLE Stadion ADD CONSTRAINT FK_Stadion_gradID FOREIGN KEY (gradID) REFERENCES Grad(gradID) ON DELETE CASCADE;
ALTER TABLE Klub ADD CONSTRAINT FK_Klub_stadionID FOREIGN KEY (stadionID) REFERENCES Stadion(stadionID) ON DELETE CASCADE;
ALTER TABLE Utakmica ADD CONSTRAINT FK_Utakmica_domacinID FOREIGN KEY (domacinID) REFERENCES Klub(klubID) ON DELETE CASCADE;
ALTER TABLE Utakmica ADD CONSTRAINT FK_Utakmica_gostID FOREIGN KEY (gostID) REFERENCES Klub(klubID);
ALTER TABLE Utakmica ADD CONSTRAINT FK_Utakmica_takmicenjeID FOREIGN KEY (takmicenjeID) REFERENCES Takmicenje(takmicenjeID) ON DELETE CASCADE;

/*Dopuna*/
CREATE TABLE Igrac(
	igracID int IDENTITY(1,1) not null,
	ime varchar(50),
	prezime varchar(70),
	datum_rodjenja date,
	poreklo int
);

CREATE TABLE Igra(
	igracID int not null,
	klubID int not null,
	poceo_da_igra date not null,
	prestao_da_igra date
);

ALTER TABLE Igrac ADD CONSTRAINT PK_Igrac PRIMARY KEY (igracID);
ALTER TABLE Igra ADD CONSTRAINT PK_Igra PRIMARY KEY (igracID,klubID);

ALTER TABLE Igra ADD CONSTRAINT vreme_igranja CHECK(prestao_da_igra>poceo_da_igra OR prestao_da_igra = NULL);

ALTER TABLE Igra ADD CONSTRAINT FK_Igra_igracID FOREIGN KEY (igracID) REFERENCES Igrac(igracID) ON DELETE CASCADE;
ALTER TABLE Igra ADD CONSTRAINT FK_Igra_klubID FOREIGN KEY (klubID) REFERENCES Klub(klubID) ON DELETE CASCADE;

/*
	USE master;
	DROP DATABASE A9;
*/

