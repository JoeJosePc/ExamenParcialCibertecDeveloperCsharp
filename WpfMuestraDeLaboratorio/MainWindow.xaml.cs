using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfMuestraDeLaboratorio.ViewModel;

namespace WpfMuestraDeLaboratorio
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GestionMuestraDeLaboratorioVM gestionMuestraDeLaboratorioVM = new GestionMuestraDeLaboratorioVM();
        public MainWindow()
        {
            InitializeComponent();
            gestionMuestraDeLaboratorioVM.CargarMuestras();
            this.DataContext = gestionMuestraDeLaboratorioVM;
        }

        private void btnInsertar_Click(object sender, RoutedEventArgs e)
        {
            this.gestionMuestraDeLaboratorioVM.nuevaMuestraDeLaboratorio.FechaDeToma = this.dtpFechaDeToma.Text;
            this.gestionMuestraDeLaboratorioVM.AgregarMuestra();
        }
    }
}
