using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDERS2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy, kilo, sonuc;
            boy = Convert.ToDouble(textBox1.Text);
            kilo = double.Parse(textBox2.Text);
            boy = boy / 100;
            sonuc = kilo / (boy * boy);
            label7.Text = sonuc.ToString();

            if (sonuc < 20 && radioButton2.Checked == true) 
             {
                label9.Text = " Fazla Zayıfsın Senin İçin İdeal Olan Kiloya Ulaşmalısın. ";
             }
           
            else if (sonuc >= 20 && sonuc<25 && radioButton2.Checked == true)
            { 
                label9.Text = "İdeal Kilodasın Formunu Koru .";
            }

            else if (sonuc >= 25 && sonuc < 100 && radioButton2.Checked == true)

            { 
                label9.Text = "Fazla Kilolardan Kurtularak Senin İçin İdeal Olan Kiloya Ulaşmalısın. ";
            }

            else if (sonuc < 18 && radioButton1.Checked == true)
            { 
                label9.Text = "Fazla Zayıfsın Senin İçin İdeal Olan Kiloya Ulaşmalısın. "; 

            }

            else if (sonuc >= 18 && sonuc < 23 && radioButton1.Checked == true)
            {
                label9.Text = "İdeal Kilodasın Formunu Koru. ";

            }

            else if (sonuc >= 23 && sonuc < 100 && radioButton1.Checked == true)
            {
                label9.Text = "Fazla Kilolardan Kurtularak Senin İçin İdeal Olan Kiloya Ulaşmalısın. ";


            }



        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}

