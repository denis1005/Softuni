using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_8._Pokemon_Trainer
{
    public class Pokemon
    {
        public Pokemon(string name, string element, double health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }

        public string Name { get; set; }

        public string Element { get; set; }

        public double Health { get; set; }
    }
}
