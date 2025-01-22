using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItSchool.App.Utilities;

namespace Application17
{
    public class App17 : ApplicationBase
    {
        public App17()
        {
            Cerinta = "Cititi un numar n si afisati tabla inmultirii de la 1 la 10 " +
            "a tuturor numerelor de la 1 la n. ";
        }
        public override void Launch()
        {
            int produs = 0;
            int n = Utils.GetIntFromKeyboard("n");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    produs = j * i;
                    Console.WriteLine($"Tabla inmultirii a numarului {i} cu {j} este :{produs}");

                }

            }
        }
    }
}
