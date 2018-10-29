# Arbetsprov - Kravspecifikation (Personlista)

PERSONLISTA
Till uppgiften så finns en xmlfil som heter personer.xml. Den innehåller en lista med person och dess personuppgifter. Uppgiften är att man ska skapa en webbapplikation som listar alla personerna. Listan ska innehålla tre kolumner:
 Namn (för och efternamn)
 Personnummer
 Persontyp
Listan ska delas upp i flera sidor och man ska kunna navigera mellan sidorna. Varje sida ska visa 10 personer men man ska kunna välja att visa 10, 50 eller 100 personer per sida.
Man ska även kunna filtrera listan på namn, befattning eller personnummer. Filtreringen ska ske genom ett textfält.

SKAPA PERSON
Man ska kunna lägga till fler personer i listan. Det ska finnas inmatning för
 Förnamn
 Efternamn
 Personnummer
 Persontyp
När man lägger till en person så ska personen visas i listan och det ska sedan finnas en knapp för att spara ner personen i xml filen. Man ska kunna skapa flera personer i listan innan man spara ner dem i xml filen. Det ska med andra ord finnas en knapp för att spara personen och en annan för att spara ner de nya personerna i XML filen.

Krav
Applikationen ska byggas i Visual studio med valfri teknik. Man får lov att använda vilka framework man vill men själva listan, sökningen och skapa person får inte vara en färdig komponent utan ska vara byggd på egen teknik men får nyttja andra framework som mvc, angular, jQuery eller likande men inget färdigt plugin för att skapa listan. Bedömningen kommer att göras på kod/teknik och inte design. Det är därför fritt att inte lägga på någon design alls eller använda något som man inte skapat själv.
