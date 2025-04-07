using ClassTrack.Domain.Entities;

namespace ClassTrack.Informes
{
    public partial class FrmInformeProfesor : Form
    {
        private readonly Profesor _profesor;
        public FrmInformeProfesor( Profesor profesor)
        {
            InitializeComponent();

            _profesor = profesor;
        }

        private void FrmInformeProfesor_Load(object sender, EventArgs e)
        {

            //lo label de informacion
            lblAreaConocimiento.Text = _profesor.AreaConocimiento.Nombre;
            lblProfesor.Text = _profesor.Nombre.ToString();
            lblDespacho.Text = _profesor?.Despacho;
            lblDepartamento.Text = _profesor.AreaConocimiento.Departamento.Nombre;

            //Asignatura
            foreach (var asignatura in _profesor.Docencias)
            {
                lbAsignatura.Items.Add(asignatura.Asignatura.Nombre);
            }

            //Horario
            foreach (var horario in _profesor.HorarioConsultas)
            {
                lbHorario.Items.Add($"{horario.HoraInicio.ToString(@"hh\:mm")} - {horario.HoraFin.ToString(@"hh\:mm")}");
            }
        }
    }
}
