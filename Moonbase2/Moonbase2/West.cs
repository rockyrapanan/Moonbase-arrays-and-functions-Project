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
 Name: Leonardo L. Rapanan
 Class: CSC202
 Assignment: Moonbase Project (Update#3)
 Date: 07/04/2024
 
 
 */

namespace Moonbase2
{
    public partial class West : Form
    {

        //Array integer
        double[] num = new double[4];
        public West()
        {
            InitializeComponent();
        }
        
        // Function updatebutton is used on LN 83. For user to enter Items
        public void UpdateButton()
        {
            // Integer will used as string for confirmation.
            num[0] = double.Parse(textBox2.Text);
            num[1] = double.Parse(textBox3.Text);
            num[2] = double.Parse(textBox4.Text);
            double sum = 0;
            double sums = 1;
            double nums = 2;
            CtextBox5.Text = sum.ToString();
            MtextBox5.Text = sums.ToString();
            DtextBox5.Text = nums.ToString();
            
        }
        private void West_Load(object sender, EventArgs e)
        {

        }

        private void WSTbutton2_Click(object sender, EventArgs e)
        {
            //When user pushes West button, it turns red and message the user that they are already on that page.
            // after meesage is clicked, background color goes back to default.
            WSTbutton2.BackColor = Color.Red;
            MessageBox.Show("You're already here!");
            WSTbutton2.BackColor = Color.White;
        }

        // Function South button to click to go to south room site.
        private void STHbutton2_Click(object sender, EventArgs e)
        {
            South frm = new South();
            this.Hide();
            frm.Show();
        }

        // Function East button to click to go to east room site.
        private void ESTbutton2_Click(object sender, EventArgs e)
        {
            East frm = new East();
            this.Hide();
            frm.Show();
        }

        // Function North button to click to go to north room site.
        private void NRTHbutton2_Click(object sender, EventArgs e)
        {
            Moonbase frm = new Moonbase();
            this.Hide();
            frm.Show();
        }

        private void SUBbutton_Click(object sender, EventArgs e)
        {
            // If statement used when user puts in QTY if items they need for their workplace.
            if (AGRradioButton.Checked)
            {
                // Function update button
                UpdateButton();
            }
            // Tells user to click on "Agreement!" radion button before cliking on submit buton.
            else if (!AGRradioButton.Checked) {

                MessageBox.Show("Need to click on Agreement! button");
            }
        }
    }
}
