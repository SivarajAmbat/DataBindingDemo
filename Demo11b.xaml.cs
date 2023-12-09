using Databinding_Session_Demo.Models;
using System.Diagnostics;

namespace Databinding_Session_Demo;

public partial class Demo11b : ContentPage
{
    Employee employee;
	public Demo11b()
	{
		InitializeComponent();
        employee = new Employee
        {
            Name = "John Doe",
            Email = "john.doe@gmail.com"
        };

        BindingContext = employee;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Debug.WriteLine($"{employee.Name} {employee.Email}");
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        employee.Name = "Bruce Lee";
        employee.Email = "bruce.lee@gmail.com";

    }
}