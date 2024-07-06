using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
/*
 Name: Leonardo L. Rapanan
 Class: CSC202
 Assignment: Moonbase Project (Update#3)
 Date: 07/04/2024
 
 
 */

namespace Moonbase2
{
    public partial class East : Form
    {
        // This string is used for LN 69 registration button.
        String[] text = new string[4];
        public East()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        // Function North button to click to go to north room site.
        private void NRTHbutton1_Click(object sender, EventArgs e)
        {
            Moonbase frm = new Moonbase();
            this.Hide();
            frm.Show();
        }

        // Function West button to click to go to west room site.
        private void WSTbutton1_Click(object sender, EventArgs e)
        {
            West frm = new West();  
            this.Hide();
            frm.Show();
            
        }

        // Function South button to click to go to south room site.
        private void STHbutton1_Click(object sender, EventArgs e)
        {
            South frm = new South();
            this.Hide();
            frm.Show();

        }
       
        // Function East button on main site.
        private void ESTbutton1_Click(object sender, EventArgs e)
        {
            //When user pushes East button, it turns red and message the user that they are already on that page.
            // after meesage is clicked, background color goes back to default.
            ESTbutton1.BackColor = Color.Red;
            MessageBox.Show("You're already here!");
            ESTbutton1.BackColor = Color.White;
        }

        private void RGSTRbutton_Click(object sender, EventArgs e)
        {
            // if statement where the user needs to check the acknowledge button
            if (AGRMNTButton.Checked)
            {
                // Inputs string as long text in RMtextbox & WRTtextbox
                string longtext = string.Empty;
                text[0] = FNtextBox.Text;
                text[1] = MItextBox.Text;
                text[2] = LNtextBox.Text;
                text[3] = EMAILtextBox.Text;
                for (int i = 0; i < text.Length; i++)
                {
                    longtext += text[i];

                }
                // Shows user what they input after submitting button.
                MessageBox.Show("You're Registered!" +" " + "You inputed: " + "\n" + FNtextBox.Text + "\n" + MItextBox.Text + "\n" + LNtextBox.Text 
                    + "\n" + EMAILtextBox.Text );
            }
            else if (!AGRMNTButton.Checked) {
                MessageBox.Show("Need to click on the acknowledge button!");
            
            }

        }
        
    }
}
