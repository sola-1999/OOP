using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Title      : EU vote calculator
 * Form       : Countires
 * Use        : Holds the county class
 * Creator    : Max Jameson, Isaac Gordon-Smith, John Joe Merritt, Kokilarathan Sivarajah
 */

namespace EU_Calculator
{
    class Countires
    {
        private double population;//Stores the popluation percentage
        private string name;//Stores country name


        public Countires(string country, double pop) //contructor to create a countries object
        {
            name = country;//Sets name to the countrys name
            population = pop;//Sets the population to the countries population
        }

        public double ReturnPop()
        {
            return population;//Returns the countries name
        }


    }
}
