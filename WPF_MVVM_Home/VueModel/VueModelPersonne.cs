using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using BusinessMVVM_Home;
namespace WPF_MVVM_Home.VueModel
{
    class VueModelPersonne : INotifyPropertyChanged //j'implemente a 
    {
        private Personne personne;
        
        public VueModelPersonne(Personne _personne)
        {
            this.personne = _personne;
        }


        public string nom
        {
            get { return this.personne.nom; }
            set {
                this.personne.nom = value;
                NotifyPropertyChanged("nom");//il joue le role du publish pour signaler  quil ye evenment
            }//Text="{Binding nom, Mode=TwoWay, UpdateSourceTrigger=PropertyChanged}" ensuite faire un binding ou le nom se trouve
        }
        public string prenom
        {
            get { return this.personne.prenom; }
        }

        public string salaire
        {
            get { return this.personne.salaire.ToString(); }
        }

        public Brush salaireCouleur
        {
            get { return this.personne.salaire > 300 ? Brushes.Green : Brushes.Blue; }
        }

        public bool estEtudiant
        {
            get { return this.personne.etudiant.ToLower() == "eTudiant".ToLower(); }
        }

        public event PropertyChangedEventHandler PropertyChanged; //2 on doit s'abonner
      public void NotifyPropertyChanged(string nomPropriete)
        {
            if (PropertyChanged != null) // on crait une propriete en string pour verifier si il ya les abonnés(c'est le publish)
                PropertyChanged(this, new PropertyChangedEventArgs(nomPropriete)); // si il ya les abonnés, on lève les évenement
        }
       /* private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }*/

    }
}
