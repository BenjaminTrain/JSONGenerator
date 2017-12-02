using System.Collections.ObjectModel;
using JSONGenerator.Controls;
using JSONGenerator.ViewModels;

namespace JSONGenerator.Models
{
    public class Path : TreeBase
    {
        #region Champs
        /// <summary>
        /// ID du path
        /// </summary>
        private int _ID;

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
            this._name = "New path";
            this._uc = new PathControl();
            this._collectionUC = new LevelCollectionControl();
        }
        #endregion

        #region Accesseurs
        protected override void AddChild()
        {
            Level child = new Level();
            this._childrens.Add(child);
            this._collectionUC = new LevelCollectionControl();
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
