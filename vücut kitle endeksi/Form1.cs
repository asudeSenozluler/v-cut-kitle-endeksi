using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vücut_kitle_endeksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy, kilo,boykare;
            double sonuç;
            boy = Convert.ToDouble(txtboy.Text);
            kilo = Convert.ToDouble(txtkilo.Text);
            boykare = Math.Pow(boy, 2);
            sonuç = kilo / boykare;
            textBox1.Text = sonuç.ToString();

            if (sonuç > 0 && sonuç < 18)
            {
                richTextBox1.Text = "";
                richTextBox1.Text = "Vücut kitle indeksiniz normalin altında doktor kontrolünde ideal kilonuza ulaşabilirsiniz!";
            }
            else if (sonuç > 18 && sonuç < 25)
            {
                richTextBox1.Text = "";
                richTextBox1.Text = "Vücut kitle indeksiniz normal günlük aktivitelerle ideal kilonuzu koruyabilirsiniz!";
            }
            else if (sonuç > 25 && sonuç < 30)
            {
                richTextBox1.Text = "";
                richTextBox1.Text = "Vücut kitle indeksiniz normalin üstünde doktor kontrolünde ideal kilonuza ulaşabilirsiniz!";
            }
            else if (sonuç > 30 && sonuç < 40)
            {
                richTextBox1.Text = "";
                richTextBox1.Text = "Vücut kitle indeksiniz normalin üstünde en kısa sürede doktorunuzla görüşüp ideal kilonuza ulaşmalısınız!";
            }
            else if (sonuç > 40)
            {
                richTextBox1.Text = "";
                richTextBox1.Text = "Vücut kitle indeksiniz normalin çok üstünde en kısa zamanda  doktor kontrolünde ideal kilonuza ulaşamalısınız!";
            }
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtkilo.Text = "";
            txtboy.Text = "";
            richTextBox1.Text = "";
            textBox1.Text = "";
        }

       
    }
}
