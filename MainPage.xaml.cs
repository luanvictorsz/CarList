using CarList.ViewModels;

namespace CarList
{
    public partial class MainPage : ContentPage
    {
        private readonly CarListViewModel carListViewModel;
        public MainPage(CarListViewModel carListViewModel)
        {
            InitializeComponent();
            BindingContext = carListViewModel;
        }
    }

}
