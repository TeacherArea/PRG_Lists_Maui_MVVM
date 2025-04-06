using System.Collections.ObjectModel;
using PRG_Lists_Maui_MVVM.Model;

namespace PRG_Lists_Maui_MVVM.ViewModel
{
    internal class PersonService
    {
        public ObservableCollection<Person> myList { get; set; }
        public PersonService()
        {
            myList = new ObservableCollection<Person>
            {
                new Person { Name = "Amanda", Age = 37, Password = "Hemligt" },
                new Person { Name = "Oscar", Age = 44, Password = "Hemligt" }
            };
        }
    }
}
