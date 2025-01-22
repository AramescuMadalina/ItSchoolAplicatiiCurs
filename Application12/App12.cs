using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItSchool.App.Utilities;

namespace Application12
{
    public class App12 : ApplicationBase
    {
        public App12()
        {
            Cerinta = "Cititi un numar si verificati daca este " +
            "prim (divizibil doar cu 1 si el insusi).";
        }
        public override void Launch()
        {
            Console.WriteLine("Numarul a este:");


            int Numargasit = 0;
            int a = Utils.GetIntFromKeyboard("a");


            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    Numargasit++;
                }

            }
            if (Numargasit > 2)
            {
                Console.WriteLine("Numarul introdus nu este prim");
            }
            else
            {
                Console.WriteLine("Numarul introdus este prim");
            }
        }
  
    }
}

