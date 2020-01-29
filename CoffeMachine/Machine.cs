using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine
{
    abstract class Machine
    {
        private string name;
        bool isOn = false;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected bool IsOn { get => isOn; set => isOn = value; }

        public Machine(string name)
        {
            this.Name = name;
        }

        
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
