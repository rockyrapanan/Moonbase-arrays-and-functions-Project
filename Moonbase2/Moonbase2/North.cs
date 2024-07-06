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
    public partial class Moonbase : Form
    {
        // The number of arrays when user inputs room and reason why (LN 77).
        String[] text = new string[2];
        public Moonbase()
        {
            InitializeComponent();
        }
        // Function for button on LN 69 to open another background image.
        public void UpdateForm()
        {
            this.BackgroundImage = Image.FromFile("MoonbaseRm2.jpg");
        }
        // Function for buton on LN 75 to return back to the original background image.
        public void ReturnForm()
        {
            this.BackgroundImage = Image.FromFile("Monbase Room.jpg");
        }
        private void NRTHbutton_Click(object sender, EventArgs e)
        {
            //When user pushes North button, it turns red and message the user that they are already on that page.
            // after meesage is clicked, background color goes back to default.
            NRTHbutton.BackColor = Color.Red;
            MessageBox.Show("You're already here!");
            NRTHbutton.BackColor = Color.White;
        }
        // Function West button to click to go to west room site.
        private void WSTbutton_Click(object sender, EventArgs e)
        {
           West frm = new West();
           this.Hide();
            frm.Show();
        }

        // Function South button to click to go to south room site.
        private void STHbutton_Click(object sender, EventArgs e)
        {
            South from = new South();
            this.Hide();
            from.Show();
        }

        // Function East button to click to go to east room site.
        private void ESTbutton_Click(object sender, EventArgs e)
        {
            East frm = new East();
            this.Hide();
            frm.Show();
        }

        private void NXTbutton1_Click(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void BCKbutton1_Click(object sender, EventArgs e)
        {
            ReturnForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Inputs string as long text in RMtextbox & WRTtextbox
            string longtext = string.Empty;
            text[0] = RMtextBox.Text;
            text[1] = WRTtextBox.Text;
            for (int i = 0; i < text.Length; i++)
            {
                longtext += text[i] + " " + " ";

            }
            // Shows user what they input after submitting button.
            SHWtextBox.Text = longtext;
        }
    }
}
