using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine
{
    abstract class CoffeMachine : Machine
    {
        Coffe coffe;
        Container container;
        protected bool isDone;

        public Coffe Coffe { get => coffe; protected set => coffe = value; }
        public Container Container { get => container; protected set => container = value; }

        public CoffeMachine(string name) : base(name)
        {

        }

        public void AddContainer(Container container)
        {
            this.Container = container;
        }
        public abstract void FillContainer(float amount, Coffe coffe);
        public abstract void Brew();
    }
}
