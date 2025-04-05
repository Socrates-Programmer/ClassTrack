using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassTrack
{
    public partial class FrmDepartamentos : Form
    {
        public FrmDepartamentos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtNombre.Focus();
        }

        private void FrmDepartamentos_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Mostrar el formulario de menú
            menu menuForm = new menu();
            menuForm.Show();
        }
    }
}
