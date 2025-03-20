
using System.Collections.ObjectModel;

namespace ListLek
{
    public class Person
    {
        public string Name { get; set ; }
        public int Age { get; set; }
        public string Password { get; set; }
    }
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Person> myList { get; set; } = new()
        {
            new Person { Name = "Stina", Age = 12, Password = "Hemligt" },
            new Person { Name = "Pelle", Age = 14, Password = "Hemligt" }
        };
         

        public MainPage()
        {
           
            InitializeComponent();
            BindingContext = this;
        }


    }

}
