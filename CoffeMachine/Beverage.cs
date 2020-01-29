using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine
{
    abstract class Beverage
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Beverage(string name)
        {
            this.Name = name;
        }
    }
}
