using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ProjetFilRouge
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        static internal Dictionary<string, string> Localized { get; set; }
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //Un objet de type dictionnaire de ressource

            ResourceDictionary localizedObject = new ResourceDictionary();
            localizedObject.Source = new Uri("ProjetFilRouge;component/ressources/ressources.xaml", UriKind.Relative);

            Localized = localizedObject.Keys.Cast<string>().ToDictionary(x => x, x => (string)localizedObject[x]);

        }
    }
}
