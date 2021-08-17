using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;



namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int bas, bit, adet,bilme = 0;
            Random rastglesayi = new Random();
            bas = int.Parse(textBox1.Text);
            bit = int.Parse(textBox2.Text);
            adet = int.Parse(textBox3.Text);
            int[] uretilensayidizisi = new int[adet];
            int[] tahminsayidizisi = new int[adet];
            for(int a=0; a<=adet-1;a++ )

            {
                tahminsayidizisi[a] = int.Parse(Interaction.InputBox("tahmin girişi", "giriş ekranı ","0" ,250 , 250));
                listBox2.Items.Add(tahminsayidizisi[a]);


            }
            for (int i = 0; i <= adet - 1; i++)

            {
                uretilensayidizisi[i] = rastglesayi.Next(bas, bit + 1);
                listBox1.Items.Add(uretilensayidizisi[i]);

            }
            for(int c = 0;c<=adet-1;c++)
            {
                for(int d = 0; d <= adet-1;d++ )

                {
                    if (uretilensayidizisi[c] == tahminsayidizisi[d]) bilme++; 


                }


            }
            label6.Text = bilme.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
