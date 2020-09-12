using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class guvenlik : Form
    {
        public guvenlik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text=="admin58" && comboBox1.SelectedItem=="Trafik")
            {
               
                        MessageBox.Show("Giriş Başarılı" + " " + textBox1.Text);
                        Form1 f = new Form1();
                        f.ShowDialog();
            }
           
            else
            {
                MessageBox.Show("Bilgileriniz hatalı");
            }
        }

        private void guvenlik_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
