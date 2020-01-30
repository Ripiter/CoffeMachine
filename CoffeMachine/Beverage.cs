using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine
{
    public enum BeverageType
    {
        NormalCoffe,
        Espresso,
        Tee
    }
    class Beverage
    {
        private string mark;

        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        private BeverageType typeOfBeverage;

        public BeverageType TypeOfBeverage
        {
            get { return typeOfBeverage; }
            set { typeOfBeverage = value; }
        }
        

        public Beverage(string mark, BeverageType type)
        {
            this.Mark = mark;
            this.typeOfBeverage = type;
        }
    }
}
