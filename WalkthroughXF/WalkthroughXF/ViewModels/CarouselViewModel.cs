using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WalkthroughXF.Views;
using Xamarin.Forms;

namespace WalkthroughXF.ViewModels
{
    public class CarouselViewModel : INotifyPropertyChanged
    {

        
        public int Position { get; set; }
        public CarouselViewModel()
        {
            Position = 0;

            ItemsSource = new ObservableCollection<View>() {
                new MyFirstView() { BindingContext = 0 },
                new MyFirstView() { BindingContext = 1 },
                new MyFirstView() { BindingContext = 2 },
                new MyFirstView() { BindingContext = 3 },
                new MyFirstView() { BindingContext = 4 }
            };

            TemplateSelector = new MyTemplateSelector(); //new DataTemplate (typeof(MyView));
        }


        public ObservableCollection<View> ItemsSource { get; set; }

        public MyTemplateSelector TemplateSelector { get; set; }

        #region Notificador ViewModel
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
