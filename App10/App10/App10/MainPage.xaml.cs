using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App10
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

public class MainPageViewModel : BindableObject
    {
        public ICommand Item1Command { get; }
        public ICommand Item2Command { get; }
        public ICommand Item3Command { get; }
        public ICommand Item4Command { get; }

            public MainPageViewModel()
        {
            // Inicializa os comandos com navegação para novas páginas
            Item1Command = new Command(OnItem1Clicked);
            Item2Command = new Command(OnItem2Clicked);
            Item3Command = new Command(OnItem3Clicked);
            Item4Command = new Command(OnItem4Clicked);
            }

        private async void OnItem1Clicked()
        {
                await Application.Current.MainPage.Navigation.PushAsync(new Page1());
            }

        private async void OnItem2Clicked()
        {
                await Application.Current.MainPage.Navigation.PushAsync(new Page2());
            }

        private async void OnItem3Clicked()
        {
                await Application.Current.MainPage.Navigation.PushAsync(new Page3());
            }
        private async void OnItem4Clicked()
         {
               await Application.Current.MainPage.Navigation.PushAsync(new Page4());
           }
        }

}
}
