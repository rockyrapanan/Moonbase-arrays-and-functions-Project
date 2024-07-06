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
    public partial class South : Form
    {
        // string for function OptionButton.
        String[] text = new string[9];
        public South()
        {
            InitializeComponent();
        }
       
        // Public function string to return text after button for item button & feedback button once clicked.
        public string[] GetText()
        {
            return text;
        }
        
        // Function used for LN 88 & 93 for Item cart button and feedback button.
        public void OptionButton(string[] text)
        {
            text[0] = ITM1textBox.Text;
            text[1] = ITM2textBox.Text;
            text[2] = ITM3textBox.Text;
            text[3] = FDBKtextBox.Text;

            CRT1textBox.Text = text[0];
            CRT2textBox.Text = text[1];
            CRT3textBox.Text = text[2];

            FDBKRtextBox.Text = text[3];
        }
        private void South_Load(object sender, EventArgs e)
        {

        }

        private void STHbutton3_Click(object sender, EventArgs e)
        {
            //When user pushes West button, it turns red and message the user that they are already on that page.
            // after meesage is clicked, background color goes back to default.
            STHbutton3.BackColor = Color.Red;
            MessageBox.Show("You're already here!");
            STHbutton3.BackColor = Color.White;
           
        }

        // Function East button to click to go to east room site.
        private void ESTbutton3_Click(object sender, EventArgs e)
        {
            East frm = new East();
            this.Hide();
            frm.Show();
            
        }

        // Function North button to click to go to north room site.
        private void NRTHbutton3_Click(object sender, EventArgs e)
        {
            Moonbase frm = new Moonbase();
            this.Hide();
            frm.Show();
        }

        // Function West button to click to go to west room site.
        private void WSTbutton3_Click(object sender, EventArgs e)
        {
            West frm = new West();
            this.Hide();
            frm.Show();
        }

        private void ITMbutton_Click(object sender, EventArgs e)
        {
            OptionButton(GetText());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AGRMNTradioButton.Checked)
            {

                OptionButton(GetText());

            }
            else if (!AGRMNTradioButton.Checked)
            {

                MessageBox.Show("Need to click on the acknowledge button!");

            }
        }
    }
}
