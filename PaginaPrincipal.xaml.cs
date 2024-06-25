using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using DBP_Xamarin.Principal;
using System.Globalization;

namespace DBP_Xamarin
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }
        
        private void btn_continue_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Formulario());
        }
    }
}
