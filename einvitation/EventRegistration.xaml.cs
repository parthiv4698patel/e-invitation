using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace einvitation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventRegistration : ContentPage
    {
        public EventRegistration()
        {
            InitializeComponent();
        }

        public async void ButtonClicked3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new dashboard());
        }
    }
}