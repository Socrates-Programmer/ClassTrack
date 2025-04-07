using ClassTrack.Domain.Entities;
using ClassTrack.Domain.Enums;
using ClassTrack.Persistence.Repositories;

namespace ClassTrack.Informes
{
    public partial class FrmInformeAsignaturas : Form
    {
        private readonly Asignatura _asignatura;
        private readonly EquivalenciaAsignaturaRepository _equivalenciaAsignaturaRepository;
        private readonly IncompatibilidadAsignaturaRepository _incompatibilidadAsignaturaRepository;
        private readonly AsignaturasRepository _asignaturasRepository;
        public FrmInformeAsignaturas(Asignatura asignatura)
        {
            InitializeComponent();
            _asignatura = asignatura;
            _equivalenciaAsignaturaRepository = new EquivalenciaAsignaturaRepository();
            _incompatibilidadAsignaturaRepository = new IncompatibilidadAsignaturaRepository();
            _asignaturasRepository = new AsignaturasRepository();
        }

        private async void FrmInformeAsignaturas_Load(object sender, EventArgs e)
        {
            lblAsignatura.Text = "INFORME POR ASIGNATURA: " + _asignatura.Nombre;

            lblDepartamento.Text = _asignatura.AreaConocimiento.Departamento.Nombre;
            lblAreaConocimiento.Text = _asignatura.AreaConocimiento.Nombre;
            //lblTitulacion.Text = _asignatura.
            lblCodigo.Text = _asignatura.Codigo;
            lblTipo.Text = _asignatura.Tipo.ToString();
            lblCurso.Text = _asignatura.Curso.ToString();
            lblTeorico.Text = _asignatura.CreditosTeoricos.ToString();
            lblLaboratorio.Text = _asignatura.CreditosPracticos.ToString();

            lblDuracion.Text = _asignatura.Duracion.ToString();
            lblLibreConf.Text = _asignatura.LibreConfiguracion? "Si":"No";

            foreach (var grupos in _asignatura.Grupos)
            {
                if (grupos.Tipo.Equals(TipoGrupo.Laboratorio))
                {
                    var gru = _asignatura.Grupos.Where(x => x.Tipo.Equals(TipoGrupo.Laboratorio)).FirstOrDefault();
                    lblGrupoLaboratorio.Text = gru.Cantidad.ToString();
                }

                if (grupos.Tipo.Equals(TipoGrupo.Teoría))
                {
                    var gru = _asignatura.Grupos.Where(x => x.Tipo.Equals(TipoGrupo.Teoría)).FirstOrDefault();
                    lblGrupoTeoria.Text = gru.Cantidad.ToString();
                }
            }


            //Incompatibles
            var incompatibles = await _incompatibilidadAsignaturaRepository.GetAllAsyncByAsignatura(_asignatura.Id);
            foreach (var incompatible in incompatibles)
            {
                var asis = await _asignaturasRepository.GetAsync(incompatible.AsignaturaID2);
                lbIncompatible.Items.Add($"{asis.Codigo} - {asis.Nombre}");
            }


            //Equivalente
            var equivalentes = await _equivalenciaAsignaturaRepository.GetAllAsyncByAsignatura(_asignatura.Id);

            foreach (var equivalente in equivalentes)
            {
                var asis = await _asignaturasRepository.GetAsync(equivalente.AsignaturaID2);
                lblEquivalentes.Items.Add($"{asis.Codigo} - {asis.Nombre}");
            }
            //lblGrupoTeoria.Text = _asignatura.Grupos

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
