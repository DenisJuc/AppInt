using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using System.Xml.Linq;
using System.Xml;
using Model;
namespace ViewModel
{

    public class LigueViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Equipe> _equipes;
        private Equipe _equipeSelectionnee;
        private Joueur _joueurSelectionne;
        private string _nouveauNomEquipe;
        private string _nouveauNomJoueur;

        public ObservableCollection<Equipe> Equipes
        {
            get => _equipes;
            set
            {
                _equipes = value;
                OnPropertyChanged(nameof(Equipes));
            }
        }

        public Equipe EquipeSelectionnee
        {
            get => _equipeSelectionnee;
            set
            {
                _equipeSelectionnee = value;
                OnPropertyChanged(nameof(EquipeSelectionnee));
            }
        }

        public Joueur JoueurSelectionne
        {
            get => _joueurSelectionne;
            set
            {
                _joueurSelectionne = value;
                OnPropertyChanged(nameof(JoueurSelectionne));
            }
        }

        public string NouveauNomEquipe
        {
            get => _nouveauNomEquipe;
            set
            {
                _nouveauNomEquipe = value;
                OnPropertyChanged(nameof(NouveauNomEquipe));
            }
        }

        public string NouveauNomJoueur
        {
            get => _nouveauNomJoueur;
            set
            {
                _nouveauNomJoueur = value;
                OnPropertyChanged(nameof(NouveauNomJoueur));
            }
        }


        public LigueViewModel()
        {
            
            Equipes = Equipe.ChargerEquipesDepuisXML();
        }

        

        public void AjouterEquipe()
        {
            if (!string.IsNullOrWhiteSpace(NouveauNomEquipe))
            {
                Equipes.Add(new Equipe(NouveauNomEquipe));
                Equipe.SauvegarderEquipes(Equipes);
            }
        }

        public void AjouterJoueur()
        {
            if (EquipeSelectionnee != null && !string.IsNullOrWhiteSpace(NouveauNomJoueur))
            {
                EquipeSelectionnee.Joueurs.Add(new Joueur(NouveauNomJoueur));
                Equipe.SauvegarderEquipes(Equipes);
            }
        }

        public bool PeutAjouterJoueur()
        {
            return EquipeSelectionnee != null && !string.IsNullOrWhiteSpace(NouveauNomJoueur);
        }

        public void RetirerJoueur()
        {
            if (EquipeSelectionnee != null && JoueurSelectionne != null)
            {
                EquipeSelectionnee.Joueurs.Remove(JoueurSelectionne);
                Equipe.SauvegarderEquipes(Equipes);
            }
        }

        public bool PeutRetirerJoueur()
        {
            return EquipeSelectionnee != null && JoueurSelectionne != null;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
