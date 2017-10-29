using GestionDeMuestraDeLaboratorio;
using InterfacesMuestraDeLaboratorio;
using InterfacesMuestraDeLaboratorio.Peticiones;
using InterfacesMuestraDeLaboratorio.Respuestas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMuestraDeLaboratorio.ViewModel
{
    public class GestionMuestraDeLaboratorioVM: BaseEntity
    {
        public ObservableCollection<MuestraDeLaboratorioRegistradas> muestraDeLaboratorioRegistradas { get; set; }
        private IGestionMuestraDeLaboratorio _gestionMuestraDeLaboratorio = new GestorDeMuestraDeLaboratorio();

        public void CargarMuestras()
        {
            var muestras = _gestionMuestraDeLaboratorio.ListarMuestrasDeLaboratorioRegistradas();
            this.muestraDeLaboratorioRegistradas = new ObservableCollection<MuestraDeLaboratorioRegistradas>(muestras);
        }

        private NuevaMuestraDeLaboratorio _nuevaMuestraDeLaboratorio = new NuevaMuestraDeLaboratorio();
        public NuevaMuestraDeLaboratorio nuevaMuestraDeLaboratorio
        {
            get { return _nuevaMuestraDeLaboratorio; }
            set
            {
                this._nuevaMuestraDeLaboratorio = value;
                this.OnPropertyChanged("nuevaMuestraDeLaboratorio");
            }
        }

        public void AgregarMuestra()
        {
            MuestraDeLaboratorioRegistradas nuevaMuestra = this._gestionMuestraDeLaboratorio.CrearMuestraDeLaboratorio(this.nuevaMuestraDeLaboratorio);
            this.muestraDeLaboratorioRegistradas.Add(nuevaMuestra);
            this.nuevaMuestraDeLaboratorio = new NuevaMuestraDeLaboratorio();
        }
    }
}
