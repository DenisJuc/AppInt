using System.ComponentModel;
using System.Windows.Input;
using Model;

namespace ViewModel
{
    public class ViewModelPersonne : INotifyPropertyChanged
    {
        private readonly Personne _personne;
        private string _nomAffiche;

        public ViewModelPersonne()
        {
            _personne = new Personne();
        }

        public string NomSaisi
        {
            get => _personne.Nom;
            set
            {
                _personne.Nom = value;
                OnPropertyChanged(nameof(NomSaisi));
            }
        }

        public string NomAffiche
        {
            get => _nomAffiche;
            set
            {
                _nomAffiche = value;
                OnPropertyChanged(nameof(NomAffiche));
            }
        }

        public void AfficherNom()
        {
            NomAffiche = NomSaisi;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
