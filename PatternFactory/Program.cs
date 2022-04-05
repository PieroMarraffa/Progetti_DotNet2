// See https://aka.ms/new-console-template for more information

using PatternFactory;

//Automobile auto = new Automobile(999, "BMX X3");

FabbricaVeicoli fv = new FabbricaVeicoli();

Automobile bmw = (Automobile) fv.GetVeicolo(TipoVeicolo.Auto, "Bmw x3");
Automobile fiat = (Automobile)fv.GetVeicolo(TipoVeicolo.Auto, "Fiat Panda 4x4");

Moto ducati = (Moto)fv.GetVeicolo(TipoVeicolo.Moto, "Ducati x1");

//Posso evitare il cast:
IVeicolo renault = fv.GetVeicolo(TipoVeicolo.Auto, "Renault Clio Sporter");

List<IVeicolo> list = new List<IVeicolo>() { bmw, fiat, ducati, renault};

foreach(var item in list)
{
    Console.WriteLine(item);
}
