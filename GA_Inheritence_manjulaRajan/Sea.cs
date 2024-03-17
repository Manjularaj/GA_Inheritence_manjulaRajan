using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritence_manjulaRajan
{
    public class Sea: Vehicle
    {
        string _type;

        // Constructor extending base and taking type
        public Sea(string color, string type) : base(color)
        {
            _type = type;
        }
        public string Type { get; set; }

        public override string ToString()
        {
            return (base.ToString() + $" - It is a {_type}");
        }

    }
}

    

