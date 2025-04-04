using ClassTrack.Domain.Common;

namespace ClassTrack.Domain.Entities
{
    public class IncompatibilidadAsignatura : BaseEntity
    {
        public int AsignaturaID1 { get; set; }
        public int AsignaturaID2 { get; set; }


        //Propiedad de navegacion
        public Asignatura Asignatura { get; set; }
    }
}
