DROP DATABASE nyiltnap;

CREATE DATABASE nyiltnap DEFAULT CHARSET=utf8 COLLECT=utf8_hungarian_ci;
USE nyiltnap;
CREATE TABLE tantárgy (id int (10) NOT NULL AUTO_INCREMENT PRIMARY KEY, nev VARCHAR(50));
CREATE TABLE oktato (id int (10) NOT NULL AUTO_INCREMENT PRIMARY KEY, nev VARCHAR(50));
CREATE TABLE agazat (id int (10) NOT NULL AUTO_INCREMENT PRIMARY KEY, nev VARCHAR(50));
CREATE TABLE oktato2tantargy (id int (10) NOT NULL AUTO_INCREMENT PRIMARY KEY, oktatoid INT, tantárgyid int);
CREATE TABLE oktato2tantargy (id int (10) NOT NULL AUTO_INCREMENT PRIMARY KEY, osztalyid INT, agazatid int);
CREATE TABLE oktato2tantargy (id int (10) NOT NULL AUTO_INCREMENT PRIMARY KEY, evfolyam INT, betujel VARCHAR(10));
CREATE TABLE oktato2tantargy (id int (10) NOT NULL AUTO_INCREMENT PRIMARY KEY, datum DATE, ora int, osztalyid int, oktato2tantargyid int);


