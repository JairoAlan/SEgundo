﻿using System;
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
    public partial class FrmActualizarOficinas : Form
    {
        public FrmActualizarOficinas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string cadenaSQL = "";
            cadenaSQL = "ActualizarOficinas '" + txtOficina.Text + "','" + txtCiudad.Text + "','" + txtRegion.Text + "','" + txtNum_Rep_Dir.Text + "','" + txtObjetivo.Text + "','" + txtVentas.Text + "'";

            try
            {
                objeto.ejecutar(cadenaSQL);
                MessageBox.Show("La Oficina se agrego correctamente!");
            }
            catch (Exception ex)
            {
                //Muestra el error en el mensaje para ver el error
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + cadenaSQL);
            }


            //Se limpian los objetos
            txtOficina.Text = "";
            txtCiudad.Text = "";
            txtRegion.Text = "";
            txtNum_Rep_Dir.Text = "";
            txtObjetivo.Text = "";
            txtVentas.Text = "";
        }
    }
}
