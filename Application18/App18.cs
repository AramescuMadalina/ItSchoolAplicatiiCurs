using ItSchool.App.Utilities;
namespace Application18
{
    public class App18 : ApplicationBase
    {
        public App18()
        {
            Cerinta = "Avem un sir de 100 de numere aleatoare intre 0 si 9 (folositi A11). Verificati numarul de aparitii pentru fiecare din aceste numere si afisati rezultatele " +
                "(Exemplu de afisaj in consola: " +
                "“0 – 10 aparitii | 1 – 12 aparitii | 3 – 8 aparitii…”)";
        }
        public override void Launch()
        {
            int[] arrayDeNumere = Utils.GenereazaArrayDeNumereIntregi(100, 0, 9);


            int[] numarator = new int[10];

            for (int i = 0; i < arrayDeNumere.Length; i++)
            {
                //valoarea gasita la pozitia curenta poate incrementa 
                numarator[arrayDeNumere[i]]++;
                Console.WriteLine(arrayDeNumere[i] + ", ");
            }

            Console.WriteLine();

            //afisare

            for (int i = 0; i < numarator.Length; i++)
            {
                Console.WriteLine(i + " - " + numarator[i]);
            }
        }
    }
}
