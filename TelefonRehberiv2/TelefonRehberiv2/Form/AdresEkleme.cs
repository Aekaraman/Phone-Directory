using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonRehberiv2
{
    public partial class AdresEkleme : Form
    {
        public AdresEkleme()
        {
            InitializeComponent();
        }

        private void AdresEkleme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'denemeDataSet.AdresEkleme2' table. You can move, or remove it, as needed.
            this.adresEkleme2TableAdapter.Fill(this.denemeDataSet.AdresEkleme2);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //DenemeDataSet.AdresEkleme2Row dr =(DenemeDataSet.AdresEkleme2Row)this.denemeDataSet.AdresEkleme2.Rows[lblSehir.Name.]

            //this.adresEkleme2TableAdapter.DeleteQuerySehir
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {

        }
    }
}
