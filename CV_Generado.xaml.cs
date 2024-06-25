using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DBP_Xamarin.Principal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CV_Generado : ContentPage
    {
        public CV_Generado(string nombre, string apellido, string fecha, string ocupacion,
            string celular, string correo, string aptitudes, string experiencia, string formacion)
        {
            InitializeComponent();

            Nombre_Label.Text = nombre;
            Apellido_Label.Text = apellido;
            Fecha_Label.Text = fecha;
            Ocupacion_Label.Text = ocupacion;
            Celular_Label.Text = celular;
            Correo_Label.Text = correo;
            Aptitudes_Label.Text = aptitudes;
            Experiencia_Label.Text = experiencia;
            Formacion_Label.Text = formacion;

        }
    }
}