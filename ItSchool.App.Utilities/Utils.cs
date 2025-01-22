using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItSchool.App.Utilities;

namespace ItSchool.App.Utilities
{
    public static class Utils
    {
        public static int GetIntFromKeyboard(string denumire = "")
        {
            int a;

            bool aValid;

            string nume = "";
            if (!string.IsNullOrEmpty(denumire))
            {
                nume = " pentru " + denumire;
            }
            do
            {
                Console.WriteLine($"Introduceti un numar intreg{nume} : ");
                aValid = int.TryParse(Console.ReadLine(), out a);

                if (!aValid)
                {
                    Console.WriteLine("Datele introduse nu sunt la valide");
                }


            } while (!aValid);

            return a;
        }

        public static int[] GenereazaArrayDeNumereIntregi(int dimensiuneArray, int limitaInferioara, int limitaSuperioara)
        {
            Random generatorDeNumereAleatoare = new Random();

            int[] arrayDeNumere = new int[dimensiuneArray];

            for (int i = 0; i < arrayDeNumere.Length; i++)
            {
                //atribuim un numar aleator pentru pozitia curenta din aray
                arrayDeNumere[i] = generatorDeNumereAleatoare.Next(limitaInferioara, limitaSuperioara + 1);
                Console.WriteLine(arrayDeNumere[i]);

            }
            return arrayDeNumere;
        }

    }
}
