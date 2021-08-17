using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonRehberiv2
{
    public partial class KisiEkleme : Form
    {
        
        kisiRepository KisiRepository;
        int seciliID;
        public KisiEkleme()
        {
            InitializeComponent();
            KisiRepository = new kisiRepository();
            
        }
        //SqlDataAdapter adapter;
        //DataTable dataTable;
        //SqlConnection baglanti;
        //SqlCommand sqlCommand;
        //public void Listele()
        //{ 
        //    string sqlCommand = "SELECT*FROM KisiEkleme";
        //    string baglanti = "Server=.; Database=Deneme; Trusted_Connection=True;";
             
        //    adapter= new SqlDataAdapter(sqlCommand, baglanti);
        //    dataTable = new DataTable();
        //    adapter.Fill(dataTable);


        //    //lVKişiEkleme.Columns.Add("ID", 100);
        //    //lVKişiEkleme.Columns.Add("AD", 150);
        //    //lVKişiEkleme.Columns.Add("SOYAD", 150);
        //    //lVKişiEkleme.Columns.Add("TELEFON", 150);


        //    foreach (DataRow item in dataTable.Rows)
        //    {
        //        lVKişiEkleme.Items.Add(item["KisiID"].ToString());
        //        lVKişiEkleme.Items.Add(item["AD"].ToString());
        //        lVKişiEkleme.Items.Add(item["SOYAD"].ToString());
        //        lVKişiEkleme.Items.Add(item["TELEFON"].ToString());
        //    }


        //    lVKişiEkleme.Clear();
        //    foreach (var item in dataTable.Columns)
        //    {
        //        lVKişiEkleme.Columns.Add(item.ToString(), 100);
        //    }
        //    foreach (DataRow row in dataTable.Rows)
        //    {
        //        ListViewItem item = new ListViewItem(row[0].ToString());
        //        for (int i = 1; i < dataTable.Columns.Count; i++)
        //        {
        //            item.SubItems.Add(row[i].ToString());
        //        }
        //        lVKişiEkleme.Items.Add(item);
        //    }

        //}
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.kisiEklemeTableAdapter.Fill(this.denemeDataSet.KisiEkleme);
            // TODO: This line of code loads data into the 'denemeDataSet.KisiEkleme' table. You can move, or remove it, as needed.

            //Listele();
            FillListView();
            

        }
        void FillListView()
        {
            lVKişiEkleme.Items.Clear();
            List<Kisi> kisis = KisiRepository.GetKisiEklemes();
            ListViewItem listViewItem;
            foreach (Kisi item in kisis)
            {
                listViewItem = new ListViewItem(item.KisiID.ToString());
                listViewItem.SubItems.Add(item.AD);
                listViewItem.SubItems.Add(item.SOYAD);
                listViewItem.SubItems.Add(item.TELEFON);
                lVKişiEkleme.Items.Add(listViewItem);

            }
            
                

        }
        private void txtKişiAra_TextChanged(object sender, EventArgs e)
        {

            
            
            KisiRepository.SearchKisi(txtKişiAra.Text);
            FillListView();

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {


            //KisiRepository.UpdateKisi()


            //lVKişiEkleme.SelectedItems[0].SubItems[1].Text = txtAD.Text;
            //lVKişiEkleme.SelectedItems[0].SubItems[2].Text = txtSoyad.Text;
            //lVKişiEkleme.SelectedItems[0].SubItems[3].Text = mtxtTelefon.Text;
            //txtAD.Text = "";
            //txtSoyad.Text = "";
            //mtxtTelefon.Text = "";

            
            ListViewItem item = lVKişiEkleme.SelectedItems[0];
            Kisi kisi = new Kisi();
            kisi.KisiID = int.Parse(item.SubItems[0].Text);
            kisi.AD = txtAD.Text;
            kisi.SOYAD = txtSoyad.Text;
            kisi.TELEFON = mtxtTelefon.Text;
            KisiRepository.UpdateKisi(kisi, item.Index);
            FillListView();


            ////baglanti = new SqlConnection("Server=.; Database=Deneme; Trusted_Connection=True;");
            //SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            //int selectid = int.Parse(lVKişiEkleme.SelectedItems[0].Text);
            //DataRow dr = null;
            //selectid = int.Parse(lVKişiEkleme.SelectedItems[0].Text); dr["AD"] = txtAD.Text;
            //dr["SOYAD"] = txtSoyad.Text;
            //dr["TELEFON"] = mtxtTelefon.Text;
            //dataTable.Rows.Remove(dr);

            //adapter.Update(dataTable);
            //Listele();




            //foreach (DataRow item in table)
            //{

            //}



            //sqlCommand = new SqlCommand();
            //baglanti.Open();
            //sqlCommand.Connection = baglanti;
            //sqlCommand.CommandText="update KisiEkleme set AD='"+txtAD.Text+"',SOYAD='"+txtSoyad.Text+"',TELEFON='"+mtxtTelefon.Text+"'";
            //sqlCommand.ExecuteNonQuery();
            //baglanti.Close();
            //Listele();


            //SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            //adapter.Update(dataTable);

        }

        private void lVKişiEkleme_SelectedIndexChanged(object sender, EventArgs e)
        {               
            if (lVKişiEkleme.SelectedItems.Count>0)
            {
                int selectid = int.Parse(lVKişiEkleme.SelectedItems[0].Text); 
                ListViewItem item = lVKişiEkleme.SelectedItems[0];
                txtAD.Text = item.SubItems[1].Text;
                txtSoyad.Text = item.SubItems[2].Text;
                mtxtTelefon.Text = item.SubItems[3].Text;
            }
            else
            {
                txtAD.Text = "";
                txtSoyad.Text = "";
                mtxtTelefon.Text = "";
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //int KisiID = (int)lVKişiEkleme.Items.;


            Kisi kisi = new Kisi();
            kisi.AD = txtAD.Text;
            kisi.SOYAD = txtSoyad.Text;
            kisi.TELEFON = mtxtTelefon.Text;
            KisiRepository.InsertKisi(kisi);
            FillListView();
        }

        private void adresEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = lVKişiEkleme.SelectedItems[0];
            int id = int.Parse(listViewItem.SubItems[0].Text);
            AdresEkleme2 frm = new AdresEkleme2(id);
            frm.ShowDialog();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem id = lVKişiEkleme.SelectedItems[0];

            Kisi kisi = new Kisi();
            kisi.KisiID = int.Parse(id.SubItems[0].Text);
            KisiRepository.DeleteKisi(kisi,id.Index);

          
           
            FillListView();

            


            //lVKişiEkleme.Items.RemoveAt(lVKişiEkleme.SelectedIndices[0]);
            //txtAD.Text = "";
            //txtSoyad.Text = "";
            //mtxtTelefon.Text = "";


            //int selectid = int.Parse(lVKişiEkleme.SelectedItems[0].Text);
            //DataRow dr =
            //DataTable dt = dataTable.Rows.Remove(dr);
            //for (int i = dt.Rows.Count - 1; i >= 0; i--)
            //{
            //    dr = dt.Rows[i];
            //    if (dr[selectid.ToString()] == "KisiID")
            //        dr.Delete();
            //}
            //dt.AcceptChanges();


            //lVKişiEkleme.Refresh();
            //DataRow dr = dataTable.Rows[0].Delete();
            //int selectid = int.Parse(lVKişiEkleme.SelectedItems[0].Text);
            //dr["AD"] = txtAD.Text;
            //dr["SOYAD"] = txtSoyad.Text;
            //dr["TELEFON"] = mtxtTelefon.Text;
            //dataTable.Rows.Remove(dr);
            //SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            //adapter.Update(dataTable);
            //Listele();


            //sqlCommand = new SqlCommand();
            //baglanti.Open();
            //sqlCommand.Connection = baglanti;
            //sqlCommand.CommandText = "delete from KisiEkleme where AD=" + txtAD.Text + "";
            //sqlCommand.ExecuteNonQuery();
            //baglanti.Close();
            //Listele();
        }
        private void lLYöneticiEkranı_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            YöneticiPaneli frm = new YöneticiPaneli();
            frm.Show();
        }
    }
}
