using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;
using Npgsql;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Informes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'empleadosDataSet.departamentos' Puede moverla o quitarla según sea necesario.
            //rellenarDataSet();
            //connectToDatabase("empleados", "SELECT * FROM departamentos");
            //this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
            importApiData(reporte);
            //reportViewer2.LocalReport.SetParameters(new ReportParameter(reportViewer2.LocalReport.GetParameters()[0].Name, "Reporte de empleados"));
            //reportViewer2.RefreshReport();
            
            reporte.RefreshReport();
        }
           
        private void rellenarDataSet(ReportViewer report)
        {
            List<Notas> notas = new List<Notas>()
            {
                new Notas{ Nombre = "Fernando", Nota = 0, Observaciones = "Descargando..."},
                new Notas{ Nombre = "Cristian", Nota = 6, Observaciones = "Participativo"},
                new Notas{ Nombre = "Alvaro", Nota = 4, Observaciones = "Pone un mala nota a Fernando"}
            };
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", notas);
            report.LocalReport.DataSources.Clear();
            report.LocalReport.DataSources.Add(reportDataSource);
        }

        private void connectToDatabase(ReportViewer report, string database, string sql)
        {
            string conection = "Server=localhost; Port=5432; User Id=postgres; Password=iesbelen; Database=" + database;
            using (NpgsqlConnection conn = new NpgsqlConnection(conection))
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                ReportDataSource reportDataSource = new ReportDataSource("datosEmpleados",dt);
                report.LocalReport.DataSources.Clear();
                report.LocalReport.DataSources.Add(reportDataSource);
            }
           
        }

        private void importApiData(ReportViewer report)
        {
            RestClient client = new RestClient("https://fakestoreapi.com/");
            RestRequest request =  new RestRequest("products");

            RestResponse response =  client.Execute(request); 
            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(response.Content);
            //Product productos = JsonSerializer.Deserialize<Product>(response.Content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            List<Rating> ratings = new List<Rating>();
            foreach (Product product in products)
            {
                ratings.Add(product.Rating);
            }

            report.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource1 = new ReportDataSource("DataSet1", products);
            report.LocalReport.DataSources.Add(reportDataSource1);
            ReportDataSource reportDataSource2 = new ReportDataSource("DataSet2", ratings);
            report.LocalReport.DataSources.Add(reportDataSource2);
            loadParameter(reporte, "Encabezado", this.Text+": Reporte de " + products[0].GetType());
        }

        private void loadParameter(ReportViewer report, string parameter, string value)
        {
            report.LocalReport.SetParameters(new ReportParameter(parameter, value));
        }
    }
}
