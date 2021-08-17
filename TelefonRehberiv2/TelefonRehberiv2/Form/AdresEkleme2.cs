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
    public partial class AdresEkleme2 : Form
    {
        AdresRepository adresRepository;
        int selectedID;
        
        public AdresEkleme2(int id)
        {
            InitializeComponent();
            selectedID = id;
            adresRepository = new AdresRepository(selectedID);
        }

        private void AdresEkleme2_Load(object sender, EventArgs e)
        {
            
            FillListViewAdres();
        }
        void FillListViewAdres()
        {
            listView1.Items.Clear();
            List<Adres> adres = adresRepository.GetAdresByKisiID(selectedID);
            ListViewItem listViewItem;
            foreach (Adres item in adres)
            {
                listViewItem = new ListViewItem(item.AdresID.ToString());
                listViewItem.SubItems.Add(item.Sehir);
                listViewItem.SubItems.Add(item.Ilce);
                listViewItem.SubItems.Add(item.AdresDetay);
                listViewItem.SubItems.Add(item.KisiID.ToString());
                listView1.Items.Add(listViewItem);
            }
        }
        private void add(string Sehir, string Ilce, string AdresDetay)
        {
            String[] row = { Sehir, Ilce, AdresDetay };


            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            Adres adres = new Adres();
            adres.KisiID = selectedID;
            adres.Sehir = txtSehir.Text;
            adres.Ilce = txtİlçe.Text;
            adres.AdresDetay = txtAdresDetay.Text;
            
            adresRepository.InsertAdres(adres);
            FillListViewAdres();
            
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = listView1.SelectedItems[0];
            Adres adres = new Adres();
            adres.AdresID = int.Parse(listViewItem.SubItems[0].Text);
            adres.Sehir = txtSehir.Text;
            adres.Ilce = txtİlçe.Text;
            adres.AdresDetay = txtAdresDetay.Text;
            adresRepository.UpdateAdres(listViewItem.Index, adres);
            FillListViewAdres();

            //listView1.SelectedItems[0].SubItems[0].Text = txtSehir.Text;
            //listView1.SelectedItems[0].SubItems[1].Text = txtİlçe.Text;
            //listView1.SelectedItems[0].SubItems[2].Text = txtAdresDetay.Text;
            //txtSehir.Text = "";
            //txtİlçe.Text = "";
            //txtAdresDetay.Text = "";

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = listView1.SelectedItems[0];
            Adres adres = new Adres();
            adres.AdresID = int.Parse(listViewItem.SubItems[0].Text);
            adresRepository.DeleteAdres(adres, listViewItem.Index);
            FillListViewAdres();

            //listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
            //txtSehir.Text = "";
            //txtİlçe.Text = "";
            //txtAdresDetay.Text = "";
          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                //string select = (listView1.SelectedItems[0].Text);
                ListViewItem item = listView1.SelectedItems[0];
                txtSehir.Text = item.SubItems[1].Text;
                txtİlçe.Text = item.SubItems[2].Text;
                txtAdresDetay.Text = item.SubItems[3].Text;
            }
            else
            {
                txtSehir.Text = " ";
                txtİlçe.Text = "";
                txtAdresDetay.Text = "";
            }
        }
    }
}
