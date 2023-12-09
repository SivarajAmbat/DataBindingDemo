
using System.Diagnostics;
using Databinding_Session_Demo.Models;

namespace Databinding_Session_Demo;

public partial class Demo11 : ContentPage
{
    Person person;
    public Demo11()
	{
		InitializeComponent();
        person = new Person
        {
            Name = "John Doe",
            Email = "john.doe@gmail.com"
        };

        BindingContext = person;

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Debug.WriteLine($"{person.Name} {person.Email}");
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        person.Name = "Bruce Lee";
        person.Email = "bruce.lee@gmail.com";

    }
}