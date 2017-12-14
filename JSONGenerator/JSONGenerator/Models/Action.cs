using System;
using System.Collections.ObjectModel;
using JSONGenerator.Controls;
using JSONGenerator.ViewModels;

namespace JSONGenerator.Models
{
    public class Action : TreeBase
    {
        #region Champs
        /// <summary>
        /// Type d'action 
        /// </summary>
        public string _type { get; set; }

        /// <summary>
        /// Liste de conséquences
        /// </summary>
        private ObservableCollection<Consequence> _consequences;

        /// <summary>
        /// Liste de conditions
        /// </summary>
        private ObservableCollection<Condition> _conditions;
        #endregion

        #region Constructeur
        public Action()
        {
            this._name = "New action";
            this._uc = new ActionControl();
        }
        #endregion

        #region Accesseurs
        /// <summary>
        /// Type d'action
        /// </summary>
        public String TypeAction
        {
            get
            {
                return _type;
            }
            set
            {
                this._type = value;
                OnPropertyChanged("TypeAction");
            }
        }
        #endregion

        //public ObservableCollection<Consequences> Consequences
        //{
        //    get => _consequences;
        //    set
        //    {
        //        _consequences = value;
        //        OnPropertyChanged("Consequences");
        //        OnPropertyChanged("Children");
        //    }
        //}

        //public ObservableCollection<Consequences> Children { get => _consequences;

        //public ObservableCollection<Condition> Conditions
        //{
        //    get => _conditions;
        //    set
        //    {
        //        _conditions = value;
        //        OnPropertyChanged("Consequences");
        //        OnPropertyChanged("Children");
        //    }
        //}

        //public ObservableCollection<Condition> Children { get => _conditions; }
    }
}
