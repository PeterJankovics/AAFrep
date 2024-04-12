CREATE DATABASE operett DEFAULT CHARSET utf8 COLLATE utf8_hungarian_ci;

USE operett;

SELECT cim FROM mu where ev=1916 ORDER BY cim;

SELECT nev, tipus 
	FROM mu 
		join kapcsolat ON mu.id = muid 
		join alkoto on alkotoid = alkoto.id 
		where cim = "BOB herceg"; 
		
SELECT ev FROM mu ORDER BY ev DESC LIMIT 1;

SELECT nev, COUNT(muid) FROM alkoto join kapcsolat on alkotoid = alkoto.id GROUP BY alkotoid ORDER BY 2 DESC LIMIT 3;