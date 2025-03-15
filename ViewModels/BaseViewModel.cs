using CommunityToolkit.Mvvm.ComponentModel;

namespace CarList.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        string? _title;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotLoading))]
        public static bool isloading;

        public bool IsNotLoading => !isloading;
    }
}