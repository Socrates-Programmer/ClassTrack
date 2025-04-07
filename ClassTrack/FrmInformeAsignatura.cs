using ClassTrack.Informes;
using ClassTrack.Persistence.Repositories;

namespace ClassTrack
{
    public partial class FrmInformeAsignatura : Form
    {
        private readonly AsignaturasRepository _asignaturasRepository;
        public FrmInformeAsignatura()
        {
            InitializeComponent();
            _asignaturasRepository = new AsignaturasRepository();
        }

        private async void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            var asignatura = await _asignaturasRepository.GetAsync((int) cbAsignatura.SelectedValue);

            FrmInformeAsignaturas frmInformeAsignaturas = new FrmInformeAsignaturas(asignatura);
            frmInformeAsignaturas.BringToFront();
            frmInformeAsignaturas.ShowDialog();
        }

        private async void FrmInformeAsignatura_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }

        private async Task CargarDatos()
        {
            var listProfesores = await _asignaturasRepository.GetAllAsync();
            //  Asignatura 1
            cbAsignatura.DataSource = listProfesores;
            cbAsignatura.DisplayMember = "Nombre";
            cbAsignatura.ValueMember = "Id";

        }
    }
}
