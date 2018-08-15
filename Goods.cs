using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Goods
    {
        private string Name { get; }
        private int Price { get; } //including decimals .00
        private string Barcode { get; }

        public Goods(string name, int price, string barcode)
        {
            Name = name;
            Price = price;
            Barcode = barcode;
        }

        public class Book: Goods
        {
            public string Genre { get; } //programming/cookbook/esotheric
            private string Property { get; }

            public Book(string name, int price, string barcode, string genre, string property) : base(name, price, barcode)
            {
                this.Genre = genre;
                this.Property = property;
            }
            public override string ToString()
            {
                return Name  + "\t" + ((double)Price / 100) + "\t" + Barcode + "\t" + Genre + "\t" + Property;
            }
        }

        public class Disk : Goods
        {
            public string Media { get; } //cd/dvd
            private string Property { get; }

            public Disk(string name, int price, string barcode, string media, string property) : base(name, price, barcode)
            {
                this.Media = media;
                this.Property = property;
            }
            public override string ToString()
            {
                return Name + "\t" + ((double)Price / 100) + "\t" + Barcode + "\t" + Media + "\t" + Property;
            }
        }
    }
}
