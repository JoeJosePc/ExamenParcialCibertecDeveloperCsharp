using AccesoDatos.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Contexto
{
    public class MuestraDeLaboratorioContexto:DbContext
    {
        public MuestraDeLaboratorioContexto(): base("MuestraDeLaboratorio") { }

        public DbSet<MuestraDeLaboratorio> muestraDeLaboratorio { get; set; }
    }
}
