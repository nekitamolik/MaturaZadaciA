/*
	CREATE DATABASE A19;
	USE A19;
*/

CREATE TABLE Sektor(
	sektorID int IDENTITY(1,1),
	naziv varchar(50),
	opis text
);

CREATE TABLE Kvalifikacija(
	kvalifikacijaID int IDENTITY(1,1),
	naziv varchar(50),
	koeficijent int
);

CREATE TABLE Radnik(
	radnikID int IDENTITY(1,1),
	ime varchar(50),
	prezime varchar(70),
	datum_rodjenja date,
	datum_zaposljenja date,
	kvalifikacijaID int,
	telefon varchar(20),
	sektorID int
);

CREATE TABLE Rukovodi_Sektorom(
	sektorID int not null,
	radnikID int not null,
	datum_postavljanja date,
	datum_razresenja date
);

CREATE TABLE Radno_Mesto(
	radno_mestoID int IDENTITY(1,1),
	naziv varchar(50),
	opis text,
	pocetna_plata int,
	najvisa_plata int
);

CREATE TABLE Istorija_RM_Radnika(
	radnikID int not null,
	radno_mestoID int not null,
	datum_pocetka date not null,
	datum_zavrsetka date
);

/*Primary keys*/

ALTER TABLE Sektor ADD CONSTRAINT PK_Sektor PRIMARY KEY (sektorID);
ALTER TABLE Radnik ADD CONSTRAINT PK_Radnik PRIMARY KEY (radnikID);
ALTER TABLE Kvalifikacija ADD CONSTRAINT PK_Kvalifikacija PRIMARY KEY (kvalifikacijaID);
ALTER TABLE Radno_Mesto ADD CONSTRAINT PK_Radno_Mesto PRIMARY KEY (radno_mestoID);
ALTER TABLE Istorija_RM_Radnika ADD CONSTRAINT PK_Istorija_RM_Radnika PRIMARY KEY (radnikID,radno_mestoID,datum_pocetka);
ALTER TABLE Rukovodi_Sektorom ADD CONSTRAINT PK_Rukovodi_Sektorom PRIMARY KEY (radnikID,sektorID);

INSERT INTO Sektor VALUES
	('Sektor1','opis'),
	('Sektor2','opis'),
	('Sektor3','opis'),
	('Sektor4','opis'),
	('Sektor5','opis'),
	('Sektor6','opis'),
	('Sektor7','opis'),
	('Sektor8','opis'),
	('Sektor9','opis'),
	('Sektor10','opis');

INSERT INTO Kvalifikacija VALUES
	('Koef1',31),
	('Koef2',27),
	('Koef3',73),
	('Koef4',49),
	('Koef5',42),
	('Koef6',87),
	('Koef7',44),
	('Koef8',19),
	('Koef9',71),
	('Koef10',3);

INSERT INTO Radnik VALUES
	('Radnik1','Radnik1','1980.4.22','2002.5.25',10,'0612345678',10),
	('Radnik2','Radnik2','1971.5.25','1993.6.28',7,'0612345678',7),
	('Radnik3','Radnik3','1972.3.19','1993.4.22',6,'0612345678',6),
	('Radnik4','Radnik4','1989.7.16','2011.8.19',9,'0612345678',9),
	('Radnik5','Radnik5','1997.3.27','2016.4.30',7,'0612345678',7),
	('Radnik6','Radnik6','1986.5.7','2008.6.10',8,'0612345678',8),
	('Radnik7','Radnik7','1996.9.8','2015.10.11',10,'0612345678',10),
	('Radnik8','Radnik8','1971.5.3','1989.6.6',9,'0612345678',9),
	('Radnik9','Radnik9','1981.7.13','2000.8.16',7,'0612345678',7),
	('Radnik10','Radnik10','1982.6.19','2001.7.22',7,'0612345678',7),
	('Radnik11','Radnik11','1993.7.20','2011.8.23',3,'0612345678',3),
	('Radnik12','Radnik12','1973.5.1','1995.6.4',1,'0612345678',1),
	('Radnik13','Radnik13','1975.3.27','1995.4.30',1,'0612345678',1),
	('Radnik14','Radnik14','1993.8.23','2014.9.26',7,'0612345678',7),
	('Radnik15','Radnik15','1986.6.25','2006.7.28',9,'0612345678',9),
	('Radnik16','Radnik16','1990.7.9','2011.8.12',3,'0612345678',3),
	('Radnik17','Radnik17','1978.8.27','1997.9.30',4,'0612345678',4),
	('Radnik18','Radnik18','1993.4.6','2014.5.9',2,'0612345678',2),
	('Radnik19','Radnik19','1974.5.1','1995.6.4',8,'0612345678',8),
	('Radnik20','Radnik20','1999.7.22','2017.8.25',5,'0612345678',5),
	('Radnik21','Radnik21','1991.8.25','2011.9.28',9,'0612345678',9),
	('Radnik22','Radnik22','1978.8.14','1999.9.17',8,'0612345678',8),
	('Radnik23','Radnik23','1984.3.19','2003.4.22',4,'0612345678',4),
	('Radnik24','Radnik24','1997.4.22','2018.5.25',8,'0612345678',8),
	('Radnik25','Radnik25','1973.7.2','1993.8.5',10,'0612345678',10),
	('Radnik26','Radnik26','1992.6.12','2010.7.15',7,'0612345678',7),
	('Radnik27','Radnik27','1986.9.13','2008.10.16',3,'0612345678',3),
	('Radnik28','Radnik28','1996.9.7','2016.10.10',7,'0612345678',7),
	('Radnik29','Radnik29','1974.8.23','1996.9.26',9,'0612345678',9),
	('Radnik30','Radnik30','1997.8.8','2018.9.11',3,'0612345678',3),
	('Radnik31','Radnik31','1978.9.25','2000.10.28',6,'0612345678',6),
	('Radnik32','Radnik32','1977.7.6','1998.8.9',8,'0612345678',8),
	('Radnik33','Radnik33','1975.5.6','1993.6.9',10,'0612345678',10),
	('Radnik34','Radnik34','1985.7.1','2004.8.4',9,'0612345678',9),
	('Radnik35','Radnik35','1981.9.25','2002.10.28',10,'0612345678',10),
	('Radnik36','Radnik36','1977.8.24','1998.9.27',8,'0612345678',8),
	('Radnik37','Radnik37','1970.4.24','1989.5.27',8,'0612345678',8),
	('Radnik38','Radnik38','1988.9.21','2006.10.24',10,'0612345678',10),
	('Radnik39','Radnik39','1972.7.7','1994.8.10',4,'0612345678',4),
	('Radnik40','Radnik40','1998.6.28','2018.7.31',8,'0612345678',8),
	('Radnik41','Radnik41','1986.8.10','2004.9.13',8,'0612345678',8),
	('Radnik42','Radnik42','1984.9.3','2006.10.6',2,'0612345678',2),
	('Radnik43','Radnik43','1987.9.13','2009.10.16',5,'0612345678',5),
	('Radnik44','Radnik44','1994.6.7','2016.7.10',10,'0612345678',10),
	('Radnik45','Radnik45','1981.8.19','2000.9.22',3,'0612345678',3),
	('Radnik46','Radnik46','1987.7.5','2005.8.8',9,'0612345678',9),
	('Radnik47','Radnik47','1991.8.4','2009.9.7',9,'0612345678',9),
	('Radnik48','Radnik48','1995.8.19','2016.9.22',3,'0612345678',3),
	('Radnik49','Radnik49','1988.9.8','2006.10.11',5,'0612345678',5),
	('Radnik50','Radnik50','1973.4.9','1995.5.12',8,'0612345678',8),
	('Radnik51','Radnik51','1998.5.22','2020.6.25',10,'0612345678',10),
	('Radnik52','Radnik52','1974.3.16','1993.4.19',4,'0612345678',4),
	('Radnik53','Radnik53','1981.8.9','2000.9.12',6,'0612345678',6),
	('Radnik54','Radnik54','1984.8.8','2002.9.11',8,'0612345678',8),
	('Radnik55','Radnik55','1975.9.22','1993.10.25',1,'0612345678',1),
	('Radnik56','Radnik56','1978.7.25','1998.8.28',6,'0612345678',6),
	('Radnik57','Radnik57','1990.5.7','2012.6.10',7,'0612345678',7),
	('Radnik58','Radnik58','1991.3.23','2012.4.26',9,'0612345678',9),
	('Radnik59','Radnik59','1987.5.2','2007.6.5',1,'0612345678',1),
	('Radnik60','Radnik60','1980.7.14','1999.8.17',1,'0612345678',1),
	('Radnik61','Radnik61','1970.9.6','1988.10.9',3,'0612345678',3),
	('Radnik62','Radnik62','1994.6.5','2012.7.8',8,'0612345678',8),
	('Radnik63','Radnik63','1988.4.25','2009.5.28',1,'0612345678',1),
	('Radnik64','Radnik64','1984.7.13','2006.8.16',10,'0612345678',10),
	('Radnik65','Radnik65','1991.9.6','2009.10.9',1,'0612345678',1),
	('Radnik66','Radnik66','1987.8.20','2009.9.23',6,'0612345678',6),
	('Radnik67','Radnik67','1970.3.18','1992.4.21',3,'0612345678',3),
	('Radnik68','Radnik68','1985.4.14','2007.5.17',7,'0612345678',7),
	('Radnik69','Radnik69','1988.9.22','2007.10.25',1,'0612345678',1),
	('Radnik70','Radnik70','1996.6.4','2016.7.7',5,'0612345678',5);

INSERT INTO Rukovodi_Sektorom VALUES
	(1,15,'7/28/2009',NULL),
	(2,4,'8/19/2014','8/19/2016'),
	(2,57,'6/10/2015',NULL),
	(3,41,'9/13/2007','9/13/2009'),
	(3,10,'7/22/2004','7/22/2006'),
	(3,9,'8/16/2003','8/16/2005'),
	(4,19,'6/4/1998','6/4/2000'),
	(4,8,'6/6/1992','6/6/1994'),
	(4,10,'7/22/2004',NULL),
	(5,53,'9/12/2003','9/12/2005'),
	(5,16,'8/12/2014','8/12/2016'),
	(5,70,'7/7/2019','7/7/2021'),
	(5,54,'9/11/2005','9/11/2007'),
	(5,44,'7/10/2019',NULL),
	(6,66,'9/23/2012',NULL),
	(7,32,'8/9/2001','8/9/2003'),
	(7,63,'5/28/2012','5/28/2014'),
	(7,9,'8/16/2003','8/16/2005'),
	(7,4,'8/19/2014','8/19/2016'),
	(7,31,'10/28/2003','10/28/2005'),
	(7,27,'10/16/2011','10/16/2013'),
	(7,22,'9/17/2002',NULL),
	(8,40,'7/31/2021','7/31/2023'),
	(8,66,'9/23/2012','9/23/2014'),
	(8,27,'10/16/2011','10/16/2013'),
	(8,24,'5/25/2021','5/25/2023'),
	(8,47,'9/7/2012','9/7/2014'),
	(8,25,'8/5/1996',NULL),
	(9,63,'5/28/2012','5/28/2014'),
	(9,30,'9/11/2021','9/11/2023'),
	(9,6,'6/10/2011','6/10/2013'),
	(9,27,'10/16/2011','10/16/2013'),
	(9,13,'4/30/1998','4/30/2000'),
	(9,70,'7/7/2019','7/7/2021'),
	(9,39,'8/10/1997',NULL),
	(10,5,'4/30/2019','4/30/2021'),
	(10,29,'9/26/1999','9/26/2001'),
	(10,22,'9/17/2002','9/17/2004'),
	(10,2,'6/28/1996',NULL);

INSERT INTO Radno_Mesto VALUES
	('RadnoMesto1','opis',25000,39000),
	('RadnoMesto2','opis',34000,44000),
	('RadnoMesto3','opis',30000,44000),
	('RadnoMesto4','opis',33000,44000),
	('RadnoMesto5','opis',28000,40000),
	('RadnoMesto6','opis',25000,37000),
	('RadnoMesto7','opis',28000,38000),
	('RadnoMesto8','opis',26000,36000),
	('RadnoMesto9','opis',30000,42000),
	('RadnoMesto10','opis',34000,46000),
	('RadnoMesto11','opis',32000,45000),
	('RadnoMesto12','opis',29000,42000),
	('RadnoMesto13','opis',25000,39000),
	('RadnoMesto14','opis',28000,39000),
	('RadnoMesto15','opis',26000,36000),
	('RadnoMesto16','opis',28000,40000),
	('RadnoMesto17','opis',27000,39000),
	('RadnoMesto18','opis',29000,39000),
	('RadnoMesto19','opis',29000,43000),
	('RadnoMesto20','opis',29000,41000),
	('RadnoMesto21','opis',25000,35000),
	('RadnoMesto22','opis',32000,42000),
	('RadnoMesto23','opis',33000,44000),
	('RadnoMesto24','opis',25000,37000),
	('RadnoMesto25','opis',33000,43000),
	('RadnoMesto26','opis',30000,43000),
	('RadnoMesto27','opis',34000,46000),
	('RadnoMesto28','opis',34000,45000),
	('RadnoMesto29','opis',29000,40000),
	('RadnoMesto30','opis',34000,46000);

INSERT INTO Istorija_RM_Radnika (radnikID ,radno_mestoID ,datum_pocetka) VALUES
	(1,16,'5/25/2002'),
	(2,18,'6/28/1993'),
	(3,21,'4/22/1993'),
	(4,5,'8/19/2011'),
	(5,2,'4/30/2016'),
	(6,20,'6/10/2008'),
	(7,19,'10/11/2015'),
	(8,27,'6/6/1989'),
	(9,3,'8/16/2000'),
	(10,17,'7/22/2001'),
	(11,26,'8/23/2011'),
	(12,12,'6/4/1995'),
	(13,18,'4/30/1995'),
	(14,1,'9/26/2014'),
	(15,9,'7/28/2006'),
	(16,16,'8/12/2011'),
	(17,12,'9/30/1997'),
	(18,19,'5/9/2014'),
	(19,9,'6/4/1995'),
	(20,15,'8/25/2017'),
	(21,1,'9/28/2011'),
	(22,8,'9/17/1999'),
	(23,5,'4/22/2003'),
	(24,29,'5/25/2018'),
	(25,11,'8/5/1993'),
	(26,23,'7/15/2010'),
	(27,16,'10/16/2008'),
	(28,15,'10/10/2016'),
	(29,18,'9/26/1996'),
	(30,14,'9/11/2018'),
	(31,17,'10/28/2000'),
	(32,24,'8/9/1998'),
	(33,20,'6/9/1993'),
	(34,29,'8/4/2004'),
	(35,24,'10/28/2002'),
	(36,6,'9/27/1998'),
	(37,20,'5/27/1989'),
	(38,7,'10/24/2006'),
	(39,8,'8/10/1994'),
	(40,2,'7/31/2018'),
	(41,11,'9/13/2004'),
	(42,28,'10/6/2006'),
	(43,24,'10/16/2009'),
	(44,18,'7/10/2016'),
	(45,23,'9/22/2000'),
	(46,17,'8/8/2005'),
	(47,25,'9/7/2009'),
	(48,24,'9/22/2016'),
	(49,18,'10/11/2006'),
	(50,28,'5/12/1995'),
	(51,22,'6/25/2020'),
	(52,17,'4/19/1993'),
	(53,1,'9/12/2000'),
	(54,30,'9/11/2002'),
	(55,22,'10/25/1993'),
	(56,24,'8/28/1998'),
	(57,10,'6/10/2012'),
	(58,1,'4/26/2012'),
	(59,29,'6/5/2007'),
	(60,23,'8/17/1999'),
	(61,1,'10/9/1988'),
	(62,20,'7/8/2012'),
	(63,7,'5/28/2009'),
	(64,30,'8/16/2006'),
	(65,12,'10/9/2009'),
	(66,28,'9/23/2009'),
	(67,28,'4/21/1992'),
	(68,6,'5/17/2007'),
	(69,6,'10/25/2007'),
	(70,2,'7/7/2016');

/*Foreign keys*/

ALTER TABLE Radnik ADD CONSTRAINT FK_Radnik_sektorID FOREIGN KEY (sektorID) REFERENCES Sektor(sektorID) ON DELETE CASCADE;
ALTER TABLE Radnik ADD CONSTRAINT FK_Radnik_kvalifikacijaID FOREIGN KEY (kvalifikacijaID) REFERENCES Kvalifikacija(kvalifikacijaID) ON DELETE CASCADE;
ALTER TABLE Rukovodi_Sektorom ADD CONSTRAINT FK_Rukovodi_Sektorom_radnikID FOREIGN KEY (radnikID) REFERENCES Radnik(radnikID) ON DELETE CASCADE;
ALTER TABLE Rukovodi_Sektorom ADD CONSTRAINT FK_Rukovodi_Sektorom_sektorID FOREIGN KEY (sektorID) REFERENCES Sektor(sektorID);
ALTER TABLE Istorija_RM_Radnika ADD CONSTRAINT FK_Istorija_RM_Radnika_radnikID FOREIGN KEY (radnikID) REFERENCES Radnik(radnikID) ON DELETE CASCADE;
ALTER TABLE Istorija_RM_Radnika ADD CONSTRAINT FK_Istorija_RM_Radnika_radno_mestoID FOREIGN KEY (radno_mestoID) REFERENCES Radno_Mesto(radno_mestoID) ON DELETE CASCADE;

/*Dopuna*/

CREATE TABLE Lokacija(
	lokacijaID int IDENTITY(1,1),
	adresa varchar(100),
	kapacitet int
);


CREATE TABLE Kancelarija(
	kancelarijaID int IDENTITY(1,1),
	lokacijaID int not null,
	sektorID int not null,
	opis text
);

ALTER TABLE Lokacija ADD CONSTRAINT PK_Lokacija PRIMARY KEY (lokacijaID);
ALTER TABLE Kancelarija ADD CONSTRAINT PK_Kancelarija PRIMARY KEY (kancelarijaID,lokacijaID,sektorID);
ALTER TABLE Kancelarija ADD CONSTRAINT FK_Kancelarija_lokacijaID FOREIGN KEY (lokacijaID) REFERENCES Lokacija(lokacijaID) ON DELETE CASCADE;
ALTER TABLE Kancelarija ADD CONSTRAINT FK_Kancelarija_sektorID FOREIGN KEY (sektorID) REFERENCES Sektor(sektorID) ON DELETE CASCADE;

CREATE TABLE Rukovodi_Sektorom_NEW(
	sektorID int not null,
	radnikID int not null,
	datum_postavljanja date not null,
	datum_razresenja date
);

ALTER TABLE Rukovodi_Sektorom_NEW ADD CONSTRAINT PK_Rukovodi_Sektorom_NEW PRIMARY KEY (radnikID,sektorID,datum_postavljanja);
ALTER TABLE Rukovodi_Sektorom_NEW ADD CONSTRAINT mandat CHECK(datum_postavljanja<ISNULL(datum_razresenja,GETDATE()));

ALTER TABLE Rukovodi_Sektorom_NEW ADD CONSTRAINT FK_Rukovodi_Sektorom_NEW_radnikID FOREIGN KEY (radnikID) REFERENCES Radnik(radnikID) ON DELETE CASCADE;
ALTER TABLE Rukovodi_Sektorom_NEW ADD CONSTRAINT FK_Rukovodi_Sektorom_NEW_sektorID FOREIGN KEY (sektorID) REFERENCES Sektor(sektorID);

INSERT INTO Rukovodi_Sektorom_NEW (sektorID,radnikID,datum_postavljanja,datum_razresenja)
	(SELECT sektorID,radnikID,datum_postavljanja,datum_razresenja FROM Rukovodi_Sektorom);

DROP TABLE Rukovodi_Sektorom;

/*
	USE master;
	DROP DATABASE A19;
*/

