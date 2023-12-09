using Databinding_Session_Demo.Models;

namespace Databinding_Session_Demo;

public partial class Demo2 : ContentPage
{
    Person person;

    public Demo2()
    {
        InitializeComponent();
        person = new Person
        {
            Name = "John Doe",
            Email = "john.doe@gmail.com"
        };
        txtName.Text = person.Name;
        txtEmail.Text = person.Email;

        txtName.TextChanged += TxtName_TextChanged;
        txtEmail.TextChanged += TxtEmail_TextChanged;
    }

    private void TxtName_TextChanged(object sender, TextChangedEventArgs e)
    {
        person.Name = txtName.Text;
    }

    private void TxtEmail_TextChanged(object sender, TextChangedEventArgs e)
    {
        person.Email = txtEmail.Text;
    }

}