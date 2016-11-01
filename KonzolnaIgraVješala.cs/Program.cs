using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IgraVjesala;

namespace IgraVjesala
{
    class Program
    {
        static void Main(string[] args)
        {
            Igra igra = new Igra();
            while (true)
            {
                string unos = Console.ReadLine();
                igra.UnesiSlovo(unos[0]);
                if(igra.IgraGotova)
                {
                    Console.WriteLine("Igra gotova");
                    Console.ReadKey();
                    break;
                }
                if (igra.SvaSlovaOtkrivena)
                {
                    Console.WriteLine("Pobjeda");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
