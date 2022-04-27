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
        public page2()

        {
            InitializeComponent();
            DisplayAlert("Bienvenido", "Usuario y Password Correctos", "Aceptar");
        }

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            //Evitar que la app cierre por un error
            try
            {
                double var1 = Convert.ToDouble(TxtNota1.Text);
                double var2 = Convert.ToDouble(TxtExamane1.Text);
                double suma = (var1 * 0.3) + (var2 * 0.2);
                TxtResultado1.Text = suma.ToString();
            }
            catch (Exception ex)
            {

                DisplayAlert("Error :", ex.Message, "Cerrar");
            }
        }

        private void BtnCalcular2_Clicked(object sender, EventArgs e)
        {
            try
            {
                double var3 = Convert.ToDouble(TxtNota2.Text);
                double var4 = Convert.ToDouble(TxtExamane2.Text);
                double suma = (var3 * 0.3) + (var4 * 0.2);
                TxtResultado2.Text = suma.ToString();
            }
            catch (Exception ex)
            {

                DisplayAlert("Error :", ex.Message, "Cerrar");
            }
        }

        private void BtnNotaFinal_Clicked(object sender, EventArgs e)
        {

            try
            {
                double Nota1 = Convert.ToDouble(TxtResultado1.Text);
                double Nota2 = Convert.ToDouble(TxtResultado2.Text);
                double NotaFinal = Nota1 + Nota2;
                TxtNotaFinal.Text = NotaFinal.ToString();
                if (NotaFinal <= 6.9 && NotaFinal >= 5)
                {
                    //TxtResultadoF.Text = "El Estudiante Debe Rendir el Examen Complementario";
                    DisplayAlert("Tiene una Oportunidad:", "El Estudiante Debe Rendir el Examen Complementario", "Cerrar");
                }
                else
                {
                    if (NotaFinal >= 7)
                    {
                        DisplayAlert("Felicitaciones", "El Estudiante Aprobo la Materia", "Cerrar");
                    }
                    else
                    {
                        if (NotaFinal < 5)
                        {
                            DisplayAlert("Lo Sentimos", "El Estudiante Reprobo la Materia", "Cerrar");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                DisplayAlert("Error :", ex.Message, "Cerrar");
            }


        }
    }
}
