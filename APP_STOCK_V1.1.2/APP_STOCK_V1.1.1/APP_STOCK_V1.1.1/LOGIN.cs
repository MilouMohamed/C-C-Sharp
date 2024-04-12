using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_STOCK_V1._1._1
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }


        private void button_cnx_Click(object sender, EventArgs e)
        {
            string tb = textbox1.Text.Trim(), mdp = textBox_motdePasse.Text.Trim();
            if (tb != "admin" && mdp != "2020")
                return ;

            LIST_M list_m = new LIST_M("mode administrateur");
            // MATERIEL list_m = new MATERIEL(2);
            list_m.Tag = this;
            this.Hide();
            list_m.Show();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
          //  textbox1.Text = "admin";
          //  textBox_motdePasse.Text = "2020";

        }

        private void LOGIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // drage
        bool mousedown;
        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void bunifuGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            { 
                int mox = MousePosition.X- 165, moy = MousePosition.Y-18;
                this.SetDesktopLocation(mox, moy);
            }
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_visiteur_Click(object sender, EventArgs e)
        {
            LIST_M LM = new LIST_M("mode visiteur");
            LM.Tag = this; 
            this.Hide();
            LM.Show();
            
        }
    }
}
