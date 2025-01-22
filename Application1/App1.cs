using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItSchool.App.Utilities;

namespace Application1
{
    public class App1 : ApplicationBase
    {

        public App1()
        {
            Cerinta = "Cititi doua numere de la tastatura calculati produsul lor si afisati rezultatul";
        }

        public override void Launch()
        {
            int a = Utils.GetIntFromKeyboard("a");
            int b = Utils.GetIntFromKeyboard("b");

            Console.WriteLine($"Produsul este {a * b}");
        }
    }
}
