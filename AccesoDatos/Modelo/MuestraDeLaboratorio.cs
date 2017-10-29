using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelo
{
    public class MuestraDeLaboratorio:BaseEntity
    {
        [Required]
        public string NombrePersonaMuestrada { get; set; }
        [Required]
        public string FechaDeToma { get; set; }
        [Required]
        public string NombrePersonaTomaMuestra { get; set; }
    }
}
