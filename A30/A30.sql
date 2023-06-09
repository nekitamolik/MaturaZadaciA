/*
	CREATE DATABASE A30;
	USE A30;
*/

CREATE TABLE Grad(
	gradID int IDENTITY(1,1),
	grad varchar(100) not null,
	pozivni_broj varchar(30),
	postanski_broj varchar(30),
	broj_stanovnika int
);

CREATE TABLE Igrac(
	igracID int IDENTITY(1,1),
	ime varchar(50) not null,
	prezime varchar(70) not null,
	adresa varchar(100),
	gradID int not null,
	email varchar(50),
	telefon varchar(30)
);

CREATE TABLE Teren(
	terenID int IDENTITY(1,1),
	teren varchar(100) not null,
	adresa varchar(100) not null,
	gradID int not null,
	kontakt_telefon varchar(30)
);

CREATE TABLE Rupa(
	rupaID int IDENTITY(1,1),
	rupaRB int not null,
	terenID int not null,
	opis text,
	udaljenost_od_rupe varchar(30),
	udaraca_po_rupi int
);

CREATE TABLE Partija(
	partijaID int IDENTITY(1,1),
	terenID int not null,
	datum date not null,
	vreme_pocetka time not null,
	vreme_zavrsetka time not null
);

CREATE TABLE Igraju(
	igracID int not null,
	partijaID int not null
);

CREATE TABLE Rezultat(
	rezultatID int IDENTITY(1,1),
	igracID int not null,
	partijaID int not null,
	rupaID int not null,
	skor int not null
);

/*Primary keys*/

ALTER TABLE Grad ADD CONSTRAINT PK_Grad PRIMARY KEY (gradID);
ALTER TABLE Igrac ADD CONSTRAINT PK_Igrac PRIMARY KEY (igracID);
ALTER TABLE Teren ADD CONSTRAINT PK_Teren PRIMARY KEY (terenID);
ALTER TABLE Rupa ADD CONSTRAINT PK_Rupa PRIMARY KEY (rupaID);
ALTER TABLE Partija ADD CONSTRAINT PK_Partija PRIMARY KEY (partijaID);
ALTER TABLE Igraju ADD CONSTRAINT PK_Igraju PRIMARY KEY (igracID,partijaID);
ALTER TABLE Rezultat ADD CONSTRAINT PK_Rezultat PRIMARY KEY (rezultatID);

INSERT INTO Grad VALUES
	('Grad1','057','57000',81342),
	('Grad2','066','66000',134633),
	('Grad3','038','38000',74426),
	('Grad4','048','48000',116389),
	('Grad5','062','62000',67668),
	('Grad6','029','29000',145832),
	('Grad7','086','86000',129464),
	('Grad8','015','15000',131885),
	('Grad9','095','95000',63847),
	('Grad10','064','64000',85952);

INSERT INTO Igrac VALUES
	('Ime1','Prezime1','Adresa1',1,'igrac1@gmail.com','0683160795'),
	('Ime2','Prezime2','Adresa2',1,'igrac2@gmail.com','0660617640'),
	('Ime3','Prezime3','Adresa3',1,'igrac3@gmail.com','0639824634'),
	('Ime4','Prezime4','Adresa4',1,'igrac4@gmail.com','0684048532'),
	('Ime5','Prezime5','Adresa5',1,'igrac5@gmail.com','0640157789'),
	('Ime6','Prezime6','Adresa6',1,'igrac6@gmail.com','0676437326'),
	('Ime7','Prezime7','Adresa7',1,'igrac7@gmail.com','0663747525'),
	('Ime8','Prezime8','Adresa8',1,'igrac8@gmail.com','0681015514'),
	('Ime9','Prezime9','Adresa9',1,'igrac9@gmail.com','0645177208'),
	('Ime10','Prezime10','Adresa10',1,'igrac10@gmail.com','0673086008'),
	('Ime11','Prezime11','Adresa11',1,'igrac11@gmail.com','0636080972'),
	('Ime12','Prezime12','Adresa12',1,'igrac12@gmail.com','0654069801'),
	('Ime13','Prezime13','Adresa13',1,'igrac13@gmail.com','0651062835'),
	('Ime14','Prezime14','Adresa14',1,'igrac14@gmail.com','0686798194'),
	('Ime15','Prezime15','Adresa15',1,'igrac15@gmail.com','0676720638'),
	('Ime16','Prezime16','Adresa16',1,'igrac16@gmail.com','0647476574'),
	('Ime17','Prezime17','Adresa17',1,'igrac17@gmail.com','0698495433'),
	('Ime18','Prezime18','Adresa18',1,'igrac18@gmail.com','0695403664'),
	('Ime19','Prezime19','Adresa19',1,'igrac19@gmail.com','0632069881'),
	('Ime20','Prezime20','Adresa20',1,'igrac20@gmail.com','0637842109'),
	('Ime21','Prezime21','Adresa21',1,'igrac21@gmail.com','0661727522'),
	('Ime22','Prezime22','Adresa22',1,'igrac22@gmail.com','0653575867'),
	('Ime23','Prezime23','Adresa23',1,'igrac23@gmail.com','0694943434'),
	('Ime24','Prezime24','Adresa24',1,'igrac24@gmail.com','0636808049'),
	('Ime25','Prezime25','Adresa25',1,'igrac25@gmail.com','0631698832'),
	('Ime26','Prezime26','Adresa26',1,'igrac26@gmail.com','0654827928'),
	('Ime27','Prezime27','Adresa27',1,'igrac27@gmail.com','0669907828'),
	('Ime28','Prezime28','Adresa28',1,'igrac28@gmail.com','0689366594'),
	('Ime29','Prezime29','Adresa29',2,'igrac29@gmail.com','0660990908'),
	('Ime30','Prezime30','Adresa30',2,'igrac30@gmail.com','0658235590'),
	('Ime31','Prezime31','Adresa31',2,'igrac31@gmail.com','0673117017'),
	('Ime32','Prezime32','Adresa32',2,'igrac32@gmail.com','0651808496'),
	('Ime33','Prezime33','Adresa33',2,'igrac33@gmail.com','0645767618'),
	('Ime34','Prezime34','Adresa34',2,'igrac34@gmail.com','0691604691'),
	('Ime35','Prezime35','Adresa35',2,'igrac35@gmail.com','0630932677'),
	('Ime36','Prezime36','Adresa36',2,'igrac36@gmail.com','0689151611'),
	('Ime37','Prezime37','Adresa37',2,'igrac37@gmail.com','0696928296'),
	('Ime38','Prezime38','Adresa38',2,'igrac38@gmail.com','0684662838'),
	('Ime39','Prezime39','Adresa39',3,'igrac39@gmail.com','0671997194'),
	('Ime40','Prezime40','Adresa40',3,'igrac40@gmail.com','0631905485'),
	('Ime41','Prezime41','Adresa41',3,'igrac41@gmail.com','0641894260'),
	('Ime42','Prezime42','Adresa42',3,'igrac42@gmail.com','0648145948'),
	('Ime43','Prezime43','Adresa43',3,'igrac43@gmail.com','0644658373'),
	('Ime44','Prezime44','Adresa44',3,'igrac44@gmail.com','0677463790'),
	('Ime45','Prezime45','Adresa45',3,'igrac45@gmail.com','0639746738'),
	('Ime46','Prezime46','Adresa46',3,'igrac46@gmail.com','0614396331'),
	('Ime47','Prezime47','Adresa47',3,'igrac47@gmail.com','0622510780'),
	('Ime48','Prezime48','Adresa48',3,'igrac48@gmail.com','0639584928'),
	('Ime49','Prezime49','Adresa49',3,'igrac49@gmail.com','0665674205'),
	('Ime50','Prezime50','Adresa50',3,'igrac50@gmail.com','0613016585'),
	('Ime51','Prezime51','Adresa51',3,'igrac51@gmail.com','0662349699'),
	('Ime52','Prezime52','Adresa52',3,'igrac52@gmail.com','0685329860'),
	('Ime53','Prezime53','Adresa53',3,'igrac53@gmail.com','0616529497'),
	('Ime54','Prezime54','Adresa54',3,'igrac54@gmail.com','0674380931'),
	('Ime55','Prezime55','Adresa55',3,'igrac55@gmail.com','0671149497'),
	('Ime56','Prezime56','Adresa56',3,'igrac56@gmail.com','0655502273'),
	('Ime57','Prezime57','Adresa57',3,'igrac57@gmail.com','0667016017'),
	('Ime58','Prezime58','Adresa58',3,'igrac58@gmail.com','0675090064'),
	('Ime59','Prezime59','Adresa59',3,'igrac59@gmail.com','0695834211'),
	('Ime60','Prezime60','Adresa60',3,'igrac60@gmail.com','0677945818'),
	('Ime61','Prezime61','Adresa61',3,'igrac61@gmail.com','0644989697'),
	('Ime62','Prezime62','Adresa62',3,'igrac62@gmail.com','0640953020'),
	('Ime63','Prezime63','Adresa63',3,'igrac63@gmail.com','0655871883'),
	('Ime64','Prezime64','Adresa64',3,'igrac64@gmail.com','0677562756'),
	('Ime65','Prezime65','Adresa65',3,'igrac65@gmail.com','0616252053'),
	('Ime66','Prezime66','Adresa66',3,'igrac66@gmail.com','0635141585'),
	('Ime67','Prezime67','Adresa67',3,'igrac67@gmail.com','0653179271'),
	('Ime68','Prezime68','Adresa68',3,'igrac68@gmail.com','0613891450'),
	('Ime69','Prezime69','Adresa69',4,'igrac69@gmail.com','0648002343'),
	('Ime70','Prezime70','Adresa70',4,'igrac70@gmail.com','0657472334'),
	('Ime71','Prezime71','Adresa71',4,'igrac71@gmail.com','0671720067'),
	('Ime72','Prezime72','Adresa72',4,'igrac72@gmail.com','0655016561'),
	('Ime73','Prezime73','Adresa73',4,'igrac73@gmail.com','0638606201'),
	('Ime74','Prezime74','Adresa74',4,'igrac74@gmail.com','0631244169'),
	('Ime75','Prezime75','Adresa75',4,'igrac75@gmail.com','0653839258'),
	('Ime76','Prezime76','Adresa76',4,'igrac76@gmail.com','0660606236'),
	('Ime77','Prezime77','Adresa77',4,'igrac77@gmail.com','0622223567'),
	('Ime78','Prezime78','Adresa78',4,'igrac78@gmail.com','0680093413'),
	('Ime79','Prezime79','Adresa79',4,'igrac79@gmail.com','0688588106'),
	('Ime80','Prezime80','Adresa80',4,'igrac80@gmail.com','0668582977'),
	('Ime81','Prezime81','Adresa81',4,'igrac81@gmail.com','0613821751'),
	('Ime82','Prezime82','Adresa82',4,'igrac82@gmail.com','0690398798'),
	('Ime83','Prezime83','Adresa83',4,'igrac83@gmail.com','0620281906'),
	('Ime84','Prezime84','Adresa84',5,'igrac84@gmail.com','0686915787'),
	('Ime85','Prezime85','Adresa85',5,'igrac85@gmail.com','0610941239'),
	('Ime86','Prezime86','Adresa86',5,'igrac86@gmail.com','0692274065'),
	('Ime87','Prezime87','Adresa87',5,'igrac87@gmail.com','0667095617'),
	('Ime88','Prezime88','Adresa88',5,'igrac88@gmail.com','0671211737'),
	('Ime89','Prezime89','Adresa89',5,'igrac89@gmail.com','0614605152'),
	('Ime90','Prezime90','Adresa90',5,'igrac90@gmail.com','0661217060'),
	('Ime91','Prezime91','Adresa91',5,'igrac91@gmail.com','0618619329'),
	('Ime92','Prezime92','Adresa92',5,'igrac92@gmail.com','0679187047'),
	('Ime93','Prezime93','Adresa93',5,'igrac93@gmail.com','0653049811'),
	('Ime94','Prezime94','Adresa94',5,'igrac94@gmail.com','0614364580'),
	('Ime95','Prezime95','Adresa95',5,'igrac95@gmail.com','0621185054'),
	('Ime96','Prezime96','Adresa96',5,'igrac96@gmail.com','0612499126'),
	('Ime97','Prezime97','Adresa97',5,'igrac97@gmail.com','0668527154'),
	('Ime98','Prezime98','Adresa98',5,'igrac98@gmail.com','0626908596'),
	('Ime99','Prezime99','Adresa99',5,'igrac99@gmail.com','0699429429'),
	('Ime100','Prezime100','Adresa100',5,'igrac100@gmail.com','0610485712'),
	('Ime101','Prezime101','Adresa101',5,'igrac101@gmail.com','0638409815'),
	('Ime102','Prezime102','Adresa102',5,'igrac102@gmail.com','0653845894'),
	('Ime103','Prezime103','Adresa103',5,'igrac103@gmail.com','0651994952'),
	('Ime104','Prezime104','Adresa104',5,'igrac104@gmail.com','0627339581'),
	('Ime105','Prezime105','Adresa105',5,'igrac105@gmail.com','0632766130'),
	('Ime106','Prezime106','Adresa106',5,'igrac106@gmail.com','0660859606'),
	('Ime107','Prezime107','Adresa107',5,'igrac107@gmail.com','0667283777'),
	('Ime108','Prezime108','Adresa108',5,'igrac108@gmail.com','0618979779'),
	('Ime109','Prezime109','Adresa109',5,'igrac109@gmail.com','0612430302'),
	('Ime110','Prezime110','Adresa110',5,'igrac110@gmail.com','0644742786'),
	('Ime111','Prezime111','Adresa111',5,'igrac111@gmail.com','0642897364'),
	('Ime112','Prezime112','Adresa112',6,'igrac112@gmail.com','0645586024'),
	('Ime113','Prezime113','Adresa113',6,'igrac113@gmail.com','0666464669'),
	('Ime114','Prezime114','Adresa114',6,'igrac114@gmail.com','0688779357'),
	('Ime115','Prezime115','Adresa115',6,'igrac115@gmail.com','0661086555'),
	('Ime116','Prezime116','Adresa116',6,'igrac116@gmail.com','0656531094'),
	('Ime117','Prezime117','Adresa117',7,'igrac117@gmail.com','0643036520'),
	('Ime118','Prezime118','Adresa118',7,'igrac118@gmail.com','0637043601'),
	('Ime119','Prezime119','Adresa119',7,'igrac119@gmail.com','0684223526'),
	('Ime120','Prezime120','Adresa120',7,'igrac120@gmail.com','0657397922'),
	('Ime121','Prezime121','Adresa121',7,'igrac121@gmail.com','0611322624'),
	('Ime122','Prezime122','Adresa122',7,'igrac122@gmail.com','0631871644'),
	('Ime123','Prezime123','Adresa123',7,'igrac123@gmail.com','0693373310'),
	('Ime124','Prezime124','Adresa124',7,'igrac124@gmail.com','0687257143'),
	('Ime125','Prezime125','Adresa125',7,'igrac125@gmail.com','0647190000'),
	('Ime126','Prezime126','Adresa126',7,'igrac126@gmail.com','0686893207'),
	('Ime127','Prezime127','Adresa127',7,'igrac127@gmail.com','0619220085'),
	('Ime128','Prezime128','Adresa128',7,'igrac128@gmail.com','0642705023'),
	('Ime129','Prezime129','Adresa129',7,'igrac129@gmail.com','0676711795'),
	('Ime130','Prezime130','Adresa130',7,'igrac130@gmail.com','0664149657'),
	('Ime131','Prezime131','Adresa131',7,'igrac131@gmail.com','0650081632'),
	('Ime132','Prezime132','Adresa132',7,'igrac132@gmail.com','0634990287'),
	('Ime133','Prezime133','Adresa133',7,'igrac133@gmail.com','0658115838'),
	('Ime134','Prezime134','Adresa134',7,'igrac134@gmail.com','0668781435'),
	('Ime135','Prezime135','Adresa135',7,'igrac135@gmail.com','0669862365'),
	('Ime136','Prezime136','Adresa136',7,'igrac136@gmail.com','0628319695'),
	('Ime137','Prezime137','Adresa137',7,'igrac137@gmail.com','0691414451'),
	('Ime138','Prezime138','Adresa138',7,'igrac138@gmail.com','0666464878'),
	('Ime139','Prezime139','Adresa139',7,'igrac139@gmail.com','0655728440'),
	('Ime140','Prezime140','Adresa140',7,'igrac140@gmail.com','0668778555'),
	('Ime141','Prezime141','Adresa141',7,'igrac141@gmail.com','0654720385'),
	('Ime142','Prezime142','Adresa142',7,'igrac142@gmail.com','0623719769'),
	('Ime143','Prezime143','Adresa143',7,'igrac143@gmail.com','0617440599'),
	('Ime144','Prezime144','Adresa144',7,'igrac144@gmail.com','0670377502'),
	('Ime145','Prezime145','Adresa145',7,'igrac145@gmail.com','0629983427'),
	('Ime146','Prezime146','Adresa146',7,'igrac146@gmail.com','0622564767'),
	('Ime147','Prezime147','Adresa147',7,'igrac147@gmail.com','0671015351'),
	('Ime148','Prezime148','Adresa148',7,'igrac148@gmail.com','0637206877'),
	('Ime149','Prezime149','Adresa149',7,'igrac149@gmail.com','0659372753'),
	('Ime150','Prezime150','Adresa150',7,'igrac150@gmail.com','0675352673'),
	('Ime151','Prezime151','Adresa151',7,'igrac151@gmail.com','0689729609'),
	('Ime152','Prezime152','Adresa152',7,'igrac152@gmail.com','0633816005'),
	('Ime153','Prezime153','Adresa153',7,'igrac153@gmail.com','0683060250'),
	('Ime154','Prezime154','Adresa154',7,'igrac154@gmail.com','0661581856'),
	('Ime155','Prezime155','Adresa155',7,'igrac155@gmail.com','0611107677'),
	('Ime156','Prezime156','Adresa156',7,'igrac156@gmail.com','0622871142'),
	('Ime157','Prezime157','Adresa157',8,'igrac157@gmail.com','0636365939'),
	('Ime158','Prezime158','Adresa158',8,'igrac158@gmail.com','0633759645'),
	('Ime159','Prezime159','Adresa159',8,'igrac159@gmail.com','0622067561'),
	('Ime160','Prezime160','Adresa160',8,'igrac160@gmail.com','0696936897'),
	('Ime161','Prezime161','Adresa161',8,'igrac161@gmail.com','0616449461'),
	('Ime162','Prezime162','Adresa162',8,'igrac162@gmail.com','0654455714'),
	('Ime163','Prezime163','Adresa163',8,'igrac163@gmail.com','0639805106'),
	('Ime164','Prezime164','Adresa164',8,'igrac164@gmail.com','0698613029'),
	('Ime165','Prezime165','Adresa165',8,'igrac165@gmail.com','0656776651'),
	('Ime166','Prezime166','Adresa166',8,'igrac166@gmail.com','0674302503'),
	('Ime167','Prezime167','Adresa167',8,'igrac167@gmail.com','0660572455'),
	('Ime168','Prezime168','Adresa168',8,'igrac168@gmail.com','0676571642'),
	('Ime169','Prezime169','Adresa169',9,'igrac169@gmail.com','0667273716'),
	('Ime170','Prezime170','Adresa170',9,'igrac170@gmail.com','0634625232'),
	('Ime171','Prezime171','Adresa171',9,'igrac171@gmail.com','0625877855'),
	('Ime172','Prezime172','Adresa172',9,'igrac172@gmail.com','0682013207'),
	('Ime173','Prezime173','Adresa173',9,'igrac173@gmail.com','0683332269'),
	('Ime174','Prezime174','Adresa174',9,'igrac174@gmail.com','0611359121'),
	('Ime175','Prezime175','Adresa175',9,'igrac175@gmail.com','0674420047'),
	('Ime176','Prezime176','Adresa176',9,'igrac176@gmail.com','0626265627'),
	('Ime177','Prezime177','Adresa177',9,'igrac177@gmail.com','0651930036'),
	('Ime178','Prezime178','Adresa178',9,'igrac178@gmail.com','0696533981'),
	('Ime179','Prezime179','Adresa179',9,'igrac179@gmail.com','0667673757'),
	('Ime180','Prezime180','Adresa180',9,'igrac180@gmail.com','0656991223'),
	('Ime181','Prezime181','Adresa181',9,'igrac181@gmail.com','0678795641'),
	('Ime182','Prezime182','Adresa182',9,'igrac182@gmail.com','0661466717'),
	('Ime183','Prezime183','Adresa183',9,'igrac183@gmail.com','0690932709'),
	('Ime184','Prezime184','Adresa184',9,'igrac184@gmail.com','0645300277'),
	('Ime185','Prezime185','Adresa185',9,'igrac185@gmail.com','0642412615'),
	('Ime186','Prezime186','Adresa186',9,'igrac186@gmail.com','0630960739'),
	('Ime187','Prezime187','Adresa187',9,'igrac187@gmail.com','0611652207'),
	('Ime188','Prezime188','Adresa188',9,'igrac188@gmail.com','0620503701'),
	('Ime189','Prezime189','Adresa189',9,'igrac189@gmail.com','0663928041'),
	('Ime190','Prezime190','Adresa190',9,'igrac190@gmail.com','0675527712'),
	('Ime191','Prezime191','Adresa191',9,'igrac191@gmail.com','0682759661'),
	('Ime192','Prezime192','Adresa192',9,'igrac192@gmail.com','0672402322'),
	('Ime193','Prezime193','Adresa193',10,'igrac193@gmail.com','0658904319'),
	('Ime194','Prezime194','Adresa194',10,'igrac194@gmail.com','0623504823'),
	('Ime195','Prezime195','Adresa195',10,'igrac195@gmail.com','0698440097'),
	('Ime196','Prezime196','Adresa196',10,'igrac196@gmail.com','0626528246'),
	('Ime197','Prezime197','Adresa197',10,'igrac197@gmail.com','0672674017'),
	('Ime198','Prezime198','Adresa198',10,'igrac198@gmail.com','0650906936'),
	('Ime199','Prezime199','Adresa199',10,'igrac199@gmail.com','0694550307'),
	('Ime200','Prezime200','Adresa200',10,'igrac200@gmail.com','0654352731'),
	('Ime201','Prezime201','Adresa201',10,'igrac201@gmail.com','0650427375'),
	('Ime202','Prezime202','Adresa202',10,'igrac202@gmail.com','0620708439'),
	('Ime203','Prezime203','Adresa203',10,'igrac203@gmail.com','0632516849'),
	('Ime204','Prezime204','Adresa204',10,'igrac204@gmail.com','0690183833'),
	('Ime205','Prezime205','Adresa205',10,'igrac205@gmail.com','0612525677'),
	('Ime206','Prezime206','Adresa206',10,'igrac206@gmail.com','0643271124'),
	('Ime207','Prezime207','Adresa207',10,'igrac207@gmail.com','0640939272'),
	('Ime208','Prezime208','Adresa208',10,'igrac208@gmail.com','0699785427'),
	('Ime209','Prezime209','Adresa209',10,'igrac209@gmail.com','0695506861'),
	('Ime210','Prezime210','Adresa210',10,'igrac210@gmail.com','0699105737'),
	('Ime211','Prezime211','Adresa211',10,'igrac211@gmail.com','0685638932'),
	('Ime212','Prezime212','Adresa212',10,'igrac212@gmail.com','0646014883'),
	('Ime213','Prezime213','Adresa213',10,'igrac213@gmail.com','0683032355'),
	('Ime214','Prezime214','Adresa214',10,'igrac214@gmail.com','0681716798'),
	('Ime215','Prezime215','Adresa215',10,'igrac215@gmail.com','0685950646'),
	('Ime216','Prezime216','Adresa216',10,'igrac216@gmail.com','0613927342'),
	('Ime217','Prezime217','Adresa217',10,'igrac217@gmail.com','0669067766'),
	('Ime218','Prezime218','Adresa218',10,'igrac218@gmail.com','0691746003'),
	('Ime219','Prezime219','Adresa219',10,'igrac219@gmail.com','0651865570'),
	('Ime220','Prezime220','Adresa220',10,'igrac220@gmail.com','0653475533'),
	('Ime221','Prezime221','Adresa221',10,'igrac221@gmail.com','0611582981'),
	('Ime222','Prezime222','Adresa222',10,'igrac222@gmail.com','0698262019'),
	('Ime223','Prezime223','Adresa223',10,'igrac223@gmail.com','0686578904'),
	('Ime224','Prezime224','Adresa224',10,'igrac224@gmail.com','0661262079'),
	('Ime225','Prezime225','Adresa225',10,'igrac225@gmail.com','0673764783'),
	('Ime226','Prezime226','Adresa226',10,'igrac226@gmail.com','0684314757'),
	('Ime227','Prezime227','Adresa227',10,'igrac227@gmail.com','0647629662'),
	('Ime228','Prezime228','Adresa228',10,'igrac228@gmail.com','0654168933'),
	('Ime229','Prezime229','Adresa229',10,'igrac229@gmail.com','0658551126'),
	('Ime230','Prezime230','Adresa230',10,'igrac230@gmail.com','0662267394'),
	('Ime231','Prezime231','Adresa231',10,'igrac231@gmail.com','0688792700'),
	('Ime232','Prezime232','Adresa232',10,'igrac232@gmail.com','0650025772');

INSERT INTO Teren VALUES
	('Teren1','Adresa1',1,'0672867454'),
	('Teren2','Adresa2',1,'0661816620'),
	('Teren3','Adresa3',2,'0642238441'),
	('Teren4','Adresa4',3,'0674238302'),
	('Teren5','Adresa5',3,'0616069991'),
	('Teren6','Adresa6',4,'0682319040'),
	('Teren7','Adresa7',5,'0638156044'),
	('Teren8','Adresa8',6,'0680534187'),
	('Teren9','Adresa9',6,'0698652004'),
	('Teren10','Adresa10',7,'0651164645'),
	('Teren11','Adresa11',8,'0682830733'),
	('Teren12','Adresa12',9,'0625303023'),
	('Teren13','Adresa13',10,'0663065980'),
	('Teren14','Adresa14',10,'0684699976');

INSERT INTO Rupa VALUES
	(1,1,'Opis1','124m',4),
	(2,1,'Opis2','115m',5),
	(3,1,'Opis3','60m',3),
	(4,1,'Opis4','105m',3),
	(1,2,'Opis1','170m',5),
	(2,2,'Opis2','115m',5),
	(3,2,'Opis3','153m',5),
	(1,3,'Opis1','88m',3),
	(2,3,'Opis2','71m',4),
	(3,3,'Opis3','55m',4),
	(1,4,'Opis1','88m',3),
	(2,4,'Opis2','76m',3),
	(3,4,'Opis3','74m',4),
	(4,4,'Opis4','158m',5),
	(1,5,'Opis1','119m',5),
	(2,5,'Opis2','133m',4),
	(3,5,'Opis3','162m',5),
	(4,5,'Opis4','95m',5),
	(1,6,'Opis1','94m',5),
	(2,6,'Opis2','86m',5),
	(3,6,'Opis3','170m',3),
	(1,7,'Opis1','129m',3),
	(2,7,'Opis2','98m',3),
	(3,7,'Opis3','111m',5),
	(4,7,'Opis4','127m',5),
	(1,8,'Opis1','67m',4),
	(2,8,'Opis2','163m',3),
	(3,8,'Opis3','71m',4),
	(4,8,'Opis4','130m',3),
	(1,9,'Opis1','175m',3),
	(2,9,'Opis2','60m',3),
	(3,9,'Opis3','102m',4),
	(1,10,'Opis1','89m',3),
	(2,10,'Opis2','140m',5),
	(3,10,'Opis3','69m',4),
	(4,10,'Opis4','78m',3),
	(1,11,'Opis1','125m',3),
	(2,11,'Opis2','100m',4),
	(3,11,'Opis3','89m',5),
	(4,11,'Opis4','59m',5),
	(1,12,'Opis1','134m',4),
	(2,12,'Opis2','111m',5),
	(3,12,'Opis3','62m',5),
	(4,12,'Opis4','77m',3),
	(1,13,'Opis1','174m',3),
	(2,13,'Opis2','102m',3),
	(3,13,'Opis3','138m',3),
	(4,13,'Opis4','88m',3),
	(1,14,'Opis1','166m',3),
	(2,14,'Opis2','124m',4),
	(3,14,'Opis3','85m',4);

INSERT INTO Partija VALUES
	(13,'2019.7.11','10:21','13:24'),
	(1,'2019.6.21','15:28','16:44'),
	(2,'2019.9.13','10:27','11:34'),
	(4,'2019.5.17','11:16','12:29'),
	(8,'2019.6.1','9:11','12:20'),
	(14,'2019.6.2','12:10','15:14'),
	(14,'2019.7.27','9:13','11:25'),
	(5,'2019.8.14','14:10','16:22'),
	(1,'2019.8.25','11:19','13:39'),
	(9,'2019.8.21','16:16','17:32'),
	(10,'2019.6.19','15:18','16:22'),
	(9,'2019.7.8','9:21','10:30'),
	(8,'2019.7.11','9:17','12:24'),
	(4,'2020.5.16','10:19','13:46'),
	(12,'2020.5.26','12:27','14:40'),
	(9,'2020.9.17','11:15','14:21'),
	(5,'2020.4.27','13:17','15:22'),
	(6,'2020.8.27','11:16','12:22'),
	(1,'2020.5.6','14:12','17:24'),
	(7,'2020.5.6','10:28','11:48'),
	(1,'2020.6.1','13:20','15:38'),
	(6,'2020.7.19','9:21','12:47'),
	(6,'2021.4.17','11:15','13:32'),
	(11,'2021.8.5','16:25','18:52'),
	(13,'2021.6.13','10:19','13:29'),
	(8,'2021.8.23','14:21','16:42'),
	(2,'2021.7.17','16:20','18:29'),
	(5,'2021.7.17','16:14','19:17'),
	(4,'2021.6.18','13:10','14:36'),
	(5,'2021.7.10','11:10','12:12'),
	(3,'2021.8.21','14:11','17:36'),
	(12,'2021.7.28','11:10','13:28'),
	(4,'2021.9.11','10:29','11:46'),
	(13,'2021.5.2','13:14','16:24'),
	(12,'2021.5.22','13:20','14:43'),
	(13,'2021.9.7','10:10','11:15'),
	(11,'2021.7.9','9:20','10:32'),
	(9,'2021.9.1','9:26','11:30'),
	(5,'2021.7.4','15:11','17:18'),
	(1,'2021.5.23','12:17','15:46'),
	(8,'2021.4.2','16:29','18:39'),
	(11,'2022.7.21','13:28','14:37'),
	(2,'2022.6.21','15:22','16:28'),
	(8,'2022.6.29','14:28','16:41'),
	(14,'2022.7.5','12:18','15:42'),
	(8,'2022.4.25','9:25','10:51'),
	(5,'2022.4.16','13:11','16:26'),
	(10,'2022.8.18','10:25','13:27'),
	(1,'2022.9.8','12:24','13:32'),
	(5,'2022.7.4','12:17','14:40'),
	(3,'2022.9.20','15:12','16:29'),
	(11,'2022.6.5','15:22','18:29'),
	(3,'2022.7.7','14:29','17:36'),
	(9,'2022.7.18','9:10','11:25'),
	(13,'2022.6.4','14:20','17:49'),
	(7,'2022.9.11','14:19','16:34'),
	(1,'2022.4.19','9:12','10:21');

INSERT INTO Igraju VALUES
	(31,1),
	(180,1),
	(132,2),
	(186,2),
	(68,3),
	(170,3),
	(90,4),
	(197,4),
	(91,5),
	(177,5),
	(73,6),
	(142,6),
	(72,7),
	(133,7),
	(64,8),
	(208,8),
	(124,9),
	(229,9),
	(103,10),
	(232,10),
	(128,11),
	(198,11),
	(15,12),
	(144,12),
	(6,13),
	(218,13),
	(126,14),
	(215,14),
	(67,15),
	(221,15),
	(79,16),
	(202,16),
	(116,17),
	(163,17),
	(84,18),
	(228,18),
	(126,19),
	(159,19),
	(67,20),
	(184,20),
	(82,21),
	(154,21),
	(14,22),
	(195,22),
	(91,23),
	(195,23),
	(59,24),
	(184,24),
	(8,25),
	(224,25),
	(111,26),
	(137,26),
	(48,27),
	(223,27),
	(95,28),
	(154,28),
	(113,29),
	(195,29),
	(5,30),
	(138,30),
	(112,31),
	(216,31),
	(127,32),
	(182,32),
	(126,33),
	(198,33),
	(93,34),
	(212,34),
	(113,35),
	(168,35),
	(6,36),
	(151,36),
	(78,37),
	(145,37),
	(44,38),
	(216,38),
	(98,39),
	(197,39),
	(73,40),
	(162,40),
	(40,41),
	(155,41),
	(131,42),
	(142,42),
	(117,43),
	(141,43),
	(124,44),
	(188,44),
	(116,45),
	(176,45),
	(20,46),
	(160,46),
	(40,47),
	(167,47),
	(109,48),
	(171,48),
	(27,49),
	(172,49),
	(92,50),
	(200,50),
	(66,51),
	(208,51),
	(66,52),
	(164,52),
	(95,53),
	(195,53),
	(75,54),
	(229,54),
	(25,55),
	(216,55),
	(57,56),
	(228,56),
	(98,57),
	(201,57);

INSERT INTO Rezultat VALUES
	(31,1,1,582),
	(31,1,2,921),
	(31,1,3,952),
	(31,1,4,400),
	(180,1,1,886),
	(180,1,2,475),
	(180,1,3,745),
	(180,1,4,426),
	(132,2,1,757),
	(132,2,2,735),
	(132,2,3,925),
	(132,2,4,460),
	(186,2,1,899),
	(186,2,2,415),
	(186,2,3,555),
	(186,2,4,392),
	(68,3,1,861),
	(68,3,2,496),
	(68,3,3,721),
	(170,3,1,551),
	(170,3,2,737),
	(170,3,3,898),
	(90,4,1,594),
	(90,4,2,749),
	(90,4,3,859),
	(90,4,4,821),
	(197,4,1,699),
	(197,4,2,835),
	(197,4,3,477),
	(197,4,4,917),
	(91,5,1,693),
	(91,5,2,869),
	(91,5,3,582),
	(91,5,4,986),
	(177,5,1,477),
	(177,5,2,451),
	(177,5,3,505),
	(177,5,4,732),
	(73,6,1,511),
	(73,6,2,709),
	(73,6,3,850),
	(142,6,1,836),
	(142,6,2,678),
	(142,6,3,442),
	(72,7,1,847),
	(72,7,2,623),
	(72,7,3,512),
	(133,7,1,387),
	(133,7,2,875),
	(133,7,3,484),
	(64,8,1,444),
	(64,8,2,937),
	(64,8,3,637),
	(64,8,4,586),
	(208,8,1,418),
	(208,8,2,991),
	(208,8,3,913),
	(208,8,4,735),
	(124,9,1,665),
	(124,9,2,772),
	(124,9,3,450),
	(124,9,4,524),
	(229,9,1,618),
	(229,9,2,530),
	(229,9,3,971),
	(229,9,4,719),
	(103,10,1,415),
	(103,10,2,583),
	(103,10,3,448),
	(232,10,1,449),
	(232,10,2,737),
	(232,10,3,576),
	(128,11,1,993),
	(128,11,2,771),
	(128,11,3,493),
	(128,11,4,667),
	(198,11,1,977),
	(198,11,2,925),
	(198,11,3,860),
	(198,11,4,811),
	(15,12,1,942),
	(15,12,2,484),
	(15,12,3,640),
	(144,12,1,454),
	(144,12,2,553),
	(144,12,3,987),
	(6,13,1,724),
	(6,13,2,512),
	(6,13,3,961),
	(6,13,4,528),
	(218,13,1,901),
	(218,13,2,434),
	(218,13,3,517),
	(218,13,4,850),
	(126,14,1,716),
	(126,14,2,756),
	(126,14,3,557),
	(126,14,4,460),
	(215,14,1,658),
	(215,14,2,783),
	(215,14,3,741),
	(215,14,4,383),
	(67,15,1,539),
	(67,15,2,649),
	(67,15,3,940),
	(67,15,4,593),
	(221,15,1,942),
	(221,15,2,996),
	(221,15,3,924),
	(221,15,4,896),
	(79,16,1,589),
	(79,16,2,435),
	(79,16,3,860),
	(202,16,1,965),
	(202,16,2,759),
	(202,16,3,881),
	(116,17,1,390),
	(116,17,2,842),
	(116,17,3,816),
	(116,17,4,586),
	(163,17,1,926),
	(163,17,2,559),
	(163,17,3,557),
	(163,17,4,795),
	(84,18,1,402),
	(84,18,2,456),
	(84,18,3,435),
	(228,18,1,691),
	(228,18,2,588),
	(228,18,3,694),
	(126,19,1,520),
	(126,19,2,925),
	(126,19,3,452),
	(126,19,4,882),
	(159,19,1,547),
	(159,19,2,502),
	(159,19,3,599),
	(159,19,4,463),
	(67,20,1,859),
	(67,20,2,460),
	(67,20,3,906),
	(67,20,4,659),
	(184,20,1,833),
	(184,20,2,733),
	(184,20,3,407),
	(184,20,4,384),
	(82,21,1,508),
	(82,21,2,506),
	(82,21,3,504),
	(82,21,4,528),
	(154,21,1,380),
	(154,21,2,887),
	(154,21,3,499),
	(154,21,4,756),
	(14,22,1,811),
	(14,22,2,646),
	(14,22,3,464),
	(195,22,1,933),
	(195,22,2,420),
	(195,22,3,398),
	(91,23,1,474),
	(91,23,2,482),
	(91,23,3,746),
	(195,23,1,942),
	(195,23,2,549),
	(195,23,3,776),
	(59,24,1,854),
	(59,24,2,666),
	(59,24,3,966),
	(59,24,4,728),
	(184,24,1,796),
	(184,24,2,946),
	(184,24,3,758),
	(184,24,4,398),
	(8,25,1,712),
	(8,25,2,963),
	(8,25,3,936),
	(8,25,4,958),
	(224,25,1,648),
	(224,25,2,639),
	(224,25,3,574),
	(224,25,4,927),
	(111,26,1,389),
	(111,26,2,579),
	(111,26,3,802),
	(111,26,4,724),
	(137,26,1,760),
	(137,26,2,737),
	(137,26,3,585),
	(137,26,4,963),
	(48,27,1,642),
	(48,27,2,901),
	(48,27,3,778),
	(223,27,1,463),
	(223,27,2,944),
	(223,27,3,668),
	(95,28,1,402),
	(95,28,2,984),
	(95,28,3,682),
	(95,28,4,627),
	(154,28,1,545),
	(154,28,2,787),
	(154,28,3,818),
	(154,28,4,674),
	(113,29,1,729),
	(113,29,2,956),
	(113,29,3,541),
	(113,29,4,656),
	(195,29,1,925),
	(195,29,2,977),
	(195,29,3,769),
	(195,29,4,566),
	(5,30,1,451),
	(5,30,2,897),
	(5,30,3,481),
	(5,30,4,701),
	(138,30,1,559),
	(138,30,2,384),
	(138,30,3,564),
	(138,30,4,695),
	(112,31,1,726),
	(112,31,2,671),
	(112,31,3,405),
	(216,31,1,555),
	(216,31,2,593),
	(216,31,3,861),
	(127,32,1,911),
	(127,32,2,433),
	(127,32,3,402),
	(127,32,4,881),
	(182,32,1,740),
	(182,32,2,502),
	(182,32,3,556),
	(182,32,4,538),
	(126,33,1,636),
	(126,33,2,533),
	(126,33,3,589),
	(126,33,4,912),
	(198,33,1,525),
	(198,33,2,808),
	(198,33,3,510),
	(198,33,4,607),
	(93,34,1,594),
	(93,34,2,676),
	(93,34,3,624),
	(93,34,4,610),
	(212,34,1,631),
	(212,34,2,870),
	(212,34,3,749),
	(212,34,4,763),
	(113,35,1,482),
	(113,35,2,901),
	(113,35,3,398),
	(113,35,4,875),
	(168,35,1,396),
	(168,35,2,674),
	(168,35,3,437),
	(168,35,4,828),
	(6,36,1,386),
	(6,36,2,847),
	(6,36,3,572),
	(6,36,4,461),
	(151,36,1,491),
	(151,36,2,409),
	(151,36,3,785),
	(151,36,4,730),
	(78,37,1,801),
	(78,37,2,838),
	(78,37,3,726),
	(78,37,4,636),
	(145,37,1,870),
	(145,37,2,870),
	(145,37,3,685),
	(145,37,4,788),
	(44,38,1,422),
	(44,38,2,431),
	(44,38,3,687),
	(216,38,1,909),
	(216,38,2,925),
	(216,38,3,792),
	(98,39,1,985),
	(98,39,2,463),
	(98,39,3,866),
	(98,39,4,669),
	(197,39,1,417),
	(197,39,2,787),
	(197,39,3,519),
	(197,39,4,759),
	(73,40,1,557),
	(73,40,2,848),
	(73,40,3,997),
	(73,40,4,480),
	(162,40,1,529),
	(162,40,2,963),
	(162,40,3,941),
	(162,40,4,803),
	(40,41,1,617),
	(40,41,2,523),
	(40,41,3,396),
	(40,41,4,805),
	(155,41,1,774),
	(155,41,2,597),
	(155,41,3,581),
	(155,41,4,484),
	(131,42,1,575),
	(131,42,2,499),
	(131,42,3,717),
	(131,42,4,971),
	(142,42,1,859),
	(142,42,2,416),
	(142,42,3,462),
	(142,42,4,730),
	(117,43,1,606),
	(117,43,2,812),
	(117,43,3,574),
	(141,43,1,587),
	(141,43,2,714),
	(141,43,3,760),
	(124,44,1,411),
	(124,44,2,982),
	(124,44,3,843),
	(124,44,4,845),
	(188,44,1,652),
	(188,44,2,971),
	(188,44,3,896),
	(188,44,4,393),
	(116,45,1,615),
	(116,45,2,985),
	(116,45,3,663),
	(176,45,1,878),
	(176,45,2,762),
	(176,45,3,588),
	(20,46,1,904),
	(20,46,2,721),
	(20,46,3,836),
	(20,46,4,596),
	(160,46,1,917),
	(160,46,2,584),
	(160,46,3,610),
	(160,46,4,467),
	(40,47,1,821),
	(40,47,2,522),
	(40,47,3,522),
	(40,47,4,862),
	(167,47,1,656),
	(167,47,2,872),
	(167,47,3,628),
	(167,47,4,784),
	(109,48,1,448),
	(109,48,2,808),
	(109,48,3,748),
	(109,48,4,832),
	(171,48,1,529),
	(171,48,2,922),
	(171,48,3,556),
	(171,48,4,825),
	(27,49,1,857),
	(27,49,2,945),
	(27,49,3,690),
	(27,49,4,525),
	(172,49,1,676),
	(172,49,2,804),
	(172,49,3,448),
	(172,49,4,740),
	(92,50,1,419),
	(92,50,2,736),
	(92,50,3,473),
	(92,50,4,842),
	(200,50,1,438),
	(200,50,2,601),
	(200,50,3,889),
	(200,50,4,959),
	(66,51,1,764),
	(66,51,2,652),
	(66,51,3,408),
	(208,51,1,716),
	(208,51,2,677),
	(208,51,3,434),
	(66,52,1,740),
	(66,52,2,756),
	(66,52,3,533),
	(66,52,4,664),
	(164,52,1,552),
	(164,52,2,448),
	(164,52,3,409),
	(164,52,4,575),
	(95,53,1,527),
	(95,53,2,710),
	(95,53,3,621),
	(195,53,1,392),
	(195,53,2,739),
	(195,53,3,777),
	(75,54,1,954),
	(75,54,2,935),
	(75,54,3,546),
	(229,54,1,641),
	(229,54,2,561),
	(229,54,3,418),
	(25,55,1,959),
	(25,55,2,507),
	(25,55,3,394),
	(25,55,4,432),
	(216,55,1,466),
	(216,55,2,663),
	(216,55,3,583),
	(216,55,4,808),
	(57,56,1,990),
	(57,56,2,571),
	(57,56,3,694),
	(57,56,4,516),
	(228,56,1,448),
	(228,56,2,433),
	(228,56,3,410),
	(228,56,4,639),
	(98,57,1,899),
	(98,57,2,705),
	(98,57,3,824),
	(98,57,4,956),
	(201,57,1,589),
	(201,57,2,553),
	(201,57,3,402),
	(201,57,4,394);

/*Foreign keys*/

ALTER TABLE Igrac ADD CONSTRAINT FK_Igrac_gradID FOREIGN KEY (gradID) REFERENCES Grad(gradID) ON DELETE CASCADE;
ALTER TABLE Teren ADD CONSTRAINT FK_Teren_gradID FOREIGN KEY (gradID) REFERENCES Grad(gradID) ON DELETE CASCADE;
ALTER TABLE Rupa ADD CONSTRAINT FK_Rupa_terenID FOREIGN KEY (terenID) REFERENCES Teren(terenID) ON DELETE CASCADE;
ALTER TABLE Partija ADD CONSTRAINT FK_Partija_terenID FOREIGN KEY (terenID) REFERENCES Teren(terenID) ON DELETE CASCADE;
ALTER TABLE Igraju ADD CONSTRAINT FK_Igraju_igracID FOREIGN KEY (igracID) REFERENCES Igrac(igracID) ON DELETE CASCADE;
ALTER TABLE Rezultat ADD CONSTRAINT FK_Rezultat_igracID FOREIGN KEY (igracID) REFERENCES Igrac(igracID) ON DELETE CASCADE;
ALTER TABLE Igraju ADD CONSTRAINT FK_Igraju_partijaID FOREIGN KEY (partijaID) REFERENCES Partija(partijaID) ;
ALTER TABLE Rezultat ADD CONSTRAINT FK_Rezultat_partijaID FOREIGN KEY (partijaID) REFERENCES Partija(partijaID) ;
ALTER TABLE Rezultat ADD CONSTRAINT FK_Rezultat_rupaID FOREIGN KEY (rupaID) REFERENCES Rupa(rupaID) ;

/*Dopuna*/

CREATE TABLE Sudija(
	sudijaID int IDENTITY(1,1),
	ime varchar(50),
	prezime varchar(70),
	adresa varchar(100),
	telefon varchar(15),
	email varchar(50)
);

CREATE TABLE Sudi_Na_Terenu(
	sudijaID int not null,
	terenID int not null
);

ALTER TABLE Sudija ADD CONSTRAINT PK_Sudija PRIMARY KEY (sudijaID);
ALTER TABLE Sudi_Na_Terenu ADD CONSTRAINT PK_Sudi_Na_Terenu PRIMARY KEY (sudijaID,terenID);

ALTER TABLE Sudi_Na_Terenu ADD CONSTRAINT FK_Sudi_Na_Terenu_terenID FOREIGN KEY (terenID) REFERENCES Teren(terenID);
ALTER TABLE Sudi_Na_Terenu ADD CONSTRAINT FK_Sudi_Na_Terenu_sudijaID FOREIGN KEY (sudijaID) REFERENCES Sudija(sudijaID);

ALTER TABLE Teren ADD kategorija_terena varchar(100);

/*
	USE master;
	DROP DATABASE A30;
*/