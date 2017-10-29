using InterfacesMuestraDeLaboratorio.Peticiones;
using InterfacesMuestraDeLaboratorio.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesMuestraDeLaboratorio
{
    public interface IGestionMuestraDeLaboratorio
    {
        MuestraDeLaboratorioRegistradas CrearMuestraDeLaboratorio(NuevaMuestraDeLaboratorio nuevaMuestraDeLaboratorio);
        List<MuestraDeLaboratorioRegistradas> ListarMuestrasDeLaboratorioRegistradas();
        MuestraDeLaboratorioRegistradas CambiarDatosDeLaMuestra(ActualizarMuestraDeLaboratorio actualizarMuestraDeLaboratorio);
    }
}
