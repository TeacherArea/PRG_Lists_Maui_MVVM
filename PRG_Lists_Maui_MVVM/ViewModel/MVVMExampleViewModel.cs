using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using PRG_Lists_Maui_MVVM.Model;

namespace PRG_Lists_Maui_MVVM.ViewModel
{
    public class MVVMExampleViewModel : INotifyPropertyChanged
    {
        private string _name;
        private string _age;
        private string _password;
        private bool _showPassword;
        private bool _IsHiddenPassword = true;

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Age
        {
            get => _age;
            set
            {
                if (_age != value)
                {
                    _age = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsPasswordHidden
        {
            get => _IsHiddenPassword;
            set
            {
                if (_IsHiddenPassword != value)
                {
                    _IsHiddenPassword = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool ShowPassword
        {
            get => _showPassword;
            set
            {
                if (_showPassword != value)
                {
                    _showPassword = value;
                    OnPropertyChanged();
                    IsPasswordHidden = !_showPassword;
                }
            }
        }

        public ObservableCollection<Person> MyList => MediaService.Instance.MyList;
        public ICommand AddPersonCommand { get; }

        public MVVMExampleViewModel()
        {
            AddPersonCommand = new Command(OnAddPerson);
        }
        private void OnAddPerson()
        {
            if (int.TryParse(Age, out int parsedAge))
            {
                MediaService.Instance.AddPerson(Name, parsedAge, Password);
                Name = string.Empty;
                Age = string.Empty;
                Password = string.Empty;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}