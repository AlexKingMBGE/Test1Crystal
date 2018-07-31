using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test1Crystal.ds2TableAdapters;


namespace Test1Crystal
{
    public partial class frmreporte2 : Form
    {
        public frmreporte2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr2 Reporte = new cr2();
            ds2 dss = new ds2();
            ListadoComprasTableAdapter2 adaptador2 = new ListadoComprasTableAdapter2();
            
            
            adaptador2.Fill(dss.Listado_Compras,1);


            Reporte.SetDataSource(dss);
            this.crystalReportViewer1.ReportSource = Reporte;





        }
    }
}
