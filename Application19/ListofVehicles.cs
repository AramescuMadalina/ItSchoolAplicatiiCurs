using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application19
{
    internal class ListofVehicles
    {
        public List<Vehicle> Vehicles;

        public ListofVehicles()
        {
            Vehicles = new List<Vehicle>();
        }


        public void ShowListofVehicles()
        {
            Console.WriteLine("In catalogul nostru avem urmatoarele:");

            for (int i = 0; i < Vehicles.Count; i++)
            {
                Console.WriteLine((i + 1) + " : " + Vehicles[i].GetData());

            }
        }

        public static void ShowAllVehiclesFromCollection(List<Vehicle> collection)
        {
            Console.WriteLine("In catalogul nostru avem urmatoarele:");


        }

        public void SortbyYear(bool orderByDescending)
        {
            if (orderByDescending == false)
            {
                Vehicles = Vehicles.OrderBy(x => x.Year).ToList();
            }
            else
            {
                Vehicles = Vehicles.OrderByDescending(x => x.Year).ToList();
            }
        }

        public void SortbyKm(bool orderByDescending)
        {
            if (orderByDescending == false)
            {
                Vehicles = Vehicles.OrderBy(x => x.Km).ToList();
            }
            else
            {
                Vehicles = Vehicles.OrderByDescending(x => x.Km).ToList();
            }
        }

        public void SortbyPrice(bool orderByDescending)
        {

            if (orderByDescending == false)
            {
                Vehicles = Vehicles.OrderBy(x => x.Price).ToList();
            }
            else
            {
                Vehicles = Vehicles.OrderByDescending(x => x.Price).ToList();
            }
        }

        public void SortbyBrand(bool orderByDescending)
        {

            if (orderByDescending == false)
            {
                Vehicles = Vehicles.OrderBy(x => x.Brand.ToLower()).ToList();
            }
            else
            {
                Vehicles = Vehicles.OrderByDescending(x => x.Brand).ToList();
            }
        }

        public List<Vehicle> FilterByBrand(string brand)
        {

            return Vehicles.FindAll(x => x.Brand == brand);
        }

    }
}
