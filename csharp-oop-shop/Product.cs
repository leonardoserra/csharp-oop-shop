﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Product
    {
#region ATTRIBUTI

        public int IdCode { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int VAT { get; set; } = 22;

        #endregion

        #region COSTRUTTORE
        public Product(string name, string description, int price)
        {
            Random random = new Random();
            this.IdCode = random.Next(0, 99999999);
            this.Name = name; 
            this.Description = description; 
            this.Price = price;
        }
        #endregion

        #region METODI
        //getter
        public void GetTaxedPrice()
        {

            int tax = (this.Price * this.VAT) / 100;
            Console.Write("Prezzo con iva: ");
            Console.WriteLine(this.Price + tax);

        }
        public void PrintSerialName()
        {
            Console.WriteLine("Prodotto: " + this.FormatIdCode() + " " + this.Name);
        }

        public string FormatIdCode()
        {
            return this.IdCode.ToString("D8");
        }

        public void PrintProductInfo(Product product) 
        {
            Console.Write("Codice Prodotto: ");
            Console.WriteLine(product.FormatIdCode());
            Console.Write("Nome Prodotto: ");
            Console.WriteLine(product.Name);
            Console.Write("Descrizione Prodotto: ");
            Console.WriteLine(product.Description);
            Console.Write("Prezzo senza iva Prodotto: ");
            Console.WriteLine(product.Price);
            Console.Write("Tassazione Prodotto: ");
            Console.WriteLine(product.VAT);
            product.PrintSerialName();
            product.GetTaxedPrice();
        }
        #endregion
    }
}
