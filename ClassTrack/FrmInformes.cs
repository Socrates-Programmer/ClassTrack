using ClassTrack.Informes;
using ClassTrack.Persistence.Repositories;

namespace ClassTrack
{
    public partial class FrmInformes : Form
    {
        private readonly ProfesoresRepository _profesoresRepository;
        public FrmInformes()
        {
            InitializeComponent();

            _profesoresRepository = new ProfesoresRepository();
        }

        private void dgvProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            var profesor = await _profesoresRepository.GetAsync((int)cbProfesores.SelectedValue);

            FrmInformeProfesor from = new FrmInformeProfesor(profesor);

            from.BringToFront();
            from.ShowDialog();

        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {

        }

        private async void FrmInformes_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }

        private async Task CargarDatos()
        {
            var listProfesores = await _profesoresRepository.GetAllAsync();
            //  Asignatura 1
            cbProfesores.DataSource = listProfesores;
            cbProfesores.DisplayMember = "Nombre";
            cbProfesores.ValueMember = "Id";

        }
    }
}
