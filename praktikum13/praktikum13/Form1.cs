using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum13
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

        private void buttonproses_Click(object sender, EventArgs e)
        {
            if (labelpesan.Text == "[EMPTY]")
            {
                labelpesan.Font = new Font("Arial", 10, FontStyle.Regular);
                labelpesan.ForeColor = Color.Black;
                labelpesan.Text = textBoxpesan.Text;
            }

            if(textBoxpesan.Text=="DELETE" && labelpesan.Text!="[EMPTY]")
            { labelpesan.Text = "[EMPTY]";
                labelpesan.ForeColor = Color.Black;
            }

            if(textBoxpesan.Text=="HIDE" && labelpesan.Text!="[EMPTY]")
            { labelpesan.Visible = false; }

            if (textBoxpesan.Text == "SHOWN" && labelpesan.Text != "[EMPTY]")
            { labelpesan.Visible = true; }

            if(textBoxpesan.Text=="BLUE" && labelpesan.Text!="[EMPTY]")
            { labelpesan.ForeColor = Color.Blue; }

            if (textBoxpesan.Text == "RED" && labelpesan.Text != "[EMPTY]")
            { labelpesan.ForeColor = Color.Red; }

            if (textBoxpesan.Text == "GREEN" && labelpesan.Text != "[EMPTY]")
            { labelpesan.ForeColor =Color.Green; }

            

        }
    }
}
