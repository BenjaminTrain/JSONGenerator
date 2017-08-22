using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;
using JSONGenerator.Utils;

namespace JSONGenerator.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool _selectedItem;
        private ICommand _addChildCmd;
        protected ObservableCollection<ViewModelBase> _childrens;
        protected string _name;
        protected UserControl _uc;

        public ICommand AddChildCmd { get => _addChildCmd; }

        public ViewModelBase()
        {
            this._childrens = new ObservableCollection<ViewModelBase>();
            this._addChildCmd = new CommandHandler(param => AddChild(), true);
            this._name = "New element";
        }

        protected virtual void AddChild() {}

        public void OnPropertyChanged(string propname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propname));
        }

        public bool IsSelected
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
                OnPropertyChanged("IsSelected");
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                this._name = value;
                OnPropertyChanged("Name");
            }
        }

        public UserControl UC { get => _uc; }

        public ObservableCollection<ViewModelBase> Children { get => _childrens; }
    }
}
