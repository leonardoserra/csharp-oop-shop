using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Product
    {
        private string _productCode;
        public string ProductCode  {
            get {
                return this._productCode;   
            }
            set {
                Random random = new Random();
                this._productCode = random.Next(0, 99999999).ToString();
            }
        }

        public string ProductName { get; set; }
        public string Description { get; set; }
        private

    }
}
