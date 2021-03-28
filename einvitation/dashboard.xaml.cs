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
    public partial class dashboard : ContentPage
    {
        public dashboard()
        {
            InitializeComponent();
        }
        // Go to EventRegistration page
        public async void ButtonClicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EventRegistration());
        }
    }
}