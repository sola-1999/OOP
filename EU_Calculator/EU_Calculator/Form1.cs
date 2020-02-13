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
        int vote_f_add;
        int vote_f_minus;
        int vote_against;
        int vote_abstain;
        string forOutput;
        string againstOutput;
        string abstain;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (vf1.Checked == true)
            {
                forDisplayAdd();
            }
            if (vf1.Checked == false)
            {
                forDisplayMinus();
            }

        }

        private void va1_CheckedChanged(object sender, EventArgs e)
        {
            vote_against = vote_against + 1;
            againstOutput = Convert.ToString(vote_against);
            label3.Text = againstOutput;
        }

        private void a1_CheckedChanged(object sender, EventArgs e)
        {
            vote_abstain = vote_abstain + 1;
            abstain = Convert.ToString(vote_abstain);
            label4.Text = abstain;
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

        private void forDisplayAdd()
        {
            vote_f_add = vote_f_add + 1;
            forOutput = Convert.ToString(vote_f_add);
            label2.Text = forOutput;
        }

        private void forDisplayMinus()
        {
            vote_f_add = vote_f_add - 1;
            forOutput = Convert.ToString(vote_f_add);
            label2.Text = forOutput;
        }

    }
}
