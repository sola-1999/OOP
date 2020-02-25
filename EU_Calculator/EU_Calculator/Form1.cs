using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Title      : EU vote calculator
 * Form       : Form1
 * Use        : Runs calculator
 * Creator    : Max Jameson, Isaac Gordon-Smith, John Joe Merritt, Kokilarathan Sivarajah
 */


namespace EU_Calculator
{
    public partial class Form1 : Form
    {

        List<Countires> Countries1 = new List<Countires>(); //List to store country objects

        public Form1()
        {
            

            InitializeComponent();
            List<string> names = new List<string> { "Austria", "Belgium", "Bulgaria", "Croatia", "Cyprus", "Czech Republic", "Denmark", "Estonia", "Finland", "France", "Germany", "Greece", "Hungary", "Ireland", "Italy", "Latvia", "Lithuania", "Luxembourg", "Malta", "Netherlands", "Poland", "Portugal", "Romania", "Slovakia", "slovenia", "Spain", "Sweden" }; //List of country names
            List<double> populations = new List<double> { 1.98, 2.56, 1.56, 0.91, 0.20, 2.35, 1.30, 0.30, 1.23, 14.98, 18.54, 2.40, 2.18, 1.10, 13.65, 0.43, 0.62, 0.14, 0.11, 3.89, 8.49, 2.30, 4.34, 1.22, 0.47, 10.49, 2.29 }; //List of populations 
            int lenght = names.Count;//Counts the lenght of the names list

            
            for (int i = 0; i < lenght; i++)//Loops through each country
            {
                Countries1.Add(new Countires(names.ElementAt(i),populations.ElementAt(i)));//Adds country to list
                dataGridView1.Rows.Add(names[i], populations[i], "Yes","Confirm");// Creates a row for each 
            }

            timer1.Enabled = true;//Enables a timer


        }

        private void CountVotes()
        {
            VoteCal voteCalculator = new VoteCal();//Creates a new voting calculator
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)//Loops trough each row in the data grid
            {
                double vote = 1;
                Countires name = Countries1.ElementAt(i);//Fetches the current object

                if (dataGridView1.Rows[i].Cells[2].Value as string == "Yes")//Checks if the current selection box is a yes vote
                {

                   voteCalculator.recieveVoteFor(vote, name.ReturnPop());//Runs a method to add yes votes in the voteCal class

                }
                if (dataGridView1.Rows[i].Cells[2].Value as string == "No")//Checks if the current selection box is a no vote
                {             

                    voteCalculator.recieveVoteAgainst(vote, name.ReturnPop());//Runs a method to add no votes in the voteCal class

                }
                if (dataGridView1.Rows[i].Cells[2].Value as string  == "Abstain")//Checks if the current selection box is a abstain vote
                {

                    voteCalculator.recieveVoteAbstain(vote, name.ReturnPop());//Runs a method to add abstain votes in the voteCal class
                }
            }


            ResultPrint.Text = voteCalculator.ReturnResult();//Runs a method in voteCal to get the vote results
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
           
        }

        private void ResultPrint_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CountVotes();//Runs countYes method
            Refresh();//refreshes the form
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
