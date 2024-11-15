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
namespace ExerciseModule7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly RoutedCommand AfficherNomCommand = new RoutedCommand();
        private readonly ViewModelPersonne _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new ViewModelPersonne();
            ////// Vraiment important!!!!
            DataContext = _viewModel;
        }

        private void AfficherNomCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _viewModel.AfficherNom();
        }

        private void AfficherNomCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (_viewModel != null)
                e.CanExecute = !string.IsNullOrWhiteSpace(_viewModel.NomSaisi);
        }
    }
}