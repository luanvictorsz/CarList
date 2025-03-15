using CarList.Models;
using CarList.Services;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CarList.ViewModels
{
    public partial class CarListViewModel : BaseViewModel
    {
        private readonly CarServices carServices;
        public ObservableCollection<Car> Cars { get; private set; }

        public CarListViewModel(CarServices carServices)
        {
            Title = "car list";
            this.carServices = carServices;
        }

        [RelayCommand]
        async Task GetCarList()
        {
            if (IsLoading) return;
            try
            {
                isloading = true;
                if (Cars.Any()) Cars.Clear();

                var cars = carServices.GetCars();
                foreach(var car in cars)
                {
                    cars.Add(car);
                }
            }   
            catch(Exception ex)
            {
                Debug.WriteLine($"Unable to  get cars: {ex.Message}");
                await Shell.Current.DisplayAlert("Error", "Failed to  retrive list of cars", "Ok"); 
            }
            finally
            {
                isloading = false;
            }
        }
    }
}
