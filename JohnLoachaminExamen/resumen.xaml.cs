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
    public partial class resumen : ContentPage
    {
        public resumen(String usuario, String nombre, String Total)
        {
            InitializeComponent();
            txtUsuario.Text = usuario;
            txtNombre.Text = nombre;
            lblTotal.Text = Total;
        }
    }
}