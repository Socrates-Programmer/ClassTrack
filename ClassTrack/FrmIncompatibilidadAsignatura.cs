using ClassTrack.Domain.Entities;
using ClassTrack.Persistence.Repositories;

namespace ClassTrack
{
    public partial class FrmIncompatibilidadAsignatura : Form
    {
        private readonly IncompatibilidadAsignaturaRepository _incompatibilidadAsignaturaRepository;
        private readonly AsignaturasRepository _asignaturasRepository;
        public FrmIncompatibilidadAsignatura()
        {
            InitializeComponent();
            _asignaturasRepository = new AsignaturasRepository();
            _incompatibilidadAsignaturaRepository = new IncompatibilidadAsignaturaRepository();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtNombre.Text))
            //{
            //    MessageBox.Show("Campo nombre vacio");
            //    return;
            //}

            var entidad = new IncompatibilidadAsignatura()
            {
                AsignaturaID1 = (int)cbAsignatura1.SelectedValue,
                AsignaturaID2 = (int)cbAsignatura2.SelectedValue
            };

            if (await _incompatibilidadAsignaturaRepository.InsertAsync(entidad))
            {
                MessageBox.Show("Creado");
            }
            else
            {
                MessageBox.Show("No se puedo crear");
                return;
            }

            //txtNombre.Text = "";
            //txtNombre.Focus();
            await CargarDatos();
        }

        private async void FrmIncompatibilidadAsignatura_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }


        private async Task CargarDatos()
        {
            dgvEquivalente.DataBindings.Clear();
            var data = await _incompatibilidadAsignaturaRepository.GetAllAsync();
            var listAsignatura = await _asignaturasRepository.GetAllAsync();
            var listAsignatura2 = await _asignaturasRepository.GetAllAsync();

            //  Asignatura 1
            cbAsignatura1.DataSource = listAsignatura;
            cbAsignatura1.DisplayMember = "Nombre";
            cbAsignatura1.ValueMember = "Id";

            //  Asignatura 2
            cbAsignatura2.DataSource = listAsignatura2;
            cbAsignatura2.DisplayMember = "Nombre";
            cbAsignatura2.ValueMember = "Id";

            dgvEquivalente.DataSource = data;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Mostrar el formulario de menú
            menu Menua = new menu();

            Menua.Show();
        }
    }
}
