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
    public partial class registro : ContentPage
    {
        private Double interes = 0;
        private Double CuotaFinal = 0;
        private string usuario = "";
        private String mensaje = "";
        public registro(String usuario)
        {
            InitializeComponent();
            this.lblNombreUsuario.Text = "Bienvenido usuario: " + usuario;
            this.usuario = usuario;
        }

        private  void btnCaulcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtNombre.Text) || String.IsNullOrWhiteSpace(txtInicial.Text))
                {
                    DisplayAlert("Aviso", "Campos vacíos", "OK");
                }
                else
                {
                    if (Convert.ToDouble(txtInicial.Text) > 1800)
                    {
                        DisplayAlert("Aviso", "El monto inicial no deber ser mayor a 1800", "OK");
                        txtInicial.Text = "1800";
                    }
                    else
                    {
                        if (Convert.ToDouble(txtInicial.Text) == 1800)
                        {
                            txtInicial.Text = "1800";
                            txtMensual.Text = "0";
                            mensaje = "Monto final 1800$.";
                            
                        }
                        else
                        {
                            interes = 1800 * 0.05;
                            double cuotas = ((1800 - Convert.ToDouble(txtInicial.Text))/3)+interes;
                            this.txtMensual.Text = Convert.ToString(cuotas);
                            double MontoFinal = (cuotas*3) + Convert.ToDouble(txtInicial.Text);

                            mensaje = "Tienes 3 pagos pendientes de: " + cuotas + "$\n Monto Final a pagar: " + MontoFinal + "$";
                           

                        }


                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtMensual.Text))
            {
                DisplayAlert("Aviso","Primero realice el calculo para Guardar.","OK");
            }
            else {
                DisplayAlert("Aviso", "Datos Guardados con exito", "OK");
                await Navigation.PushAsync(new resumen(this.usuario, txtNombre.Text, mensaje));
            }
            
        }
    }
}