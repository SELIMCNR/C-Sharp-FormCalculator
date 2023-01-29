using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x ,y;

        private void button22_Click(object sender, EventArgs e)
        {
            //Cikarma
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(x - y);

            textBox1.Text = null; textBox2.Text = null;
           
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //Çarpma
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(x * y);
            textBox1.Text = null; textBox2.Text = null;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double x, y;
            //Bölme
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(x / y);
            textBox1.Text = null; textBox2.Text = null;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Kalan bulma
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(x % y);
            textBox1.Text = null; textBox2.Text = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           textBox1.Text= Convert.ToString(Math.Tan(Convert.ToDouble(textBox1.Text)));
            
                textBox2.Text = Convert.ToString(Math.Tan(Convert.ToDouble(textBox2.Text)));

        
        
           


        }

        private void button5_Click(object sender, EventArgs e)
        {
          textBox3.Text= Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Text),Convert.ToDouble(textBox2.Text)));
   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox3.Text)));
            textBox2.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox2.Text)));
            textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Cos(Convert.ToDouble(textBox1.Text)));
            textBox2.Text = Convert.ToString(Math.Cos(Convert.ToDouble(textBox2.Text)));
      
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "1";

            }

            else

            {

                textBox1.Text = textBox1.Text + "1";

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "2";

            }

            else

            {

                textBox1.Text = textBox1.Text + "2";

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "3";

            }

            else

            {

                textBox1.Text = textBox1.Text + "3";

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "4";

            }

            else

            {

                textBox1.Text = textBox1.Text + "4";

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "5";

            }

            else

            {

                textBox1.Text = textBox1.Text + "5";

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "6";

            }

            else

            {

                textBox1.Text = textBox1.Text + "6";

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "7";

            }

            else

            {

                textBox1.Text = textBox1.Text + "7";

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "8";

            }

            else

            {

                textBox1.Text = textBox1.Text + "8";

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "9";

            }

            else

            {

                textBox1.Text = textBox1.Text + "9";

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = "=";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //Toplama
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(x + y);

        }
    }
}
