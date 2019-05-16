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

namespace ProjetFilRouge
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ViewModel.FolderViewModel _vm = new ViewModel.FolderViewModel();
            //  ViewModel.PersonneViewModel _vmp = new ViewModel.PersonneViewModel();

            DataContext = _vm;
            // DataContext[] = { _vm, _vmp };   
        }  

       

        //Deux méthodes différentes 

        /*  private void Connection_ClickButton(object sender, RoutedEventArgs e)
          {

              MessageBox.Show("Je suis Gabriel "+sender.ToString());
              MessageBox.Show(App.Localized["CheckAll"]);
              e.Handled = true;
          }

          private void Connection_ClickDockPanel(object sender, RoutedEventArgs e)
          {

              MessageBox.Show("Je suis Nydia " + sender.ToString());
            //  MessageBox.Show(App.Localized["CheckAll"]);
              //e.Handled = true;
          }*/

        private void Connection_Click(object sender, RoutedEventArgs e)
        {

           // MessageBox.Show("Je suis Gabriel " + sender.ToString());
            MessageBox.Show(Application.Current.FindResource("CheckAll").ToString());
           // Connection.Content = App.Localized["CheckAll"];
            e.Handled = true;
        }
        
           /*Test Bubled*/
/*
        private void Connection_Impossible(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Vous ne pouvez pas vous connecter en SQL");
            
        }
        private void Connection_SQL(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Vous souhaitez vous connecter en SQL");
            
        }

        private void Connection_Window(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Vous souhaitez vous connecter avec Window");
            e.Handled = true;
        }*/



    }
}
