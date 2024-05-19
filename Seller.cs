using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealESTATESGUI
{
    internal class Seller
    {   //Felvezzük a változókat és a Getter Setter elemeket.
        public int SellerId { get; set; }
        public string SellerName { get; set; }
        public string SellerPhone { get; set; }
        //Csinálunk neki egy konstruktort, paraméterekkel.
        public Seller(int SellerId, string SellerName, string SellerPhone)
        {
            this.SellerId = SellerId;
            this.SellerName = SellerName;
            this.SellerPhone = SellerPhone;
        }

        public override string ToString()
        {
            return $"{SellerName}"; // Csak az eladó nevét adja vissza
        }
    }
}
