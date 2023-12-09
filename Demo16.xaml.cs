using System.Collections.ObjectModel;
using Databinding_Session_Demo.Models;

namespace Databinding_Session_Demo;

public partial class Demo16 : ContentPage
{

    ObservableCollection<Person> people;
    public Demo16()
	{
		InitializeComponent();
        people = new ObservableCollection<Person> {
        new Person{ Name="John Doe", Email="john.doe@gmail.com" },
        new Person{ Name="Mary Jane", Email="mary.jane@gmail.com" },
        new Person{ Name="Clark Kent", Email="clark.kent@gmail.com" },
        new Person{ Name="Tony Stark", Email="tony.stark@gmail.com" }
        };

        collectionView.ItemsSource = people;
    }
}
