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
    public partial class KisiEkleme2 : Form
    {
        public KisiEkleme2()
        {
            InitializeComponent();
        }

        private void KisiEkleme2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'denemeDataSet.KisiEkleme' table. You can move, or remove it, as needed.
            this.kisiEklemeTableAdapter.Fill(this.denemeDataSet.KisiEkleme);

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            this.kisiEklemeBindingSource.EndEdit();
            kisiEklemeTableAdapter.Update(this.denemeDataSet.KisiEkleme);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //AdresEkleme frm = new AdresEkleme();
            //frm.ShowDialog();

            this.kisiEklemeBindingSource.AddNew();

            this.kisiEklemeTableAdapter.Insert(txtAD.Text, txtSoyad.Text, mtxtTelefon.Text);
            this.kisiEklemeTableAdapter.Fill(this.denemeDataSet.KisiEkleme);
        }

        private void txtKişiAra_TextChanged(object sender, EventArgs e)
        {
            string Filter = "[AD] Like'" + txtKişiAra.Text + "%'";
            kisiEklemeBindingSource.Filter = Filter;
        }

        private void lLYöneticiEkranı_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            YöneticiPaneli frm = new YöneticiPaneli();
            frm.Show();
        }

        private void adresEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //AdresEkleme2 frm = new AdresEkleme2();
            //frm.ShowDialog();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DenemeDataSet.KisiEklemeRow dr = (DenemeDataSet.KisiEklemeRow)this.denemeDataSet.KisiEkleme.Rows[dataGridView1.CurrentRow.Index];
            this.kisiEklemeTableAdapter.DeleteQuery(dr.KisiID);
            this.kisiEklemeTableAdapter.Fill(this.denemeDataSet.KisiEkleme);

        }
    }
}
