using Patronage_16.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace Patronage_16.ViewModel
{
    public class PersonsViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Person> Persons { get; set; }
        public ICommand SaveCmd { get; set; }

        private int _BornDate = 0;
        public int BornDate
        {
            get
            {
                return _BornDate;
            }
            set
            {
                _BornDate = value;
                OnPropertyChanged("BornDate");
            }
        }

        public PersonsViewModel()
        {
            SaveCmd = new RelayCommand(pars => Save());

            Persons = new ObservableCollection<Person>()
            {
                new Person("Jan", "Kowalski"),
                new Person("John","Smith")
            };
        }

        private void Save()
        {
            // TODO
        }

        public event PropertyChangedEventHandler PropertyChanged = null;
        virtual protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

    }
}
