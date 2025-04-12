using ClassTrack.Domain.Entities;
using ClassTrack.Domain.Enums;
using ClassTrack.Persistence.Repositories;

namespace ClassTrack
{
    public partial class FrmHorarioConsulta : Form
    {

        private readonly ProfesoresRepository _profesoresRepository;
        private readonly HorarioConsultaRepository _horarioConsultaRepository;
        public FrmHorarioConsulta()
        {
            InitializeComponent();

            _profesoresRepository = new ProfesoresRepository();
            _horarioConsultaRepository = new HorarioConsultaRepository();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void FrmHorarioConsulta_Load(object sender, EventArgs e)
        {
            await CargarDatos();

        }

        private async Task CargarDatos()
        {
            dgvHorarioConsulta.DataBindings.Clear();
            var data = await _horarioConsultaRepository.GetAllAsync();
            var listProfesores = await _profesoresRepository.GetAllAsync();



            //Titular
            cbDias.DataSource = Enum.GetValues(typeof(Dias));


            //Area de conocimiento
            cbProfesor.DataSource = listProfesores;
            cbProfesor.DisplayMember = "Nombre";
            cbProfesor.ValueMember = "Id";

            dgvHorarioConsulta.DataSource = data;
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtNombre.Text))
            //{
            //    MessageBox.Show("Campo nombre vacio");
            //    return;
            //}

            var entidad = new HorarioConsulta()
            {
                ProfesorID = (int)cbProfesor.SelectedValue,
                Dia = (Dias)cbDias.SelectedItem,
                HoraInicio = dTPHorarioInicio.Value.TimeOfDay,
                HoraFin = dTPHorarioFin.Value.TimeOfDay
            };

            if (await _horarioConsultaRepository.InsertAsync(entidad))
            {
                MessageBox.Show("Horario creado");
            }
            else
            {
                MessageBox.Show("Horario no se puedo crear");
                return;
            }

            //txtNombre.Text = "";
            //txtNombre.Focus();
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
