<!doctype html>
<html>
  <head>
    <title>Tower Defense</title>
  </head><center>
  <body>
    <h1>GAME DESIGN DOCUMENT.</h1>
   <h2><p><strong>Tower Defense / Turna Vörnin</strong></p></h2>
    <h3>3D Strategy eða Herstjórnar leikur.</h3>
    
    <h3>1.1  Liðin.</h3>
    <p>
    Það eru 2 lið eins og er, við stöndum með turnunum, við eigum að búa til turna til að hindra það að óvinurinn komist ekki til leiðarenda.
    <br>
    Óvinirnir eru farartæki sem er klætt grænum her búnaði, það mun vera trukkar, smábílar og jafnvel flugvélar.
    </p>
    <h2>Óvinirnir.</h2>
    <h3>Það eru 3 óvinir.</h3>
    <h4>Truck</h4>
    <img src="Myndir/Enemy 1.PNG" alt="Truck" width="800" height="532">
    <p>Þetta mun vera fyrsti óvinurinn og mun sjást í öllum borðum.
    <br>
    Þessi bíll er algengasti óvinurinn og er voða lítið sérstakt við hann.
    <br>
    Hann hefur 30 líf, 10 í hraða, og virði 75 dollara.</p>
    <br>

    <h4>Jeep</h4>
    <img src="Myndir/Enemy 2.PNG" alt="Jeep" width="800" height="532">
    <p>Þetta mun vera annar óvinurinn og mun sjást í borði 2 og 3.
    <br>
    Þessi bíll er smár, en mjög hraður.
    <br>
    Hann hefur 15 líf, 25 í hraða, og virði 40 dollara.</p>
    
    <h4>Airplane</h4>
    <img src="Myndir/Enemy 3.PNG" alt="Airplane" width="800" height="532">
    <p>Þetta mun vera þriðji óvinurinn og mun sjást í borði 3.
    <br>
    Þessi flugvél er kröftug, fer hægt og með mikið líf, og þarf ekki að fylgja sömu reglum og bílarnir.
    <br>
    Flugvélin getur farið yfir varnirnar og veggina þar sem hún getur flogið yfir allt til leiðarenda.
    <br>
    Flugvélin hefur 140 líf, 4.5 í hraða, og virði 100 dollara.</p>
    <h2>Turnarnir</h2>
    <h3>Það eru 2 turnar.</h3>
    <h4>Normal Tower</h4>
    <img src="Myndir/Tower 1.PNG" alt="Tower" width="800" height="532">
    <p>Þetta mun vera fyrsti turninn.
    <br>
    Þessi turn skýtur hægt, hefur langt drif og gerir mikinn skaða.
    <br>
    Turninn hefur skothraðann 1, drif 30 og gerir 5 skaða.
    <br>
    <br>
    <h4>Sentry Tower</h4>
    <img src="Myndir/Tower 2.PNG" alt="Sentry" width="800" height="532">
    <p>Þetta mun vera annar turninn.
    <br>
    Þessi turn skýtur hratt, hefur stutt drif og gerir lítinn skaða.
    <br>
    Turninn hefur skothraðann 10, drif 15 og gerir 0.25 skaða.
    <br>
    <br>
    <br>
    <h2>Borð Yfirlit</h2>
        <h3>Það eru 3 borð.</h3>
    <h4>Level 1</h4>
    <img src="Myndir/Level 1.PNG" alt="Borð 1" width="800" height="532">
    <p>Þetta mun vera borð nr 1, eða fyrsta level.
    <br>
    Fyrsta borðið hefur bara venjulega trukkana og fara þeir sikksakk meðfram veggjunum.
    <br>
    <br>
    <h4>Level 2</h4>
    <img src="Myndir/Level 2.PNG" alt="Borð 2" width="800" height="532">
    <p>Þetta mun vera borð nr 2, eða annað level.
    <br>
    Annað borðið hefur 2 óvini sem eru venjulegu trukkarnir og litlu bílarnir.
    <br>
    Markmiðið þeirra er að fara í snúð í kringum borðið og inn í miðjuna.
    <br>
    Þegar þeir komast í miðjuna missir leikmaðurinn líf.
    <br>
    <br>
    <h4>Level 3</h4>
    <img src="Myndir/Level 3.PNG" alt="Borð 3" width="800" height="532">
    <p>Þetta mun vera borð nr 3, eða þriðja level.
    <br>
    þriðja borðið hefur 3 óvini sem eru venjulegu trukkarnir, litlu bílarnir og flugvélar.
    <br>
    Í þessu leveli verðuru að gera þér grein fyrir að flugvélarnar fara yfir veggina og turnana.
    <br>
    Þannig þú verður að reikna með staðsetningunni fyrir turnana vel svo þeir drífa í allt.
    <br>
    <br>
    <br>
    <h2>Nokkrar Skriptur</h2>
    <p>
    <h4>WaveSpawner</h4>
    <img src="Myndir/WaveSpawnerscript.PNG" alt="Wavespawner" width="800" height="532">
    <p>WaveSpawner skriptan les út hvenær má og má ekki senda óvini út á borðið.
    <br>
    Þegar borðið byrjar mun skriptan gefa nokkrar sekúndur áður en hún leggur fram óvinina.<br>
    Hún mun telja fram óvinina og ef það eru óvinir á borðinu stoppar skriptan<br>
    Þegar óvinur kemur á borðið mun bætast í 'EnemiesAlive'<br> 
    þegar 'EnemiesAlive' fer í 0 þá mun skriptan gefa nokkrar sekúndur áður en næsta alda byrjar<br>
    <br>
    <p>
    <h4>EnemyHealth</h4>
    <img src="Myndir/Enemyhealthscript.PNG" alt="Enemyhealth" width="800" height="532">
    <p>EnemyHealth skriptan er bæði til að telja niður lífið á óvinum,<br>
    og fyrir Wavespawner skriptuna til að lesa út hvenær það eru óvinir eftir á borðinu.
    <br>
    <br>
    <p>
    <h4>Waypoints</h4>
    <img src="Myndir/Waypointsscript.PNG" alt="Waypoints" width="800" height="532">
    <p>Waypoints skriptan er nýtt til að láta óvini elta ákveðna punkta í gegnum borðið<br>
    Þessi skripta er aðeins hægt að nýta ef þú setur nokkra waypoints inn í 'Empty Object'<br>
    <br>
    <br>
    <p>
    <h4>Enemymovement</h4>
    <img src="Myndir/Enemymovementscript.PNG" alt="Enemymovement" width="800" height="532">
    <p>Enemymovement skriptan er sett á óvinina til að láta þá elta waypoints<br>
    Þegar óvinirnir eru búnir að fara í gegnum alla punktana eða 'Childs'<br>
    Þá eyðist óvinurinn upp og leikmaðurinn missir líf.
    <br>
    <br>
    <h2>Aukapunktar.</h2>
    <p>Ég hef alltaf verið hrifinn af smáleikjunum sem er hægt að demba nokkrum mínútum í turna vörn,<br> 
        það er hægt að finna endalaust af slíkum leikjum sem eru svipaðir,<br> 
        sumir hafa svona sitt eigið snúning á leiknum.<br>
        <br>
        Stundum getur það verið rosalega flott, vel gert og vel úthugsað, og stundum er það algjört klúður og vesen.<br>
         Ég vildi læra mig áfram og gera svona frekar einfaldann Turna Vörn leik,<br>
         klassískir turnar, klassískir óvinir. <br>
        <br>
         Því lengra sem ég fer inn, finn ég alltaf fleiri leiðir sem hægt er að fikta mig áfram í einu og öðru,<br>
          bæta við öðruvísi turnum eða jafnvel öðruvísi óvinum.</p>
          <br>
          <br>
          <br>
          <br>
    </p></center>
</body>
</html>
  
