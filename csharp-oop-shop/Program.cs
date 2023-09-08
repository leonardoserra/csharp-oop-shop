// See https://aka.ms/new-console-template for more information
using csharp_oop_shop;

internal class Program
{
    private static void Main(string[] args)
    {
#region ESERCIZIO BASE
        Console.WriteLine("---------------------ESERCIZIO BASE----------------------");
        Console.WriteLine();


        Product ball = new Product("Palla da Basket", "Una palla per giocare a basket", 23);
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
        ball.GetTaxedPrice();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();


        #endregion

#region BONUS
        Console.WriteLine("----------------BONUS---------------------");
        Console.WriteLine();


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
        Console.WriteLine("Benvenuto da Decathlon! Scegli fra la nostra vastissima gamma di prodotti e ti stamperemo le sue caratteristiche!");
        Console.WriteLine();

        for (int i = 0; i < products.Length; i++)
        {
            Console.Write($"{i + 1}: {products[i].Name}");
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.Write("Digita il numero di un prodotto: ");

        int choice = int.Parse(Console.ReadLine());
        if(choice <= 0||choice > products.Length) 
            Console.WriteLine("Articolo non trovato.");
        else
            products[choice-1].PrintProductInfo(products[choice-1]);
            
        
    }
#endregion
}

