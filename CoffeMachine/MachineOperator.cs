using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine
{
    class MachineOperator
    {
        CoffeMachine machine;
        public CoffeMachine MachineryChoice(Beverage beverage)
        {
            ChooseMachine(beverage.TypeOfBeverage);

            return machine;
        }


        void ChooseMachine(BeverageType type)
        {
            switch (type)
            {
                case BeverageType.NormalCoffe:
                    machine = new DripCoffeMachine("George");
                    break;
                case BeverageType.Espresso:
                    machine = new EspressoCoffeMachine("Mikeal");
                    break;
                default:
                    break;
            }
        }

    }
}
