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
            Machine machine = new DripCoffeMachine("George");
            Beverage beverage = new Coffe("Coffe");
            Container container = new Container(30);


            ((DripCoffeMachine)machine).AddContainer(container);
            ((DripCoffeMachine)machine).FillContainer(15,(Coffe)beverage);
            

            machine.TurnOn();

            Console.ReadKey();
        }
    }
}
