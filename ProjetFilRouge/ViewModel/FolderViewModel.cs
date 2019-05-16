using ProjetFilRouge.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;

namespace ProjetFilRouge.ViewModel
{
    class FolderViewModel : INotifyPropertyChanged
    {

        public FolderViewModel ()
        {
            AddFolders();
        }

        private List<Folder> _folders;

        public List<Folder> Folders
        {
            get
            {
                return _folders;
            }
            set
            {
                _folders = value;
                OnPropertyChanged("Folders");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            // if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        public void AddFolders()
        {
            _folders = new List<Folder>();

            var doc = new XmlDocument();

            try
            {
                doc.Load("../../Folders/Folders.xml");
                var xmlNodeList = doc.DocumentElement?.SelectNodes("/folders/folder");
                if (xmlNodeList == null) return;
                foreach (XmlNode folder in xmlNodeList)
                {
                    if (folder.Attributes == null) continue;
                    var selectSingleNode = folder.SelectSingleNode("display");
                    if (selectSingleNode?.Attributes == null) continue;

                    var tf = new Folder
                    {
                        Lang = selectSingleNode.Attributes["lang"].Value,
                        Label = selectSingleNode.Attributes["label"].Value,
                        Tooltip = selectSingleNode.Attributes["tooltip"].Value,
                        Name = folder.Attributes["name"].Value,
                    };
                    Folders.Add(tf);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, App.Localized["msgErrorLoadingFolder"], MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
