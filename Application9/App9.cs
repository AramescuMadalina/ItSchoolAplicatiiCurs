using ItSchool.App.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItSchool.App.Utilities;

namespace Application9
{
    public class App9 : ApplicationBase
    {
        public App9()
        {
            Cerinta = "Cititi varsta unei persoane si afisati daca este " +
            "minora(sub 18 ani), pensionara (65 ani sau mai mult), " +
            "sau adulta. Avertizati la numere carenu corespund.";
        }
        public override void Launch()
        {
            int varsta = Utils.GetIntFromKeyboard("varsta");

            if (varsta < 18)
            {
                Console.WriteLine("Persoana este minora!!! ");
            }
            if (varsta < 65 && varsta >= 18)
            {
                Console.WriteLine("Persoana este adulta");
            }
            if (varsta >= 65)
            {
                Console.WriteLine("Persoana este pensionara");
            }
        }
    }
}
