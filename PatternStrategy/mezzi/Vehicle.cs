using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternStrategy;
using PatternStrategy.algoritmi;

namespace PatternStrategy.mezzi
{
    abstract class Vehicle
    {
        protected IGo algorithm;
        protected string name;

        public Vehicle(string name)
        {
            this.name = name;
        }

        public void setAlgorithm(IGo alg)
        {
            algorithm = alg;
        }

        public void Go()
        {
            Console.Write(name + ": ");
            this.algorithm.Go();
        }
    }
}
