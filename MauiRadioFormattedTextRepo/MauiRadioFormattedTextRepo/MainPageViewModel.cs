using System.ComponentModel;

namespace MauiRadioFormattedTextRepo;

public class MainPageViewModel: INotifyPropertyChanged
{
    private int _count = 30;

    public event PropertyChangedEventHandler? PropertyChanged;

    public int Count
    {
        get => _count;
        set => _count = value;
    }

    public Command IncrementCommand => new Command(() =>
    {
        Count++;

        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Count)));
    });
}
