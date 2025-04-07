using ClassTrack.Domain.Common;

namespace ClassTrack.Domain.Entities
{
    public class EquivalenciaAsignatura : BaseEntity
    {
        public int AsignaturaID1 { get; set; }
        public int AsignaturaID2 { get; set; }


        //Propiedad de navegacion
        public ICollection<Asignatura> Asignatura { get; set; }
    }
}
