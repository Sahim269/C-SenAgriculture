using AppSenAgriculture.Models;
using Microsoft.Reporting.WinForms;
using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenAgriculture.Views.Parametre
{
    public partial class frmPrintCategorie : Form
    {
        public frmPrintCategorie()
        {
            InitializeComponent();
        }

        private void frmPrintCategorie_Load(object sender, EventArgs e)
        {
            BdSenAgricultureContext db = new BdSenAgricultureContext();

            // Charger les données des clients depuis la base de données
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Report\\rptListCategorie.rdlc";

            var data = db.Categories.ToList();

            // Créer une source de données pour le rapport
            ReportDataSource rds = new ReportDataSource("DataSet1", data);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
