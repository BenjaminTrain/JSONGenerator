using System.Collections.ObjectModel;
using JSONGenerator.Models;

namespace JSONGenerator.ViewModels
{
    class TreeViewModel : ViewModelBase
    {
        private ObservableCollection<Scenario> _scenarii;

        public TreeViewModel() {
            _scenarii = new ObservableCollection<Scenario>
            {
                new Scenario()
            };
        }

        public ObservableCollection<Scenario> Scenarii
        {
            get
            {
                return _scenarii;
            }
            set
            {
                _scenarii = value;
                OnPropertyChanged("Scenarii");
            }
        }
    }
}
