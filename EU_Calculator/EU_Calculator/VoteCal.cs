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
 * Group      : 56
 */

namespace EU_Calculator
{
    class VoteCal
    {
        private double state_for { get; set; }//Stores the states vote for
        private double state_against { get; set; }//Stores the states vote against
        private double state_abstain { get; set; }//Stores the states vote abstain
        private double pop_for { get; set; }//Stores the populations vote for
        private double pop_against { get; set; }//Stores the populations vote against
        private double pop_abstain { get; set; }//Stores the populations vote abstain
        private string resultQM { get; set; }//Stores the result
        private string resultUN { get; set; }//Stores the result

        private string votingType { get; set; }//Stores the voting type

        public VoteCal(string VoteT)
        {
            state_for = 0;
            state_against = 0;
            state_abstain = 0;
            pop_for = 0;
            pop_against = 0;
            pop_abstain = 0;//Sets all double variables to 0
            votingType = VoteT;
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
            if(state_for < 14.85 || pop_for < 65)//Checks if the vote are under the pass mark for a qualified majority
            {
                resultQM = "Rejected";//rejects the vote
            }
            else
            {
                resultQM = "Passed";//Passes the vote
            }

            if (state_for < 27 & pop_for < 100)//Checks if the vote are under the pass mark for unamity
            {
                resultUN = "Rejected";//rejects the vote
            }
            else
            {
                resultUN = "Passed";//Passes the vote
            }

        }

        public string ReturnResult()
        {
            if (votingType == "QM")//Checks which vote was carried out
            {
                return resultQM;//Returns vote result
            }
            else
            {
                return resultUN;//Returns vote result
            }
        }
    }

}
