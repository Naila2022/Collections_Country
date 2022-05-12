using System;
using System.Collections.Generic;
using System.Text;

namespace Population
{
    class Country
    {
        public string Name;
        public uint TotalPopulation;

        public Country(string name, uint totalPop)
        {
            Name = name;
            TotalPopulation = totalPop;
        }
    }
}