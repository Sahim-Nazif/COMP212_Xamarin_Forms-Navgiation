using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace COMP212_PassingInputs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Checkout : ContentPage
    {
        public Checkout()
        {
            InitializeComponent();
        }

        private void chk1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            chk2.IsChecked = !chk1.IsChecked;
        }
        private void chk2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            chk1.IsChecked = !chk2.IsChecked;
        }

        private async void btnOrder_Clicked(object sender, EventArgs e)
        {
            if (txtAccount.Text == null)
            {
                await DisplayAlert("Error", "Account Number is Required !","Ok");
            }
            if (txtSecurity.Text == null)
            {
                await DisplayAlert("Error", "Security Code is required. Can be found on back of the card !", "Ok");
            }
            else
            {
                await DisplayAlert("Confirmation", "Payment was successful. You will receive an email shortly!", "Ok");
                await Navigation.PushAsync(new MainPage());
            }
          
        }
    }
}