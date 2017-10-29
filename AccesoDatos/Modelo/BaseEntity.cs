using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelo
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public DateTime FechaDeModificacion { get; set; }

        public BaseEntity()
        {
            this.FechaDeCreacion = DateTime.Now;
            this.FechaDeModificacion = DateTime.Now;
        }
    }
}
