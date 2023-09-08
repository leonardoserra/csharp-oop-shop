// See https://aka.ms/new-console-template for more information
using csharp_oop_shop;

Product[] products =
{
    new Product(
        "Longboard",
        "Progettato per fare dei giri e pump track. La sua costruzione riproduce le sensazioni del surf sull'asfalto. Ideale per persone alte più di 1,70 m.",
        109
        ),
    new Product(
        "Tenda da tetto AUTO",
        "Voglia di libertà? I nostri ideatori hanno sviluppato questa tenda da tetto per 2 persone facile e veloce da montare, per spostarti come desideri.",
        1300
        ),
    new Product(
        "Mazza baseball",
        "Prodotto ideato per i giocatori di livello principiante. Il barile di questa mazza in legno ha il peso ripartito in modo equilibrato, per facilitare i colpi.",
        49
        ),
    new Product(
        "Guantoni adulto boxe",
        "Ideati per il pugile che cerca dei guantoni confortevoli per gli allenamenti a bassa intensità, per lo sparring o sul sacco.",
        16
        ),
    new Product(
        "Calciobalilla GOLEADOR",
        "Calciobalilla da interno, gambe richiudibili in mdf, piano gioco in vetro, aste uscenti, 10 palline incluse.",
        445
        )
};


Console.WriteLine("Benvenuto alla decathlon! Scegli fra la nostra vastissima gamma di prodotti e ti stamperemo le sue caratteristiche!");

while(!(int.TryParse(Console.ReadLine(), out int choice){
    if(choice < 0 || choice > products.Length-1) {
        continue;
    }
    else
    {
        products[choice].PrintProductInfo();
    }
}

/*Product ball = new Product("Palla da Basket", "Una palla per giocare a basket", 23);
Console.Write("Codice Prodotto: ");
Console.WriteLine(ball.FormatIdCode());
Console.Write("Nome Prodotto: ");
Console.WriteLine(ball.Name);
Console.Write("Descrizione Prodotto: ");
Console.WriteLine(ball.Description);
Console.Write("Prezzo senza iva Prodotto: ");
Console.WriteLine(ball.Price);
Console.Write("Tassazione Prodotto: ");
Console.WriteLine(ball.VAT);
ball.PrintSerialName();
ball.GetTaxedPrice();*/