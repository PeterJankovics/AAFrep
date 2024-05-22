CREATE DATABASE eszam DEFAULT CHARSET utf8 COLLATE utf8_hungarian_ci;
USE eszam;


SELECT nev FROM adalek WHERE mellekhatas ORDER BY nev;

select fnev from funkcio inner join adalek on funkcio.kod = adalek.kod where adalek.nev like "%karamell%";
