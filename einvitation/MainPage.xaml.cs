using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace einvitation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        // Go to dashboard page
        public async void ButtonClicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new dashboard());
        }
    }
}
