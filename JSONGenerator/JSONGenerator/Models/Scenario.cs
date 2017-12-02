using System.Collections.ObjectModel;
using JSONGenerator.ViewModels;

namespace JSONGenerator.Models
{
    public class Scenario : ViewModelBase
    {
        private ObservableCollection<Story> _stories;

        public Scenario()
        {
            this._stories = new ObservableCollection<Story>();
            this._name = "Scenarios";
        }

        public ObservableCollection<Story> Stories
        {
            get => _stories;
            set
            {
                _stories = value;
                OnPropertyChanged("Paths");
                OnPropertyChanged("Children");
            }
        }

        protected override void AddChild()
        {
            Story child = new Story();
            this._childrens.Add(child);
            this._stories.Add(child);
        }
    }
}
