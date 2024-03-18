using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritence_manjulaRajan
{
    public class Land :Vehicle
    {
        private int wheels;

        public Land(string color, int wheels) : base(color)
        {
            -
            _wheels = wheels;
        }

        public int Wheels { get => wheels; set => wheels = value; }

        public override string ToString()
        {
            return $"{base.ToString()} - Number of Wheels {Wheels}";
        }
    }//class






}//Namespaace
