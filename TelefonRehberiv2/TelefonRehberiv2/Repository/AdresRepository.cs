using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberiv2
{
    class AdresRepository
    {
        int selectedID;
        public AdresRepository(int selectedID)
        {
            sqlConnection = new SqlConnection("Server=.; Database=Deneme; Trusted_Connection=True;");
            adresTable = new DataTable();
            dataAdapter = new SqlDataAdapter("SELECT*FROM AdresEkleme2", sqlConnection);
            dataAdapter.Fill(adresTable);
            builder = new SqlCommandBuilder(dataAdapter);
        }
        DataTable adresTable;
        SqlDataAdapter dataAdapter;
        SqlCommandBuilder builder;
        SqlConnection sqlConnection;
        public List<Adres> GetAdresByKisiID(int selectedid)
        {
            DataView view = new DataView();
            view.RowFilter = "KisiID =" + selectedid;
            List<Adres> adres = new List<Adres>();
            foreach (DataRow item in view)
            {
                adres.Add(
                new Adres
                {
                    AdresID = (int)item["AdresID"],
                    Sehir = item["Sehir"].ToString(),
                    Ilce = item["Ilce"].ToString(),
                    AdresDetay = item["AdresDetay"].ToString()

                });
            }
            return adres;
        }
        public List<Adres> GetAdres()
        {
            adresTable.Clear();
            dataAdapter.Fill(adresTable);
           
            List<Adres> adres = new List<Adres>();
            foreach (DataRow item in adresTable.Rows)
            {
                adres.Add(
                    new Adres
                    {
                        AdresID = (int)item["AdresID"],
                        Sehir = item["Sehir"].ToString(),
                        Ilce = item["Ilce"].ToString(),
                        AdresDetay = item["AdresDetay"].ToString(),
                        //KisiID = (int)item["KisiID"]
                    });

            }
            return adres;
        }

        public void InsertAdres(Adres adres)
        {
            //SqlCommand cmd = new SqlCommand("INSERT INTO AdresEkleme2(Sehir,Ilce,AdresDetay)"+ "VALUES(@Sehir,@Ilce,@AdresDetay)", sqlConnection);
            //cmd.Parameters.Add("@Sehir", SqlDbType.NVarChar, 50, "Sehir");
            //cmd.Parameters.Add("@Ilce", SqlDbType.NVarChar, 50, "Ilce");
            //cmd.Parameters.Add("@AdresDetay", SqlDbType.NVarChar, 250, "AdresDetay");
            //dataAdapter.InsertCommand = cmd;



            dataAdapter.InsertCommand = new SqlCommand("INSERT INTO AdresEkleme2 (Sehir, Ilce,AdresDetay,KisiID) " +
            "VALUES (@Sehir, @Ilce,@AdresDetay,@KisiID)", sqlConnection);
            dataAdapter.InsertCommand.Parameters.AddWithValue("Sehir",adres.Sehir);
            dataAdapter.InsertCommand.Parameters.AddWithValue("Ilce", adres.Ilce);
            dataAdapter.InsertCommand.Parameters.AddWithValue("AdresDetay", adres.AdresDetay);
            dataAdapter.InsertCommand.Parameters.AddWithValue("KisiID", adres.KisiID);
            DataRow dataRow = adresTable.NewRow();
            dataRow["Sehir"] = adres.Sehir;
            dataRow["Ilce"] = adres.Ilce;
            dataRow["AdresDetay"] = adres.AdresDetay;
            dataRow["KisiID"] = adres.KisiID;
            adresTable.Rows.Add(dataRow);
            dataAdapter.Update(adresTable);
        }

        public void UpdateAdres(int index, Adres adres)
        {
            builder = new SqlCommandBuilder(dataAdapter);
            DataRow dataRow = null;
            foreach ( DataRow item  in adresTable.Rows)

            {
                if ((int)(item["AdresID"]) == adres.AdresID)
                {
                    dataRow = item;
                    break;
                }

            }
            dataRow["KisiID"] = adres.KisiID;
            dataRow["Sehir"] = adres.Sehir;
            dataRow["Ilce"] = adres.Ilce;
            dataRow["AdresDetay"] = adres.AdresDetay;
            
            //adresTable.Rows.Add(dataRow);
            dataAdapter.Update(adresTable);

        }

        public void DeleteAdres(Adres adres, int index )
        {
            DataRow [] dataRows = adresTable.Select("AdresID=" + adres.AdresID);
            for (int i = 0; i < dataRows.Length; i++)
            {
                dataRows[i].Delete();
            }
            dataAdapter.Update(adresTable);
        }

        public List<Adres> IlceyeGoreFiltre(string Filter, int id)
        {
            adresTable.Rows.Clear();
            dataAdapter.SelectCommand = new SqlCommand("Select *From AdresEkleme2 Where KisiID=@KisiID and Ilce LIKE '" + Filter + "%'", sqlConnection);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@KisiID", id);
            dataAdapter.Fill(adresTable);
            List<Adres> adres = GetAdres();
            return adres;
        }
        public List<Adres> SehireGoreFiltre(string Filter, int id)
        {
            adresTable.Rows.Clear();
            dataAdapter.SelectCommand = new SqlCommand("Select *From AdresEkleme2 Where KisiID=@KisiID and Sehir LIKE '" + Filter + "%'", sqlConnection);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@KisiID", id);
            dataAdapter.Fill(adresTable);
            List<Adres> adres = GetAdres();
            return adres;
        }
    }
}
