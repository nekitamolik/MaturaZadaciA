/*CREATE DATABASE A3;
USE A3;*/

CREATE TABLE Kvalifikacija(
	kvalifikacijaID int not null,
	naziv varchar(50),
	koeficijent int
);

CREATE TABLE Radnik (
	radnikID int not null,
	ime varchar(30),
	prezime varchar(45),
	datum_rodjenja date,
	datum_zaposlenja date,
	kvalifikacijaID int,
	telefon varchar(35)	
);

CREATE TABLE Angazman(
	radnikID int not null,
	projekatID int not null,
	datum_angazovanja date not null,  
	broj_sati int,
	opis_posla varchar(100)
);

CREATE TABLE Projekat(
	projekatID int not null,
	naziv varchar(50),
	datum_pocetka date,
	budzet int,
	projekat_zavrsen varchar(5),
	opis varchar(100)
);	

CREATE TABLE Istorija_rm_radnika(
	radnikID int not null,
	radno_mestoID int not null,
	datum_pocetka date not null,
	datum_zavrsetka date
);

CREATE TABLE Radno_mesto(
	radno_mestoID int not null,
	naziv varchar(50),
	opis varchar(100),
	pocetna_plata int,
	najvisa_plata int	
);


/*Primary keys*/
ALTER TABLE Kvalifikacija ADD CONSTRAINT PK_Kvalifikacija PRIMARY KEY (kvalifikacijaID);
ALTER TABLE Radnik ADD CONSTRAINT PK_Radnik PRIMARY KEY (radnikID);
ALTER TABLE Angazman ADD CONSTRAINT PK_Angazman PRIMARY KEY (radnikID, projekatID, datum_angazovanja);
ALTER TABLE Projekat ADD CONSTRAINT PK_Projekat PRIMARY KEY (projekatID);
ALTER TABLE Istorija_rm_radnika ADD CONSTRAINT PK_Istorija_rm_radnika PRIMARY KEY (radnikID, radno_mestoID, datum_pocetka);
ALTER TABLE Radno_mesto ADD CONSTRAINT PK_Radno_mesto PRIMARY KEY (radno_mestoID);

/*Constraints*/


INSERT INTO Kvalifikacija VALUES
	(1,'Kvalif1',20),
	(2,'Kvalif2',21),
	(3,'Kvalif3',22);

INSERT INTO Radnik VALUES
	(1,'Radnik1','Radnik1','1991.01.01','2009.05.05',1,'0611231231'),
	(2,'Radnik2','Radnik2','1992.02.10','2010.01.11',1,'0611231232'),
	(3,'Radnik3','Radnik3','1993.11.08','2011.02.12',2,'0611231233'),
	(4,'Radnik4','Radnik4','1994.12.05','2012.03.13',3,'0611231234'),
	(5,'Radnik5','Radnik5','1995.06.11','2013.04.14',2,'0611231235'),
	(6,'Radnik6','Radnik6','1991.01.01','2009.05.05',1,'0611231231'),
	(7,'Radnik7','Radnik7','1992.02.10','2010.01.11',1,'0611231232'),
	(8,'Radnik8','Radnik8','1993.11.08','2011.02.12',2,'0611231233'),
	(9,'Radnik9','Radnik9','1994.12.05','2012.03.13',3,'0611231234'),
	(10,'Radnik10','Radnik10','1995.06.11','2013.04.14',2,'0611231235'),
	(11,'Radnik11','Radnik11','1991.01.01','2009.05.05',1,'0611231231'),
	(12,'Radnik12','Radnik12','1992.02.10','2010.01.11',1,'0611231232'),
	(13,'Radnik13','Radnik13','1993.11.08','2011.02.12',2,'0611231233'),
	(14,'Radnik14','Radnik14','1994.12.05','2012.03.13',3,'0611231234'),
	(15,'Radnik15','Radnik15','1995.06.11','2013.04.14',2,'0611231235'),
	(16,'Radnik16','Radnik16','1991.01.01','2009.05.05',1,'0611231231'),
	(17,'Radnik17','Radnik17','1992.02.10','2010.01.11',1,'0611231232'),
	(18,'Radnik18','Radnik18','1993.11.08','2011.02.12',2,'0611231233'),
	(19,'Radnik19','Radnik19','1994.12.05','2012.03.13',3,'0611231234'),
	(20,'Radnik20','Radnik20','1995.06.11','2013.04.14',2,'0611231235'),
	(21,'Radnik21','Radnik21','1991.01.01','2009.05.05',1,'0611231231'),
	(22,'Radnik22','Radnik22','1992.02.10','2010.01.11',1,'0611231232'),
	(23,'Radnik23','Radnik23','1993.11.08','2011.02.12',2,'0611231233'),
	(24,'Radnik24','Radnik24','1994.12.05','2012.03.13',3,'0611231234'),
	(25,'Radnik25','Radnik25','1995.06.11','2013.04.14',2,'0611231235');

INSERT INTO Radno_mesto VALUES
	(1,'Radno Mesto 1','Opis Radno mesto ',50000,150000),
	(2,'Radno Mesto 2','Opis Radno mesto ',70000,250000),
	(3,'Radno Mesto 3','Opis Radno mesto ',60000,220000);

INSERT INTO Projekat VALUES
	(1,'Projekat1','2007.11.15',150000,'TRUE','Opis projekta'),
	(2,'Projekat2','2008.11.15',1100000,'TRUE','Opis projekta'),
	(3,'Projekat3','2009.11.15',1120000,'FALSE','Opis projekta'),
	(4,'Projekat4','2012.11.15',11110000,'FALSE','Opis projekta'),
	(5,'Projekat5','2016.11.15',1150000,'TRUE','Opis projekta'),
	(6,'Projekat6','2017.11.15',11110000,'TRUE','Opis projekta'),
	(7,'Projekat7','2018.11.15',11110000,'TRUE','Opis projekta'),
	(8,'Projekat8','2019.11.15',11110000,'FALSE','Opis projekta'),
	(9,'Projekat9','2021.11.15',11110000,'TRUE','Opis projekta'),
	(10,'Projekat10','2007.11.15',150000,'FALSE','Opis projekta'),
	(11,'Projekat11','2008.11.15',1100000,'FALSE','Opis projekta'),
	(12,'Projekat12','2009.11.15',1120000,'TRUE','Opis projekta'),
	(13,'Projekat13','2012.11.15',11110000,'FALSE','Opis projekta'),
	(14,'Projekat14','2016.11.15',1150000,'TRUE','Opis projekta'),
	(15,'Projekat15','2017.11.15',11110000,'TRUE','Opis projekta'),
	(16,'Projekat16','2018.11.15',11110000,'TRUE','Opis projekta'),
	(17,'Projekat17','2019.11.15',11110000,'FALSE','Opis projekta'),
	(18,'Projekat18','2021.11.15',11110000,'TRUE','Opis projekta'),
	(19,'Projekat19','2007.11.15',150000,'FALSE','Opis projekta'),
	(20,'Projekat20','2008.11.15',1100000,'FALSE','Opis projekta'),
	(21,'Projekat21','2009.11.15',1120000,'TRUE','Opis projekta'),
	(22,'Projekat22','2012.11.15',11110000,'FALSE','Opis projekta'),
	(23,'Projekat23','2016.11.15',1150000,'TRUE','Opis projekta'),
	(24,'Projekat24','2017.11.15',11110000,'TRUE','Opis projekta'),
	(25,'Projekat25','2020.11.15',11110000,'TRUE','Opis projekta');

INSERT INTO Angazman VALUES 
	(1,1,'12.15.2007 ',110,'Opis'),
	(1,5,'12.15.2016 ',150,'Opis'),
	(1,19,'12.15.2007 ',290,'Opis'),
	(1,25,'12.15.2018 ',350,'Opis'),
	(2,2,'12.15.2008 ',120,'Opis'),
	(2,6,'12.15.2017 ',160,'Opis'),
	(2,20,'12.15.2008 ',300,'Opis'),
	(2,24,'12.15.2017 ',340,'Opis'),
	(3,3,'12.15.2009 ',130,'Opis'),
	(3,4,'12.15.2012 ',140,'Opis'),
	(3,21,'12.15.2009 ',310,'Opis'),
	(3,23,'12.15.2016 ',330,'Opis'),
	(4,4,'12.15.2012 ',140,'Opis'),
	(4,22,'12.15.2012 ',320,'Opis'),
	(5,5,'12.15.2016 ',150,'Opis'),
	(5,21,'12.15.2009 ',310,'Opis'),
	(6,6,'12.15.2017 ',160,'Opis'),
	(6,20,'12.15.2008 ',300,'Opis'),
	(6,22,'12.15.2012 ',320,'Opis'),
	(7,3,'12.15.2009 ',130,'Opis'),
	(7,7,'12.15.2018 ',170,'Opis'),
	(7,19,'12.15.2007 ',290,'Opis'),
	(7,23,'12.15.2016 ',330,'Opis'),
	(8,8,'12.15.2019 ',180,'Opis'),
	(8,18,'12.15.2021 ',280,'Opis'),
	(8,24,'12.15.2017 ',340,'Opis'),
	(9,7,'12.15.2018 ',170,'Opis'),
	(9,9,'12.15.2021 ',190,'Opis'),
	(9,17,'12.15.2019 ',270,'Opis'),
	(9,25,'12.15.2018 ',350,'Opis'),
	(10,1,'12.15.2007 ',110,'Opis'),
	(10,10,'12.15.2007 ',200,'Opis'),
	(10,14,'12.15.2016 ',240,'Opis'),
	(10,16,'12.15.2018 ',260,'Opis'),
	(11,10,'12.15.2007 ',200,'Opis'),
	(11,11,'12.15.2008 ',210,'Opis'),
	(11,15,'12.15.2017 ',250,'Opis'),
	(11,16,'12.15.2018 ',260,'Opis'),
	(11,18,'12.15.2021 ',280,'Opis'),
	(11,25,'12.15.2018 ',350,'Opis'),
	(12,11,'12.15.2008 ',210,'Opis'),
	(12,12,'12.15.2009 ',220,'Opis'),
	(12,14,'12.15.2016 ',240,'Opis'),
	(12,15,'12.15.2017 ',250,'Opis'),
	(12,18,'12.15.2021 ',280,'Opis'),
	(12,24,'12.15.2017 ',340,'Opis'),
	(13,12,'12.15.2009 ',220,'Opis'),
	(13,13,'12.15.2012 ',230,'Opis'),
	(13,14,'12.15.2016 ',240,'Opis'),
	(13,23,'12.15.2016 ',330,'Opis'),
	(14,13,'12.15.2012 ',230,'Opis'),
	(14,14,'12.15.2016 ',240,'Opis'),
	(14,22,'12.15.2012 ',320,'Opis'),
	(15,1,'12.15.2007 ',110,'Opis'),
	(15,11,'12.15.2008 ',210,'Opis'),
	(15,12,'12.15.2009 ',220,'Opis'),
	(15,15,'12.15.2017 ',250,'Opis'),
	(15,17,'12.15.2019 ',270,'Opis'),
	(15,21,'12.15.2009 ',310,'Opis'),
	(16,10,'12.15.2007 ',200,'Opis'),
	(16,11,'12.15.2008 ',210,'Opis'),
	(16,16,'12.15.2018 ',260,'Opis'),
	(16,20,'12.15.2008 ',300,'Opis'),
	(17,9,'12.15.2021 ',190,'Opis'),
	(17,10,'12.15.2007 ',200,'Opis'),
	(17,15,'12.15.2017 ',250,'Opis'),
	(17,17,'12.15.2019 ',270,'Opis'),
	(17,19,'12.15.2007 ',290,'Opis'),
	(18,8,'12.15.2019 ',180,'Opis'),
	(18,9,'12.15.2021 ',190,'Opis'),
	(18,12,'12.15.2009 ',220,'Opis'),
	(18,18,'12.15.2021 ',280,'Opis'),
	(1,1,'2010.05.11',110,'Opis'),
	(1,5,'2010.05.11',150,'Opis'),
	(1,19,'2010.05.11',290,'Opis'),
	(1,25,'2010.05.11',350,'Opis'),
	(2,2,'2010.05.11',120,'Opis'),
	(2,6,'2010.05.11',160,'Opis'),
	(2,20,'2010.05.11',300,'Opis'),
	(2,24,'2010.05.11',340,'Opis'),
	(3,3,'2010.05.11',130,'Opis'),
	(3,4,'2010.05.11',140,'Opis'),
	(3,21,'2010.05.11',310,'Opis'),
	(3,23,'2010.05.11',330,'Opis'),
	(4,4,'2010.05.11',140,'Opis'),
	(4,22,'2010.05.11',320,'Opis'),
	(5,5,'2010.05.11',150,'Opis'),
	(5,21,'2010.05.11',310,'Opis'),
	(6,6,'2010.05.11',160,'Opis'),
	(6,20,'2010.05.11',300,'Opis'),
	(6,22,'2010.05.11',320,'Opis'),
	(7,3,'2010.05.11',130,'Opis'),
	(14,22,'2011.05.11',320,'Opis'),
	(15,1,'2011.05.11',110,'Opis'),
	(15,11,'2011.05.11',210,'Opis'),
	(15,12,'2011.05.11',220,'Opis'),
	(15,15,'2011.05.11',250,'Opis'),
	(15,17,'2011.05.11',270,'Opis'),
	(15,21,'2011.05.11',310,'Opis'),
	(16,10,'2011.05.11',200,'Opis'),
	(16,11,'2011.05.11',210,'Opis'),
	(16,16,'2011.05.11',260,'Opis'),
	(16,20,'2011.05.11',300,'Opis'),
	(17,9,'2011.05.11',190,'Opis'),
	(17,10,'2011.05.11',200,'Opis'),
	(17,15,'2011.05.11',250,'Opis'),
	(17,17,'2011.05.11',270,'Opis'),
	(17,19,'2011.05.11',290,'Opis'),
	(18,8,'2011.05.11',180,'Opis'),
	(18,9,'2011.05.11',190,'Opis'),
	(19,7,'12.15.2018 ',170,'Opis'),
	(19,8,'12.15.2019 ',180,'Opis'),
	(19,17,'12.15.2019 ',270,'Opis'),
	(19,19,'12.15.2007 ',290,'Opis'),
	(1,25,'2020.05.11',350,'Opis'),
	(2,2,'2020.05.11',120,'Opis'),
	(2,6,'2020.05.11',160,'Opis'),
	(2,20,'2020.05.11',300,'Opis'),
	(2,24,'2020.05.11',340,'Opis'),
	(3,3,'2020.05.11',130,'Opis'),
	(3,4,'2020.05.11',140,'Opis'),
	(3,21,'2020.05.11',310,'Opis'),
	(3,23,'2020.05.11',330,'Opis'),
	(4,4,'2020.05.11',140,'Opis'),
	(4,22,'2020.05.11',320,'Opis'),
	(5,5,'2020.05.11',150,'Opis'),
	(5,21,'2020.05.11',310,'Opis'),
	(6,6,'2020.05.11',160,'Opis'),
	(6,20,'2020.05.11',300,'Opis'),
	(6,22,'2020.05.11',320,'Opis'),
	(7,3,'2020.05.11',130,'Opis'),
	(7,7,'2020.05.11',170,'Opis'),
	(7,19,'2020.05.11',290,'Opis'),
	(7,23,'2020.05.11',330,'Opis'),
	(8,8,'2020.05.11',180,'Opis'),
	(8,18,'2020.05.11',280,'Opis'),
	(8,24,'2020.05.11',340,'Opis'),
	(9,7,'2020.05.11',170,'Opis'),
	(9,9,'2020.05.11',190,'Opis'),
	(9,17,'2020.05.11',270,'Opis'),
	(9,25,'2020.05.11',350,'Opis'),
	(10,1,'2020.05.11',110,'Opis'),
	(20,6,'12.15.2017 ',160,'Opis'),
	(20,7,'12.15.2018 ',170,'Opis'),
	(20,13,'12.15.2012 ',230,'Opis'),
	(20,20,'12.15.2008 ',300,'Opis'),
	(21,2,'12.15.2008 ',120,'Opis'),
	(21,5,'12.15.2016 ',150,'Opis'),
	(21,6,'12.15.2017 ',160,'Opis'),
	(21,9,'12.15.2021 ',190,'Opis'),
	(21,16,'12.15.2018 ',260,'Opis'),
	(21,21,'12.15.2009 ',310,'Opis'),
	(22,4,'12.15.2012 ',140,'Opis'),
	(22,5,'12.15.2016 ',150,'Opis'),
	(22,8,'12.15.2019 ',180,'Opis'),
	(22,22,'12.15.2012 ',320,'Opis'),
	(23,3,'12.15.2009 ',130,'Opis'),
	(23,4,'12.15.2012 ',140,'Opis'),
	(23,23,'12.15.2016 ',330,'Opis'),
	(24,2,'12.15.2008 ',120,'Opis'),
	(24,3,'12.15.2009 ',130,'Opis'),
	(24,24,'12.15.2017 ',340,'Opis'),
	(25,1,'12.15.2007 ',110,'Opis'),
	(25,2,'12.15.2008 ',120,'Opis'),
	(25,13,'12.15.2012 ',230,'Opis'),
	(25,25,'12.15.2018 ',350,'Opis');

INSERT INTO Istorija_rm_radnika VALUES
	(1,1,'2009.05.05',NULL),
	(2,3,'2010.01.11','2015.01.11'),
	(3,2,'2011.02.12','2017.02.12'),
	(4,1,'2012.03.13','2018.03.13'),
	(5,2,'2013.04.14',NULL);

/*Foreign keys*/
ALTER TABLE Radnik ADD CONSTRAINT FK_Radnik_kvalifikacijaID FOREIGN KEY (kvalifikacijaID) REFERENCES Kvalifikacija(kvalifikacijaID) ON DELETE CASCADE;
ALTER TABLE Angazman ADD CONSTRAINT FK_Angazman_radnikID FOREIGN KEY (radnikID) REFERENCES Radnik(radnikID) ON DELETE CASCADE;
ALTER TABLE Istorija_rm_radnika ADD CONSTRAINT FK_Istorija_rm_radnika_radnikID FOREIGN KEY (radnikID) REFERENCES Radnik(radnikID) ON DELETE CASCADE;
ALTER TABLE Angazman ADD CONSTRAINT FK_Angazman_projekaID FOREIGN KEY (projekatID) REFERENCES Projekat(projekatID) ON DELETE CASCADE;
ALTER TABLE Istorija_rm_radnika ADD CONSTRAINT FK_Istorija_rm_radnika_radno_mestoID FOREIGN KEY (radno_mestoID) REFERENCES Radno_mesto(radno_mestoID) ON DELETE CASCADE;

/*Dopuna*/

CREATE TABLE Podizvodjac(
	podizvodjacID int not null,
	naziv varchar(30),
	telefon varchar(35),
	broj_radnika int
);

CREATE TABLE Angazman_podizvodjaca(
	podizvodjacID int not null,
	projekatID int not null,
	datum_angazovanja date not null,  
	datum_kraja_angazovanja date 
);

ALTER TABLE Angazman_podizvodjaca ADD CONSTRAINT PK_Angazman_podizvodjaca PRIMARY KEY (podizvodjacID,projekatID,datum_angazovanja);
ALTER TABLE Podizvodjac ADD CONSTRAINT PK_Proizvodjac PRIMARY KEY (podizvodjacID);

ALTER TABLE Angazman_podizvodjaca ADD CONSTRAINT Angazman_podizvodjaca_datum_angazovanja CHECK(datum_angazovanja<datum_kraja_angazovanja);
ALTER TABLE Angazman_podizvodjaca ADD CONSTRAINT Angazman_podizvodjaca_datum_angazovanja_defautl DEFAULT GETDATE()  FOR datum_angazovanja;
ALTER TABLE Angazman_podizvodjaca ADD CONSTRAINT Angazman_podizvodjaca_datum_kraja_angazovanja_defautl DEFAULT DATEFROMPARTS(YEAR(GETDATE()), 12, 31) FOR datum_kraja_angazovanja;
ALTER TABLE Angazman_podizvodjaca ADD CONSTRAINT FK_Angazman_podizvodjaca_projekatID FOREIGN KEY (projekatID) REFERENCES Projekat(projekatID) ON DELETE CASCADE;
ALTER TABLE Angazman_podizvodjaca ADD CONSTRAINT FK_Angazman_podizvodjaca_podizvodjacID FOREIGN KEY (podizvodjacID) REFERENCES Podizvodjac(podizvodjacID) ON DELETE CASCADE;


/*
	USE master;
	DROP DATABASE A3;
*/

