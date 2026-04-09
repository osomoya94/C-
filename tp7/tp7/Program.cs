using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal perro = new Perro("jon", "can",14,"caniche");
            Animal gato = new Gato("tom", "pedigri", 12 ,"siames");

            perro.seAlimenta();
            gato.seAlimenta();
        }
    }
}
