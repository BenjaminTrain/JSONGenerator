using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;
using JSONGenerator.Utils;

namespace JSONGenerator.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        #region Champs
        /// <summary>
        /// Evement envoyé à chaque modification de l'objet
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Vrai si l'objet est sélectionné dans le treeview
        /// </summary>
        private bool _selectedItem;

        /// <summary>
        /// Méthode pour ajouter un enfent à l'objet
        /// </summary>
        private ICommand _addChildCmd;

        /// <summary>
        /// Liste des enfants de l'objet
        /// </summary>
        protected ObservableCollection<ViewModelBase> _childrens;

        /// <summary>
        /// Nom de l'objet
        /// </summary>
        protected string _name;

        /// <summary>
        /// Formulaire de l'objet
        /// </summary>
        protected UserControl _uc;

        /// <summary>
        /// Affichage de la collection de fils sous forme de carte
        /// </summary>
        protected UserControl _collectionUC;
        #endregion

        #region constructeur
        public ViewModelBase()
        {
            this._childrens = new ObservableCollection<ViewModelBase>();
            this._addChildCmd = new CommandHandler(param => AddChild(), true);
            this._name = "New element";
        }
        #endregion

        #region Accesseurs
        /// <summary>
        /// Nom de l'objet
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                this._name = value;
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Vrai si l'objet est sélectionné dans le treeview
        /// </summary>
        public bool IsSelected
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
                OnPropertyChanged("IsSelected");
            }
        }

        /// <summary>
        /// Formulaire de l'objet
        /// </summary>
        public UserControl UC { get => _uc; }

        /// <summary>
        /// Affichage de la collection de fils sous forme de carte
        /// </summary>
        public UserControl CollectionUC { get => _collectionUC; }

        /// <summary>
        /// Liste des enfants de l'objet
        /// </summary>
        public ObservableCollection<ViewModelBase> Children { get => _childrens; }

        /// <summary>
        /// Ajoute un élément dans la collection d'enfants
        /// </summary>
        public ICommand AddChildCmd { get => _addChildCmd; }

        protected virtual void AddChild() { }
        #endregion

        #region Evènement
        public void OnPropertyChanged(string propname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propname));
        }
        #endregion      
    }
}
