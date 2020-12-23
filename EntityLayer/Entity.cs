using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    [Serializable]
    public class Entity
    {
        public string Month { get; set; }
        public double Grocery { get; set; }
        public double Medical { get; set; }
        public double Personal { get; set; }
        public double Rent { get; set; }
        public double EMI { get; set; }
        public double Travelling { get; set; }
    }
}
