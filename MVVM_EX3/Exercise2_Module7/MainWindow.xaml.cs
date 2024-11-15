using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViewModel;

namespace Exercise2_Module7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly RoutedCommand AjouterEquipeCommand = new RoutedCommand();
        public static readonly RoutedCommand AjouterJoueurCommand = new RoutedCommand();
        public static readonly RoutedCommand RetirerJoueurCommand = new RoutedCommand();
        LigueViewModel viewModel;
        public MainWindow()
        {
            viewModel = new LigueViewModel();
            DataContext = viewModel;
            InitializeComponent();
            

        }

        private void AjouterEquipe_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            viewModel.AjouterEquipe();
        }

        private void AjouterJoueur_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            viewModel.AjouterJoueur();
        }

        private void PeutAjouterJoueur_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

            e.CanExecute = viewModel != null && viewModel.PeutAjouterJoueur();
        }

        private void RetirerJoueur_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            viewModel.RetirerJoueur();
        }

        private void PeutRetirerJoueur_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = viewModel != null && viewModel.PeutRetirerJoueur();
        }
    }
}