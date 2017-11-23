using System.Collections.ObjectModel;
using JSONGenerator.Controls;
using JSONGenerator.ViewModels;

namespace JSONGenerator.Models
{
    public class Block : ViewModelBase
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
        /// Collection d'actions
        /// </summary>
        private ObservableCollection<Action> _actions;

        /// <summary>
        /// Condition d'accés au block
        /// </summary>
        private string _accessConditions;
        #endregion

        #region Constructeur
        public Block()
        {
            this._actions = new ObservableCollection<Action>();
            this._uc = new BlockControl();
        }
        #endregion

        #region Accesseurs
        /// <summary>
        /// Collection d'actions
        /// </summary>
        public ObservableCollection<Action> Actions
        {
            get => _actions;
            set
            {
                _actions = value;
                OnPropertyChanged("Actions");
                OnPropertyChanged("Children");
            }
        }

        protected override void AddChild()
        {
            Action child = new Action();
            this._childrens.Add(child);
            this._actions.Add(child);
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
