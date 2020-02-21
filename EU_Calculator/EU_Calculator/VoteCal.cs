﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EU_Calculator
{
    class VoteCal
    {
        double state_for;//Stores the states votes for
        double state_against; //Stores the states votes against
        double state_abstain; //Stores the states votes abstain
        double pop_for; //Stores the populations votes for
        double pop_against; //Stores the populations votes against
        double pop_abstain;//Stores the populations votes abstain
        string result;//Stores the result


        public VoteCal()
        {
            state_for = 0;
            state_against = 0;
            state_abstain = 0;
            pop_for = 0;
            pop_against = 0;
            pop_abstain = 0;//Sets all double variables to 0
        }

        public void recieveVoteFor(double vote, double population)
        {
            state_for = state_for + vote;//Increments state_for votes
            pop_for = pop_for + population;//Increments pop_for votes

        }

        public void recieveVoteAgainst(double vote, double population)
        {
            state_against = state_against + vote;//Increments state_against votes
            pop_against = pop_against + population;//Increments pop_against votes

        }

        public void recieveVoteAbstain(double vote, double population)
        {
            state_abstain = state_abstain + vote;//Increments state_abstain votes
            pop_abstain = pop_abstain + population;//Increments pop_abstain votes

        }

        public string Result()
        {
            if(state_for < 14.85 || pop_for < 65)//Checks if the vote are under the pass mark
            {
                result = "Rejected";//rejects the vote
            }
            else
            {
                result = "Passed";//Passes the vote
            }

            return result;//Returns results to the main program
        }
    }
}
