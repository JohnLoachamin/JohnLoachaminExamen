using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JohnLoachaminExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class logincs : ContentPage
    {
        public logincs()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtUsuario.Text)&& String.IsNullOrWhiteSpace(txtContrasenia.Text))
                {
                    DisplayAlert("Aviso", "Campos vacíos", "OK");
                }
                else
                {
                    if (txtUsuario.Text.Equals("estudiante2021") && txtContrasenia.Text.Equals("uisrael2021"))
                    {
                        await Navigation.PushAsync(new registro(txtUsuario.Text));
                    }
                    else
                    {
                        DisplayAlert("Aviso", "Usuario o contraseña incorrectos", "OK");
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}