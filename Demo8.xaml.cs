namespace Databinding_Session_Demo;

public partial class Demo8 : ContentPage
{
	public Demo8()
	{
		InitializeComponent();

		label.BindingContext = slider;
		label.SetBinding(Label.RotationProperty, "Value");
	}
}