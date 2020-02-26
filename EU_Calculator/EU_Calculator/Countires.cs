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
 * Group      : 56
 */

namespace EU_Calculator
{
    class Countires
    {
        private double population { get; set; } //Stores the population value
        private string name { get; set; } //Stores the name of the country


        public Countires(string country, double pop) //contructor to create a countries object
        {
            name = country;//Sets name to the countrys name
            population = pop;//Sets the population to the countries population
        }

        public double ReturnPop()
        {
            double retVal = population; //Fethes the population value
            return retVal; //Returns the value to the main program
        }


    }
}
