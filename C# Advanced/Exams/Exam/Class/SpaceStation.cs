using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        public List<Astronaut> data { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public SpaceStation(string name,int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Astronaut>();

        }



//•	Method Remove(string name) – removes an astronaut by given name, if such exists, and returns bool.
//•	Method GetOldestAstronaut() – returns the oldest astronaut.
//•	Method GetAstronaut(string name) – returns the astronaut with the given name.
//•	Getter Count – returns the number of astronauts

        public void Add(Astronaut astronaut)
        {
            if (this.Capacity<this.data.Count())
            {
                this.data.Add(astronaut);
            }
            

        }
        public  bool Remove(string name)
        {
           
           
           this.data.Remove(this.data.FirstOrDefault(h => h.Name == name));
           return true;


            
         }

     
        public Astronaut GetOldestAstronaut()
        {
            int maxAge = this.data.Max(h => h.Age);

            return this.data.FirstOrDefault(h => h.Age == maxAge);
        }

        public Astronaut GetAstronaut(string name)
        {
            return this.data.FirstOrDefault(x => x.Name == name);
        }

        public int Count
        {
            get
            {
               return data.Count();
            }
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Astronauts working at Space Station {this.Name}:");
            foreach (var hero in this.data)
            {
                sb.AppendLine(hero.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
