using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinozicSebastianZapisivanje
{
    class Program
    {
        static void Main(string[] args)
        {
           using(StreamWriter sw = new StreamWriter(@"C:\drivers\Corona.txt"))
                {
                sw.Write("Bazinga");
                Console.WriteLine("File is created");
            }
        }
    }
}
