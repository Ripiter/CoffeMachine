using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine
{
    class DripCoffeMachine : CoffeMachine
    {
        public DripCoffeMachine(string name) : base(name)
        {

        }

        public override string TurnOn()
        {
            return base.TurnOn();
        }

        public override string TurnOff()
        {   
            return base.TurnOff();
        }

        public override void Brew()
        {
            isDone = false;
            //Brew some coffe
            isDone = true;
        }

        public override void FillContainer(float amount)
        {
            Container.Capacity += amount;
        }

        public override Beverage GiveBack(float amount)
        {
            Container.Capacity -= amount;

            return Bev;
        }

        public override void AddFilter(int amountOfFilters)
        {
            for (int i = 0; i < amountOfFilters; i++)
            {
                Filter filt = new Filter();
            }
            //Add filter to the mahine
        }
    }
}
