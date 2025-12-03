using System.Collections.ObjectModel;
using AlienUD.Models;

namespace AlienUD.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<Film> Filmy { get; } = new()
    {
        new Film { Tytul = "Alien" },
        new Film { Tytul = "Top Gun" },
        new Film { Tytul = "Man in Black" },
    };
}