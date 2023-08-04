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
    public partial class FrmConsultaRepVentas : Form
    {
        public FrmConsultaRepVentas()
        {
            InitializeComponent();
        }

        private void FrmConsultaRepVentas_Load(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            // llenar el comboBox de Oficinas.
            cmbOficinas.DataSource = objeto.LeerDatos("Select Oficina from Oficinas");
            cmbOficinas.DisplayMember = "Oficina";

            // Agregando los Operadores utilizanco el metodo AddRange()
            cmbOperadores.Items.AddRange(new string[] { "=", "<", "<=", ">", ">=" });

            // Establecer un valor predeterminado seleccionado
            cmbOperadores.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnListRepVen.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string consultaSQL = "Select Num_Rep, Nombre, Edad, Titulo, Oficina_Rep from Rep_Ventas";
                objeto.llenargrid(consultaSQL, dataGridView1);
                // Desactivar el Checkbob que fue seleccionado
                rbtnListRepVen.Checked = false;
                // Habilitar el checkbox
                rbtnListRepVen.Enabled = true;
            }
            else if (rbtnRepVen_Ofi.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string consultaSQL = "Select * from Rep_Ventas where Oficina_Rep = '"+ cmbOficinas.Text + "'";
                objeto.llenargrid(consultaSQL, dataGridView1);
                rbtnRepVen_Ofi.Checked = false;
                rbtnRepVen_Ofi.Enabled = true;
            }
            else if (rbtnCuoRepVent.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string consultaSQL = "Select * from Rep_Ventas where Cuota "+ cmbOperadores.Text +" '"+ txtRepCuota.Text +"' ";
                objeto.llenargrid(consultaSQL, dataGridView1);
                rbtnCuoRepVent.Checked = false;
                rbtnCuoRepVent.Enabled = true;
            }
        }
    }
}
