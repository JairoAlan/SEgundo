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
    public partial class FrmConsultaOficina : Form
    {
        public FrmConsultaOficina()
        {
            InitializeComponent();
        }

        private void FrmConsultaOficina_Load(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            // llena el combobox con el Numero de representante director
            cmbRepDirVen.DataSource = objeto.LeerDatos("Select distinct Num_Rep_Dir from Oficinas");
            cmbRepDirVen.DisplayMember = "Num_Rep_Dir";

            // Agregando los Operadores utilizanco el metodo AddRange()
            cmbOperadores.Items.AddRange(new string[] { "=", "<", "<=", ">", ">=" });

            // Establecer un valor predeterminado seleccionado
            cmbOperadores.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnListOfi.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string consultaSQL = "Select Oficina, Ciudad, Region from Oficinas;";
                objeto.llenargrid(consultaSQL, dataGridView1);
                // Desactivar el Checkbob que fue seleccionado
                rbtnListOfi.Checked = false;
                // Habilitar el checkbox
                rbtnListOfi.Enabled = true;
            }
            else if (rbtnOfiDir.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string consultaSQL = "Select * from Oficinas where Num_Rep_Dir = '"+ cmbRepDirVen.Text + "'";
                objeto.llenargrid(consultaSQL, dataGridView1);
                rbtnOfiDir.Checked = false;
                rbtnOfiDir.Enabled = true;
            }
            else if (rbtnObjetVentOfi.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string consultaSQL = "Select * from Oficinas where Objetivo " + cmbOperadores.Text + " '"+ txtObjOfi.Text + "' ";
                objeto.llenargrid(consultaSQL, dataGridView1);
                rbtnObjetVentOfi.Checked = false;
                rbtnObjetVentOfi.Enabled = true;
            }
        }
    }
}
