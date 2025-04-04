using ClassTrack.Domain.Common;
using ClassTrack.Domain.Enums;

namespace ClassTrack.Domain.Entities
{
    public class Asignatura : BaseEntity
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public TipoAsignatura Tipo { get; set; }

        public int Curso { get; set; }

        public string Duracion { get; set; }

        public decimal CreditosTeoricos { get; set; }
        public decimal CreditosPracticos { get; set; }

        public bool LibreConfiguracion { get; set; }

        public int LimiteAdmision { get; set; }

        public int AreaID { get; set; }

        //Propiedad de navegacion

        public AreaConocimiento AreaConocimiento { get; set; }

        public ICollection<Docencia> Docencias { get; set; }

        public ICollection<Grupos> Grupos { get; set; }
    }
}
