using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_8._Pokemon_Trainer
{
    public class Trainer
    {
        public Trainer(string name, Pokemon collectionOfPokemon)
        {
            this.Name = name;
            this.CollectionOfPokemon.Add(collectionOfPokemon);
        }

        public string Name { get; set; }

        public int Badges { get; set; } = 0;

        public List<Pokemon> CollectionOfPokemon { get; set; } = new List<Pokemon>();
    }
}
