using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "ss.waw";
            ses.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s1, s2;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            int toplam = s1 - s2;
            label3.Text = "toplam= " + toplam;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int s1, s2;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            int toplam = s1 + s2;
            label3.Text = "Sonuç= " + toplam;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s1, s2;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            int toplam = s1 * s2;
            label3.Text = "Sonuç= " + toplam;
        }

        private void button4_Click(object sender, EventArgs e)
        {
             int s1, s2;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            int toplam = s1 + s2;
            label3.Text = "Sonuç= " + toplam;
        }
    }
}
