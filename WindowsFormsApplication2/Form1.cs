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
    public partial class Form1 : Form
    {
        Database1Entities1 db = new Database1Entities1();
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Duzeltme frm = new Duzeltme();
            frm.yeni = true;
            frm.r = dataSet1.vatandas.NewvatandasRow();

            if (frm.ShowDialog() == DialogResult.OK)
            {

               dataSet1.vatandas.AddvatandasRow(frm.r);
              vatandasTableAdapter.Update(frm.r);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.vatandas' table. You can move, or remove it, as needed.
            this.vatandasTableAdapter.Fill(this.dataSet1.vatandas);
            // TODO: This line of code loads data into the 'dataSet1.vatandas' table. You can move, or remove it, as needed.


           /* var bilgi = db.vatandas.ToList();
            dataGridView1.DataSource = bilgi;*/
            
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            DataSet1.vatandasRow r = dataSet1.vatandas.FindByvatandas_id(id);
            r.Delete();
           vatandasTableAdapter.Update(r);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Duzeltme frm = new Duzeltme();
            frm.yeni = false;
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            frm.r = dataSet1.vatandas.FindByvatandas_id(id);

            if (frm.ShowDialog() == DialogResult.OK)
                vatandasTableAdapter.Update(frm.r);
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
            string filtre_cumlesi = "vatandas_adsaoyad like'" + textBox1.Text + "%'";
           // stokBindingSource.Filter = filtre_cumlesi;  //  kayıtları gridde filtreler

           DataRow[]  sec=dataSet1.vatandas.Select(filtre_cumlesi); 
                            object id=   sec[0]["vatandas_id"];
                          vatandasBindingSource1.Position= vatandasBindingSource1.Find("vatandas_id", id);
        }
        

        
    }
}
