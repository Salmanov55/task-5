using System;
using System.Collections.Generic;
using System.Text;

namespace task
{
    class Vehicle
    {
        public string Color;
        public int Year;
       
        public Vehicle(string Color)
        {
            this.Color = Color;
        }
        public Vehicle(string color, int year) : this(color)
        {
            this.Year = year;
        }

       
    }
}
