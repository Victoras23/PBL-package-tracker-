using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PackageTracker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddANewPackage : ContentPage
    {
        public AddANewPackage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            var code = packageCode.Text;
        }
        private void ImageButton_Clicked(object sender, EventArgs e)
        {
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
    
}