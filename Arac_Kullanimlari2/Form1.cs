using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanimlari2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Antalya");
            //eğer kodsuz eklemek istersen üzerine bir tane tıkla
           //items öge ekle mor küp gördügümüz yere () acıp kapat yani bu methoddur
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Danışma");
            listBox1.Items.Add("Çaycı");
            listBox1.Items.Add("Satış Danışmanı");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox3.Text+" "+textBox4.Text+" "+textBox5.Text+" "+textBox6.Text+" "+textBox7.Text);
        }
    }
}
