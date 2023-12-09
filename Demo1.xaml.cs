using Databinding_Session_Demo.Models;

namespace Databinding_Session_Demo;

public partial class Demo1 : ContentPage
{

    public Demo1()
    {

        InitializeComponent();
        Person person  = new Person
        {
            Name = "John Doe",
            Email = "john.doe@gmail.com"
        };
        lblName.Text = person.Name;
        lblEmail.Text = person.Email;

    }
}