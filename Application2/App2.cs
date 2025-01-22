using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItSchool.App.Utilities;

namespace Application2
{
    public class App2 : ApplicationBase
    {
        public App2()
        {
            Cerinta = "Declarati doua variabile, atribuiti valori numerice si afisati suma lor ";
        }
        public override void Launch()
        {
            int a = Utils.GetIntFromKeyboard("a");
            int b = Utils.GetIntFromKeyboard("b");

            Console.WriteLine($"Suma numerelor a si b este {a + b}");
        }
    }
}
