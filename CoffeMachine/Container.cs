using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine
{
    class Container
    {
        float maxcapacity;
        float capacity;
        Beverage beverage;
        public Container(float capacity,float maxCapacity, Beverage beverage)
        {
            this.Maxcapacity = maxCapacity;
            this.Beverage = beverage;
            this.Capacity = capacity;

            if (Capacity > Maxcapacity)
                throw new OverflowException();  

        }
        public float Maxcapacity { get => maxcapacity; set => maxcapacity = value; }
        public float Capacity { get => capacity; set => capacity = value; }
        public Beverage Beverage { get => beverage; set => beverage = value; }
    }
}
