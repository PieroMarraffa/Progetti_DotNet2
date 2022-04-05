using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternStrategy.algoritmi;

namespace PatternStrategy.mezzi
{
    internal class Car : Vehicle
    {
        public Car(string name) : base(name)
        {
            this.setAlgorithm(new GoByDriving());
        }
    }
}
