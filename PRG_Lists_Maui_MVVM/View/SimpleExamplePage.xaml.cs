
using System.Collections.ObjectModel;
using PRG_Lists_Maui_MVVM.Model;

namespace PRG_Lists_Maui_MVVM.View
{
    public partial class SimpleExamplePage : ContentPage
    {
        public ObservableCollection<Person> myList { get; set; } = new()
        {
            new Person { Name = "Stina", Age = 12, Password = "Hemligt" },
            new Person { Name = "Pelle", Age = 14, Password = "Hemligt" }
        };
         

        public SimpleExamplePage()
        {          
            InitializeComponent();
            BindingContext = this;
        }
    }
}
