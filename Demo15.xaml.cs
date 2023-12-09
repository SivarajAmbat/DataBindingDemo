using Databinding_Session_Demo.Models;
using System.Collections.ObjectModel;

namespace Databinding_Session_Demo;

public partial class Demo15 : ContentPage
{

    //   List<Person> people;
    ObservableCollection<Person> people;
    public Demo15()
    {
        InitializeComponent();
 //       people = new List<Person> {
        people = new ObservableCollection<Person> { 
        new Person{ Name="John Doe", Email="john.doe@gmail.com" },
        new Person{ Name="Mary Jane", Email="mary.jane@gmail.com" },
        new Person{ Name="Clark Kent", Email="clark.kent@gmail.com" },
        new Person{ Name="Tony Stark", Email="tony.stark@gmail.com" }
        };

        peopleList.ItemsSource = people;

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        people.Add(new Person { Name = "Sherlock Holmes", Email = "sherlock.holmes@gmail.com" });
    }
}