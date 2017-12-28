using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalkthroughXF.Controls;
using WalkthroughXF.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalkthroughXF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            //BindingContext = new MainViewModel();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<MainViewModel, TransitionType>(this, AppSettings.TransitionMessage, (sender, arg) =>
            {
                var transitionType = (TransitionType)arg;
                var transitionNavigationPage = Parent as Controls.TransitionNavigationPage;

                if (transitionNavigationPage != null)
                {
                    transitionNavigationPage.TransitionType = transitionType;
                    Navigation.PushAsync(new Page2());
                }
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<MainViewModel, TransitionType>(this, AppSettings.TransitionMessage);
        }
    }
}