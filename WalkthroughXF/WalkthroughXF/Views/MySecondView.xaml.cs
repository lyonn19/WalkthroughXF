using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalkthroughXF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MySecondView : ContentView
    {
        public MySecondView()
        {
            InitializeComponent();

            InitializeComponent();
            BackgroundColor = Color.White;

            /*var source = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

			myList.ItemsSource = source;*/

            var tapGesture = new TapGestureRecognizer((obj) => Debug.WriteLine("Second View tapped"));
            GestureRecognizers.Add(tapGesture);
        }
    }
}