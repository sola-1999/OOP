using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EU_Calculator
{
    class Countires
    {
        private double population; //stores the popluation percentage
        private string name;


        public Countires(string country, double pop) //contructor to create a countries object
        {
            name = country;
            population = pop;
        }

    }
}
