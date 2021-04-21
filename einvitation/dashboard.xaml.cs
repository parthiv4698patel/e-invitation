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
        protected override void OnAppearing()
        {
            PopulateEventList();
        }
        public void PopulateEventList()
        {
            EventList.ItemsSource = null;
            EventList.ItemsSource = DependencyService.Get<ISQLite>().GetEvents();
        }

        // Go to EventRegistration page
        public async void ButtonClicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EventRegistration(null));
        }
    }
}