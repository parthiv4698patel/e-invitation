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
        Event eventDetails;
        public EventRegistration(Event details)
        {
            InitializeComponent();
            if (details != null)
            {
                eventDetails = details;
                PopulateDetails(eventDetails);
            }
        }

       
        private void PopulateDetails(Event details)
        {
            title.Text = details.Title;
            description.Text = details.Description;
        }

        public async void ButtonClicked3(object sender, EventArgs e)
        {

            //await Navigation.PushAsync(new dashboard());
            if (registrationsubmit.Text == "Save")
            {
                Event evt = new Event();
                evt.Title = title.Text;
                evt.Description = description.Text;
                bool res = DependencyService.Get<ISQLite>().ButtonClicked3(evt);

                if (res)
                {
                    await Navigation.PopAsync();
                }
                else
                {
                    DisplayAlert("Message", "Data Failed To Save", "Ok");
                }
            } //if
            
          
        }
    }
}