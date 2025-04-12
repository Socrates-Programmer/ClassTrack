using ClassTrack.Domain.Entities;
using ClassTrack.Persistence.Repositories;

namespace ClassTrack
{
    public partial class FrmAsignaturas : Form
    {
        private readonly AreaConocimientoRepository _areaConocimientoRepository;
        private readonly AsignaturasRepository _asignaturasRepository;
        private readonly TitulacionRepository _titulacionRepository;

        public FrmAsignaturas()
        {
            InitializeComponent();

            _areaConocimientoRepository = new AreaConocimientoRepository();
            _asignaturasRepository = new AsignaturasRepository();
            _titulacionRepository = new TitulacionRepository();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Campo nombre vacio");
                return;
            }

            var entidad = new Asignatura()
            {
                Nombre = textBox1.Text,
                Codigo = textBox2.Text,
                Tipo = Domain.Enums.TipoAsignatura.Obligatoria,
                Curso = 3,
                Duracion = "Primer Semestre",
                CreditosTeoricos = 2.5M,
                CreditosPracticos = 2.5M,
                LibreConfiguracion = true,
                LimiteAdmision = 0,
                AreaConocimientoId = (int)cbArea.SelectedValue
            };

            if (await _asignaturasRepository.InsertAsync(entidad))
            {
                MessageBox.Show("Asignatura creado");
            }
            else
            {
                MessageBox.Show("Asignatura no se puedo crear");
                return;
            }


            await CargarDatos();
            // Limpiar campos para nueva asignatura
            textBox1.Text = "";
            textBox2.Text = "";

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
            // Limpiar selección y campos
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Mostrar asignaturas.
        }

        private async void FrmAsignaturas_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }


        private async Task CargarDatos()
        {
            dgvAsignatura.DataBindings.Clear();
            //cbDepartamento.Items.Clear();
            var data = await _asignaturasRepository.GetAllAsync();
            var listArea = await _areaConocimientoRepository.GetAllAsync();
            var listTitular = await _titulacionRepository.GetAllAsync();


            //Titular
            cbTitulacion.DataSource = listTitular;
            cbTitulacion.DisplayMember = "Nombre";
            cbTitulacion.ValueMember = "Id";

            //Area de conocimiento
            cbArea.DataSource = listArea;
            cbArea.DisplayMember = "Nombre";
            cbArea.ValueMember = "Id";

            dgvAsignatura.DataSource = data;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Mostrar el formulario de menú
            menu Menua = new menu();

            Menua.Show();
        }
    }
}


