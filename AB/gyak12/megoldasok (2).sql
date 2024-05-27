-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

-- 1. feladat:
CREATE DATABASE teljesitok DEFAULT charset utf8 collate=utf8_hungarian_ci;

use teljesitok;
-- 3. feladat:
SELECT nev from teljesites WHERE nevelotag="ifj.";
-- 4. feladat:
SELECT teljesites.nev, telepules.nev, orszag from teljesites join telepules on telepulesid=telepules.id WHERE orszag != ""
 AND YEAR(datum) < 1990;
-- 5. feladat:
SELECT teljesites.nev, min(telepules.datum), orszag from teljesites join telepules on telepulesid=telepules.id GROUP BY telepules.nev;
-- 6. feladat:

