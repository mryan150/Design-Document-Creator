using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignDocumentDesignersharp
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            
            InitializeComponent();
            

            label1.Text = "Working Title";
            textBox1.Text = "Enter Your Title";
            label2.Text = "Introduction";
            richTextBox1.Text = "What IS your program?";
            label3.Text = "Description";
            richTextBox2.Text = "Describe exactly what the project is going to do.  Possibly give some examples of how it will work, or exciting things you can do with it.";

            button1.Text = "Continue";
            button2.Text = "Cancel";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            
            Form2 f2 = new Form2(textBox1.Text, richTextBox1.Text, richTextBox2.Text);
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "You will lose all design document information";
            string caption = "Are you sure you want to quit?";
            MessageBoxButtons mb = MessageBoxButtons.YesNo;

            DialogResult result;

            result = MessageBox.Show(message, caption, mb);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
