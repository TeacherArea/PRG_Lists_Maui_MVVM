using PRG_Lists_Maui_MVVM.Model;
using System.Collections.ObjectModel;

namespace PRG_Lists_Maui_MVVM.ViewModel
{
    internal class MediaService
    {
        public static MediaService Instance { get; } = new MediaService();
        public ObservableCollection<Person> MyList { get; set; }
        public MediaService()
        {
            MyList = new ObservableCollection<Person>
            {
                new Person { Name = "Amanda", Age = 41, Password = "Hemligt" },
                new Person { Name = "Oscar", Age = 37, Password = "Hemligt" }
            };
        }
        public void AddPerson(string name, int age, string password)
        {
            MyList.Add(new Person { Name = name, Age = age, Password = password });
        }
    }
}
