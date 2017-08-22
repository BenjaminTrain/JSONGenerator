using System.Collections.ObjectModel;
using JSONGenerator.Controls;
using JSONGenerator.ViewModels;

namespace JSONGenerator.Models
{
    class Path : ViewModelBase
    {
        private int _ID;
        private int _IDStory;
        private ObservableCollection<Level> _levels;
        private string _description;
        private bool _isActive;

        public Path()
        {
            this._levels = new ObservableCollection<Level>();
            this._uc = new PathControl();
        }

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
    }
}
