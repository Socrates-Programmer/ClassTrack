using ClassTrack.Domain.Entities;
using ClassTrack.Persistence.Repositories;

namespace ClassTrack
{
    public partial class FrmAreasConocimiento : Form
    {

        private readonly AreaConocimientoRepository _areaConocimientoRepository;
        public DepartamentoRepository _departamentoRepository;

        public FrmAreasConocimiento()
        {
            InitializeComponent();

            _areaConocimientoRepository = new AreaConocimientoRepository();
            _departamentoRepository = new DepartamentoRepository();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void FrmAreasConocimiento_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }


        private async Task CargarDatos()
        {
            dgvAreaConocimiento.DataBindings.Clear();
            //cbDepartamento.Items.Clear();
            var data = await _areaConocimientoRepository.GetAllAsync();
            var listDepartamento = await _departamentoRepository.GetAllAsync();


            cbDepartamento.DataSource = listDepartamento;
            cbDepartamento.DisplayMember = "Nombre";   // Lo que se muestra
            cbDepartamento.ValueMember = "Id";         // Valor asociado

            dgvAreaConocimiento.DataSource = data;
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Campo nombre vacio");
                return;
            }

            var entidad = new AreaConocimiento()
            {
                Nombre = txtNombre.Text,
                DepartamentoID = (int)cbDepartamento.SelectedValue
            };

            if (await _areaConocimientoRepository.InsertAsync(entidad))
            {
                MessageBox.Show("Area de Conocimiento creado");
            }
            else
            {
                MessageBox.Show("Area de Conocimiento no se puedo crear");
                return;
            }

            txtNombre.Text = "";
            txtNombre.Focus();
            await CargarDatos();
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
