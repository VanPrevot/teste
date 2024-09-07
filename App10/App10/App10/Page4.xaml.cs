using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App10
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
        }

        private async void btEnviar_Clicked(object sender, EventArgs e)
        {
            String re = etRemetente.Text;
            String des = etDestino.Text;
            String ass = etAssunto.Text;
            String texto = etTexto.Text;

            String url = "mailto:" + des + "?subject=" + ass + "&body=" + texto;
            Device.OpenUri(new Uri(url));

            // Aguarda 2 segundos antes de voltar para a MainPage
            await Task.Delay(2000);

            // Retorna à MainPage
            await Navigation.PopToRootAsync();
        }

        private void btLimpar_Clicked(object sender, EventArgs e)
        {
            // Limpa os campos de entrada de dados
            etRemetente.Text = string.Empty;
            etDestino.Text = string.Empty;
            etAssunto.Text = string.Empty;
            etTexto.Text = string.Empty;
        }
    }
}