using ModelView;
using System.ComponentModel.Design;
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
using System.Xml;

namespace MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly RoutedCommand AfficherNom = new RoutedCommand();
        public PersonneViewModel viewModel;
        public MainWindow()
        {
            viewModel = new PersonneViewModel();
            DataContext = viewModel;
            InitializeComponent();
        }

        private void AfficherNom_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = viewModel != null && !string.IsNullOrEmpty(viewModel.NomSaisi);
        }
        private void AfficherNom_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            viewModel.AfficherNom();
        }
    }
}