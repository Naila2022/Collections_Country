using System;
using System.Collections.Generic;
using System.Text;

namespace Population
{
    class City
    {
        public string Name;
        public uint Population;
        public Country Country;

        public City(Country country, string name, uint pop)
        {
            Country = country;
            Name = name;
            Population = pop;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}