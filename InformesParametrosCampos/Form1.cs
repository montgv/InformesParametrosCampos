using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformesParametrosCampos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string marcaBuscar = this.tbMarcaBuscar.Text;

            this.clientesCochesTableAdapter.Fill(this.dataSetConcesionario.ClientesCoches, marcaBuscar);

            this.reportViewer1.RefreshReport();
        }
    }
}
