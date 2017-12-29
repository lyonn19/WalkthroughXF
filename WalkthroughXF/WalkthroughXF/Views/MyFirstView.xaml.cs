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
    public partial class MyFirstView : ContentView
    {
        public MyFirstView()
        {
            InitializeComponent();
            BackgroundColor = Color.White;
        }
    }
}