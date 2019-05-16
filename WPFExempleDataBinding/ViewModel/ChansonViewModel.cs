using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFExempleDataBinding.Model;

namespace WPFExempleDataBinding.ViewModel
{
    class ChansonViewModel : INotifyPropertyChanged
    {
        List<ChansonModel> _chansons; 

        public List<ChansonModel> Chansons
        {
            get
            {
                return _chansons;
            }
            set
            {
                 _chansons = value;
                OnPropertyChanged("Chansons");
            }
        }

        public void AddChanson()
        {
            _chansons = new List<ChansonModel>();
            _chansons.Add(new ChansonModel() { NomArtiste = "Nydia NOMEDE", TitreChanson = "C#" });

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
           /* if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName))
                */
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
  

}
