using ClassTrack.Domain.Common;

namespace ClassTrack.Domain.Entities
{
    public class Profesor : BaseEntity
    {
        public string Nombre { get; set; }

        public string Despacho { get; set; }

        public int AreaID { get; set; }


        //Propiedad de navegacion 
        public AreaConocimiento AreaConocimiento { get; set; }
        public ICollection<Docencia> Docencias{ get; set; }

        public ICollection<HorarioConsulta> HorarioConsultas{ get; set; }
    }
}
