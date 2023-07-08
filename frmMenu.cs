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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            // Establecer el formulario principal como contenedor MDI
            this.IsMdiContainer = true;

        }

        private void altaInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciamos el formulario para usarlo
            FrmAltaProductos f = new FrmAltaProductos();
            // le indicamos que correra dentro del contenedor
            f.MdiParent = this;
            //Le indicamos que corra
            f.Show();
        }

        private void descontinuarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDescontinuarProd f = new frmDescontinuarProd();
            f.MdiParent = this;
            f.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void actualizarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciamos el formulario para usarlo.
            FrmActualizarProducto f = new FrmActualizarProducto();
            //le indicamos que corra dentro del contenedor
            f.MdiParent = this;
            //Le indicamos que corra
            f.Show();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciamos el formulario para usuarlo.
            FrmEliminar f = new FrmEliminar();
            // le indicamos que corra dentro del contenedor.
            f.MdiParent = this;
            //Le indicamos que corra
            f.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciamos el formulario para usarlo.
            frmpedido f = new frmpedido();
            // le indicamos que corra dentro del ordenador.
            f.MdiParent= this;
            // Le indicamos que corra
            f.Show();
        }

        private void consultarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciamos el formulario para usarlo.
            FrmQueryProductos f = new FrmQueryProductos();
            // le indicamos que corra dentro del ordenador.
            f.MdiParent = this;
            // Le indicamos que corra
            f.Show();
        }
    }
}
