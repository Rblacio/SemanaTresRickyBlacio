using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SemanaTresRickyBlacio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class page2 : ContentPage
    {
        public page2(string usuario, string contrasena) 
        {
            InitializeComponent();

            // DisplayAlert("Datos enviados", "El usuario es "+ usuario + " La clave es " + contrasena, "cerrar");

            lblNombre.Text = "El usuario es "+ usuario;
            lblContrasena.Text = "La contrasena es " + contrasena;

        
    }
    }
}