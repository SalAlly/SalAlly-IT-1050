using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final

{
    class Passenger
    {
        private double Weight;
        private string Name;

        public Passenger(string Name, double Weight)
        {
            this.Name = Name;
            this.Weight = Weight;

        }

        public string GetName()

        {
            return Name;
        }

        public double GetWeight()
        {
            return Weight;
        }

    }
}
