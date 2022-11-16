using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asal_sayi_odev
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


            long ilksayi, sonsayi;
            ilksayi = long.Parse(textBox1.Text);
            sonsayi = long.Parse(textBox2.Text);

            long sayi = ilksayi;
            bool durum = true;
            while (sayi < sonsayi)
            {
                sayi++;
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        durum = false;
                    }
                }
                if (durum == true && sayi != 1)
                {
                    listBox1.Items.Add(sayi.ToString());
                }
                durum = true;
            }
            
            
              label4.Text = "İki Sayı Arasında " + listBox1.Items.Count.ToString() + " Tane Asal Sayı Var";
             
        }
    }
}
