using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WepApiDemo.Models
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        public static List<Product> Products = new List<Product>
        {
            new Product { ID=1, Name="Checkers", Price=6.99M },
            new Product { ID=2, Name="Chess", Price=5.99M },
            new Product { ID=3, Name="Backgammon", Price=10.99M },
            new Product { ID=4, Name="Dominos", Price=8.99M },
        };
    }
}