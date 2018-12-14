using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            txtDay.Text = "";
            txtMonth.Text = "";
            txtYear.Text = "";
            txtDay.Focus();
        }

        private void bntCheck_Click(object sender, EventArgs e)
        {
            bool check;
      
            MessageBoxButtons button = MessageBoxButtons.OK;
            string tile = "Error";
            IntegerNumber i = new IntegerNumber();
            check = i.CheckInt(txtDay.Text);
            if (!check)
            {
                MessageBox.Show("Input data of Day is incorrect format!",tile,button);
                return;
            }
            check = i.CheckInt(txtMonth.Text);
            if (!check)
            {
                MessageBox.Show("Input data of Month is incorrect format!", tile, button);
                return;
            }
            check = i.CheckInt(txtYear.Text);
            if (!check)
            {
                MessageBox.Show("Input data of Year is incorrect format!", tile, button);
                return;
            }
            TimeChecker checker = new TimeChecker(int.Parse(txtDay.Text), int.Parse(txtMonth.Text), int.Parse(txtYear.Text));
             check= checker.IsValidDate();
            if (int.Parse(txtDay.Text)<1||int.Parse(txtDay.Text)>31)
            {
                MessageBox.Show("input data of date is out of range!");
                return;
            }
            if (int.Parse(txtMonth.Text) < 1 || int.Parse(txtMonth.Text) > 12)
            {
                MessageBox.Show("input data of Month is out of range!");
                return;
            }
            if (int.Parse(txtYear.Text) < 1000 || int.Parse(txtYear.Text) > 3000)
            {
                MessageBox.Show("input data of Year is out of range!");
                return;
            }
            if (check)
            {
                MessageBox.Show(txtDay.Text+"/"+txtMonth.Text+"/"+txtYear.Text +" is correct date time!");
                return;
            }
            else
            {
                MessageBox.Show(txtDay.Text + "/" + txtMonth.Text + "/" + txtYear.Text + " is NOT correct date time!");
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
         
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are you sure to exit!", "confirm message", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (rs == DialogResult.OK)
            {

               
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
