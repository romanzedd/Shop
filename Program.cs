using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Goods.Book> books = new List<Goods.Book>();
            List<Goods.Disk> disks = new List<Goods.Disk>();

            ReadData reader = new ReadData();

            reader.Load(ref books, ref disks);

            books.Sort((x, y) => x.Genre.CompareTo(y.Genre));
            disks.Sort((x, y) => x.Media.CompareTo(y.Media));

            foreach (var book in books)
                Console.WriteLine(book.ToString());

            foreach (var disk in disks)
                Console.WriteLine(disk.ToString());

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
