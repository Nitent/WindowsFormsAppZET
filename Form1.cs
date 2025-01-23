using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppZET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double a, b, c;
            bool rez1 = double.TryParse(textBox1.Text, out a);
            if (rez1 == false)
            {
                MessageBox.Show("Неверный формат числа" + textBox1.Text + "!");
                return;
            }
            bool rez2 = double.TryParse(textBox2.Text, out b);
            if (rez2 == false)
            {
                MessageBox.Show("Неверный формат числа" + textBox2.Text + "!");
                return;
            }
            if (listBox1.SelectedItem.ToString() == "cos")
            {
                c=a*(Math.Cos(b));
                string cStr = c.ToString();
                textBox3.Text = cStr;
                return;
            }
            if (listBox1.SelectedItem.ToString() == "sin")
            {
                c=a*(Math.Sin(b));
                string cStr = c.ToString();
                textBox3.Text = cStr;
                return;
            }
            if (listBox1.SelectedItem.ToString() == "tg")
            {
                c=a*(Math.Tan(b));
                string cStr = c.ToString();
                textBox3.Text = cStr;
                return;
            }
            

        }
    }
}
