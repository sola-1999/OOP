using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EU_Calculator
{
    public partial class Form1 : Form
    {
        int vote_for;//Stores votes of agreement 
        int vote_against;//Stores votes of disagreement
        int vote_abstain;//Stores abstains

        


        public Form1()
        {
            

            InitializeComponent();
            List<string> names = new List<string> { "Austria", "Belgium", "Bulgaria", "Croatia", "Cyprus", "Czech Republic", "Denmark", "Estonia", "Finland", "France", "Germany", "Greece", "Hungary", "Ireland", "Italy", "Latvia", "Lithuania", "Luxembourg", "Malta", "Netherlands", "Poland", "Portugal", "Romania", "Slovakia", "Spain", "Sweden" };
            List<double> populations = new List<double> { 1.98, 2.56, 1.56, 0.91, 0.20, 2.35, 1.30, 0.30, 1.23, 14.98, 18.54, 2.40, 2.18, 1.10, 13.65, 0.43, 0.62, 0.14, 0.11, 3.89, 8.49, 2.30, 4.34, 1.22, 0.47, 10.49, 2.29 };
            int lenght = names.Count;

            List<Countires> Country = new List<Countires>();
            int i = 0;
            while (i < lenght)
            {
                Country.Add(new Countires(names.ElementAt(i),populations.ElementAt(i)));
                i++;
            }
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (va1.Checked == true || a1.Checked == true)
            {
                vf1.Checked = false;
            }

            else
            {

                if (vf1.Checked == true)//Checks if the tick box is ticked
                {
                    forDisplayAdd();//Runs a method to update the votes
                }
                if (vf1.Checked == false)// checkes if the tickbox in unticked
                {
                    forDisplayMinus();//Runs a method to update the votes
                }
            }

        }

        private void va1_CheckedChanged(object sender, EventArgs e)
        {
            if (va1.Checked == true)//Checks if the tick box is ticked
            {
                againstDisplayAdd();//Runs a method to update the votes
            }
            if (va1.Checked == false)// checkes if the tickbox in unticked
            {
                againstDisplayMinus();//Runs a method to update the votes
            }
 
        }

        private void a1_CheckedChanged(object sender, EventArgs e)
        {
            if (a1.Checked == true)//Checks if the tick box is ticked
            {
                abstainDisplayAdd();//Runs a method to update the votes
            }
            if (a1.Checked == false)// checkes if the tickbox in unticked
            {
                abstainDisplayMinus();//Runs a method to update the votes
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
           

        }

        private void forDisplayAdd()//Method to add for votes
        {
            vote_for = vote_for + 1;//Adds one vote for
            label2.Text = Convert.ToString(vote_for);//Outputs votes to a label
        
        }

        private void forDisplayMinus()//Method to minus for votes
        {
            vote_for = vote_for - 1;//Minus one vote for
            label2.Text = Convert.ToString(vote_for);//Outputs votes to a label

        }

        private void againstDisplayAdd()//Method to add against votes
        {
            vote_against = vote_against + 1;//Adds one vote against
            label3.Text = Convert.ToString(vote_against);//Outputs votes to a label

        }

        private void againstDisplayMinus()//Method to minus against votes
        {
            vote_against = vote_against - 1;//Minus one vote against
            label3.Text = Convert.ToString(vote_against);//Outputs votes to a label

        }

        private void abstainDisplayAdd()//Method to add abstains
        {
            vote_abstain = vote_abstain + 1;//Adds one abstain
            label4.Text = Convert.ToString(vote_abstain);//Outputs votes to a label

        }

        private void abstainDisplayMinus()//Method to minus abstains
        {
            vote_abstain = vote_abstain - 1;//Minus one abstain
            label4.Text = Convert.ToString(vote_abstain);//Outputs votes to a label

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
