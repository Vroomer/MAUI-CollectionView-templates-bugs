using System.Collections.ObjectModel;

namespace MauiApp10;

public class MainPageViewModel
{
    public ObservableCollection<Group> Data { get; set; } = [new("group A", [1, 2, 3])];
}
