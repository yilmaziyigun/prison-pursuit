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
    public partial class prsnlduzletme : Form
    {
        public bool yeni;
        public DataSet2.PersonelRow r;
        public prsnlduzletme()
        {
            InitializeComponent();
        }

        private void prsnlduzletme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.Birimler' table. You can move, or remove it, as needed.
            this.birimlerTableAdapter.Fill(this.dataSet2.Birimler);

        }
    }
}
