using InterfacesMuestraDeLaboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesMuestraDeLaboratorio.Peticiones;
using InterfacesMuestraDeLaboratorio.Respuestas;
using AccesoDatos.Contexto;
using AccesoDatos.Modelo;

namespace GestionDeMuestraDeLaboratorio
{
    public class GestorDeMuestraDeLaboratorio : IGestionMuestraDeLaboratorio
    {
        public MuestraDeLaboratorioRegistradas CambiarDatosDeLaMuestra(ActualizarMuestraDeLaboratorio actualizarMuestraDeLaboratorio)
        {
            var muestraDeLaboratorioActualizar = new MuestraDeLaboratorio { Id = actualizarMuestraDeLaboratorio.Id };

            using (MuestraDeLaboratorioContexto bd = new MuestraDeLaboratorioContexto())
            {
                bd.muestraDeLaboratorio.Attach(muestraDeLaboratorioActualizar);
                bd.SaveChanges();
                return ConvertirA_DTO(muestraDeLaboratorioActualizar);
            }
        }

        public MuestraDeLaboratorioRegistradas CrearMuestraDeLaboratorio(NuevaMuestraDeLaboratorio nuevaMuestraDeLaboratorio)
        {
            using (MuestraDeLaboratorioContexto bd = new MuestraDeLaboratorioContexto())
            {
                MuestraDeLaboratorio muestraDeLaboratorio = new MuestraDeLaboratorio();
                muestraDeLaboratorio.NombrePersonaMuestrada = nuevaMuestraDeLaboratorio.NombrePersonaMuestrada;
                muestraDeLaboratorio.FechaDeToma = nuevaMuestraDeLaboratorio.FechaDeToma;
                muestraDeLaboratorio.NombrePersonaTomaMuestra = nuevaMuestraDeLaboratorio.NombrePersonaTomaMuestra;
                bd.muestraDeLaboratorio.Add(muestraDeLaboratorio);
                bd.SaveChanges();
                return ConvertirA_DTO(muestraDeLaboratorio);
            }
        }

        public List<MuestraDeLaboratorioRegistradas> ListarMuestrasDeLaboratorioRegistradas()
        {
            using (MuestraDeLaboratorioContexto bd = new MuestraDeLaboratorioContexto())
            {
                return bd.muestraDeLaboratorio.ToList().Select(x => ConvertirA_DTO(x)).ToList();
            }
        }

        private MuestraDeLaboratorioRegistradas ConvertirA_DTO(MuestraDeLaboratorio muestraDeLaboratorio)
        {
            MuestraDeLaboratorioRegistradas muestraDeLaboratorioRegistradas = new MuestraDeLaboratorioRegistradas();
            muestraDeLaboratorioRegistradas.NombrePersonaMuestrada = muestraDeLaboratorio.NombrePersonaMuestrada;
            muestraDeLaboratorioRegistradas.FechaDeToma = muestraDeLaboratorio.FechaDeToma;
            muestraDeLaboratorioRegistradas.NombrePersonaTomaMuestra = muestraDeLaboratorio.NombrePersonaTomaMuestra;
            return muestraDeLaboratorioRegistradas;
        }
    }
}
