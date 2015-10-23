using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningAverage
{
    public partial class frmRunningAverage : Form
    {
        int clickCounter;
        int totalNumber;
        public frmRunningAverage()
        {
            InitializeComponent();
        }

        private void btnEnterNumber_Click(object sender, EventArgs e)
        {
            //Variables
            int newNumber;
            clickCounter++;

            //Input
            newNumber = Convert.ToInt32(txtNewNumber.Text);

            //Process
            if (newNumber == -1)
            {
                MessageBox.Show("Done!");
                this.btnEnterNumber.Enabled = false;
                this.txtNewNumber.Visible = false;
            }  
            else if (newNumber <-1 || newNumber > 100)
            {
                MessageBox.Show("This Input is not valid.");
                this.txtNewNumber.Clear();
            }
            else
            {
                totalNumber = totalNumber + newNumber;
                this.lblAverage.Text = ("Your running Average is:" + Convert.ToString(totalNumber / clickCounter));
                this.txtNewNumber.Clear();
                
            }
            
        }

        private void frmRunningAverage_Load(object sender, EventArgs e)
        {
            clickCounter = 0;
            totalNumber = 0;
           
        }
    }
}
