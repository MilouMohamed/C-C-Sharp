using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace APP_STOCK_V1._1._1
{
    public class M_GLOBAL
    { 

        public static SqlConnection cn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=IH_BASE;Integrated Security=True");
        public static SqlConnection cn_Dossie = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=IH_BASE;Integrated Security=True");
        static SqlCommand cmd = new SqlCommand();
        static SqlDataReader dr;
    

        public static DataTable Requet_Table(string requiet)
        {
            DataTable dt = new DataTable();
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = requiet;
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            cn.Close();
            return dt;
        }

        public static DataTable Requet_Table_Dossier(string requiet)
        {
            DataTable dt = new DataTable("med");
            cn_Dossie.Open();
            cmd.Connection = cn_Dossie;
            cmd.CommandText = requiet;
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            cn_Dossie.Close();
            return dt;
        }

        public static void Requet_Insert_Update(string requiet)
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = requiet;
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        //Insert 
        public static void InsertFileinToSqlDatabase_Images(string insertQuery)
        {
            try
            {
                OpenFileDialog fi = new OpenFileDialog();
                fi.CheckFileExists = true; 
                   fi.Filter =  "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif|(Tous)|*.*";


                if (fi.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                string filePath = fi.FileName;
                cn.Open();

                byte[] fileData = File.ReadAllBytes(filePath);
              


                // insertQuery = @"update MATERIL_IH set " + NomColone + " = @FileData  where Id=" + Id;

                // Insert  file Value into Sql Table by SqlParameter
                SqlCommand insertCommand = new SqlCommand(insertQuery, cn);
                SqlParameter sqlParam = insertCommand.Parameters.AddWithValue("@FileData", fileData);
                sqlParam.DbType = DbType.Binary;
                insertCommand.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Bien ajouter dons la base de donneés");
            }
            catch
            {
                MessageBox.Show("Erreur De Connexion ");
            }
        }

    }
}
