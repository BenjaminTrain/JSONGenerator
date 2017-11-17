using System.Collections.ObjectModel;
using JSONGenerator.Controls;
using JSONGenerator.ViewModels;

namespace JSONGenerator.Models
{
    public class Level : ViewModelBase
    {
        public int _ID { get; set; }
        private string _transition; 
        private ObservableCollection<Block> _blocks;
        private string _imagePath;

        public Level()
        {
            this._blocks = new ObservableCollection<Block>();
            this._uc = new LevelControl();
        }

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
    }
}
