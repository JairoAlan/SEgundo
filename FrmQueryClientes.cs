using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Jairo
{
    public partial class FrmQueryClientes : Form
    {
        public FrmQueryClientes()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmQueryClientes_Load(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            // llenar el combo de Rep Ventas 
            cmbClientes.DataSource = objeto.LeerDatos("Select distinct Num_Rep from Clientes");
            cmbClientes.DisplayMember = "Num_Rep";

            // Agregando los Operadores utilizanco el metodo AddRange()
            cmbOperadores.Items.AddRange(new string[] { "=", "<", "<=",  ">", ">=" });

            // Establecer un valor predeterminado seleccionado
            cmbOperadores.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnListadoClientes.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "Select Num_Clie, Empresa from Clientes";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                // Desactivar el Checkbob que fue seleccionado
                rbtnListadoClientes.Checked = false;
                // Habilitar el checkbox
                rbtnListadoClientes.Enabled = true;
            }
            else if (rbnClie_Rep.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "Select * from Clientes where Num_Rep = '"+ cmbClientes.Text + "' ";
                objeto.llenargrid(cadenaSQL,dataGridView1);
                rbnClie_Rep.Checked = false;
                rbnClie_Rep.Enabled = true;
            }
            else if (rbtnClie_Lim.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "Select * from Clientes where Lim_Cred "+ cmbOperadores.Text + " '"+ txtClieExi.Text + "' ";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                rbtnClie_Lim.Checked = false;
                rbtnClie_Lim.Enabled = true;
            }
        }
    }
}
