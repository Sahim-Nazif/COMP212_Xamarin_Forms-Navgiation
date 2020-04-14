using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace COMP212_PassingInputs
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

       public string fullName, program, semester, course,email;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void RegisterBtn_Clicked(object sender, EventArgs e)
        {
            if (txtFullName.Text==null)
            {
                await Application.Current.MainPage.DisplayAlert(
                     "Error",
                     "Please Enter Your Full Name !",
                     "Ok"
                    );
                return;
            }
            if (txtProgram.Text == null)
            {
                await Application.Current.MainPage.DisplayAlert(
                     "Error",
                     "Please Enter Your Program Name !",
                     "Ok"
                    );
                return;
            }
            if (txtSemster.Text == null)
            {
                await Application.Current.MainPage.DisplayAlert(
                     "Error",
                     "Which is Your Semester Classification ?",
                     "Ok"
                    );
                return;
            }
            if (txtCourse.Text == null)
            {
                await Application.Current.MainPage.DisplayAlert(
                     "Error",
                     "You Need Enter Course Code !",
                     "Ok"
                    );
                return;
            }
            if (txtEmail.Text == null)
            {
                await Application.Current.MainPage.DisplayAlert(
                   "Error",
                   "Email is required !",
                   "Ok"
                  );
                return;
            }
        
            else if (txtCourse.Text=="COMP 212" || txtCourse.Text=="Java")
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Info",
                     "This Course's Cost is $477. Click Ok to Proceed To Checkout!",
                     "Ok"
                    );
                fullName = txtFullName.Text;
                program = txtProgram.Text;
                semester = txtSemster.Text;
                course = txtCourse.Text;
                email = txtEmail.Text;
               await Navigation.PushAsync(new DisplayDetails(fullName, program, semester, course,email));

            }
            else if (txtCourse.Text !="COMP 212" || txtCourse.Text !="Java")
            {
                await Application.Current.MainPage.DisplayAlert(
                   "Error",
                    "Please Check Your input for Course. It should be COMP 212 or Java!",
                    "Ok"
                   );
            }

        }

        private void ClearBtn_Clicked(object sender, EventArgs e)
        {
            txtFullName.Text = null;
            txtProgram.Text = null;
            txtSemster.Text = null;
            txtCourse.Text = null;
        }

    }
}
