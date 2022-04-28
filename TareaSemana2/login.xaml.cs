using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaSemana2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {


        public login()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "estudiante2022" && txtpass.Text == "uisrael2022")
            {
                Navigation.PushAsync(new Nota());

            }
            else
            {
                DisplayAlert("Error", "Usuario o Clave Incottecta", "ok");
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
}