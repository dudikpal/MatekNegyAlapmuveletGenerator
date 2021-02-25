# MatekNegyAlapmuveletGenerator
Matematikai példákat generál a 4 alapművelethez

# Használati útmutató

Operátorok panelen ki kell választani, hogy milyen műveleteket szeretnénk használni. 

Több operátor kiválasztása esetén véletlengenerátor határozza meg az operátorokat. 

Kettőnél több operandus, és több operátor kiválasztása esetén feladatonként az összes operátor közül válogat, így feladatonként többféle operátor is lehet.

Osztásnál tört számok nem lesznek, viszont ha a kivonás is ki van mellé választva, akkor negatív végeredmény előfordulhat, ezeket nyugodtan ki lehet húzni, hogy ne zavarja össze a gyerkőcöt.
Sok plusz energiát nem akartam ráfordítani, mert idővel tanulják majd a negatív számokat is, akkor meg gyomlálhatom ki a bonyolított kódrészletet. 

Csak osztás kiválasztása esetén 2 operandus a megengedett, hiszen 3-nál már egészen nagy számokkal kellene dolgozni (generálásnál valójában felszoroz, hogy ne legyen tört eredmény).

Az operandus értéktartományát is lekorlátoztam, egyrészt, hogy beleférjen a 3 hasábba, másrészt meg ha van benne szorzás, így elég nagy értékek is ki tudnak jönni.

A későbbiekben ez is bővíthető, ahogy haladnak majd az anyaggal.

A feladatok száma egyértelmű, azt adjuk itt meg, hogy a Generálás gomb mennyi feladatot állítson elő (max 100db).

A "Mi legyen ismeretlen?" panelon a lehetőségek:
  - Eredmény érték: csak a feladat végeredménye lesz ismeretlen.
  - Bármely érték: az összes operandus, és a végeredmény közül egy véletlenszám generátor mondja meg, melyik elem lesz az ismeretlen.
  - Bármely operátor: két operandusnál ez adott, hiszen csak egy operátor van, többnél kiválaszt egyet, ami ismeretlen lesz.
  
Ha ezek beállításával készen vagyunk, a "Generálás" gombra kell kattintani, ami alatta kiírja, hogy mennyi feladat vár a kiírásra.

Ha másféle feladatokat is készíteni akarunk, akkor a paraméterek beállítása után szintén a "Generálás" gombra kell klikkelni, ami hozzáadja a memóriában tárolt listához őket.
Ezt annyiszor ismételjük, ahány féle feladatot szeretnénk.

Ha készen vagyunk, akkor a "PDF-be írás" gombon katt. Ha sikerült kiírnia, akkor a nyomtatásra váró feladatok infósorban 0 db fog megjelenni, 
és kezdhető előlről a folyamat, vagy be lehet zárni a jobb felső sarokban az "X"-szel.

Abban a könyvtárban, ahol a program található, lesz egy pdf fájl, azt kell kinyomtatni. Ebben az első részben vannak a megoldandó feladatok, 
majd következik a megoldókulcs, az természetesen nekünk lesz.

Kérdéssel, kéréssel, észrevétellel, hibajelzéssel kapcsolatban kérem jelezzetek a dudikpal@gmail.com címen.
