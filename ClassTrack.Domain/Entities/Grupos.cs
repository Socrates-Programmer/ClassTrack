using ClassTrack.Domain.Common;
using ClassTrack.Domain.Enums;

namespace ClassTrack.Domain.Entities
{
    public class Grupos : BaseEntity
    {
        public int AsignaturaID { get; set; }

        public TipoGrupo Tipo { get; set; }

        public int Cantidad { get; set; }
        //Propiedad de navegacion
        public Asignatura Asignatura { get; set; }
    }
}
