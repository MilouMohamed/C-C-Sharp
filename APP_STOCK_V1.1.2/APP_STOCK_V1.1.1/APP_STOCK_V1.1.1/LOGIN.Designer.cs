namespace APP_STOCK_V1._1._1
{
    partial class LOGIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.textbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBox_motdePasse = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.button1_CNX = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton_close = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_visiteur = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox1
            // 
            this.textbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.textbox1, "textbox1");
            this.textbox1.ForeColor = System.Drawing.Color.White;
            this.textbox1.HintForeColor = System.Drawing.Color.Empty;
            this.textbox1.HintText = "";
            this.textbox1.isPassword = false;
            this.textbox1.LineFocusedColor = System.Drawing.Color.Red;
            this.textbox1.LineIdleColor = System.Drawing.SystemColors.GrayText;
            this.textbox1.LineMouseHoverColor = System.Drawing.Color.White;
            this.textbox1.LineThickness = 3;
            this.textbox1.Name = "textbox1";
            this.textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBox_motdePasse
            // 
            this.textBox_motdePasse.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.textBox_motdePasse, "textBox_motdePasse");
            this.textBox_motdePasse.ForeColor = System.Drawing.Color.White;
            this.textBox_motdePasse.HintForeColor = System.Drawing.Color.Empty;
            this.textBox_motdePasse.HintText = "";
            this.textBox_motdePasse.isPassword = true;
            this.textBox_motdePasse.LineFocusedColor = System.Drawing.Color.Red;
            this.textBox_motdePasse.LineIdleColor = System.Drawing.Color.Gray;
            this.textBox_motdePasse.LineMouseHoverColor = System.Drawing.Color.White;
            this.textBox_motdePasse.LineThickness = 3;
            this.textBox_motdePasse.Name = "textBox_motdePasse";
            this.textBox_motdePasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::APP_STOCK_V1._1._1.Properties.Resources.Logo_incentive_Huse_vec_white__Converti_;
            this.bunifuImageButton1.ImageActive = null;
            resources.ApplyResources(this.bunifuImageButton1, "bunifuImageButton1");
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // button1_CNX
            // 
            this.button1_CNX.ActiveBorderThickness = 1;
            this.button1_CNX.ActiveCornerRadius = 20;
            this.button1_CNX.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button1_CNX.ActiveForecolor = System.Drawing.Color.White;
            this.button1_CNX.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button1_CNX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.button1_CNX, "button1_CNX");
            this.button1_CNX.ButtonText = "CONNEXION";
            this.button1_CNX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1_CNX.ForeColor = System.Drawing.Color.SeaGreen;
            this.button1_CNX.IdleBorderThickness = 1;
            this.button1_CNX.IdleCornerRadius = 20;
            this.button1_CNX.IdleFillColor = System.Drawing.Color.White;
            this.button1_CNX.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.button1_CNX.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button1_CNX.Name = "button1_CNX";
            this.button1_CNX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1_CNX.Click += new System.EventHandler(this.button_cnx_Click);
            // 
            // bunifuThinButton_close
            // 
            this.bunifuThinButton_close.ActiveBorderThickness = 1;
            this.bunifuThinButton_close.ActiveCornerRadius = 20;
            this.bunifuThinButton_close.ActiveFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton_close.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton_close.ActiveLineColor = System.Drawing.Color.Red;
            this.bunifuThinButton_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.bunifuThinButton_close, "bunifuThinButton_close");
            this.bunifuThinButton_close.ButtonText = "X";
            this.bunifuThinButton_close.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuThinButton_close.ForeColor = System.Drawing.Color.Red;
            this.bunifuThinButton_close.IdleBorderThickness = 1;
            this.bunifuThinButton_close.IdleCornerRadius = 20;
            this.bunifuThinButton_close.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton_close.IdleForecolor = System.Drawing.Color.Red;
            this.bunifuThinButton_close.IdleLineColor = System.Drawing.Color.Red;
            this.bunifuThinButton_close.Name = "bunifuThinButton_close";
            this.bunifuThinButton_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton_close.Click += new System.EventHandler(this.bunifuThinButton_close_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.bunifuGradientPanel1, "bunifuGradientPanel1");
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            this.bunifuGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseDown);
            this.bunifuGradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseMove);
            this.bunifuGradientPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // button_visiteur
            // 
            this.button_visiteur.ActiveBorderThickness = 1;
            this.button_visiteur.ActiveCornerRadius = 20;
            this.button_visiteur.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_visiteur.ActiveForecolor = System.Drawing.Color.White;
            this.button_visiteur.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_visiteur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.button_visiteur, "button_visiteur");
            this.button_visiteur.ButtonText = "VISITEUR";
            this.button_visiteur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_visiteur.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_visiteur.IdleBorderThickness = 1;
            this.button_visiteur.IdleCornerRadius = 20;
            this.button_visiteur.IdleFillColor = System.Drawing.Color.White;
            this.button_visiteur.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.button_visiteur.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button_visiteur.Name = "button_visiteur";
            this.button_visiteur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_visiteur.Click += new System.EventHandler(this.button_visiteur_Click);
            // 
            // LOGIN
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ControlBox = false;
            this.Controls.Add(this.button_visiteur);
            this.Controls.Add(this.bunifuThinButton_close);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.textBox_motdePasse);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.button1_CNX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGIN";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LOGIN_FormClosing);
            this.Load += new System.EventHandler(this.LOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 button1_CNX;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox_motdePasse;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton_close;
        private System.Windows.Forms.Panel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 button_visiteur;
    }
}