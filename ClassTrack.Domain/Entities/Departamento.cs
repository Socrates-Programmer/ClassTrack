﻿using ClassTrack.Domain.Common;

namespace ClassTrack.Domain.Entities
{
    public class Departamento : BaseEntity
    {
        public string Nombre { get; set; }

        //Propiedad de navegacion

        public ICollection<AreaConocimiento> AreaConocimientos { get; set; }
    }
}
