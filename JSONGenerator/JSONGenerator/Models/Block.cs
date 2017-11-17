using System.Collections.ObjectModel;
using JSONGenerator.Controls;
using JSONGenerator.ViewModels;

namespace JSONGenerator.Models
{
    public class Block : ViewModelBase
    {
        private int _ID;
        private string _description { get; set; }
        private string _type;
        private ObservableCollection<Action> _actions;
        private string _accessConditions;

        public Block()
        {
            this._actions = new ObservableCollection<Action>();
            this._uc = new BlockControl();
        }

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
    }
}
