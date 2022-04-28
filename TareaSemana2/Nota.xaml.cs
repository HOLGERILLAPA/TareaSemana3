using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaSemana2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Nota : ContentPage
    {
      

        public Nota()
        {
            InitializeComponent();
        }

        private void BtnNota_Clicked(object sender, EventArgs e)
        {        
              try
                {
                    decimal NotaSeguimiento1 = decimal.Parse(TextNotaSeguimiento1.Text);
                    decimal Examenparcial1 = decimal.Parse(TxtExamenparcial1.Text);
                    decimal parcial1 = (NotaSeguimiento1 * (decimal)0.3) + Examenparcial1 * (decimal)0.2;
                     PrimeraNotaParcial.Text = parcial1.ToString();
                   decimal NotaSeguimiento2 = decimal.Parse(TextNotaSeguimiento2.Text);
                    decimal Examenparcial2 = decimal.Parse(TxtExamenparcia12.Text);
                    decimal Parcial2 = (NotaSeguimiento2 * (decimal)0.3) + Examenparcial2 * (decimal)0.2;
                    SegundaNotaParcial.Text = Parcial2.ToString();
                        
                decimal notafinal = parcial1 + Parcial2;
                    Notafinal.Text = notafinal.ToString();
                    if (notafinal >= 7)
                    {
                        DisplayAlert("Calificacion", "Aprobado", "ok");
                        return;
                    }
                    if (notafinal >= 5 && notafinal <= (decimal)6.9)
                    {
                        DisplayAlert("Calificacion", " Examen Completantario", "ok");
                        return;
                    }
                    if (notafinal < 5)

                    {
                        DisplayAlert("Calificacion", "Reprobado", "ok");
                        return;
                    }
                    }
                catch (Exception ex)

                {
                    DisplayAlert("Error", ex.Message, "ok");
                }


            }
        }
    }