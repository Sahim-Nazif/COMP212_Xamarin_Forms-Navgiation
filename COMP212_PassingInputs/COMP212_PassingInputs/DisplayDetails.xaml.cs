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
        public DisplayDetails(string fname, string program, string semester, string course)
        {
            InitializeComponent();
            lblFullName.Text = fname;
            lblProgram.Text = program;
            lblSemester.Text = semester;
            lblCourse.Text = course;
          
        }
    }
}