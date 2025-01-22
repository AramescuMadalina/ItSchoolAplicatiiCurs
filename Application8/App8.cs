using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItSchool.App.Utilities;

namespace Application8
{
        public class App8 : ApplicationBase
        {
            public App8()
            {
                Cerinta = "Cititi doua numere si afisati-l " +
                "pe cel mai mare dintre ele.";
            }

            public override void Launch()
            {
                int a = Utils.GetIntFromKeyboard("a");
                int b = Utils.GetIntFromKeyboard("b");


                if (a > b)
                {
                    Console.WriteLine($"Numarul a ={a} este mai mare decat numarul b= {b}");
                }
                else if (a < b)
                {
                    Console.WriteLine($"Numarul b ={b} este mai mare decat numarul a= {a}");
                }
                else if (a == b)
                {
                    Console.WriteLine("Cele doua numere sunt egale");
                }
            }
        }
}
