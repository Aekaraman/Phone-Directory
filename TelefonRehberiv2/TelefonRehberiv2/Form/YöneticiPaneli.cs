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
    public partial class YöneticiPaneli : Form
    {
        AdresRepository adresler;
        kisiRepository kisiRepository;
        int selectedid;
        public YöneticiPaneli()
        {
            InitializeComponent();
            kisiRepository = new kisiRepository();
        }


        private void txtArama_TextChanged(object sender, EventArgs e)
        
        {
            listView1.Items.Clear();
            if (rbSehirAra.Checked == true )
            {
                adresler.SehireGoreFiltre(txtArama.Text, selectedid);
                //string Filter = "[Sehir] Like'" + txtArama.Text + "%'";
                
                
            }
            else if(rbİlçeAra.Checked== true)
            {
                adresler.IlceyeGoreFiltre(txtArama.Text, selectedid);
                //string Filter = "[İlçe] Like'" + txtArama.Text + "%'";
            }
        }

        private void YöneticiPaneli_Load(object sender, EventArgs e)

        {
            rbSehirAra.Checked = true;
            List<Kisi> kisiEklemes = kisiRepository.GetKisiEklemes();
            lbKişiler.DataSource = kisiEklemes;
            lbKişiler.DisplayMember = "AD";
            lbKişiler.ValueMember = "KisiID";

            selectedid = (int)lbKişiler.SelectedValue;
            adresler = new AdresRepository(selectedid);
            FillListView();




            //SqlConnection connectionString = new SqlConnection("Server=.; Database=Deneme; uid=emre; pwd=12314758");
            //SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM KisiEkleme; SELECT * FROM AdresEkleme2", connectionString);
            //DataSet dataSet = new DataSet();
            //adapter.Fill(dataSet);
            //foreach (DataRow item in dataSet.Tables[0].Rows)
            //{
            //    lbKişiler.Items.Add(item["AD"]);

            //}
            //foreach (DataRow item in dataSet.Tables[1].Rows)
            //{
            //    listView1.Items.Add(item["Sehir"] + " " + item["Ilce"] + " " + item["AdresDetay"]);

            //}
        }
        void FillListView()
        {
            listView1.Items.Clear();
            List<Adres> adresList = adresler.GetAdresByKisiID(selectedid);
            ListViewItem listView;
            foreach (Adres item in adresList)
            {
                listView = new ListViewItem(item.Ilce);
                listView.SubItems.Add(item.Sehir);
                listView.SubItems.Add(item.AdresDetay);
                listView.SubItems.Add(item.KisiID.ToString());
                listView1.Items.Add(listView);

            }


        }
        private void lbKişiler_DoubleClick(object sender, EventArgs e)
        {
            selectedid = (int)lbKişiler.SelectedValue;
            adresler = new AdresRepository(selectedid);
            FillListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedid = (int)lbKişiler.SelectedValue;
            adresler = new AdresRepository(selectedid);
            FillListView();
        }
    }
}
