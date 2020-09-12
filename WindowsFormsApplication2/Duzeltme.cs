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
    public partial class Duzeltme : Form
    {
        public bool yeni;
        public DataSet1.vatandasRow r;
        public Duzeltme()
        {
            InitializeComponent();
        }

        private void Duzeltme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Birimler' table. You can move, or remove it, as needed.
            
            
            if (yeni)
                temizle();
            else
                db_to_src();

        }
        private void temizle()
        {
           
            textBox2.Text = "";
          

        }

        private void db_to_src()
        {
            textBox2.Text = r.vatandas_adsaoyad;
            dateTimePicker2.Value = r.vatandas_dogumgunu;
            comboBox2.Text = r.vatandas_sicil;
           
         
               
            

        }
        private void src_to_db()
        {
            
            r.vatandas_adsaoyad= textBox2.Text;
            r.vatandas_dogumgunu = dateTimePicker2.Value;
            r.vatandas_sicil = comboBox2.Text;
            r.sicil_no = Convert.ToInt32(comboBox1.Text);
            
           
            
            
           

        }

        private void button6_Click(object sender, EventArgs e)
        {
            src_to_db();
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
