using Databinding_Session_Demo.Models;
using System.Diagnostics;

namespace Databinding_Session_Demo;

public partial class Demo12 : ContentPage
{
    Customer customer;
	public Demo12()
	{
		InitializeComponent();
        customer = new Customer 
        {
            Name = "John Doe",
            Email = "john.doe@gmail.com"
        };

        BindingContext = customer;
	}


    private void Button_Clicked(object sender, EventArgs e)
    {
        Debug.WriteLine($"{customer.Name} {customer.Email}");
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        customer.Name = "Bruce Lee";
        customer.Email = "bruce.lee@gmail.com";

    }
}


