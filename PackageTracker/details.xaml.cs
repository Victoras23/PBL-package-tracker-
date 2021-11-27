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
    public partial class details : ContentPage
    {
        public details(string id , string sender, string destination, string location , string cid, string phone, string state, string time)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Id.Text = id;
            Sender.Text = sender;
            Destination.Text = destination;
            Location.Text = location;
            CId.Text = cid;
            PN.Text = phone;
            State.Text = state;
            Time.Text = time;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}