using Microsoft.Win32;
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
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static readonly RoutedCommand routedCommand = new RoutedCommand();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChargerFichier_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";

            string nom_fichier;
            if (openFileDialog.ShowDialog() == true)
            {
                nom_fichier = openFileDialog.FileName;
                editeur_texte.Text = File.ReadAllText(openFileDialog.FileName);
                txt_nom_fichier.Text = $"Fichier chargé : {System.IO.Path.GetFileName(nom_fichier)}"; 

            }
        }

        private void Sauvegarder_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Sauvegarder_Sous_Click(object sender, RoutedEventArgs e)
        {
            string nom_fichier;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";

            if(saveFileDialog.ShowDialog() == true)
            {
                nom_fichier = saveFileDialog.FileName;
                File.WriteAllText(nom_fichier, editeur_texte.Text);

                txt_nom_fichier.Text = $"Fichier enregistré : {System.IO.Path.GetFileName(nom_fichier)}";
                MessageBox.Show("Fichier enregistré avec succès.", "Information");
            }
        }

        private void ViderTexte_Click(object sender, RoutedEventArgs e)
        {
            editeur_texte.Text = "";
        }


    }
}