// See https://aka.ms/new-console-template for more information
using csharp_oop_shop;

Product ball = new Product("Palla da Basket", "Una palla per giocare a basket", 23);
Console.Write("Codice Prodotto: ");
Console.WriteLine(ball.IdCode);
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