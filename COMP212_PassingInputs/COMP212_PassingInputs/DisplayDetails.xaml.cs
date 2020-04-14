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
    public partial class DisplayDetails : ContentPage
    {
        public DisplayDetails(string fname, string program, string semester, string course, string email)
        {
            InitializeComponent();
            lblFullName.Text ="Your Name: " + fname;
            lblProgram.Text ="Your Program: " + program;
            lblSemester.Text ="Semster Classification: " +  semester;
            lblCourse.Text ="Course Selection: " + course;
            lblEmail.Text = "Email: " + email;
          
        }

        private void CheckoutBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Checkout());
        }
    }
}