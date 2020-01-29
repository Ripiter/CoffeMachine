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
        public Container(float maxCapacity)
        {
            this.Maxcapacity = maxCapacity;
        }
        public float Maxcapacity { get => maxcapacity; set => maxcapacity = value; }
        public float Capacity { get => capacity; set => capacity = value; }
    }
}
