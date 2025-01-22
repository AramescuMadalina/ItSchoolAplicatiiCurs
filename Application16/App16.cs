using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItSchool.App.Utilities;

namespace Application16
{
    public class App16 : ApplicationBase
    {
        public App16()
        {
            Cerinta = "Cititi un numar si afisati tabla inmultirii " +
            "de la 1 la 10 a acestuia.";
        }
        public override void Launch()
        {

            int a = Utils.GetIntFromKeyboard("a");
            int produs = 0;

            for (int i = 0; i <= 10; i++)
            {
                produs = a * i;
                Console.WriteLine($"Tabla inmultirii lui {a} cu {i} este: {produs}");
            }
        }
    }
}
