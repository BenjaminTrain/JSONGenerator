using System.Collections.ObjectModel;
using JSONGenerator.Controls;
using JSONGenerator.ViewModels;

namespace JSONGenerator.Models
{
    class Level : ViewModelBase
    {
        #region Champs
        /// <summary>
        /// ID du level
        /// </summary>
        public int _ID { get; set; }

        /// <summary>
        /// Texte de transition entre les levels
        /// </summary>
        private string _transition; 

        /// <summary>
        /// Collection de blocks
        /// </summary>
        private ObservableCollection<Block> _blocks;

        /// <summary>
        /// Cheminde l'image du path 
        /// </summary>
        private string _imagePath;
        #endregion

        #region Constructeur
        public Level()
        {
            this._blocks = new ObservableCollection<Block>();
            this._uc = new LevelControl();
        }
        #endregion

        #region Accesseurs
        /// <summary>
        /// Collection de blocks
        /// </summary>
        public ObservableCollection<Block> Blocks
        {
            get => _blocks;
            set
            {
                _blocks = value;
                OnPropertyChanged("Blocks");
                OnPropertyChanged("Children");
            }
        }
        protected override void AddChild()
        {
            Block child = new Block();
            this._childrens.Add(child);
            this._blocks.Add(child);
        }

        /// <summary>
        /// Texte de transition entre les levels
        /// </summary>
        public string Transition
        {
            get
            {
                return _transition;
            }
            set
            {
                this._transition = value;
                OnPropertyChanged("Transition");
            }
        }

        /// <summary>
        /// Cheminde l'image du path 
        /// </summary>
        public string ImagePathLevel
        {
            get
            {
                return _imagePath;
            }
            set
            {
                this._imagePath = value;
                OnPropertyChanged("ImagePathLevel");
            }
        }
        #endregion
    }
}
