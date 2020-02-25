using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Title      : EU vote calculator
 * Form       : Form1
 * Use        : Holds the voting calculator class
 * Creator    : Max Jameson, Isaac Gordon-Smith, John Joe Merritt, Kokilarathan Sivarajah
 */

namespace EU_Calculator
{
    class VoteCal
    {
       private double state_for;//Stores the states votes for
       private double state_against; //Stores the states votes against
       private double state_abstain; //Stores the states votes abstain
       private double pop_for; //Stores the populations votes for
       private double pop_against; //Stores the populations votes against
       private double pop_abstain;//Stores the populations votes abstain
       private string result;//Stores the result


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
            Result();//Runs result method
        }

        public void recieveVoteAgainst(double vote, double population)
        {
            state_against = state_against + vote;//Increments state_against votes
            pop_against = pop_against + population;//Increments pop_against votes
            Result();//Runs result method

        }

        public void recieveVoteAbstain(double vote, double population)
        {
            state_abstain = state_abstain + vote;//Increments state_abstain votes
            pop_abstain = pop_abstain + population;//Increments pop_abstain votes
            Result();//Runs result method

        }

        private void Result()
        {
            if(state_for < 14.85 || pop_for < 65)//Checks if the vote are under the pass mark
            {
                result = "Rejected";//rejects the vote
            }
            else
            {
                result = "Passed";//Passes the vote
            }

        }

        public string ReturnResult()
        {
            return result;//Returns vote result
        }
    }
}
