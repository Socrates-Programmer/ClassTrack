using ClassTrack.Domain.Common;
using ClassTrack.Domain.Enums;

namespace ClassTrack.Domain.Entities
{
    public class HorarioConsulta : BaseEntity
    {
        public int ProfesorID { get; set; }

        public Dias Dia { get; set; }

        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        //Propiedad de navegacion

        public Profesor Profesor { get; set; }
    }
}
