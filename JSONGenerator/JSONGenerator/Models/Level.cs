using System.Collections.ObjectModel;
using JSONGenerator.Controls;
using JSONGenerator.ViewModels;

namespace JSONGenerator.Models
{
    public class Level : TreeBase
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
        /// Cheminde l'image du path 
        /// </summary>
        private string _imagePath;
        #endregion

        #region Constructeur
        public Level()
        {
            this._name = "New level";
            this._uc = new LevelControl();
            this._collectionUC = new BlockCollectionControl();
        }
        #endregion

        #region Accesseurs
        protected override void AddChild()
        {
            Block child = new Block();
            this._childrens.Add(child);
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
