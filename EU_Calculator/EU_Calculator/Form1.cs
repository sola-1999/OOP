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

        List<Countires> Countries1 = new List<Countires>(); //List to store country objects

        public Form1()
        {
            

            InitializeComponent();
            List<string> names = new List<string> { "Austria", "Belgium", "Bulgaria", "Croatia", "Cyprus", "Czech Republic", "Denmark", "Estonia", "Finland", "France", "Germany", "Greece", "Hungary", "Ireland", "Italy", "Latvia", "Lithuania", "Luxembourg", "Malta", "Netherlands", "Poland", "Portugal", "Romania", "Slovakia", "Spain", "Sweden" }; //List of country names
            List<double> populations = new List<double> { 1.98, 2.56, 1.56, 0.91, 0.20, 2.35, 1.30, 0.30, 1.23, 14.98, 18.54, 2.40, 2.18, 1.10, 13.65, 0.43, 0.62, 0.14, 0.11, 3.89, 8.49, 2.30, 4.34, 1.22, 0.47, 10.49, 2.29 }; //List of populations 
            int lenght = names.Count;//counts the lenght of the names list

            
            for (int i = 0; i < lenght; i++)//Loops through each country
            {
                Countries1.Add(new Countires(names.ElementAt(i),populations.ElementAt(i)));// Adds country to list
                dataGridView1.Rows.Add(names[i], populations[i], "Yes");// Creates a row for each 
            }
 


        }

        private void countYes()
        {
            int yes = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if (dataGridView1.Rows[i].Cells[2].Value as string == "Yes")
                {
                   Countires name = Countries1.ElementAt(i);//fetches the current object

                   double population = name.ReturnPop(); //fetches the current objects current

                    yes++;
                }
            }
             
        }
        private void countNo()
        {
            int no = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if (dataGridView1.Rows[i].Cells[2].Value as string == "No")
                {
                    Countires name = Countries1.ElementAt(i);//fetches the current object

                    double population = name.ReturnPop(); //fetches the current objects current

                    no++;
                }
            }
            
        }
        private void countAbstain()
        {
            int abstain = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if (dataGridView1.Rows[i].Cells[2].Value as string == "Abstain")
                {
                    Countires name = Countries1.ElementAt(i);//fetches the current object

                    double population = name.ReturnPop(); //fetches the current objects current

                    abstain++;
                }
            }
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
