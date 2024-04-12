using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace APP_STOCK_V1._1._1
{
    class M_GLOBAL
    {


        public static SqlConnection cn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=IH_BASE;Integrated Security=True");
        public static SqlConnection cn_Dossie = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=IH_BASE;Integrated Security=True");
        static SqlCommand cmd = new SqlCommand();
        static SqlDataReader dr;


        public static DataTable Requet_Table(string requieT)
        {
            try
            {
                cn.Close();
            }
            catch (Exception)
            {
            }
            DataTable dt = new DataTable();
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = requieT;
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
            try
            {
                cn.Close();
            }
            catch (Exception)
            {
            }
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = requiet;
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        //Insert 

        //Insert 
        public static void Insert_File_Images(string typeRequrt, int ID, string disegn, string catagore, int qttInit, int qttReel, int qttEntr, int qttSort, string empl, string descrip, byte[] image__)
        {
            try
            {
                string MSG = "Bien ajouter dons la base de donneés",
                    QueryFIle = "update MATERIL_IH set disg=@desig, categore=@catagore , qttStock=@qttReel ,  qttInit=@qttInit, qttReel=@qttReel " +
                    ",qttSort=@qttSort, qttEntr=@qttEntr, emplacem=@empl  ,  descrep=@descrip  ,  image_=@ImageDATA  where id =@Id_Materail  ";

                if (typeRequrt == "update" && image__ == null)
                {
                    QueryFIle = "update MATERIL_IH set disg=@desig, categore=@catagore , qttStock=@qttReel , qttInit=@qttInit, qttReel=@qttReel " +
                        ",qttSort=@qttSort, qttEntr=@qttEntr,  emplacem=@empl  ,  descrep=@descrip     where id =@Id_Materail  ";
                }


                if (typeRequrt == "insert")
                {
                    QueryFIle = "insert into MATERIL_IH (disg ,categore , qttStock, qttInit,qttReel,qttSort ,qttEntr, emplacem ,descrep ,image_) " +
                        "values  (@desig , @catagore , @qttReel , @qttInit,  @qttReel ,@qttSort ,@qttEntr , @empl , @descrip , @ImageDATA   ) ";

                    if (image__ == null)
                    {
                        QueryFIle = "insert into MATERIL_IH (disg ,categore  ,qttStock, qttInit,qttReel,qttSort ,qttEntr, emplacem ,descrep ) " +
                            "values  (@desig , @catagore , @qttReel , @qttInit,  @qttReel ,@qttSort ,@qttEntr , @empl , @descrip  ) ";
                    }

                }



                cn.Open();
                cmd = new SqlCommand(QueryFIle, cn);
                if (typeRequrt != "insert")
                { cmd.Parameters.Add(new SqlParameter("@Id_Materail", ID)); }
                cmd.Parameters.Add(new SqlParameter("@desig", disegn));
                cmd.Parameters.Add(new SqlParameter("@catagore", catagore));
                cmd.Parameters.Add(new SqlParameter("@qttInit", qttInit));
                cmd.Parameters.Add(new SqlParameter("@qttReel", qttReel));
                cmd.Parameters.Add(new SqlParameter("@qttSort", qttSort));
                cmd.Parameters.Add(new SqlParameter("@qttEntr", qttEntr));
                cmd.Parameters.Add(new SqlParameter("@empl", empl));
                cmd.Parameters.Add(new SqlParameter("@descrip", descrip));
                // cmd.Parameters = Parameters.Parameters.AddWithValue("@FileData", fileData);
                // cmd.Parameters.DbType = DbType.Binary;
                if (image__ != null)
                    cmd.Parameters.Add(new SqlParameter("@ImageDATA", image__)).DbType = DbType.Binary;

                cmd.ExecuteNonQuery();
                cn.Close();


                MessageBox.Show(MSG);
            }
            catch
            {
                MessageBox.Show("Erreur De Connexion ");
                cn.Close();
            }
        }

    }
}
