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
    public partial class subeye_glen_sec : Form
    {
        public subeye_glen_sec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            persnlgoruntu p = new persnlgoruntu();
            p.ShowDialog();
        }
    }
}
