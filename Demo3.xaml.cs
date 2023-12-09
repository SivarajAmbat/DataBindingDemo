using Databinding_Session_Demo.Models;
using System.Security.Cryptography;

namespace Databinding_Session_Demo;

public partial class Demo3 : ContentPage
{
    Person person;
    public Demo3()
	{
		InitializeComponent();
        person = new Person
        {
            Name = "John Doe",
            Email = "john.doe@gmail.com"
        };
        
        var nameBinding = new Binding();
        nameBinding.Source = person;
        nameBinding.Path = "Name";
        txtName.SetBinding(Entry.TextProperty, nameBinding);


        var emailBinding = new Binding();
        emailBinding.Source = person;
        emailBinding.Path = "Email";
        txtEmail.SetBinding(Entry.TextProperty, emailBinding);
    }
}