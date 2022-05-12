using System;
using System.Collections;
using System.Collections.Generic;

namespace Population
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<uint, City> cities = new SortedList<uint, City>();

            Country fransa = new Country("Fransa", 2181371);
            City marsel = new City(fransa, "Marsel", 839043);
            City strasburq = new City(fransa, "Strasburq", 2729775);
            City lyon = new City(fransa, "Lyon", 472305);

            Country canada = new Country("Canada", 67100000);
            City ottava = new City(canada, "Ottova", 9002488);
            Country turkey = new Country("Turkey", 67100000);
            City ankara = new City(turkey, "Ankara", 547627);

            City[] arr = {marsel, strasburq, lyon, ottava, ankara};
            int max = 3000000;
            int min = 50000;
            foreach (var item in  arr)
            {
                if (item.Population < max && item.Population > min)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
