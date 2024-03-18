using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritence_manjulaRajan
{
    public class Vehicle
    {

        string _color;

        public Vehicle(string color)//Constructor
        {
            _color = color;
        }

        public string Color { get => _color; set => _color = value; }

        public override string ToString()
        {


            //return $"this.GetType().Name-(Color)";

            return $"{this.GetType().Name} - {_color}";

        }
      
            
    }
}
