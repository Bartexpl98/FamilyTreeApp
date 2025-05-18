using System;
using FamilyTreeApp.Models;
namespace FamilyTreeApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    //public string Greeting { get; } = "Welcome to Avalonia!";
    public Person Gary { get; set; } = new Person("Gary", new DateTime(1980, 1, 1));
}
