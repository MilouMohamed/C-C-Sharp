using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions;
using System.Data.SqlClient;
using CrystalDecisions.Windows.Forms;

namespace APP_STOCK_V1._1._1
{
    public partial class LES_RAPORTS : Form
    {
        public LES_RAPORTS()
        {
            InitializeComponent();
        }

        private string _idS=""; 

        public string idS
        {
            get { return this._idS; }
            set { this._idS = value; }
        }
        

        public LES_RAPORTS(string idS_  )
        {
            InitializeComponent();
            this.idS = idS_; 
        }

        DataSet_CryslaReport ds = new DataSet_CryslaReport();
       
        private void LES_RAPORTS_Load(object sender, EventArgs e)
        {
            string rep = "select * from MATERIL_IH where qttSort !=0 or qttEntr != 0";
            if(this.idS != "")
            {
                rep  = "select * from MATERIL_IH  where id in(" + idS + ") ;";
            }

             CrystalReport1 cr = new CrystalReport1(); 

            cr.Database.Tables["DataTable1"].SetDataSource(M_GLOBAL.Requet_Table(rep));

            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = cr;
        }


        private void btn_Impremer_Click(object sender, EventArgs e)
        {

        }


        private void btnExport_Click(object sender, EventArgs e)
        {
          //  cr.ExportReport();
        }

        
    }
}
