using HotelForm.Factory.Interface;
using HotelForm.Service.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelForm.View.Reporte
{
    public partial class frmReporte : Form
    {
        IFactoryService factory;
        IFacturaService service;
        public frmReporte(IFactoryService factory)
        {
            InitializeComponent();
            this.factory = factory;
            service = factory.CreateFacturaService();

            btnBuscar.Click += BtnBuscar_Click;
            this.Load += FrmReporte_Load;
        }

        private void FrmReporte_Load(object? sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "HotelForm.View.Reporte.ClientesAnuales.rdlc";
        }

        private async void BtnBuscar_Click(object? sender, EventArgs e)
        {
            var list = await service.GetReporte(dateTimePicker1.Value.Year);
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Posicion", Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("Cliente", Type.GetType("System.String")));
            dt.Columns.Add(new DataColumn("Total", Type.GetType("System.Decimal")));
            dt.Columns.Add(new DataColumn("Noches", Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("Promedio", Type.GetType("System.Decimal")));
            foreach (var item in list)
            {
                dt.Rows.Add(item.Posicion, item.Cliente, item.Total, item.Noches, item.Promedio);
            }
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("año", dateTimePicker1.Value.Year.ToString()));
            reportViewer1.RefreshReport();
        }
    }
}
