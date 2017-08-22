using System;
using System.Collections.ObjectModel;
using JSONGenerator.Controls;
using JSONGenerator.ViewModels;

namespace JSONGenerator.Models
{
    class Story : ViewModelBase
    {
        private int _ID;
        private ObservableCollection<Path> _paths;
        private string _description;
        private bool _nsfw;
        private string _pegi;
        private string _imagePath;
        private string _author;
        private DateTime _creationDate;
        private int _version;

        public Story() {
            this._paths = new ObservableCollection<Path>();
            this._uc = new StoryControl();
        }

        public ObservableCollection<Path> Paths
        {
            get => _paths;
            set
            {
                _paths = value;
                OnPropertyChanged("Levels");
                OnPropertyChanged("Children");
            }
        }

        protected override void AddChild()
        {
            Path child = new Path();
            this._childrens.Add(child);
            this._paths.Add(child);
        }

        public string DescriptionStory
        {
            get
            {
                return _description;
            }
            set
            {
                this._description = value;
                OnPropertyChanged("DescriptionStory");
            }
        }

        public bool NSFW
        {
            get
            {
                return _nsfw;
            }
            set
            {
                this._nsfw = value;
                OnPropertyChanged("NSFW");
            }
        }

        public string PEGI
        {
            get
            {
                return _pegi;
            }
            set
            {
                this._pegi = value;
                OnPropertyChanged("PEGI");
            }
        }

        public string ImagePathStory
        {
            get
            {
                return _imagePath;
            }
            set
            {
                this._imagePath = value;
                OnPropertyChanged("ImagePathStory");
            }
        }

        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                this._author = value;
                OnPropertyChanged("Author");
            }
        }
    }
}
