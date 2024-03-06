\C latin2

CREATE DATABASE nb1 DEFAULT CHARSET utf8 collate utf8_hungarian_ci;

use nb1

SELECT vezeteknev, utonev, FROM labdarugo WHERE magyar AND kulfoldi;

SELECT vezeteknev, utonev, szulido FROM labdarugo, poszt WHERE labdarugo. = posztid = poszt.id AND poszt.nev != "kapus";
ORDER BY szulido LIMIT 1;

SELECT klub.csapatnev, SUM(ertek) AS osszertek FROM labdarugo, klub WHERE labdarugo.klubid=klub.id GROUP BY 1;