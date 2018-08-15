using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Shop
{
    class ReadData
    {
        public void Load(ref List<Goods.Book> books, ref List<Goods.Disk> disks)
        {
            string filepath = System.IO.Directory.GetCurrentDirectory() + @"\Goods.dat";

            if (!File.Exists(filepath))
            {
                Console.WriteLine("Error: Could not find *.dat file");
                return;
            }

            string contents = File.ReadAllText(filepath);
            string[] lines = lines = contents.Split(new[] {Environment.NewLine}, StringSplitOptions.None);

            for (int i = 0; i < lines.Length - 1; i++)
            {
                string[] entry = lines[i].Split('\t');
                if (entry[3] == "programming" || entry[3] == "cooking" || entry[3] == "esoteric")
                {
                    books.Add(new Goods.Book(entry[0], Int32.Parse(entry[1]), entry[2], entry[3], entry[4]));
                }

                if (entry[3] == "cd" || entry[3] == "dvd")
                {
                    disks.Add(new Goods.Disk(entry[0], Int32.Parse(entry[1]), entry[2], entry[3], entry[4]));
                }
            }

        }
    }
}
