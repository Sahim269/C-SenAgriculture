using AppSenAgriculture.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenAgriculture.Views.Compte
{
    public partial class frmPrintClient : Form
    {
        public frmPrintClient()
        {
            InitializeComponent();
        }

        private void frmPrintClient_Load(object sender, EventArgs e)
        {
            BdSenAgricultureContext db = new BdSenAgricultureContext();

            // Charger les données des clients depuis la base de données
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Report\\rptListClient.rdlc";

            var data = db.Clients.ToList();

            // Créer une source de données pour le rapport
            ReportDataSource rds = new ReportDataSource("DataSet1", data);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
