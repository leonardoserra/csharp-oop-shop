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
            Console.Write("Prezzo con iva: ");
            Console.WriteLine(this.Price + (this.Price * (this.VAT/100))); 
        }
        public void PrintSerialName()
        {
            Console.WriteLine("Prodotto: " + this.IdCode + " " + this.Name);
        }
        #endregion
    }
}
