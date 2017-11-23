using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JSONGenerator.ViewModels;

namespace JSONGenerator.Models
{
    class Action : ViewModelBase
    {
        #region Champs
        /// <summary>
        /// Type d'action 
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Liste de conséquences
        /// </summary>
        private ObservableCollection<Consequence> _consequences;

        /// <summary>
        /// Liste de conditions
        /// </summary>
        private ObservableCollection<Condition> _conditions;
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
