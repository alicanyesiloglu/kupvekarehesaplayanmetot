using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_44_küp_hesaplayan_metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kup(int sayi)
        {
            int sonuc = sayi * sayi * sayi;
            return sonuc;
        }


        int kare(int s2)
        {
            int sonuc2 = s2 * s2;
            return sonuc2;
        } 


        private void button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(textBox1.Text);
            label3.Text = kup(s).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt32(textBox1.Text);
            label6.Text = kare(d).ToString();

        }
    }
}
