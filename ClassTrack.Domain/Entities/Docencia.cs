using ClassTrack.Domain.Common;

namespace ClassTrack.Domain.Entities
{
    public class Docencia : BaseEntity
    {
        public int ProfesorID { get; set; }
        public int AsignaturaID { get; set; }


        //Propiedad de navegacion
        public Profesor Profesor { get; set; }
        public Asignatura Asignatura { get; set; }
    }
}
