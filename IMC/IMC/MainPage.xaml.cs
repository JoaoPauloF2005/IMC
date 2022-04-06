using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(Peso.Text);
            double altura = Convert.ToDouble(Altura.Text);
            double imc;

            imc = peso / (altura * altura);
           

            if (imc < 18.5)
            {
               DisplayAlert ("Seu IMC:" + Math.Round(imc, 2), $"Sua classificação é Abaixo do Peso", "OK");
            }
            else if (imc > 18.5 && imc < 24.9)
            {
                DisplayAlert ("Seu IMC:" + Math.Round(imc, 2), $"Sua classificação é Peso Normal", "OK");
            }
            else if (imc > 25 && imc < 29.9)
            {
                DisplayAlert ("Seu IMC:" + Math.Round(imc, 2), $"Sua classificação é Sobrepeso", "OK");
            }
            else if (imc > 30 && imc < 34.9)
            {
                DisplayAlert ("Seu IMC:" + Math.Round(imc, 2), $"Sua classificação é Obesidade Grau 1", "OK");
            }
            else if (imc > 35 && imc < 39.9)
            {
                DisplayAlert ("Seu IMC:" + Math.Round(imc, 2), $"Sua classificação é Obesidade Grau 2", "OK");
            }
            else
            {
                 DisplayAlert ("Seu IMC:" + Math.Round(imc, 2), $"Sua classificação é Obesidade Grau 3", "OK");
            }
           
        }
    }
}
