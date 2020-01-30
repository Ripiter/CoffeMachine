using System;

namespace CoffeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Beverage("Normal", BeverageType.Espresso);
            MachineOperator machineOperator = new MachineOperator();
            Container container = new Container(15, 30, beverage);
            CoffeMachine machine = machineOperator.MachineryChoice(beverage);

            machine.TurnOn();
            machine.AddFilter(0);
            machine.AddContainer(container);
            machine.Brew();
            machine.TurnOff();

            float coffeBack = 5f;
            while (machine.Container.Capacity > 0)
            {
                Container cup = new Container(coffeBack, 30, machine.GiveBack(coffeBack));
                Console.WriteLine(cup.Capacity + " with " + cup.Beverage.TypeOfBeverage);
            }
            Console.ReadKey();
        }
    }
}
