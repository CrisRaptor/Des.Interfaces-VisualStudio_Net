using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformeCiudades
{
    public partial class Ciudades : Form
    {
        public List<Ciudad> listaCiudades { get; set; }
        public string Busqueda { get; set; }
        public bool CiudadesGrandes { get; set; }
        public string ZonaHoraria { get; set; }

        

        public Ciudades()
        {
            InitializeComponent();
        }

        private void Ciudades_Load(object sender, EventArgs e)
        {
            //Filtrar ciudades
            filtrarCiudades(listaCiudades);
            //Inserta parametros
            List<ReportParameter> reportParameters = new List<ReportParameter>()
            {
                new ReportParameter("ParametroHorario", "Zona Horaria: "+ZonaHoraria),
                new ReportParameter("ParametroCantidadCiudades", "Filas totales: "+listaCiudades.Count),
                new ReportParameter("ParametroSoloCiudadesGrandes", "Solo ciudades grandes: "+((CiudadesGrandes)?"Si":"No"))
            };
            cargarParametros(reportViewerCiudades, reportParameters);
            //Inserta datos
            cargarDatos(reportViewerCiudades, listaCiudades);
            this.reportViewerCiudades.RefreshReport();
        }

        private void cargarDatos(ReportViewer report, List<Ciudad> ciudades)
        {
            report.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource = new ReportDataSource("DataCiudad", ciudades);
            report.LocalReport.DataSources.Add(reportDataSource);
        }

        private void cargarParametros(ReportViewer report, List<ReportParameter> parametros)
        {
            //ParametroHorario
            report.LocalReport.SetParameters(parametros);
        }

        private void filtrarCiudades(List<Ciudad> ciudades)
        {
            if (Busqueda != null && Busqueda != "")
            {
                listaCiudades = (List<Ciudad>)listaCiudades.Where(item => item.Name.Equals(Busqueda)).ToList();
            }
            if (CiudadesGrandes)
            {
                listaCiudades = (List<Ciudad>)listaCiudades.Where(item => item.Population > 1000000).ToList();
            }
            if (ZonaHoraria != "America")
            {
                listaCiudades = (List<Ciudad>)listaCiudades.Where(item => item.Timezone.Equals(ZonaHoraria)).ToList();
            }
        }
    }
}
