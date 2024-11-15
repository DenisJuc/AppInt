using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelView
{
    public class PersonneViewModel : INotifyPropertyChanged
    {
        private Personne _personne;
        private string _nomAffiche;

        public PersonneViewModel()
        {
            _personne = new Personne();
            NomAffiche = "Denis";

        }

        public string NomSaisi
        {
            get; set;
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
            NomAffiche = _personne.Nom;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
