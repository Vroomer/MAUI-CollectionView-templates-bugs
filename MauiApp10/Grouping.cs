using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiApp10;

public class Group : Grouping<string, int>
{
    public Group(string key, IEnumerable<int> items) : base(key, items)
    {
    }

    public int Total => Items.Sum();
}

public class Grouping<TKey, TItem> : ObservableRangeCollection<TItem>, INotifyPropertyChanged
{
    public TKey Key { get; }

    public new ICollection<TItem> Items => base.Items;

    public Grouping(TKey key, IEnumerable<TItem> items)
    {
        Key = key;
        AddRange(items);
    }
}