using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Botones.Vistas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        double N1;
        double N2;
        double resultado;

        private void btnHola_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Esto es una prueba", "Hola", "OK");
        }

        private void btnCasa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimerPagina());
        }

        private void caclular_Clicked(object sender, EventArgs e)
        {
            calcular();
        }

        private void calcular()
        {
            if(string.IsNullOrEmpty(txtNumero1.Text))
            {
                DisplayAlert("Error", "Valor 1 requerido", "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(txtNumero2.Text))
            {
                DisplayAlert("Error", "Valor 2 requerido", "Aceptar");
                return;
            }
            N1 = Convert.ToDouble(txtNumero1.Text);
            N2 = Convert.ToDouble(txtNumero2.Text);
            resultado = N1 + N2;
            DisplayAlert("Resultado", resultado.ToString(), "OK");
        }
    }
}
