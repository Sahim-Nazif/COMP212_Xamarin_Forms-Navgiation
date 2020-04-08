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

       public string fullName, program, semester, course;
        public MainPage()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Clicked(object sender, EventArgs e)
        {
            fullName = txtFullName.Text;
            program = txtProgram.Text;
            semester = txtSemster.Text;
            course = txtCourse.Text;
        Navigation.PushAsync(new DisplayDetails(fullName, program, semester,course));

        }   
    }
}
