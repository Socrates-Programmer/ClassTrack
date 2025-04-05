using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ClassTrack
{
    public partial class FrmAsignaturas : Form
    {
        public FrmAsignaturas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Limpiar campos para nueva asignatura
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // TODO: Obtener la fila seleccionada del DataGridView
            // y llenar los campos para editar
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // TODO: Confirmar y eliminar asignatura seleccionada
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Mostrar el formulario de menú
            menu menuForm = new menu();
            menuForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Mostrar asignaturas.
        }
    }
}

    
