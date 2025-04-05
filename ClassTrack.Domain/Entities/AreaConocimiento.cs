using ClassTrack.Domain.Common;

namespace ClassTrack.Domain.Entities
{
    public class AreaConocimiento : BaseEntity
    {
        public string Nombre { get; set; }
        public int DepartamentoID { get; set; }

        //Propiedad de navegacion

        public Departamento Departamento { get; set; }
        public ICollection<Asignatura> Asignaturas { get; set; }
        public ICollection<Profesor> Profesores { get; set; }
    }
}
