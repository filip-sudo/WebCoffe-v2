CREATE TABLE kava(
id INT(11) NOT NULL AUTO_INCREMENT,
naziv VARCHAR(45) NOT NULL,
cijena INT (5) NOT NULL,
PRIMARY KEY (id)
);

INSERT INTO kava(id, naziv, cijena) VALUES
(1, 'Supernature', 20),
(2, 'Hair Bender', 16),
(3, 'Holler Mountain', 17),
(4, 'French Roast', 17),
(5, 'Indonesia Bies Penantan', 19),
(6, 'Ground Holler Mountain', 17),
(7, 'Founders Blend', 17),
(8, 'Hundred Mile', 17),
(9, 'House Blend', 16),
(10, 'Guatamala El Injerto Bourbon', 20),
(11, 'Trapper Creek Decaf', 17),
(12, 'Costa Rica Montes De Oro', 21),
(13, 'Colombia El Jordan', 22),
(14, 'Rwanda Huye Mountain', 21),
(15, 'Roasters Pick', 21),
(16, 'Ground Hair Bender', 16),
(17, 'Ecuador Rancho Carmen', 23);

CREATE TABLE poslovnica(
id INT(11) NOT NULL AUTO_INCREMENT,
naziv VARCHAR(45) NOT NULL,
PRIMARY KEY (id)
);

INSERT INTO poslovnica(id, naziv) VALUES
(1, 'prva'),
(2, 'druga'),
(3, 'treca'),
(4, 'cetvrta');

CREATE TABLE narudzba(
id INT(11) NOT NULL AUTO_INCREMENT,
ime VARCHAR(45) NOT NULL,
prezime VARCHAR(45) NOT NULL,
telefon INT(25) NOT NULL,
adresa VARCHAR(45) NOT NULL,
grad VARCHAR(25) NOT NULL,
postanski_broj INT(11) NOT NULL,
id_poslovnica INT(11) NOT NULL,
id_kava INT(11) NOT NULL,
PRIMARY KEY (id)
);

CREATE TABLE ovlasti (
  sifra VARCHAR(5) NOT NULL,
  naziv VARCHAR(255) NOT NULL,
  PRIMARY KEY (sifra)
);

CREATE TABLE korisnici (
  korisnicko_ime VARCHAR(30) NOT NULL,
  email VARCHAR(50) NOT NULL,
  prezime VARCHAR(255) NOT NULL,
  ime VARCHAR(255) NOT NULL,
  lozinka VARCHAR(255) NOT NULL,
  ovlast VARCHAR(5) DEFAULT NULL,
  PRIMARY KEY (korisnicko_ime)
);

ALTER TABLE korisnici 
ADD CONSTRAINT FK_korisnici_ovlast FOREIGN KEY (ovlast)
REFERENCES ovlasti(sifra) ON DELETE NO ACTION;

INSERT INTO ovlasti(sifra, naziv) VALUES
('AD', 'Administrator'),
('MO', 'Moderator');

INSERT INTO korisnici(korisnicko_ime,email,prezime,ime,lozinka,ovlast) 
VALUES('admin','admin@net.hr','Varga','Filip','jUPY60RIRBTWGhhlm0Q/v+UjmVENpGidU1K9ljHGxRs=','AD'),
('cecelja','cecelja@net.hr','Cecelja','David','9OGS0TpjNkgD0+dwSB1lpnsrlAZhsobZwZ5cQEtMOPo=','MO'),
('katic','katic@net.hr','Katic','Anja','jUPY60RIRBTWGhhlm0Q/v+UjmVENpGidU1K9ljHGxRs=','MO'),
('zilavec','zilavec@net.hr','Zilavec','Neven','jUPY60RIRBTWGhhlm0Q/v+UjmVENpGidU1K9ljHGxRs=','MO');