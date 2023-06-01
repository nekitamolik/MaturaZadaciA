/*
	CREATE DATABASE A27;
	USE A27;
*/

CREATE TABLE Grad(
	gradID int IDENTITY(1,1),
	grad varchar(100),
	pozivni_broj varchar(40),
	postanski_broj varchar(40),
	broj_stanovnika int
);

CREATE TABLE Vozac(
	vozacID int IDENTITY(1,1),
	ime varchar(50),
	prezime varchar(70),
	datum_rodjenja date,
	dozvola_izdata date,
	adresa varchar(100),
	gradID int
);

CREATE TABLE Proizvodjac(
	proizvodjacID int IDENTITY(1,1),
	naziv varchar(100)
);

CREATE TABLE Model(
	modelID int IDENTITY(1,1),
	naziv varchar(100),
	proizvodjacID int,
	naziv_fajla text,
	slika varbinary(max),
	kubikaza int
);

CREATE TABLE Polisa(
	polisaID int IDENTITY(1,1),
	datum_pocetka date,
	datum_zavrsetka date,
	vrednost float
);

CREATE TABLE Vozilo(
	voziloID int IDENTITY(1,1),
	broj_sesije varchar(50),
	broj_motora varchar(50),
	velicina_motora varchar(100),
	modelID int,
	godina_registracije int,
	registarski_broj varchar(15),
	polisaID int
);

CREATE TABLE Vozilo_Vozac(
	vozacID int not null,
	voziloID int not null
);

/*Primary keys*/

ALTER TABLE Grad ADD CONSTRAINT PK_Grad PRIMARY KEY (gradID);
ALTER TABLE Vozac ADD CONSTRAINT PK_Vozac PRIMARY KEY (vozacID);
ALTER TABLE Proizvodjac ADD CONSTRAINT PK_Prozivodjac PRIMARY KEY (proizvodjacID);
ALTER TABLE Model ADD CONSTRAINT PK_Model PRIMARY KEY (modelID);
ALTER TABLE Polisa ADD CONSTRAINT PK_Polisa PRIMARY KEY (polisaID);
ALTER TABLE Vozilo ADD CONSTRAINT PK_Vozilo PRIMARY KEY (voziloID);
ALTER TABLE Vozilo_Vozac ADD CONSTRAINT PK_Vozilo_Vozac PRIMARY KEY (voziloID,vozacID);

INSERT INTO Grad VALUES
	('Grad1','1000','10000',95000),
	('Grad2','2000','20000',97000),
	('Grad3','3000','30000',68000),
	('Grad4','4000','40000',50000),
	('Grad5','5000','50000',89000),
	('Grad6','6000','60000',74000),
	('Grad7','7000','70000',77000),
	('Grad8','8000','80000',72000),
	('Grad9','9000','90000',52000),
	('Grad10','10000','100000',86000);

INSERT INTO Vozac VALUES
	('Vozac1','Vozac1','1997.5.20','2017.5.20','Adresa1',2),
	('Vozac2','Vozac2','1992.4.23','2012.4.23','Adresa2',4),
	('Vozac3','Vozac3','1995.6.20','2015.6.20','Adresa3',4),
	('Vozac4','Vozac4','1993.9.15','2013.9.15','Adresa4',6),
	('Vozac5','Vozac5','1993.4.29','2013.4.29','Adresa5',7),
	('Vozac6','Vozac6','1998.3.17','2018.3.17','Adresa6',7),
	('Vozac7','Vozac7','1995.9.22','2015.9.22','Adresa7',10),
	('Vozac8','Vozac8','1997.6.10','2017.6.10','Adresa8',5),
	('Vozac9','Vozac9','1994.3.9','2014.3.9','Adresa9',9),
	('Vozac10','Vozac10','1991.7.10','2011.7.10','Adresa10',8),
	('Vozac11','Vozac11','1998.9.25','2018.9.25','Adresa11',6),
	('Vozac12','Vozac12','1998.6.15','2018.6.15','Adresa12',4),
	('Vozac13','Vozac13','1995.7.15','2015.7.15','Adresa13',9),
	('Vozac14','Vozac14','1995.6.10','2015.6.10','Adresa14',1),
	('Vozac15','Vozac15','1997.8.22','2017.8.22','Adresa15',7),
	('Vozac16','Vozac16','1994.4.19','2014.4.19','Adresa16',3),
	('Vozac17','Vozac17','1992.8.1','2012.8.1','Adresa17',10),
	('Vozac18','Vozac18','1997.8.16','2017.8.16','Adresa18',3),
	('Vozac19','Vozac19','1999.6.23','2019.6.23','Adresa19',7),
	('Vozac20','Vozac20','1992.4.4','2012.4.4','Adresa20',10),
	('Vozac21','Vozac21','1994.9.28','2014.9.28','Adresa21',1),
	('Vozac22','Vozac22','1990.4.9','2010.4.9','Adresa22',1),
	('Vozac23','Vozac23','1996.7.28','2016.7.28','Adresa23',1),
	('Vozac24','Vozac24','1998.3.4','2018.3.4','Adresa24',5),
	('Vozac25','Vozac25','1992.8.3','2012.8.3','Adresa25',6),
	('Vozac26','Vozac26','1994.4.5','2014.4.5','Adresa26',1),
	('Vozac27','Vozac27','1991.8.4','2011.8.4','Adresa27',8),
	('Vozac28','Vozac28','1997.5.10','2017.5.10','Adresa28',1),
	('Vozac29','Vozac29','1995.7.24','2015.7.24','Adresa29',5),
	('Vozac30','Vozac30','1993.7.27','2013.7.27','Adresa30',6),
	('Vozac31','Vozac31','1995.3.18','2015.3.18','Adresa31',10),
	('Vozac32','Vozac32','1998.3.24','2018.3.24','Adresa32',1),
	('Vozac33','Vozac33','1993.4.22','2013.4.22','Adresa33',9),
	('Vozac34','Vozac34','1992.3.19','2012.3.19','Adresa34',5),
	('Vozac35','Vozac35','1997.4.26','2017.4.26','Adresa35',3),
	('Vozac36','Vozac36','1991.4.9','2011.4.9','Adresa36',3),
	('Vozac37','Vozac37','1993.6.24','2013.6.24','Adresa37',4),
	('Vozac38','Vozac38','1992.7.8','2012.7.8','Adresa38',3),
	('Vozac39','Vozac39','1999.3.15','2019.3.15','Adresa39',7),
	('Vozac40','Vozac40','1995.3.27','2015.3.27','Adresa40',5),
	('Vozac41','Vozac41','1999.5.22','2019.5.22','Adresa41',1),
	('Vozac42','Vozac42','1996.9.9','2016.9.9','Adresa42',6),
	('Vozac43','Vozac43','1990.6.23','2010.6.23','Adresa43',5),
	('Vozac44','Vozac44','1997.7.25','2017.7.25','Adresa44',2),
	('Vozac45','Vozac45','1997.5.20','2017.5.20','Adresa45',4),
	('Vozac46','Vozac46','1993.7.17','2013.7.17','Adresa46',4),
	('Vozac47','Vozac47','1999.3.14','2019.3.14','Adresa47',8),
	('Vozac48','Vozac48','1996.4.21','2016.4.21','Adresa48',2),
	('Vozac49','Vozac49','1992.8.9','2012.8.9','Adresa49',7),
	('Vozac50','Vozac50','1994.8.21','2014.8.21','Adresa50',9),
	('Vozac51','Vozac51','1991.5.6','2011.5.6','Adresa51',5),
	('Vozac52','Vozac52','1998.3.27','2018.3.27','Adresa52',8),
	('Vozac53','Vozac53','1992.4.22','2012.4.22','Adresa53',4),
	('Vozac54','Vozac54','1994.6.21','2014.6.21','Adresa54',3),
	('Vozac55','Vozac55','1997.3.18','2017.3.18','Adresa55',4),
	('Vozac56','Vozac56','1994.4.26','2014.4.26','Adresa56',6),
	('Vozac57','Vozac57','1998.4.26','2018.4.26','Adresa57',9),
	('Vozac58','Vozac58','1993.3.25','2013.3.25','Adresa58',9),
	('Vozac59','Vozac59','1995.4.7','2015.4.7','Adresa59',10),
	('Vozac60','Vozac60','1994.8.28','2014.8.28','Adresa60',10),
	('Vozac61','Vozac61','1992.3.26','2012.3.26','Adresa61',9),
	('Vozac62','Vozac62','1994.5.6','2014.5.6','Adresa62',5),
	('Vozac63','Vozac63','1991.9.5','2011.9.5','Adresa63',8),
	('Vozac64','Vozac64','1991.4.28','2011.4.28','Adresa64',5),
	('Vozac65','Vozac65','1994.5.27','2014.5.27','Adresa65',10),
	('Vozac66','Vozac66','1992.3.1','2012.3.1','Adresa66',7),
	('Vozac67','Vozac67','1993.8.21','2013.8.21','Adresa67',3),
	('Vozac68','Vozac68','1992.7.28','2012.7.28','Adresa68',2),
	('Vozac69','Vozac69','1990.8.9','2010.8.9','Adresa69',9),
	('Vozac70','Vozac70','1993.6.12','2013.6.12','Adresa70',4),
	('Vozac71','Vozac71','1999.3.22','2019.3.22','Adresa71',5),
	('Vozac72','Vozac72','1998.5.23','2018.5.23','Adresa72',4),
	('Vozac73','Vozac73','1993.4.16','2013.4.16','Adresa73',4),
	('Vozac74','Vozac74','1999.5.18','2019.5.18','Adresa74',1),
	('Vozac75','Vozac75','1991.7.3','2011.7.3','Adresa75',2),
	('Vozac76','Vozac76','1997.3.14','2017.3.14','Adresa76',7),
	('Vozac77','Vozac77','1999.5.11','2019.5.11','Adresa77',5),
	('Vozac78','Vozac78','1998.7.20','2018.7.20','Adresa78',4),
	('Vozac79','Vozac79','1999.6.20','2019.6.20','Adresa79',1),
	('Vozac80','Vozac80','1992.7.11','2012.7.11','Adresa80',1),
	('Vozac81','Vozac81','1990.5.25','2010.5.25','Adresa81',10),
	('Vozac82','Vozac82','1991.8.27','2011.8.27','Adresa82',1),
	('Vozac83','Vozac83','1991.3.7','2011.3.7','Adresa83',8),
	('Vozac84','Vozac84','1993.8.20','2013.8.20','Adresa84',7),
	('Vozac85','Vozac85','1996.5.12','2016.5.12','Adresa85',10),
	('Vozac86','Vozac86','1990.5.15','2010.5.15','Adresa86',6),
	('Vozac87','Vozac87','1995.6.5','2015.6.5','Adresa87',8),
	('Vozac88','Vozac88','1996.6.28','2016.6.28','Adresa88',5),
	('Vozac89','Vozac89','1992.3.19','2012.3.19','Adresa89',6),
	('Vozac90','Vozac90','1991.6.7','2011.6.7','Adresa90',5),
	('Vozac91','Vozac91','1993.7.8','2013.7.8','Adresa91',2),
	('Vozac92','Vozac92','1993.9.20','2013.9.20','Adresa92',8),
	('Vozac93','Vozac93','1998.7.13','2018.7.13','Adresa93',2),
	('Vozac94','Vozac94','1992.8.27','2012.8.27','Adresa94',10),
	('Vozac95','Vozac95','1998.3.13','2018.3.13','Adresa95',7),
	('Vozac96','Vozac96','1997.6.5','2017.6.5','Adresa96',7),
	('Vozac97','Vozac97','1991.7.13','2011.7.13','Adresa97',7),
	('Vozac98','Vozac98','1991.4.23','2011.4.23','Adresa98',3),
	('Vozac99','Vozac99','1990.4.7','2010.4.7','Adresa99',3),
	('Vozac100','Vozac100','1991.7.11','2011.7.11','Adresa100',5);

INSERT INTO Proizvodjac VALUES
	('Proizvodjac1'),
	('Proizvodjac2'),
	('Proizvodjac3'),
	('Proizvodjac4'),
	('Proizvodjac5'),
	('Proizvodjac6'),
	('Proizvodjac7'),
	('Proizvodjac8'),
	('Proizvodjac9'),
	('Proizvodjac10');

INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model1',1,'Model4.jpg',1751,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model4.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model2',1,'Model3.jpg',1143,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model3.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model3',1,'Model3.jpg',1229,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model3.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model4',2,'Model5.jpg',1068,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model5.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model5',2,'Model5.jpg',2718,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model5.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model6',2,'Model2.jpg',2544,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model2.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model7',3,'Model2.jpg',1595,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model2.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model8',3,'Model4.jpg',2024,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model4.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model9',3,'Model2.jpg',2987,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model2.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model10',4,'Model2.jpg',873,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model2.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model11',4,'Model5.jpg',2936,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model5.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model12',4,'Model1.jpg',2539,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model1.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model13',5,'Model5.jpg',1181,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model5.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model14',5,'Model3.jpg',2271,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model3.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model15',5,'Model5.jpg',2285,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model5.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model16',6,'Model2.jpg',1992,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model2.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model17',6,'Model4.jpg',2382,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model4.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model18',6,'Model1.jpg',2474,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model1.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model19',7,'Model4.jpg',1575,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model4.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model20',7,'Model3.jpg',2297,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model3.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model21',7,'Model3.jpg',1549,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model3.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model22',8,'Model5.jpg',2726,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model5.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model23',8,'Model1.jpg',1988,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model1.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model24',8,'Model5.jpg',973,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model5.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model25',9,'Model5.jpg',1661,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model5.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model26',9,'Model3.jpg',963,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model3.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model27',9,'Model5.jpg',1203,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model5.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model28',10,'Model4.jpg',1082,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model4.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model29',10,'Model1.jpg',2944,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model1.jpg',SINGLE_BLOB) m
INSERT INTO Model (naziv,proizvodjacID,naziv_fajla,kubikaza,slika) 
	                                    SELECT 'Model30',10,'Model2.jpg',1693,* FROM OPENROWSET(BULK N'/mediaserver/sambashare/SQL/Model2.jpg',SINGLE_BLOB) m


INSERT INTO Polisa VALUES
	('2021.11.9','2022.11.9',194000.00),
	('2021.11.20','2022.11.20',180000.00),
	('2021.6.1','2022.6.1',86000.00),
	('2021.11.29','2022.11.29',151000.00),
	('2021.8.2','2022.8.2',235000.00),
	('2021.3.22','2022.3.22',227000.00),
	('2021.5.22','2022.5.22',276000.00),
	('2021.9.16','2022.9.16',303000.00),
	('2021.9.15','2022.9.15',219000.00),
	('2021.5.6','2022.5.6',308000.00),
	('2021.10.13','2022.10.13',259000.00),
	('2021.4.17','2022.4.17',171000.00),
	('2021.11.26','2022.11.26',275000.00),
	('2021.7.18','2022.7.18',333000.00),
	('2021.8.7','2022.8.7',287000.00),
	('2021.11.9','2022.11.9',120000.00),
	('2021.8.1','2022.8.1',223000.00),
	('2021.4.20','2022.4.20',191000.00),
	('2021.7.28','2022.7.28',326000.00),
	('2021.7.26','2022.7.26',93000.00),
	('2021.3.19','2022.3.19',345000.00),
	('2021.8.4','2022.8.4',324000.00),
	('2021.10.22','2022.10.22',300000.00),
	('2021.3.18','2022.3.18',171000.00),
	('2021.12.26','2022.12.26',280000.00),
	('2021.4.11','2022.4.11',166000.00),
	('2021.12.28','2022.12.28',97000.00),
	('2021.8.5','2022.8.5',345000.00),
	('2021.5.13','2022.5.13',273000.00),
	('2021.7.24','2022.7.24',92000.00),
	('2021.5.12','2022.5.12',152000.00),
	('2021.6.25','2022.6.25',246000.00),
	('2021.4.18','2022.4.18',169000.00),
	('2021.8.24','2022.8.24',269000.00),
	('2021.8.23','2022.8.23',235000.00),
	('2021.4.10','2022.4.10',278000.00),
	('2021.3.20','2022.3.20',201000.00),
	('2021.8.15','2022.8.15',303000.00),
	('2021.5.28','2022.5.28',96000.00),
	('2021.10.20','2022.10.20',338000.00),
	('2021.5.6','2022.5.6',290000.00),
	('2021.7.24','2022.7.24',158000.00),
	('2021.11.12','2022.11.12',105000.00),
	('2021.3.7','2022.3.7',260000.00),
	('2021.12.29','2022.12.29',145000.00),
	('2021.3.21','2022.3.21',187000.00),
	('2021.8.18','2022.8.18',147000.00),
	('2021.11.25','2022.11.25',272000.00),
	('2021.3.18','2022.3.18',316000.00),
	('2021.3.15','2022.3.15',297000.00),
	('2021.8.13','2022.8.13',108000.00),
	('2021.11.13','2022.11.13',293000.00),
	('2021.9.3','2022.9.3',81000.00),
	('2021.5.4','2022.5.4',290000.00),
	('2021.12.28','2022.12.28',106000.00),
	('2021.3.14','2022.3.14',197000.00),
	('2021.8.23','2022.8.23',224000.00),
	('2021.7.9','2022.7.9',247000.00),
	('2021.12.26','2022.12.26',305000.00),
	('2021.12.30','2022.12.30',104000.00),
	('2021.9.22','2022.9.22',307000.00),
	('2021.3.5','2022.3.5',335000.00),
	('2021.8.9','2022.8.9',255000.00),
	('2021.3.8','2022.3.8',90000.00),
	('2021.11.23','2022.11.23',116000.00),
	('2021.11.16','2022.11.16',246000.00),
	('2021.5.9','2022.5.9',225000.00),
	('2021.3.15','2022.3.15',287000.00),
	('2021.10.11','2022.10.11',247000.00),
	('2021.8.22','2022.8.22',142000.00),
	('2021.4.22','2022.4.22',338000.00),
	('2021.5.12','2022.5.12',338000.00),
	('2021.3.28','2022.3.28',196000.00),
	('2021.7.23','2022.7.23',273000.00),
	('2021.5.16','2022.5.16',153000.00),
	('2021.6.17','2022.6.17',225000.00),
	('2021.9.7','2022.9.7',318000.00),
	('2021.3.24','2022.3.24',263000.00),
	('2021.11.8','2022.11.8',247000.00),
	('2021.8.12','2022.8.12',343000.00),
	('2021.11.3','2022.11.3',127000.00),
	('2021.10.15','2022.10.15',90000.00),
	('2021.3.5','2022.3.5',170000.00),
	('2021.5.7','2022.5.7',116000.00),
	('2021.11.28','2022.11.28',341000.00),
	('2021.10.22','2022.10.22',214000.00),
	('2021.6.17','2022.6.17',256000.00),
	('2021.10.6','2022.10.6',162000.00),
	('2021.6.20','2022.6.20',214000.00),
	('2021.8.25','2022.8.25',317000.00),
	('2021.11.20','2022.11.20',144000.00),
	('2021.9.19','2022.9.19',248000.00),
	('2021.5.13','2022.5.13',329000.00),
	('2021.11.5','2022.11.5',148000.00),
	('2021.7.23','2022.7.23',115000.00),
	('2021.4.3','2022.4.3',270000.00),
	('2021.9.10','2022.9.10',137000.00),
	('2021.6.20','2022.6.20',245000.00),
	('2021.9.10','2022.9.10',82000.00),
	('2021.4.23','2022.4.23',119000.00);

INSERT INTO Vozilo VALUES
	('1','1234MXQV','velicina motora',15,2021,'LE-123-TL',1),
	('2','2234MXQV','velicina motora',20,2021,'LE-123-EQ',2),
	('2','3234MXQV','velicina motora',15,2021,'LE-123-LO',3),
	('1','4234MXQV','velicina motora',5,2021,'LE-123-ED',4),
	('4','5234MXQV','velicina motora',24,2021,'LE-123-RN',5),
	('2','6234MXQV','velicina motora',9,2021,'LE-123-UO',6),
	('2','7234MXQV','velicina motora',25,2021,'LE-123-XL',7),
	('1','8234MXQV','velicina motora',4,2021,'LE-123-GR',8),
	('1','9234MXQV','velicina motora',12,2021,'LE-123-UF',9),
	('5','10234MXQV','velicina motora',4,2021,'LE-123-CU',10),
	('2','11234MXQV','velicina motora',20,2021,'LE-123-XN',11),
	('2','12234MXQV','velicina motora',10,2021,'LE-123-XU',12),
	('1','13234MXQV','velicina motora',30,2021,'LE-123-SK',13),
	('2','14234MXQV','velicina motora',25,2021,'LE-123-BH',14),
	('1','15234MXQV','velicina motora',8,2021,'LE-123-PI',15),
	('4','16234MXQV','velicina motora',12,2021,'LE-123-OL',16),
	('4','17234MXQV','velicina motora',30,2021,'LE-123-EB',17),
	('5','18234MXQV','velicina motora',8,2021,'LE-123-ZZ',18),
	('5','19234MXQV','velicina motora',20,2021,'LE-123-WC',19),
	('2','20224MXQV','velicina motora',11,2021,'LE-123-GN',20),
	('1','21234MXQV','velicina motora',14,2021,'LE-123-LY',21),
	('5','22234MXQV','velicina motora',11,2021,'LE-123-VC',22),
	('3','23234MXQV','velicina motora',5,2021,'LE-123-YY',23),
	('4','24234MXQV','velicina motora',7,2021,'LE-123-KY',24),
	('3','25234MXQV','velicina motora',21,2021,'LE-123-NO',25),
	('5','26234MXQV','velicina motora',6,2021,'LE-123-OB',26),
	('4','27234MXQV','velicina motora',6,2021,'LE-123-SY',27),
	('5','28234MXQV','velicina motora',14,2021,'LE-123-YZ',28),
	('1','29234MXQV','velicina motora',30,2021,'LE-123-WH',29),
	('3','30234MXQV','velicina motora',10,2021,'LE-123-CE',30),
	('1','31234MXQV','velicina motora',29,2021,'LE-123-WS',31),
	('1','32234MXQV','velicina motora',1,2021,'LE-123-UY',32),
	('5','33234MXQV','velicina motora',15,2021,'LE-123-KW',33),
	('4','34234MXQV','velicina motora',24,2021,'LE-123-IP',34),
	('2','35234MXQV','velicina motora',18,2021,'LE-123-UR',35),
	('5','36234MXQV','velicina motora',5,2021,'LE-123-QG',36),
	('5','37234MXQV','velicina motora',19,2021,'LE-123-ZD',37),
	('1','38234MXQV','velicina motora',27,2021,'LE-123-QD',38),
	('2','39234MXQV','velicina motora',12,2021,'LE-123-PD',39),
	('5','40234MXQV','velicina motora',30,2021,'LE-123-BE',40),
	('4','41234MXQV','velicina motora',28,2021,'LE-123-MO',41),
	('1','42234MXQV','velicina motora',17,2021,'LE-123-FI',42),
	('2','43234MXQV','velicina motora',25,2021,'LE-123-SY',43),
	('3','44234MXQV','velicina motora',25,2021,'LE-123-ZC',44),
	('4','45234MXQV','velicina motora',14,2021,'LE-123-DC',45),
	('4','46234MXQV','velicina motora',3,2021,'LE-123-CK',46),
	('2','47234MXQV','velicina motora',9,2021,'LE-123-NK',47),
	('2','48234MXQV','velicina motora',4,2021,'LE-123-PU',48),
	('4','49234MXQV','velicina motora',12,2021,'LE-123-TJ',49),
	('1','50234MXQV','velicina motora',14,2021,'LE-123-RP',50),
	('4','51234MXQV','velicina motora',24,2021,'LE-123-IQ',51),
	('4','52234MXQV','velicina motora',13,2021,'LE-123-HZ',52),
	('3','53234MXQV','velicina motora',12,2021,'LE-123-RJ',53),
	('5','54234MXQV','velicina motora',22,2021,'LE-123-CH',54),
	('1','55234MXQV','velicina motora',22,2021,'LE-123-GG',55),
	('5','56234MXQV','velicina motora',17,2021,'LE-123-FQ',56),
	('5','57234MXQV','velicina motora',21,2021,'LE-123-OG',57),
	('4','58234MXQV','velicina motora',21,2021,'LE-123-QJ',58),
	('3','59234MXQV','velicina motora',30,2021,'LE-123-HK',59),
	('3','60234MXQV','velicina motora',12,2021,'LE-123-YP',60),
	('3','61234MXQV','velicina motora',1,2021,'LE-123-BQ',61),
	('2','62234MXQV','velicina motora',17,2021,'LE-123-CL',62),
	('3','63234MXQV','velicina motora',17,2021,'LE-123-QK',63),
	('3','64234MXQV','velicina motora',26,2021,'LE-123-ZZ',64),
	('4','65234MXQV','velicina motora',16,2021,'LE-123-YO',65),
	('1','66234MXQV','velicina motora',5,2021,'LE-123-IT',66),
	('2','67234MXQV','velicina motora',27,2021,'LE-123-JF',67),
	('4','68234MXQV','velicina motora',21,2021,'LE-123-WH',68),
	('4','69234MXQV','velicina motora',3,2021,'LE-123-GC',69),
	('3','70234MXQV','velicina motora',24,2021,'LE-123-CL',70),
	('1','71234MXQV','velicina motora',26,2021,'LE-123-RF',71),
	('2','72234MXQV','velicina motora',1,2021,'LE-123-NP',72),
	('2','73234MXQV','velicina motora',17,2021,'LE-123-WS',73),
	('3','74234MXQV','velicina motora',16,2021,'LE-123-LZ',74),
	('2','75234MXQV','velicina motora',6,2021,'LE-123-TH',75),
	('5','76234MXQV','velicina motora',29,2021,'LE-123-TW',76),
	('2','77234MXQV','velicina motora',20,2021,'LE-123-IG',77),
	('5','78234MXQV','velicina motora',7,2021,'LE-123-FY',78),
	('3','79234MXQV','velicina motora',19,2021,'LE-123-SC',79),
	('1','80234MXQV','velicina motora',13,2021,'LE-123-TR',80),
	('4','81234MXQV','velicina motora',24,2021,'LE-123-RK',81),
	('1','82234MXQV','velicina motora',25,2021,'LE-123-TR',82),
	('2','83234MXQV','velicina motora',7,2021,'LE-123-WO',83),
	('4','84234MXQV','velicina motora',25,2021,'LE-123-MZ',84),
	('4','85234MXQV','velicina motora',12,2021,'LE-123-OQ',85),
	('2','86234MXQV','velicina motora',29,2021,'LE-123-JP',86),
	('5','87234MXQV','velicina motora',5,2021,'LE-123-CB',87),
	('2','88234MXQV','velicina motora',23,2021,'LE-123-OC',88),
	('1','89234MXQV','velicina motora',17,2021,'LE-123-MF',89),
	('2','90234MXQV','velicina motora',7,2021,'LE-123-CM',90),
	('4','91234MXQV','velicina motora',19,2021,'LE-123-BZ',91),
	('4','92234MXQV','velicina motora',2,2021,'LE-123-EV',92),
	('4','93234MXQV','velicina motora',3,2021,'LE-123-RQ',93),
	('1','94234MXQV','velicina motora',18,2021,'LE-123-SN',94),
	('1','95234MXQV','velicina motora',13,2021,'LE-123-GW',95),
	('4','96234MXQV','velicina motora',3,2021,'LE-123-YV',96),
	('5','97234MXQV','velicina motora',21,2021,'LE-123-ZT',97),
	('2','98234MXQV','velicina motora',11,2021,'LE-123-TZ',98),
	('1','99234MXQV','velicina motora',22,2021,'LE-123-BI',99),
	('2','100234MXQV','velicina motora',9,2021,'LE-123-ON',100);

INSERT INTO Vozilo_Vozac VALUES
	(1,1),
	(2,2),
	(3,3),
	(4,4),
	(5,5),
	(6,6),
	(7,7),
	(8,8),
	(9,9),
	(10,10),
	(11,11),
	(12,12),
	(13,13),
	(14,14),
	(15,15),
	(16,16),
	(17,17),
	(18,18),
	(19,19),
	(20,20),
	(21,21),
	(22,22),
	(23,23),
	(24,24),
	(25,25),
	(26,26),
	(27,27),
	(28,28),
	(29,29),
	(30,30),
	(31,31),
	(32,32),
	(33,33),
	(34,34),
	(35,35),
	(36,36),
	(37,37),
	(38,38),
	(39,39),
	(40,40),
	(41,41),
	(42,42),
	(43,43),
	(44,44),
	(45,45),
	(46,46),
	(47,47),
	(48,48),
	(49,49),
	(50,50),
	(51,51),
	(52,52),
	(53,53),
	(54,54),
	(55,55),
	(56,56),
	(57,57),
	(58,58),
	(59,59),
	(60,60),
	(61,61),
	(62,62),
	(63,63),
	(64,64),
	(65,65),
	(66,66),
	(67,67),
	(68,68),
	(69,69),
	(70,70),
	(71,71),
	(72,72),
	(73,73),
	(74,74),
	(75,75),
	(76,76),
	(77,77),
	(78,78),
	(79,79),
	(80,80),
	(81,81),
	(82,82),
	(83,83),
	(84,84),
	(85,85),
	(86,86),
	(87,87),
	(88,88),
	(89,89),
	(90,90),
	(91,91),
	(92,92),
	(93,93),
	(94,94),
	(95,95),
	(96,96),
	(97,97),
	(98,98),
	(99,99),
	(100,100);


/*Foreign keys*/

ALTER TABLE Vozac ADD CONSTRAINT FK_Vozac_gradID FOREIGN KEY (gradID) REFERENCES Grad(gradID);
ALTER TABLE Model ADD CONSTRAINT FK_Model_proizvodjacID FOREIGN KEY (proizvodjacID) REFERENCES Proizvodjac(proizvodjacID);
ALTER TABLE Vozilo ADD CONSTRAINT FK_Vozilo_modelID FOREIGN KEY (modelID) REFERENCES Model(modelID);
ALTER TABLE Vozilo ADD CONSTRAINT FK_Vozilo_polisaID FOREIGN KEY (polisaID) REFERENCES Polisa(polisaID);
ALTER TABLE Vozilo_Vozac ADD CONSTRAINT FK_Vozilo_Vozac_vozacID FOREIGN KEY (vozacID) REFERENCES Vozac(vozacID);
ALTER TABLE Vozilo_Vozac ADD CONSTRAINT FK_Vozilo_Vozac_voziloID FOREIGN KEY (voziloID) REFERENCES Vozilo(voziloID);

/*Dopuna*/

ALTER TABLE Vozilo ADD trenutna_cena float;

CREATE TABLE Prekrsaj(
	prekrsajID int IDENTITY(1,1),
	naziv varchar(100),
	opis text
);

CREATE TABLE Pocinio_Prekrsaj(
	vozacID int not null,
	prekrsajID int not null
);

ALTER TABLE Prekrsaj ADD CONSTRAINT PK_Prekrsaj PRIMARY KEY (prekrsajID);
ALTER TABLE Pocinio_Prekrsaj ADD CONSTRAINT PK_Pocinio_Prekrsaj PRIMARY KEY (vozacID,prekrsajID);
ALTER TABLE Pocinio_Prekrsaj ADD CONSTRAINT FK_Pocinio_Prekrsajc_vozacID FOREIGN KEY (vozacID) REFERENCES Vozac(vozacID);
ALTER TABLE Pocinio_Prekrsaj ADD CONSTRAINT FK_Pocinio_Prekrsajc_prekrsajID FOREIGN KEY (prekrsajID) REFERENCES Prekrsaj(prekrsajID);


/*
	USE master;
	DROP DATABASE A27;
*/