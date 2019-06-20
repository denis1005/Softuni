using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_7._Car_Salesman
{
    public class Car
    {
        //        Car has the following properties:
        //•	Model
        //•	Engine
        //•	Weight 
        //•	Color
        public string Model { get; set; }

        public string Engine { get; set; }

        public double Weight { get; set; }

        public string Color { get; set; }

        public Car(string Model,string Engine,double Weight,string Color)
        {
            this.Model = Model;
            this.Engine = Engine;
            this.Weight = Weight;
            this.Color = Color;
        }

    }
}
