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
            Coffe = new Coffe("Black Coffe");
            isDone = true;
        }

        public override void FillContainer(float amount, Coffe coffe)
        {
            Container.Capacity += amount;
            this.Coffe = coffe;
        }


        public Coffe Drip(float amount)
        {
            Container.Capacity -= amount;

            return Coffe;
        }
    }
}
