using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine
{
    class EspressoCoffeMachine : CoffeMachine
    {
        public EspressoCoffeMachine(string name) : base(name)
        {

        }

        public override void AddFilter(int amountOfFilters)
        {
            for (int i = 0; i < amountOfFilters; i++)
            {
                Filter filter = new Filter();
            }
            //Implements filter into the coffee machine
        }

        public override void Brew()
        {
            isDone = false;
            // Does some Brewing
            isDone = true;
        }

        public override void FillContainer(float amount)
        {
            Container.Capacity += amount;
        }

        public override Beverage GiveBack(float amount)
        {
            return Bev;
        }

        public override string TurnOff()
        {
            return base.TurnOff();
        }

        public override string TurnOn()
        {
            return base.TurnOn();
        }
    }
}
