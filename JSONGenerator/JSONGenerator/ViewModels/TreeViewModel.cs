using System.Collections.ObjectModel;
using JSONGenerator.Models;

namespace JSONGenerator.ViewModels
{
    public class TreeViewModel : ViewModelBase
    {
        private ObservableCollection<Scenario> _scenarios;

        public TreeViewModel() {
            _scenarios = new ObservableCollection<Scenario>
            {
                new Scenario()
            };
        }

        public ObservableCollection<Scenario> Scenarios
        {
            get
            {
                return _scenarios;
            }
            set
            {
                _scenarios = value;
                OnPropertyChanged("Scenarios");
            }
        }
    }
}
