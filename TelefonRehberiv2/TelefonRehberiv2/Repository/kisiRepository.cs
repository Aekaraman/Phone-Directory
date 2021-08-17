using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberiv2
{
    class kisiRepository
    {
        public  kisiRepository()
        {
            sqlConnection = new SqlConnection("Server=.; Database=Deneme; Trusted_Connection=True;");
            kisiTable = new DataTable();
            dataAdapter = new SqlDataAdapter("SELECT*FROM KisiEkleme", sqlConnection);
            dataAdapter.Fill(kisiTable);
            builder = new SqlCommandBuilder(dataAdapter);
        }

        SqlConnection sqlConnection;
        DataTable kisiTable;
        SqlDataAdapter dataAdapter;
        SqlCommandBuilder builder;
        public List<Kisi>GetKisiEklemes()
        {
            kisiTable.Clear();
            dataAdapter.Fill(kisiTable);
            List<Kisi> kisiler = new List<Kisi>();
            foreach (DataRow item in kisiTable.Rows)
            {
                kisiler.Add(
                    new Kisi
                    {
                        KisiID=(int)item["KisiID"],
                        AD=item["AD"].ToString(),
                        SOYAD=item["SOYAD"].ToString(),
                        TELEFON=item["TELEFON"].ToString()

                    });

            }
            return kisiler;

        }
        public void  InsertKisi(Kisi kisi)
        {
            DataRow dataRow = kisiTable.NewRow();
            dataRow["AD"] = kisi.AD;
            dataRow["SOYAD"] = kisi.SOYAD;
            dataRow["TELEFON"] = kisi.TELEFON;
            kisiTable.Rows.Add(dataRow);
            dataAdapter.Update(kisiTable);
        }
        public void UpdateKisi(Kisi kisi,int index)

        {
            dataAdapter.DeleteCommand = new SqlCommand("Update KisiEkleme Set AD=@AD, SOYAD=@SOYAD, TELEFON=@TELEFON Where KisiID=@KisiID", sqlConnection);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@KisiID", kisi.KisiID);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@AD", kisi.AD);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@SOYAD", kisi.SOYAD);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@TELEFON", kisi.TELEFON);
            DataRow dataRow = kisiTable.Rows[index];
            dataRow["AD"] = kisi.AD;
            dataRow["SOYAD"] = kisi.SOYAD;
            dataRow["TELEFON"] = kisi.TELEFON;

            dataAdapter.Update(kisiTable);


            //builder = new SqlCommandBuilder(dataAdapter);
            //DataRow dataRow = kisiTable.NewRow();
            ////dataRow["KisiID"] = KisiID;
            //dataRow["AD"] = kisi.AD;
            //dataRow["SOYAD"] = kisi.SOYAD;
            //dataRow["TELEFON"] = kisi.TELEFON;

            //dataAdapter.Update(kisiTable);

            //DataRow dataRow = kisiTable.Rows.Find(kisi);
            //dataRow["AD"] = kisi.AD;
            //dataRow["SOYAD"] = kisi.SOYAD;
            //dataRow["TELEFON"] = kisi.TELEFON;
            ////kisiTable.Rows(dataRow);
            //dataAdapter.Update(kisiTable);
        }
        public void DeleteKisi(Kisi kisi,int id)
        {
            dataAdapter.DeleteCommand = new SqlCommand("Delete From KisiEkleme Where KisiID=@KisiID", sqlConnection);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@KisiID", kisi.KisiID);
            kisiTable.Rows[id].Delete();
            dataAdapter.Update(kisiTable);






            //builder = new SqlCommandBuilder(dataAdapter);
            //DataRow deleteRow = null;
            //foreach (DataRow item in kisiTable.Rows)
            //{
            //    if ((int)item["KisiID"] == id)
            //    {
            //        deleteRow = item;
            //        break;
            //    }
            //}
            //deleteRow.Delete();
            //kisiTable.Rows.Remove(deleteRow);
            //dataAdapter.Update(kisiTable);
        }
        public List<Kisi> SearchKisi(string rowFilter)

        {
            kisiTable.Rows.Clear();
            dataAdapter.SelectCommand = new SqlCommand("Select *From KisiEkleme Where AD LIKE '" +rowFilter+ "%'", sqlConnection);
            dataAdapter.Fill(kisiTable);
            List<Kisi> kisiler = new List<Kisi>();
            foreach (DataRow item in kisiTable.Rows)
            {
                kisiler.Add(
                    new Kisi
                    {
                        KisiID = (int)item["KisiID"],
                        AD = item["AD"].ToString(),
                        SOYAD = item["SOYAD"].ToString(),
                        TELEFON = item["TELEFON"].ToString()

                    });
               
            }

            return kisiler;
        }

             
        
    }
 
}
