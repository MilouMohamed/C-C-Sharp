using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace APP_STOCK_V1._1._1
{
    public partial class ENTRE_SORTIR : Form
    {
        public ENTRE_SORTIR()
        {
            InitializeComponent();
        }

        DataGridViewTextBoxColumn col0_id = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn col1_typd = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn col2_disg = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn col3_qttStok = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn col3_qttStock = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn col3_qttReel = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn col3_qttEnt = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn col3_qttSort = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn col4_emplc = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn col5_desc = new DataGridViewTextBoxColumn();
        DataGridViewImageColumn col6_image = new DataGridViewImageColumn();

         

        DataTable dt;
        string lesIds = "";
        private void ENTRE_SORTIR_Load(object sender, EventArgs e)
        {
            radioButton1_ENTRE.Checked = true;


            DataBNGrid1.AutoGenerateColumns = false;
            DataBNGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataBNGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            col0_id.Name = "ID";
            col0_id.Width = 25;
            col0_id.HeaderText = "ID";
            col0_id.DataPropertyName = "id";

            col1_typd.Name = "categore";
            col1_typd.HeaderText = "categore";
            col1_typd.DataPropertyName = "categore";

            col2_disg.Name = "dis";
            col2_disg.HeaderText = "DÉSIGNATION";
            col2_disg.DataPropertyName = "disg";

            col3_qttStok.Name = "qttInit";
            col3_qttStok.HeaderText = "QEE INITIALE";
            col3_qttStok.DataPropertyName = "qttInit";

            col3_qttReel.Name = "qttReel";
            col3_qttReel.HeaderText = "QTT REELLE";
            col3_qttReel.DataPropertyName = "qttReel";

            col3_qttEnt.Name = "qttEntr";
            col3_qttEnt.HeaderText = "QTT ENTRÉE";
            col3_qttEnt.DataPropertyName = "qttEntr";


            col3_qttStock.Name = "qttStock";
            col3_qttStock.HeaderText = "qttStock";
            col3_qttStock.DataPropertyName = "qttStock";
            col3_qttStock.Visible = false;

            col3_qttSort.Name = "qttSort";
            col3_qttSort.HeaderText = "QTT SORTIE";
            col3_qttSort.DataPropertyName = "qttSort";

            col4_emplc.Name = "emplc";
            col4_emplc.HeaderText = "EMPLACEMENT";
            col4_emplc.DataPropertyName = "emplacem";

            col5_desc.Name = "desc";
            col5_desc.DataPropertyName = "descrep";
            col5_desc.HeaderText = "DESCRIPTION";

            /* col6_image.Name = "image";
             col6_image.HeaderText = "IMAGE";
             col6_image.DataPropertyName = "image_";*/

            DataBNGrid1.Columns.AddRange(col0_id, col2_disg, col1_typd, col3_qttStok, col3_qttReel, col3_qttSort, col3_qttEnt, col4_emplc, col5_desc, col3_qttStock);





            Dropdown_categore.AddItem("TOUS");
            Dropdown_categore.AddItem("SON");
            Dropdown_categore.AddItem("VIDEO");
            Dropdown_categore.AddItem("LUMIERE");
            Dropdown_categore.AddItem("CABLAGE");
            Dropdown_categore.AddItem("AUTILLAGE");
            Dropdown_categore.AddItem("DECOR");
            Dropdown_categore.AddItem("DIVERS");

            /*  dt = new DataTable();
             dt = M_GLOBAL.Requet_Table("select * from MATERIL_IH ");
             DataBNGrid1.DataSource = dt;
             */
            Dropdown_categore.selectedIndex = 0;
            /*  if (dt.Rows.Count > 0)
                  DataBNGrid1.SelectedRows[0].Selected = true;
                 */


            col0_id.Width = 35;
            col2_disg.Width = 200;
            col1_typd.Width = 75;

            col3_qttEnt.Width = 45;
            col3_qttReel.Width = 45;
            col3_qttSort.Width = 45;
            col3_qttStok.Width = 45;

            col4_emplc.Width = 120;

            coloreCellesDGV();
             
            label_DISIGNATION.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void DataBNGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int qttSort, rowindex = DataBNGrid1.CurrentRow.Index;

            qttSort = int.Parse(dt.Rows[rowindex]["qttSort"].ToString().Trim());
             

            label8QTT_STOCK.Text = label9QTT_STOCK.Text = label9QTT_STOCK.Text = DataBNGrid1.Rows[rowindex].Cells["qttReel"].Value.ToString().Trim();

            remplirDropDown("E", qttSort);
        }

        private void DataBNGrid1_Click(object sender, EventArgs e)
        { 
            pictureBox1.BackgroundImage = (null);
            label_PasDimage.Visible = true;
            string iidd = DataBNGrid1.CurrentRow.Cells["ID"].Value.ToString().Trim();
            int qtt_Stock, qttSort, rowindex = DataBNGrid1.CurrentRow.Index;
             

            qtt_Stock = int.Parse(DataBNGrid1.Rows[rowindex].Cells["qttReel"].Value.ToString().Trim());
            qttSort = int.Parse(DataBNGrid1.Rows[rowindex].Cells["qttSort"].Value.ToString().Trim()); 
            label9QTT_STOCK.Text = label8QTT_STOCK.Text = label9QTT_STOCK.Text = 
                DataBNGrid1.Rows[rowindex].Cells["qttReel"].Value.ToString().Trim();
            // label_DE_LISTbOX.Text = dt.Rows[rowindex]["id"] + "ID //R"+ rowindex+" celle=";

            //  if (radioButton1_ENTRE.Checked)
            remplirDropDown("E", qttSort);

            //  if (radioButton_SORTIR.Checked)
            remplirDropDown("S", qtt_Stock);

            try
            {
                int index = DataBNGrid1.CurrentCell.RowIndex;
            //    qtt_Entr_Sorti(dt, iidd);
                label_DISIGNATION.Text = dt.Rows[index]["disg"].ToString().ToUpper();
                label_DISIGNATION.TextAlign = ContentAlignment.MiddleCenter;


                Byte[] data = new Byte[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (iidd == dt.Rows[i]["ID"].ToString())
                    {
                        data = (Byte[])(dt.Rows[i]["image_"]);
                        break;
                    }
                }


                MemoryStream mem = new MemoryStream(data);
                pictureBox1.BackgroundImage = Image.FromStream(mem);
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;


                label_PasDimage.Visible = false;
            }
            catch (Exception)
            {
            }

        }

        //Entre sortie 
      /*  void qtt_Entr_Sorti(DataTable dttt, string iddd)
        {
            for (int i = 0; i < dttt.Rows.Count; i++)
            {
                if (iddd == dt.Rows[i]["ID"].ToString())
                {
                 //   label1.Text = iddd + "mrd ";

                }
            }
        }*/



        void remplirDropDown(string type, int nbr)
        {

            //  label1.Text = type;
            if (type == "E")
            {

                bunifuDropdown1_ENTRE.Clear();
                bunifuDropdown1_ENTRE.AddItem("Autre");

                for (int i = 1; i <= nbr; i++)
                {
                    bunifuDropdown1_ENTRE.AddItem(i + "");
                }
            }
            if (type == "S")
            {
                bunifuDropdown1_SORTI.Clear();
                bunifuDropdown1_SORTI.AddItem("Autre");

                for (int i = 1; i <= nbr; i++)
                {
                    bunifuDropdown1_SORTI.AddItem(i + "");
                }
            }
        }

        private void bunifuDropdown1_ENTRE_onItemSelected(object sender, EventArgs e)
        {
            tb_ENTRE.Enabled = false;
            tb_ENTRE.Text = bunifuDropdown1_ENTRE.selectedValue;
            if (bunifuDropdown1_ENTRE.selectedValue.ToString() == "Autre")
            {
                tb_ENTRE.Enabled = true;
                tb_ENTRE.Text = "00";
            }

        }

        private void radioButton1_ENTRE_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_SORTI.Enabled = groupBox_Entre.Enabled = false;

            if (radioButton_SORTIR.Checked) groupBox_SORTI.Enabled = true;
            if (radioButton1_ENTRE.Checked) groupBox_Entre.Enabled = true;
        }

        private void bunifuDropdown1_SORTI_onItemSelected(object sender, EventArgs e)
        {
            tb_Sortie.Enabled = false;
            tb_Sortie.Text = bunifuDropdown1_SORTI.selectedValue;


            if (bunifuDropdown1_SORTI.selectedValue.ToString() == "Autre")
            {
                tb_Sortie.Enabled = true;
                tb_Sortie.Text = "00";
            }
        }




        private void bunifuDropdown_categore_onItemSelected(object sender, EventArgs e)
        {
            string reqt = "select * from MATERIL_IH  ;";

            /*  pictureBox1.BackgroundImage = (null);
              label_PasDimage.Visible = true;*/

            if (Dropdown_categore.selectedValue != "TOUS")
                reqt = "select * from MATERIL_IH where categore='" + Dropdown_categore.selectedValue + "' ;";


            dt = new DataTable();
            dt = M_GLOBAL.Requet_Table(reqt);
            DataBNGrid1.DataSource = dt;

            coloreCellesDGV();

        }

        void coloreCellesDGV()
        {
            int qttStok = 0, qttReel = 0, i;

            if (DataBNGrid1.Rows.Count > 0)
                for (i = 0; i < DataBNGrid1.Rows.Count; i++)
                {
                    try
                    {
                        qttStok = int.Parse(DataBNGrid1.Rows[i].Cells["qttStock"].Value.ToString().Trim());
                        qttReel = int.Parse(DataBNGrid1.Rows[i].Cells["qttReel"].Value.ToString().Trim());

                        if (qttStok < qttReel)
                            DataBNGrid1.Rows[i].Cells["qttReel"].Style.BackColor = Color.Red;
                    }
                    catch (Exception)
                    { }

                }
        }




        private void BTN_SORToK_Click(object sender, EventArgs e)
        {
            /////
            int qtEntr = 0, qtSort = 0, qttInit = 0, qttReel = 0, qttStok = 0, iidd = 0, entr_TXB = 0, sorti_TXB = 0;
            int qtEntrDBc = 0 , qtSortDBc = 0 ;

            try
            {
                entr_TXB = int.Parse(tb_ENTRE.Text.ToString().Trim());
                sorti_TXB = int.Parse(tb_Sortie.Text.ToString().Trim());
            }
            catch (Exception) { }


            try
            {
                iidd = int.Parse(DataBNGrid1.CurrentRow.Cells["ID"].Value.ToString().Trim());

                if (lesIds == "") lesIds = "" + iidd; else lesIds += "," + iidd;


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (iidd.ToString().Trim() == dt.Rows[i]["ID"].ToString().Trim())
                    { 
                        qttInit = int.Parse(DataBNGrid1.CurrentRow.Cells["qttInit"].Value.ToString().Trim());
                        qttReel = int.Parse(DataBNGrid1.CurrentRow.Cells["qttReel"].Value.ToString().Trim());  
                        qtSort = int.Parse(DataBNGrid1.CurrentRow.Cells["qttSort"].Value.ToString().Trim()); 
                        qttStok = int.Parse(DataBNGrid1.CurrentRow.Cells["qttStock"].Value.ToString().Trim()); 

                        qtSortDBc = qtSort; 
                        qtEntrDBc = int.Parse(DataBNGrid1.CurrentRow.Cells["qttEntr"].Value.ToString().Trim());


                        qtSort = qtSort + sorti_TXB;

                        qtSort = qtSort - qtEntr;

                        qttReel = qttStok - qtSort;

                        break;
                    }
                }

                 

                string req = "";

                #region SORTIE
                if (radioButton_SORTIR.Checked)
                {

                    req = "";
                    if (qttReel < 0)
                    {
                        DialogResult msb = MessageBox.Show("ATTENTION LE NOMBRE DES MATERIELS ENTRANTS N EST PAS LE MEME DANS L ETATS INITIALE", "ATTENTION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
                        if (DialogResult.OK != msb) return;
                    }
                    req = "update MATERIL_IH SET qttSort='" + qtSort + "' ,qttEntr='0', qttReel='" + qttReel + "'   where  id=" + iidd;

                    M_GLOBAL.Requet_Insert_Update(req);
                }
                #endregion

                string val = Dropdown_categore.selectedValue.ToString().Trim().ToUpper(); 

                if (val == "" || val == "TOUS")
                {
                    req = "select * from MATERIL_IH ";
                }
                else req = "select * from MATERIL_IH where categore='" + val + "' ; ";

                DataTable dt2 = new DataTable();
                dt2= M_GLOBAL.Requet_Table(req);
                DataBNGrid1.DataSource = dt2;
                coloreCellesDGV();

                 
                int vaal = Dropdown_categore.selectedIndex;
                Dropdown_categore.selectedIndex = vaal;


            }
            catch (Exception)
            {
                MessageBox.Show("Pas de donnees numerique  dans le champ !!!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private void btn_ENTRoK_Click_2(object sender, EventArgs e)
        {
            int qtEntrDBc = 0, qtEntrDB = 0, qtSortDBc = 0, qtSortDB = 0, qttInitDB = 0, qttReelDB = 0, qttStokDB = 0, iidd = 0, entr_TXB = 0;
       

            try
            {
                entr_TXB = int.Parse(tb_ENTRE.Text.ToString().Trim());
            }
            catch (Exception) { }
            try
            {
                iidd = int.Parse(DataBNGrid1.CurrentRow.Cells["ID"].Value.ToString().Trim());
                if (lesIds == "") lesIds = "" + iidd; else lesIds += "," + iidd;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (iidd.ToString().Trim() == dt.Rows[i]["ID"].ToString().Trim())
                    {

                        qttInitDB = int.Parse(DataBNGrid1.CurrentRow.Cells["qttInit"].Value.ToString().Trim());
                         qttReelDB = int.Parse(DataBNGrid1.CurrentRow.Cells["qttReel"].Value.ToString().Trim());
                        qtSortDBc = qtSortDB = int.Parse(DataBNGrid1.CurrentRow.Cells["qttSort"].Value.ToString().Trim());
                        qttStokDB = int.Parse(DataBNGrid1.CurrentRow.Cells["qttStock"].Value.ToString().Trim());
                        qtEntrDBc = int.Parse(DataBNGrid1.CurrentRow.Cells["qttEntr"].Value.ToString().Trim());

                        


                        qtEntrDB = entr_TXB ;


                        qtSortDB = qtSortDB - qtEntrDB;

                        if (qtSortDB < 0) qtSortDB = 0;

                        qttReelDB = qttStokDB - qtSortDB;

                        break;
                    }
                }


                string req = "";
 
                #region ENTRE 
                if (radioButton1_ENTRE.Checked)
                {

                    if (qttReelDB > qttStokDB)
                    {
                        DialogResult msb = MessageBox.Show("ATTENTION LE NOMBRE DES MATERIELS ENTRANTS N EST PAS LE MEME DANS L ETATS INITIALE", "ATTENTION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
                        if (DialogResult.OK != msb) return;
                    }
                    req = "update MATERIL_IH SET qttEntr='" + qtEntrDB + "' , qttSort='" + qtSortDB + "', qttReel='" + qttReelDB + "'   where  id=" + iidd;

                    M_GLOBAL.Requet_Insert_Update(req);
                }
                #endregion
               

              string val = Dropdown_categore.selectedValue.ToString().Trim().ToUpper(); ;
                if(val == "" || val == "TOUS")
                {
                    req = "select * from MATERIL_IH ";
                }
                else req = "select * from MATERIL_IH where categore='" +val+ "' ; ";


                DataTable dt2 = new DataTable();
                dt2 = M_GLOBAL.Requet_Table(req);
                DataBNGrid1.DataSource = dt2;
                coloreCellesDGV();
                  

                int vaal = Dropdown_categore.selectedIndex; 
                Dropdown_categore.selectedIndex = vaal;
            }
            catch (Exception)
            {
                MessageBox.Show("Pas de donnees numerique  dans le champ !!!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Button_RAPORT_Click(object sender, EventArgs e)
        {
           // LES_RAPORTS lesRaports = new LES_RAPORTS("1,2");
            LES_RAPORTS lesRaports = new LES_RAPORTS( lesIds  );
            lesRaports.Show();
        }
    }
}
