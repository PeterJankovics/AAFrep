A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!
\C latin2


1. feladat:
 CREATE DATABASE forma1 DEFAULT CHARSET utf8 collate utf8_hungarian_ci;
 
USE forma1;


3. feladat:
CREATE INDEX pnev
	ON pilotak (pnev);

4. feladat:


5. feladat:
SELECT * FROM versenyek WHERE vnev LIKE "N%";
DELETE FROM versenyek WHERE vnev LIKE "N%";


6. feladat:
UPDATE versenyek SET hely = "Sao Paolo" WHERE vnev LIKE "Bra%";

7. feladat:
SELECT pnev, COUNT(pazon) AS gyozelmek FROM pilotak join eredmenyek ON pazon = pilota WHERE celpoz = 1 GROUP BY pazon ORDER by 2 LIMIT 1;

8. feladat:


9. feladat:

