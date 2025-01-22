using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItSchool.App.Utilities;

namespace Application6
{
    public class App6 : ApplicationBase
    {
        public App6()
        {
            Cerinta = "Cititi trei numere si " +
            "afisati daca toate sunt pozitive.";
        }
        public override void Launch()
        {
            int a = Utils.GetIntFromKeyboard("a");
            int b = Utils.GetIntFromKeyboard("b");
            int c = Utils.GetIntFromKeyboard("c");


            if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("Toate numerele sunt pozitive");
            }
        }
    }
}
