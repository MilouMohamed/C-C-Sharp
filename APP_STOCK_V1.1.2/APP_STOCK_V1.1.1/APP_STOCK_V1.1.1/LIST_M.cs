using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Windows.Forms;

namespace APP_STOCK_V1._1._1
{
    public partial class LIST_M : Form
    {
        private string id = "0";

        public string iid
        {
            get { return id; }
            set { id = value; }
        }

        public LIST_M()
        {
            InitializeComponent();
        }

        public LIST_M(string Id_User)
        {
            InitializeComponent();
            this.id = Id_User;
        }

        DataGridViewTextBoxColumn col0_id = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn col1_typd = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn col2_disg = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn col3_qttStok = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn col3_qttReel = new DataGridViewTextBoxColumn(); 
        DataGridViewTextBoxColumn col3_qttStock = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn col3_qttEnt = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn col3_qttSort = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn col4_emplc = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn col5_desc = new DataGridViewTextBoxColumn();
        DataGridViewImageColumn col6_image = new DataGridViewImageColumn();

        DataTable dt;

        private void LIST_M_Load(object sender, EventArgs e)
        {
            DataBNGrid1.AutoGenerateColumns = false;
            DataBNGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataBNGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            col0_id.Name = "ID";
            col0_id.HeaderText = "ID";
            col0_id.DataPropertyName = "id";

            col1_typd.Name = "categore";
            col1_typd.HeaderText = "CATEGORE";
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

            col3_qttSort.Name = "qttSort";
            col3_qttSort.HeaderText = "QTT SORTIE";
            col3_qttSort.DataPropertyName = "qttSort";


            col3_qttStock.Name = "qttStock";
            col3_qttStock.HeaderText = "qttStock";
            col3_qttStock.DataPropertyName = "qttStock";
            col3_qttStock.Visible = false;


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


            dt = new DataTable();
            dt = M_GLOBAL.Requet_Table("select * FROM MATERIL_IH ");

            DataBNGrid1.DataSource = dt;

            col0_id.Width = 35;
            col2_disg.Width = 200;
            col1_typd.Width = 75;

            col3_qttEnt.Width = 45;
            col3_qttReel.Width = 45;
            col3_qttSort.Width = 45;
            col3_qttStok.Width = 45;

            col4_emplc.Width = 120;

            label1_bjr.Text =  iid.ToUpper();
             

            if (dt.Rows.Count > 0)
                DataBNGrid1.SelectedRows[0].Selected=true;
             

            if(iid== "mode visiteur")
            {
                btn_ajouter.Enabled 
                    = btn_entre_sortir.Enabled 
                    = btn_modifier.Enabled 
                    = btn_suppreme.Enabled = false; 

            }
            coloreCellesDGV();
        }



        private void button_dxn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        //*  vert info material  */



        private void LIST_M_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_OnTextChange(object sender, EventArgs e)
        {
            DataBNGrid1.DataSource = M_GLOBAL.Requet_Table("select * from MATERIL_IH where disg like '%" + textBox1.text + "%' ");
        }

        private void DataBNGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void DataBNGrid1_Click(object sender, EventArgs e)
        {
            //pictureBox1.BackgroundImage = dt.Rows[e.RowIndex]["image_"];
            try
            {
                int index = DataBNGrid1.CurrentCell.RowIndex;
                string iidd = DataBNGrid1.CurrentRow.Cells["ID"].Value.ToString().Trim();

                label_DISIGNATION.Text = dt.Rows[index]["disg"].ToString();

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
                label_PasDimage.Visible = true;
                pictureBox1.BackgroundImage = (null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //INFOTMATION
            if (dt.Rows.Count > 0)
            {
                int idd, rowindex = DataBNGrid1.CurrentRow.Index;

                idd = int.Parse(dt.Rows[rowindex]["id"].ToString());

                MATERIEL materail_m = new MATERIEL(idd, "INFORMATION  : ");
                materail_m.Show();
            }
            else
            {
                MessageBox.Show("Pas de donnees ", "ATTENTION", MessageBoxButtons.OK,
        MessageBoxIcon.Information);
            }

        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            //modofication
            if (iid == "mode visiteur") return;
            if (dt.Rows.Count > 0)
            {

                int idd, rowindex = DataBNGrid1.CurrentRow.Index;

                idd = int.Parse(dt.Rows[rowindex]["id"].ToString().Trim());

                MATERIEL materail_m = new MATERIEL(idd, "MODIFICATION   : ");

                materail_m.Show();
            }
            else
            {
                MessageBox.Show("Pas de donnees", "ATTENTION", MessageBoxButtons.OK,
        MessageBoxIcon.Information);
            }
        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            // NOUVEAU MATÉRIEL   : 
            if (iid == "mode visiteur") return;
            MATERIEL materail_m = new MATERIEL(-1, "NOUVEAU MATÉRIEL   : ");

            materail_m.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            dt = M_GLOBAL.Requet_Table("select * FROM MATERIL_IH ;");

            textBox1.text = "";
            DataBNGrid1.DataSource = dt;
            coloreCellesDGV();
        }

        private void btn_suppreme_Click(object sender, EventArgs e)
        {
            if (iid == "mode visiteur") return;

                if (dt.Rows.Count > 0)
            {

                int idd, rowindex = DataBNGrid1.CurrentRow.Index;
                idd = int.Parse(dt.Rows[rowindex]["id"].ToString().Trim());

                DialogResult dr = MessageBox.Show("Vous voullez supprimer ce material.", "suppression", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                { M_GLOBAL.Requet_Table("delete  from MATERIL_IH where id =" + idd);
                    DataBNGrid1.DataSource = M_GLOBAL.Requet_Table("select * from MATERIL_IH ;");
                }

            }
            else
            {
                MessageBox.Show("Pas de donnees", "ATTENTION", MessageBoxButtons.OK,
        MessageBoxIcon.Information);
            }

        }

        private void BTN_SON_Click(object sender, EventArgs e)
        {
            dt = M_GLOBAL.Requet_Table("select * from MATERIL_IH where categore ='son'; ");
            textBox1.text = ""; 
            DataBNGrid1.DataSource = dt;
            coloreCellesDGV();

        }

        private void BTN_LUMIERE_Click(object sender, EventArgs e)
        { 
            dt = M_GLOBAL.Requet_Table("select * from MATERIL_IH where categore ='LUMIERE' ;");
            textBox1.text = "";
            DataBNGrid1.DataSource = dt;
            coloreCellesDGV();
        }

        private void BTN_VIDEO_Click(object sender, EventArgs e)
        {
            dt = M_GLOBAL.Requet_Table("select * from MATERIL_IH where categore ='video' ;");
            textBox1.text = "";
            DataBNGrid1.DataSource = dt;
            coloreCellesDGV();
        }

        private void BTN_CABLAGE_Click(object sender, EventArgs e)
        {
            dt = M_GLOBAL.Requet_Table("select * from MATERIL_IH where categore ='cablage' ;");
            textBox1.text = "";
            DataBNGrid1.DataSource = dt;
            coloreCellesDGV();
        }

        private void BTN_OUTILLAGE_Click(object sender, EventArgs e)
        {
            dt = M_GLOBAL.Requet_Table("select * from MATERIL_IH where categore ='autillage' ;");
            textBox1.text = "";
            DataBNGrid1.DataSource = dt;
            coloreCellesDGV();
        }

        private void BTN_DECOR_Click(object sender, EventArgs e)
        {
            dt = M_GLOBAL.Requet_Table("select * from MATERIL_IH where categore ='decor' ;");
            textBox1.text = "";
            DataBNGrid1.DataSource = dt;
            coloreCellesDGV();
        }

        private void BTN_DIVERS_Click(object sender, EventArgs e)
        {
            dt = M_GLOBAL.Requet_Table("select * from MATERIL_IH where categore ='DIVERS' ;");
            textBox1.text = "";
            DataBNGrid1.DataSource = dt;
            coloreCellesDGV();
        }

        private void BTN_entre_sortir_Click(object sender, EventArgs e)
        {
            if (iid == "mode visiteur") return;
            ENTRE_SORTIR entreSortie = new ENTRE_SORTIR( );
            entreSortie.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }




        void coloreCellesDGV()
        {
            //change la couleur de la zone qttReel > qttINIT 
            // qtt Reel et qtt initail
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
                    { 
                    }

                }
        }
        ////////////////////// 



    }
}
