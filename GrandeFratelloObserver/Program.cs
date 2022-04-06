//Creo una partita di calcio
using GrandeFratelloObserver;

Vip RobertDeNiro = new Vip("Robert De Niro");

//Creo due osservatori, due cronisti di due emittenti diverse
Follower nonnina = new Follower("Nonna Ida Da Castelvolturno");
Follower ragazzina = new Follower("Bimbina sciocchina 06");

//Si collegano alla partita appena iniziata
RobertDeNiro.addOsservatore(nonnina);
RobertDeNiro.addOsservatore(ragazzina);

Thread.Sleep(3000);
RobertDeNiro.Notifica("E' finita la cicca e vado a fare la ciccia");

Thread.Sleep(3000);
RobertDeNiro.Notifica("Mangiata la ciccia vado a fare la cacca");

Thread.Sleep(3000);
RobertDeNiro.Notifica("Fatta la cacca cerco la ciccia");

//RaiUno si scollega
RobertDeNiro.removeOsservatore(nonnina);

Thread.Sleep(3000);
RobertDeNiro.Notifica("Trovo la ciccia se vado a caccia");

Thread.Sleep(3000);
RobertDeNiro.Notifica("Trovata la ciccia mi appiccio la miccia");