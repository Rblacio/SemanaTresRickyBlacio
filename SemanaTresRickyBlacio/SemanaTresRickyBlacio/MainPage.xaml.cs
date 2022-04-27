using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SemanaTresRickyBlacio
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        
        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            string usuario = TxtUsuario.Text;
            string pass = TxtPass.Text;
            if (usuario == "estudiante2022" && pass == "uisrael2022")
            {
                await Navigation.PushAsync(new page2());

            }
            else
            {
                await DisplayAlert("ERROR", "USUARIO Y/O PASSWORD INCORRECTOS", "Cerrar");
            }

        }
    }
}
