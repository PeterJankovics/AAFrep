 CREATE DATABASE diafilmek DEFAULT CHARSET utf8 collate utf8_hungarian_ci;
 
 USE diafilmek;
# 2. feladat

SELECT cim, kiadasiev FROM film WHERE kiadasiev > 2000 ORDER BY cim;

# 3. feladat
SELECT cim, kocka, kiadasiev FROM film WHERE cim LIKE "%farkas%";

# 4. feladat

SELECT DISTINCT nev FROM film join kiado on kiadoid = kiado.id WHERE cim LIKE "%sicc%";

# 5. feladat

SELECT cim, COUNT(*) FROM film GROUP BY cim ORDER BY 2 DESC LIMIT 1 ;

# 6. feladat

SELECT kiadasiev, COUNT(*) FROM film WHERE kiadasiev != 0 GROUP BY kiadasiev ORDER BY 2 DESC;

# 7. feladat

SELECT DISTINCT film.cim FROM film join film AS film2 on film.cim = film2.cim WHERE film.szinese AND NOT film2.szinese;

# 8. feladat




