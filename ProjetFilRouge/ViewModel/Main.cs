using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjetFilRouge.ViewModel
{
    class Main
    {
        //des propriétés (gérées par liaisons de données et 
        //pourront mettre à jour l'interface)



        // méthodes(donc du comportement qui sera déclenché à partir 
        //des événements que je vais gérer dans la vue)
        public void test()
        {
            MessageBox.Show("coucou");
            //e.Handled = true;
        }
    }
}
