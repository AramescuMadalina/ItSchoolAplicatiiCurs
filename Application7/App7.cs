using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItSchool.App.Utilities;

namespace Application7
{
    public class App7 : ApplicationBase

    {
        public App7()
        {
            Cerinta = "Cititi un numar si afisati " +
            "“Pozitiv” daca numarul este mai mare decat" +
            " 0, “Negativ” daca este mai mic decat 0 si " +
            "“Zero” daca este egal cu 0.";
        }
        public override void Launch()
        {
            int a = Utils.GetIntFromKeyboard("a");

            if (a > 0)
            {
                Console.WriteLine("Pozitiv");
            }
            if (a < 0)
            {
                Console.WriteLine("Negativ");
            }
            if (a == 0)
            {
                Console.WriteLine("Zero");
            }
        }
    }
}
