using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Beverage("Normal", BeverageType.NormalCoffe);
            MachineOperator machineOperator = new MachineOperator();
            Container container = new Container(15,30, beverage);

            CoffeMachine machine = machineOperator.MachineryChoice(beverage);

            machine.TurnOn();
            machine.AddContainer(container);
            machine.Brew();
            machine.TurnOff();

            float coffeBack = 5f;
            Container cup = new Container(5, 30, machine.GiveBack(coffeBack));


            Console.WriteLine(cup.Capacity + " with " + cup.Beverage.TypeOfBeverage);

            Console.ReadKey();
        }
    }
}
