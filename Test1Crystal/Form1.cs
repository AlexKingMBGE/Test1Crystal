using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test1Crystal.ds1TableAdapters;

namespace Test1Crystal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ds1.Compra' Puede moverla o quitarla según sea necesario.
            this.compraTableAdapter.Fill(this.ds1.Compra);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRY1 Reporte = new CRY1();
            ds1 ds = new ds1();
            ListadoComprasTableAdapter adaptador= new ListadoComprasTableAdapter();

            adaptador.Fill(ds.ListadoCompras, Convert.ToInt32(this.comboBox1.SelectedValue));
            Reporte.SetDataSource(ds);
            this.crystalReportViewer1.ReportSource = Reporte;





        }
    }
}
