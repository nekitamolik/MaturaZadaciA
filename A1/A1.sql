/*
	CREATE DATABASE A1;
	USE A1;
*/

CREATE TABLE Citalac(
	CitalacID int not null,
	MaticniBroj varchar(20),
	Ime varchar(20),
	Prezime varchar(35),
	Adresa varchar(40)
);

CREATE TABLE Knjiga(
	KnjigaID int not null,
	UDK int,
	ISBN varchar(30),
	Naziv varchar(30)
);

CREATE TABLE Napisali(
	AutorID int not null,
	KnjigaID int not null
);

CREATE TABLE Autor(
	AutorID int not null,
	Ime varchar(20),
	Prezime varchar(35),
	DatumRodjenja date,
	Adresa varchar(40),
	Zvanje varchar(30)
);

CREATE TABLE Izdavac(
	IzdavacID int not null,
	NazivIzdavaca varchar(30),
	Adresa varchar(40)
);

CREATE TABLE Izdali(
	IzdavacID int not null,
	KnjigaID int not null,
	Godina int
);

CREATE TABLE Na_Citanju(
	KnjigaID int not null,
	CitalacID int not null,
	DatumUzimanja date not null,
	DatumVracanja date
);

/*Primary keys*/
ALTER TABLE Citalac ADD CONSTRAINT PK_Citalac PRIMARY KEY (CitalacID);
ALTER TABLE Knjiga ADD CONSTRAINT PK_Knjiga PRIMARY KEY (KnjigaID);
ALTER TABLE Izdavac ADD CONSTRAINT PK_Izdavac PRIMARY KEY (IzdavacID);
ALTER TABLE Autor ADD CONSTRAINT PK_Autor PRIMARY KEY (AutorID);
ALTER TABLE Izdali ADD CONSTRAINT PK_Izdali PRIMARY KEY (IzdavacID, KnjigaID);
ALTER TABLE Na_Citanju ADD CONSTRAINT PK_Na_Citanju PRIMARY KEY (KnjigaID, CitalacID, DatumUzimanja);
ALTER TABLE Napisali ADD CONSTRAINT PK_Napisali PRIMARY KEY (AutorID, KnjigaID);

INSERT INTO Citalac VALUES
	(1,'1605997740011','Citalac1','Citalac1','Adresa1'),
	(2,'1605997740012','Citalac2','Citalac2','Adresa2'),
	(3,'1605997740013','Citalac3','Citalac3','Adresa3'),
	(4,'1605997740014','Citalac4','Citalac4','Adresa4'),
	(5,'1605997740015','Citalac5','Citalac5','Adresa5'),
	(6,'1605997740016','Citalac6','Citalac6','Adresa6'),
	(7,'1605997740017','Citalac7','Citalac7','Adresa7'),
	(8,'1605997740018','Citalac8','Citalac8','Adresa8'),
	(9,'1605997740019','Citalac9','Citalac9','Adresa9'),
	(10,'1605997740010','Citalac10','Citalac10','Adresa10'),
	(11,'1605997740011','Citalac11','Citalac11','Adresa11'),
	(12,'1605997740012','Citalac12','Citalac12','Adresa12');

INSERT INTO Autor VALUES
	(1,'Autor1','Autor1','1991.11.01','Adresa1','A1'),
	(2,'Autor2','Autor2','1992.12.02','Adresa2','A2'),
	(3,'Autor3','Autor3','1993.01.03','Adresa3','A3'),
	(4,'Autor4','Autor4','1994.02.04','Adresa4','A4'),
	(5,'Autor5','Autor5','1995.03.05','Adresa5','A5');

INSERT INTO Izdavac VALUES
	(1,'Izdavac1','Adresa1'),
	(2,'Izdavac2','Adresa2'),
	(3,'Izdavac3','Adresa3'),
	(4,'Izdavac4','Adresa4'),
	(5,'Izdavac5','Adresa5');

INSERT INTO Knjiga VALUES
	(1,8,'123 45 6789 101 1','Knjiga1'),
	(2,7,'123 45 6789 101 1','Knjiga2'),
	(3,6,'123 45 6789 101 1','Knjiga3'),
	(4,5,'123 45 6789 101 1','Knjiga4'),
	(5,4,'123 45 6789 101 1','Knjiga5'),
	(6,3,'123 45 6789 101 1','Knjiga6'),
	(7,2,'123 45 6789 101 1','Knjiga7'),
	(8,1,'123 45 6789 101 1','Knjiga8');

INSERT INTO Na_Citanju VALUES
	(1,1,'2010.04.01',null),
	(2,1,'2012.05.11','2012.11.02'),
	(3,1,'2013.06.21',null),
	(4,1,'2014.07.01','2014.08.21'),
	(5,1,'2015.08.11','2015.11.03'),
	(6,1,'2016.09.21',null),
	(7,1,'2017.10.01','2017.11.14'),
	(8,1,'2018.11.11',null),
	(1,2,'2010.04.01',null),
	(2,2,'2012.05.11','2012.11.02'),
	(3,2,'2013.06.21',null),
	(4,2,'2014.07.01','2014.08.21'),
	(5,2,'2015.08.11','2015.11.03'),
	(6,2,'2016.09.21',null),
	(7,2,'2017.10.01','2017.11.14'),
	(8,2,'2018.11.11',null),
	(1,3,'2010.04.01',null),
	(2,3,'2012.05.11','2012.11.02'),
	(3,3,'2013.06.21',null),
	(4,3,'2014.07.01','2014.08.21'),
	(5,3,'2015.08.11','2015.11.03'),
	(6,3,'2016.09.21',null),
	(7,3,'2017.10.01','2017.11.14'),
	(8,3,'2018.11.11',null),
	(1,4,'2010.04.01',null),
	(2,4,'2012.05.11','2012.11.02'),
	(3,4,'2013.06.21',null),
	(4,4,'2014.07.01','2014.08.21'),
	(5,4,'2015.08.11','2015.11.03'),
	(6,4,'2016.09.21',null),
	(7,4,'2017.10.01','2017.11.14'),
	(8,4,'2018.11.11',null),
	(1,5,'2010.04.01',null),
	(2,5,'2012.05.11','2012.11.02'),
	(3,5,'2013.06.21',null),
	(4,5,'2014.07.01','2014.08.21'),
	(5,5,'2015.08.11','2015.11.03'),
	(6,5,'2016.09.21',null),
	(7,5,'2017.10.01','2017.11.14'),
	(8,5,'2018.11.11',null),
	(1,6,'2010.04.01',null),
	(2,6,'2012.05.11','2012.11.02'),
	(3,6,'2013.06.21',null),
	(4,6,'2014.07.01','2014.08.21'),
	(5,6,'2015.08.11','2015.11.03'),
	(6,6,'2016.09.21',null),
	(7,6,'2017.10.01','2017.11.14'),
	(8,6,'2018.11.11',null),
	(1,7,'2010.04.01',null),
	(2,7,'2012.05.11','2012.11.02'),
	(3,7,'2013.06.21',null),
	(4,7,'2014.07.01','2014.08.21'),
	(5,7,'2015.08.11','2015.11.03'),
	(6,7,'2016.09.21',null),
	(7,7,'2017.10.01','2017.11.14'),
	(8,7,'2018.11.11',null),
	(1,8,'2010.04.01',null),
	(2,8,'2012.05.11','2012.11.02'),
	(3,8,'2013.06.21',null),
	(4,8,'2014.07.01','2014.08.21'),
	(5,8,'2015.08.11','2015.11.03'),
	(6,8,'2016.09.21',null),
	(7,8,'2017.10.01','2017.11.14'),
	(8,8,'2018.11.11',null),
	(1,9,'2010.04.01',null),
	(2,9,'2012.05.11','2012.11.02'),
	(3,9,'2013.06.21',null),
	(4,9,'2014.07.01','2014.08.21'),
	(5,9,'2015.08.11','2015.11.03'),
	(6,9,'2016.09.21',null),
	(7,9,'2017.10.01','2017.11.14'),
	(8,9,'2018.11.11',null),
	(1,10,'2010.04.01',null),
	(2,10,'2012.05.11','2012.11.02'),
	(3,10,'2013.06.21',null),
	(4,10,'2014.07.01','2014.08.21'),
	(5,10,'2015.08.11','2015.11.03'),
	(6,10,'2016.09.21',null),
	(7,10,'2017.10.01','2017.11.14'),
	(1,11,'2010.04.01',null),
	(2,11,'2012.05.11','2012.11.02'),
	(3,11,'2013.06.21',null),
	(4,11,'2014.07.01','2014.08.21'),
	(5,11,'2015.08.11','2015.11.03'),
	(6,11,'2016.09.21',null),
	(7,11,'2017.10.01','2017.11.14'),
	(8,11,'2018.11.11',null),
	(1,12,'2010.04.01',null),
	(2,12,'2012.05.11','2012.11.02'),
	(3,12,'2013.06.21',null),
	(4,12,'2014.07.01','2014.08.21'),
	(5,12,'2015.08.11','2015.11.03'),
	(6,12,'2016.09.21',null),
	(7,12,'2017.10.01','2017.11.14'),
	(8,12,'2018.11.11',null);
	
INSERT INTO Napisali VALUES
	(1,1),
	(5,2),
	(4,3),
	(3,4),
	(2,5),
	(1,6),
	(5,7),
	(4,8);

INSERT INTO Izdali VALUES
	(1,1,2001),
	(4,2,2002),
	(3,3,2003),
	(2,4,2004),
	(3,5,2005),
	(1,6,2006),
	(5,7,2007),
	(2,8,2008);


/*Foreign keys*/
ALTER TABLE Na_Citanju ADD CONSTRAINT FK_CitalacID_Na_Citanju FOREIGN KEY (CitalacID) REFERENCES Citalac(CitalacID);
ALTER TABLE Na_Citanju ADD CONSTRAINT FK_KnjigaID_Na_Citanju FOREIGN KEY (KnjigaID) REFERENCES Knjiga(KnjigaID);
ALTER TABLE Primerak ADD CONSTRAINT FK_KnjigaID_Primerak FOREIGN KEY (KnjigaID) REFERENCES Knjiga(KnjigaID);
ALTER TABLE Napisali ADD CONSTRAINT FK_AutorID_Napisali FOREIGN KEY (AutorID) REFERENCES Autor(AutorID);
ALTER TABLE Napisali ADD CONSTRAINT FK_KnjigaID_Napisali FOREIGN KEY (KnjigaID) REFERENCES Knjiga(KnjigaID);
ALTER TABLE Izdali ADD CONSTRAINT FK_IzdavacID_Izdali FOREIGN KEY (IzdavacID) REFERENCES Izdavac(IzdavacID);
ALTER TABLE Izdali ADD CONSTRAINT FK_KnjigaID_Izdali FOREIGN KEY (KnjigaID) REFERENCES Knjiga(KnjigaID);

/*Dopuna*/
	
CREATE TABLE Primerak(
	KnjigaID int not null,
	PrimerakID int not null,
	SkolaID int not null,
	Datum_nabavke date 
);

CREATE TABLE Skola(
	SkolaID int not null,
	Naziv varchar(70),
	Adresa varchar(40),
	Datum_osnivanja_grane date
);

ALTER TABLE Skola ADD CONSTRAINT PK_Skola PRIMARY KEY (SkolaID);
ALTER TABLE Primerak ADD CONSTRAINT PK_Primerak PRIMARY KEY (KnjigaID, PrimerakID);
ALTER TABLE Primerak ADD CONSTRAINT Primerak_datum_nabavke CHECK(Datum_nabavke>= '2000.01.01');
ALTER TABLE Skola ADD CONSTRAINT Skola_datum_osnivanja_grane CHECK (Datum_osnivanja_grane>='2000.01.01');
ALTER TABLE Primerak ADD CONSTRAINT FK_Primerak_Skola FOREIGN KEY (SkolaID) REFERENCES Skola(SkolaiD);


/*
	USE master;	
	DROP DATABASE A1;
*/
