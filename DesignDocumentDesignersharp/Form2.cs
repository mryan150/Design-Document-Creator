using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace DesignDocumentDesignersharp
{
    public partial class Form2 : Form
    {
        string title;
        string intro;
        string background;
        public Form2(string str_value, string str_value2, string str_value3)
        {
            
            
            
            

            InitializeComponent();
            string f1Text = str_value;
            string f1Text2 = str_value2;
            string f1Text3 = str_value3;

            

            label1.Text = "Key Features";
            label2.Text = "Genre";
            label4.Text = "Platform";

            richTextBox1.Text = "List your Key Features.  Everything the software will do, and how it will do it";

            textBox1.Text = "What type of software will it be?";

            textBox2.Text = "What platform are you targeting?";

            button1.Text = "Generate Design Document";

            button3.Text = "Cancel";

            title = f1Text;
            intro = f1Text2;
            background = f1Text3;

            

            
        }

       

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                    
                


                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (Stream s = File.Open(saveFileDialog1.FileName+".rtf", FileMode.OpenOrCreate))
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                    
                    sw.WriteLine(title);
                    sw.WriteLine("---------------------------------------------------------");
                    sw.WriteLine("\r\n" + "Introduction: ");
                    sw.WriteLine("\r\n" + intro);
                    sw.WriteLine("---------------------------------------------------------");
                    sw.WriteLine("\r\n" + "Background: ");
                    sw.WriteLine("\r\n" + background);
                    sw.WriteLine("---------------------------------------------------------");
                    sw.WriteLine("\r\n" + "Key Functions: ");
                    sw.WriteLine("\r\n" + richTextBox1.Text);
                    sw.WriteLine("---------------------------------------------------------");
                    sw.WriteLine("\r\n" + "Genre: ");
                    sw.WriteLine("\r\n" + textBox1.Text);
                    sw.WriteLine("---------------------------------------------------------");
                    sw.WriteLine("\r\n" + "Target Platform: ");
                    sw.WriteLine(textBox2.Text);
                    }
                }


                
                System.Windows.Forms.Application.Exit();
            }
        

        private void button3_Click(object sender, EventArgs e)
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
    }
}
