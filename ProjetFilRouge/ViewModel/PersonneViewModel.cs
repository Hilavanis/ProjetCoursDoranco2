using ProjetFilRouge.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFilRouge.ViewModel
{
    class PersonneViewModel
    {
        public PersonneViewModel()
        {
            AddPersonne();
        }

        private List<Personne> _personne;

        public List<Personne> Personnes
        {
            get
            {
                return _personne;
            }
            set
            {
                _personne = value;
                OnPropertyChanged("Personnes");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            // if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        public void AddPersonne()
        {
            _personne = new List<Personne>();
            _personne.Add(new Personne() { Name = "Nydia NOMEDE" });
            _personne.Add(new Personne() { Name = "Nydia NOMEDE" });
        }
    }
}
