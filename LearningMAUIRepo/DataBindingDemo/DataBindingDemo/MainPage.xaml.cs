using System.ComponentModel;
using Person = DataBindingDemo.Models.Person;

namespace DataBindingDemo;

public partial class MainPage : ContentPage
{
	Person person = new Person();
	public MainPage()
	{
		InitializeComponent();
        person = new Person
        {
            Name = "Alp",
            Phone = "999999999",
            Address = "İstanbul"
        };

        BindingContext = person;
    }

    private void OnCounterClicked(object sender, EventArgs e)
	{
        //person.Name = "Ahmet";
        //person.Phone = "111111";
        //person.Address = "Ümraniye";
        // böyle olunca çalıştı aşağıdaki gibi olunca çalışmadı :)
        person = new Person
        {
            Name = "Ahmet",
            Phone = "1111111",
            Address = "New York"
        };




        //txtName.BindingContext = person;
        //txtName.SetBinding(Label.TextProperty, "Phone");


        //Binding personBinding = new Binding();
        //personBinding.Source = person;
        //personBinding.Path = "Address";
        //txtName.SetBinding(Label.TextProperty, personBinding);
        //Burayı XAML ile yapmaya gidiyoruz.
    }
}

