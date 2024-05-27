A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

CREATE DATABASE varosok DEFAULT CHARSET utf8 COLLATE utf8_hungarian_ci;
USE varosok
1. feladat:

3. feladat:
SELECT vnev FROM varos where vnev like "%v?s?r%";

4. feladat:
SELECT vnev, terulet, nepesseg FROM varos where terulet > 400 ORDER by 3 DESC;

5. feladat:
SELECT nepesseg, vnev FROM varos inner join	megye on megyeid = megye.id where mnev = "Fej?r" AND nepesseg > 15000;

6. feladat:

SELECT vtip AS "Város Tipus", COUNT(varos.id) AS "varosok szama", sum(nepesseg) AS "Nepesseg" FROM varostipus inner join varos on varostipus
7. feladat:

