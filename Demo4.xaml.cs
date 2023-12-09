using Databinding_Session_Demo.Models;

namespace Databinding_Session_Demo;

public partial class Demo4 : ContentPage
{
    Person p;
	public Demo4()
	{
		InitializeComponent();
        p = new Person
        {
            Name = "John Doe",
            Email = "john.doe@gmail.com"
        };
        
        BindingContext = p;

        var nameBinding = new Binding();
        nameBinding.Path = "Name";
        txtName.SetBinding(Entry.TextProperty, nameBinding);


        var emailBinding = new Binding();
        emailBinding.Path = "Email";
        txtEmail.SetBinding(Entry.TextProperty, emailBinding);

    }
}