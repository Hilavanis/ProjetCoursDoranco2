using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfPremierPas
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    
   public class Coucou : ContentControl
    {
        public string salutation { get; set; }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //< Button Content = "Button" HorizontalAlignment = "Left" Margin = "242,46,0,0" VerticalAlignment = "Top" Width = "75" />
            
            //Version sans xmal et sans drag and drop
        /*    Button b = new Button();
            b.Content = "Ajouter un nouvel utilisateur";
            b.HorizontalAlignment = HorizontalAlignment.Left;
            b.Margin = new Thickness(242, 46, 0, 0);
            maGrille.Children.Add(b);*/

           

        }
    }
}
