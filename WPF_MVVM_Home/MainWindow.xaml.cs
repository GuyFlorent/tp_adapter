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
using BusinessMVVM_Home;
using WPF_MVVM_Home.VueModel;
using System.Threading;

namespace WPF_MVVM_Home
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        private Personne _personne;
        VueModelPersonne monVM;
        public MainWindow()
        {
            InitializeComponent();

            _personne = new Personne();
            _personne.nom = "Monsieur A";
            _personne.prenom = "Gentil";
            _personne.salaire = 400;
            _personne.etudiant = "Etudiant";

            monVM = new VueModelPersonne(_personne);

            this.DataContext = monVM;

            Thread myThread = new Thread(MyTask);
            myThread.Start();
        }

        public void MyTask()
        {

            int i = 0;
            while(true)
            {
                string nom = _personne.nom;


                System.Threading.Thread.Sleep(500);
                monVM.nom = _personne.nom +i++;
                System.Threading.Thread.Sleep(500);
                _personne.nom = nom;

                Console.WriteLine("En cours ... " + DateTime.Now.ToString());
            }
        }
      
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //txt_Nom.Text = monVM.nom;
            //txt_Prenom.Text = monVM.prenom;
            //txt_salaire.Text = monVM.salaire;
            //txt_salaire.Background = monVM.salaireCouleur;
            //Chk_Etudiant.IsChecked = monVM.estEtudiant;


            //txt_Nom.Text = _personne.nom;
            //txt_Prenom.Text = _personne.prenom;
            //txt_salaire.Text = _personne.salaire.ToString();
            //txt_salaire.Background = _personne.salaire > 300 ? 
            //                            Brushes.Green : 
            //                            Brushes.Blue;
            //Chk_Etudiant.IsChecked = _personne.etudiant == "Etudiant" ?
            //                            true :
            //                            false;

        }

        
    }
}
