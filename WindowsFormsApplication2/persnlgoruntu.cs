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
    public partial class persnlgoruntu : Form
    {
        Database1Entities1 db = new Database1Entities1();
        public persnlgoruntu()
        {
            InitializeComponent();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {

            prsnlduzletme frm = new prsnlduzletme();
            frm.yeni = true;
            frm.r = dataSet2.Personel.NewPersonelRow();

            if (frm.ShowDialog() == DialogResult.OK)
            {

                dataSet2.Personel.AddPersonelRow(frm.r);
                personelTableAdapter.Update(frm.r);
            }
            /*var personel = (from x in db.calısan
                              select new { adsoy = x.calısan_ad + " " + x.calısan_soyad.ToUpper(),  }).ToList();

            dataGridView1.DataSource = personel ;*/
        }

        private void button2_Click(object sender, EventArgs e)
        {


            prsnlduzletme frm = new prsnlduzletme();
            frm.yeni = false;
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            frm.r = dataSet2.Personel.FindByper_id(id);

            if (frm.ShowDialog() == DialogResult.OK)
                personelTableAdapter.Update(frm.r);
            
           /* int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var duz_cari = (from x in db.calısan
                            where x.calısan_id == id
                            select x).FirstOrDefault();

            
            duz_cari.calısan_soyad = duz_cari.calısan_soyad.ToUpper();
            
            db.SaveChanges();
            dataGridView1.DataSource = db.calısan.ToList();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            DataSet2.PersonelRow r = dataSet2.Personel.FindByper_id(id);
            r.Delete();
            personelTableAdapter.Update(r);
            /*int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var sil_per = (from x in db.calısan
                            where x.calısan_id== id
                            select x).FirstOrDefault();
            db.calısan.Remove(sil_per);
            db.SaveChanges();
            dataGridView1.DataSource = db.calısan.ToList();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void persnlgoruntu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.dataSet2.Personel);
          
                    

        }

       
    }
}
