using AccesoDatos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesMuestraDeLaboratorio.Peticiones
{
    public class ActualizarMuestraDeLaboratorio
    {
        public int Id { get; set; }
        public string NombrePersonaMuestrada { get; set; }
        public string FechaDeToma { get; set; }
        public string NombrePersonaTomaMuestra { get; set; }

        public ActualizarMuestraDeLaboratorio()
        {
            MuestraDeLaboratorio muestraDeLaboratorio = new MuestraDeLaboratorio();
            muestraDeLaboratorio.FechaDeModificacion = DateTime.Now;
        }
    }
}
