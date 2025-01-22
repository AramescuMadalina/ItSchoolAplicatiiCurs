using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItSchool.App.Utilities;

namespace Application13
{
    public class App13 : ApplicationBase
    {
        public App13()
        {
            Cerinta = "Cititi un numar si afisati suma cifrelor sale.";
        }
        public override void Launch()
        {
            Console.WriteLine("a este:");

            int suma = 0;
            int cifraSalvata;
            int a = Utils.GetIntFromKeyboard("a");
            while (a > 0)
            {
                cifraSalvata = a % 10;
                a = a / 10;
                suma += cifraSalvata;

            }
            Console.WriteLine($"Suma cifrelor numarului a este: {suma}");


        }
    }
}
