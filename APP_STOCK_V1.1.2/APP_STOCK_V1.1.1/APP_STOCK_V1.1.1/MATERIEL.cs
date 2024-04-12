using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_STOCK_V1._1._1
{
    public partial class MATERIEL : Form
    {
        private int id_Materail;
        private string typ_Oper;
        DataTable dt;

        public int Id_Materail
        {
            get { return id_Materail; }
            set { id_Materail = value; }
        }
        public string Typ_Oper
        {
            get { return typ_Oper; }
            set { typ_Oper = value; }
        }
        public MATERIEL()
        {
            InitializeComponent();
        }
        public MATERIEL(int id_mater, string type_operation)
        {
            InitializeComponent();
            this.Id_Materail = id_mater;
            this.Typ_Oper = type_operation;
        }

        private void MATERIEL_Load(object sender, EventArgs e)
        {

            if (Typ_Oper == "NOUVEAU MATÉRIEL   : ")
            {
                button1_AJ_MODIF.ButtonText = "ajouter";
            }


            dt = new DataTable();
            if (Typ_Oper == "INFORMATION  : ")
            {
                button1_AJ_MODIF.ButtonText = "information";
                button1_AJ_MODIF.Enabled = false;
                button1_AJ_MODIF.Padding = new Padding(5, 5, 5,5); 
                button1_AJ_MODIF.Padding = new Padding(180,10,180,5); 

                button1_AJ_MODIF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
              //  button1_AJ_MODIF.ButtonText = "test ";




                radioButton1_SON.Enabled = radioButton_LUMIE.Enabled =
                    radioButton_VIDEO.Enabled = radioButton_cable.Enabled =
                    radioButton_DIVERS.Enabled = radioButton_AUTILLAGE.Enabled =
                       radioButton_DECOR.Enabled = false; 
                dt = M_GLOBAL.Requet_Table("select * from MATERIL_IH where id =" + Id_Materail + " ");
            }

            else if (Typ_Oper == "MODIFICATION   : ")
            {
                button1_AJ_MODIF.ButtonText = "Modifier"; 
                dt = M_GLOBAL.Requet_Table("select * from MATERIL_IH where id =" + Id_Materail + " ");
            }


            groupBox_ajou_supp.Text = Typ_Oper;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;

             

            rempleTB();




        }
        // end load    milou med



        private void button1_insert_Click(object sender, EventArgs e)
        {

            int qttInit = 0, qttReel = 0, qttSort = 0, qttEnt = 0;
            string desig = textbox1_desig.Text.Trim(),
                categori = TYPE_RADIO(),
                empl = Textbox_Emplace.Text.Trim(),   
                descrip = Textbox_descrip.Text.Trim(),
                msgErro = "";

            if (desig == "") msgErro = "Designation est vide  \n";
            if (empl == "") msgErro += "Type est vide \n";
            if (descrip == "") msgErro += "Description  est vide \n";
            if (Textbox_Qtt_Init.Text.Trim() == "") msgErro += "Quentite  est vide \n";

            if (ImageDATA == null && msgErro != "")
            {
                MessageBox.Show(msgErro, "ERROR !!! ", MessageBoxButtons.OK,
                 MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
             try
            {
                try
                {
                    qttInit = int.Parse(Textbox_Qtt_Init.Text.Trim());
                    qttReel = int.Parse(Textbox_Qtt_Reel.Text.Trim());
                    qttSort = int.Parse(Textbox_Qtt_SORTI.Text.Trim());
                    qttEnt = 0;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur dans champ qtt veuillez saisir un nombre", "AJOUTER", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }



                if (Typ_Oper == "NOUVEAU MATÉRIEL   : ")
                {
                    M_GLOBAL.Insert_File_Images("insert", Id_Materail, desig, categori, qttInit, qttReel,
                        qttSort, qttEnt, empl, descrip, ImageDATA);
                    msgErro = "LE NOUVEAU MATÉRIEL EST BIEN AJOUTE";
                }
                if (Typ_Oper == "MODIFICATION   : ")
                {
                    M_GLOBAL.Insert_File_Images("update", Id_Materail, desig , categori , qttInit , qttReel, 
                        qttSort,qttEnt, empl, descrip, ImageDATA);
                    msgErro = "Bien modifer";
                }


          //      MessageBox.Show(msgErro,Typ_Oper, MessageBoxButtons.OK,  MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            catch (Exception)
            {
                MessageBox.Show("Errour d ajouter ", "ERROR !!! ", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }


        }

        private void MATERIEL_FormClosing(object sender, FormClosingEventArgs e)
        {
            //  Application.Exit();
        }

        string TYPE_RADIO()
        {
            string rd = "DIVERS";
            if (radioButton1_SON.Checked) rd = "SON";
            if (radioButton_cable.Checked) rd = "cablage";
            if (radioButton_VIDEO.Checked) rd = "VIDEO";
            if (radioButton_LUMIE.Checked) rd = "LUMIERE";
            if (radioButton_AUTILLAGE.Checked) rd = "autillage";
            if (radioButton_DECOR.Checked) rd = "decor";
            return rd;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        void rempleTB()
        {
            if (Typ_Oper == "NOUVEAU MATÉRIEL   : ") return;


            if (Typ_Oper == "INFORMATION  : ")
            {
                textbox1_desig.Enabled = Textbox_descrip.Enabled =
                    Textbox_Emplace.Enabled = Textbox_Qtt_Init.Enabled =
                    Textbox_Qtt_ENTRE.Enabled = Textbox_Qtt_SORTI.Enabled = 
                    Textbox_Qtt_Reel.Enabled = false;

                textbox1_desig.ForeColor = Color.Red;

                Textbox_Qtt_Reel.BackColor = Textbox_Qtt_SORTI.BackColor = Textbox_Qtt_ENTRE.BackColor = Textbox_Qtt_Init.BackColor = Textbox_Emplace.BackColor =
                    Textbox_descrip.BackColor = textbox1_desig.BackColor = Color.LightGray;
                
                btn_chemImg.Visible = false;
            }
            if (dt.Rows.Count == 0) return;

            textbox1_desig.Text = dt.Rows[0]["disg"].ToString();

            Textbox_Qtt_Init.Text = dt.Rows[0]["qttInit"].ToString();
            Textbox_Qtt_Reel.Text = dt.Rows[0]["qttReel"].ToString();
            Textbox_Qtt_SORTI.Text = dt.Rows[0]["qttSort"].ToString();
            Textbox_Qtt_ENTRE.Text = dt.Rows[0]["qttEntr"].ToString();

            Textbox_descrip.Text = dt.Rows[0]["descrep"].ToString();
            Textbox_Emplace.Text = dt.Rows[0]["emplacem"].ToString();

            try
            {

                Byte[] data = new Byte[0];
                data = (Byte[])(dt.Rows[0]["image_"]);
                MemoryStream mem = new MemoryStream(data);
                pictureBox1.BackgroundImage = Image.FromStream(mem);

                label_PasDimage.Visible = false;
            }
            catch (Exception)
            { 
                label_PasDimage.Visible = true;
                pictureBox1.BackgroundImage = (null);
            }



            var typ = dt.Rows[0]["categore"].ToString();
            radioButton_DIVERS.Checked = true;
            if (typ == "SON") radioButton1_SON.Checked = true;
            if (typ == "cablage") radioButton_cable.Checked = true;
            if (typ == "VIDEO") radioButton_VIDEO.Checked = true;
            if (typ == "LUMIERE") radioButton_LUMIE.Checked = true;
            if (typ == "decor") radioButton_DECOR.Checked = true;
            if (typ == "autillage") radioButton_AUTILLAGE.Checked = true;
        }


        private void bunifuThinButton_chemImg_Click(object sender, EventArgs e)
        {
            image_TO_Data();
        }

        //Insert 
        byte[] ImageDATA = null;

        public void image_TO_Data()
        {
            try
            {
                OpenFileDialog fi = new OpenFileDialog();
                fi.CheckFileExists = true;
                fi.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif|(Tous)|*.*";


                if (fi.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                string filePath = fi.FileName;
                
                ImageDATA = File.ReadAllBytes(filePath);
                
                MemoryStream mem = new MemoryStream(ImageDATA);
                pictureBox1.BackgroundImage = Image.FromStream(mem);

                label_PasDimage.Visible = false;

                MessageBox.Show("L image Bien Ajouter", "INFO !!! ", MessageBoxButtons.OK,
                  MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            catch
            {
                MessageBox.Show("Errour d ajouter l image", "ERROR !!! ", MessageBoxButtons.OK,
                 MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); 
                label_PasDimage.Visible = true;

            }
        }
    }
}
