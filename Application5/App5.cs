using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItSchool.App.Utilities;

namespace Application5
{
    public class App5 : ApplicationBase
    {
        public App5()
        {
            Cerinta = "Cititi un numar si verificati " +
            "daca este par sau impar.";
        }
        public override void Launch()
        {
            int a = Utils.GetIntFromKeyboard();

            if (a % 2 == 0)
            {
                Console.WriteLine($"Numarul a ={a} este par");
            }
            else
            {
                Console.WriteLine($"Numarul a ={a} este impar");
            }
        }
    }
}
