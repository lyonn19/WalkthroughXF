using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarouselView.FormsPlugin.Abstractions;
using WalkthroughXF.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalkthroughXF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {

        public CarouselViewModel _vm;
        public MainPage()
        {
            InitializeComponent();

            BindingContext = _vm = new CarouselViewModel();

            ConfigureButtons();
        }
        void ConfigureButtons()
        {
            prevBtn.IsVisible = _vm.Position > 0;
            //addPageBtn.IsVisible = _vm.ItemsSource != null;
            nextBtn.IsVisible = _vm.Position < _vm.ItemsSource?.Count - 1;
        }

        void Handle_PositionSelected(object sender, PositionSelectedEventArgs e)
        {
            ConfigureButtons();
            Debug.WriteLine("Position " + myCarousel.Position + " selected");
        }

        public void OnPrev(object sender, EventArgs eventArgs)
        {
            if (_vm.Position > 0)
                _vm.Position--;
        }

        public void OnNext(object sender, TappedEventArgs e)
        {
            if (_vm.Position < _vm.ItemsSource?.Count - 1)
                _vm.Position++;
        }
    }
}