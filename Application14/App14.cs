using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItSchool.App.Utilities;

namespace Application14
{
    public class App14 : ApplicationBase
    {
        public App14()
        {
            Cerinta = "Cititi 5 numere si afisati cel mai mare " +
            "dintre ele.";
        }
        public override void Launch()
        {

            int a = Utils.GetIntFromKeyboard("a");
            int b = Utils.GetIntFromKeyboard("b");
            int c = Utils.GetIntFromKeyboard("c");
            int d = Utils.GetIntFromKeyboard("d");
            int e = Utils.GetIntFromKeyboard("e");


            if (a > b && a > c && a > d && a > e)
            {
                Console.WriteLine($"Cel mai mare numar este {a}");

            }
            else if (b > a && b > c && b > d && b > e)
            {
                Console.WriteLine($"Cel mai mare numar este {b}");
            }
            else if (c > a && c > b && c > d && c > e)
            {
                Console.WriteLine($"Cel mai mare numar este {c}");
            }
            else if (d > a && d > b && d > c && d > e)
            {
                Console.WriteLine($"Cel mai mare numar este {d}");
            }
            else
            {
                Console.WriteLine($"Cel mai mare numar este {e}");
            }


        }
    }
}
