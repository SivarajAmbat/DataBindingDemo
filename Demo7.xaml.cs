using Databinding_Session_Demo.Models;

namespace Databinding_Session_Demo;

public partial class Demo7 : ContentPage
{
	public Demo7()
	{
		InitializeComponent();
		Person person = new Person
        {
            Name = "John Doe",
            Email = "john.doe@gmail.com"
        };
        BindingContext = person;
    }
}