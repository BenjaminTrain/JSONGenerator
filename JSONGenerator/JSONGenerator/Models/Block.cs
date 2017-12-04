using System.Collections.ObjectModel;
using JSONGenerator.Controls;
using JSONGenerator.ViewModels;

namespace JSONGenerator.Models
{
    public class Block : TreeBase
    {
        #region
        /// <summary>
        /// ID du block
        /// </summary>
        private int _ID;

        /// <summary>
        /// Description du block
        /// </summary>
        private string _description { get; set; }

        /// <summary>
        /// Type de block
        /// </summary>
        private string _type;

        /// <summary>
        /// Condition d'accés au block
        /// </summary>
        private string _accessConditions;
        #endregion

        #region Constructeur
        public Block()
        {
            this._name = "New block";
            this._uc = new BlockControl();
            this._collectionUC = new ActionCollectionControl();
        }
        #endregion

        #region Accesseurs
        protected override void AddChild()
        {
            Action child = new Action();
            this._childrens.Add(child);

            child.IsSelected = true;
            IsExpanded = true;
        }

        /// <summary>
        /// Description du block
        /// </summary>
        public string DescriptionBlock
        {
            get
            {
                return _description;
            }
            set
            {
                this._description = value;
                OnPropertyChanged("DescriptionBlock");
            }
        }

        /// <summary>
        /// Type de block
        /// </summary>
        public string TypeBlock
        {
            get
            {
                return _type;
            }
            set
            {
                this._type = value;
                OnPropertyChanged("TypeBlock");
            }
        }

        /// <summary>
        /// Condition d'accés au block
        /// </summary>
        public string AccessConditions
        {
            get
            {
                return _accessConditions;
            }
            set
            {
                this._accessConditions = value;
                OnPropertyChanged("AccessConditions");
            }
        }
        #endregion
    }
}
