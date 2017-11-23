using System.Collections.ObjectModel;
using JSONGenerator.Controls;
using JSONGenerator.ViewModels;

namespace JSONGenerator.Models
{
    class Path : ViewModelBase
    {
        #region Champs
        /// <summary>
        /// ID du path
        /// </summary>
        private int _ID;

        /// <summary>
        /// Collection de levels
        /// </summary>
        private ObservableCollection<Level> _levels;

        /// <summary>
        /// Description du path 
        /// </summary>
        private string _description;

        /// <summary>
        /// Vrai si le joueur se trouve dans ce path
        /// </summary>
        private bool _isActive;
        #endregion

        #region Constructeur
        public Path()
        {
            this._levels = new ObservableCollection<Level>();
            this._uc = new PathControl();
        }
        #endregion

        #region Accesseurs
        /// <summary>
        /// Collection de levels
        /// </summary>
        public ObservableCollection<Level> Levels
        {
            get => _levels;
            set
            {
                _levels = value;
                OnPropertyChanged("Levels");
                OnPropertyChanged("Children");
            }
        }

        protected override void AddChild()
        {
            Level child = new Level();
            this._childrens.Add(child);
            this._levels.Add(child);
        }

        /// <summary>
        /// Description du path 
        /// </summary>
        public string DescriptionPath
        {
            get
            {
                return _description;
            }
            set
            {
                this._description = value;
                OnPropertyChanged("DescriptionPath");
            }
        }
        #endregion
    }
}
