using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItSchool.App.Utilities;

namespace Application4
{
    public class App4 : ApplicationBase
    {
        public App4()
        {
            Cerinta = "Cititi doua numere si afisati daca primul " +
            "este mai mare decat al doilea ";

        }
        public override void Launch()
        {
            int a = Utils.GetIntFromKeyboard("a");
            int b = Utils.GetIntFromKeyboard("b");

            if (a > b)
            {
                Console.WriteLine($"Numarul a ={a} este mai mare decat numarul b={b}");
            }
            else
            {
                Console.WriteLine($"Numarul b ={b} este mai mare decat numarul a={a}");

            }

        }
    }
}
