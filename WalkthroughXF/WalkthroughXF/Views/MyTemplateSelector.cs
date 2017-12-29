using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WalkthroughXF.Views
{
    public class MyTemplateSelector : DataTemplateSelector
    {
        private readonly DataTemplate templateOne;
        private readonly DataTemplate templateTwo;

        public MyTemplateSelector()
        {
            this.templateOne = new DataTemplate(typeof(MyFirstView));
            this.templateTwo = new DataTemplate(typeof(MySecondView));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if ((int)item % 2 == 0)
                return templateTwo;

            return templateOne;
        }
    }
}
