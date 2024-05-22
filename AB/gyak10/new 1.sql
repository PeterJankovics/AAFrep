
 
CREATE DATABASE nemzet DEFAULT CHARSET utf8 COLLATE utf8_hungarian_ci;

USE nemzet;

SELECT nev FROM szinesz WHERE valasztas = "2000-08-22" ORDER BY nev;

SELECT nev, szuletesinev FROM szinesz WHERE nev != szuletesinev AND szuletesinev != "";

