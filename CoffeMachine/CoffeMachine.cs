using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine
{
    abstract class CoffeMachine
    {
        private Beverage bev;

        public Beverage Bev
        {
            get { return bev; }
            set { bev = value; }
        }

        Container container;
        protected bool isDone;

        private string name;
        bool isOn = false;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Container Container { get => container; protected set => container = value; }
        protected bool IsOn { get => isOn; set => isOn = value; }

        public CoffeMachine(string name)
        {

        }

        public void AddContainer(Container container)
        {
            this.Container = container;
            this.Bev = container.Beverage;
        }
        public abstract void AddFilter(int amountOfFilters);    
        public abstract void FillContainer(float amount);
        public abstract void Brew();
        public abstract Beverage GiveBack(float amount);
        
        public virtual string TurnOn()
        {
            IsOn = true;

            return "Machine in on";
        }

        public virtual string TurnOff()
        {
            IsOn = false;

            return "Machine is off";
        }
    }
}
