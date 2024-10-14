using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Act_Criticografo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Button_Critica(object sender, EventArgs e)
        {
            // Se almacena el nombre que ingresas
            string nombre = Nombre.Text;

            // Te da el genero que seleccionaste
            string genero = Hom.IsChecked ? "Hombre" : "Mujer";

            // Verifica que si eligiste el checkbox
            List<string> caracteristicas = new List<string>();

            if(genero == "Hombre")
            {
                if (Alto.IsChecked)
                    caracteristicas.Add("Alto");
                if (Listo.IsChecked)
                    caracteristicas.Add("Listo");
                if (Raro.IsChecked)
                    caracteristicas.Add("Raro");
                if (Feo.IsChecked)
                    caracteristicas.Add("Feo");
                if (Extravagante.IsChecked)
                    caracteristicas.Add("Extravagante");
                if (Grande.IsChecked)
                    caracteristicas.Add("Grande");
            }
            else if (genero == "Mujer")
            {
                if (Alto.IsChecked)
                    caracteristicas.Add("Alta");
                if (Listo.IsChecked)
                    caracteristicas.Add("Lista");
                if (Raro.IsChecked)
                    caracteristicas.Add("Rara");
                if (Feo.IsChecked)
                    caracteristicas.Add("Fea");
                if (Extravagante.IsChecked)
                    caracteristicas.Add("Extravagante");
                if (Grande.IsChecked)
                    caracteristicas.Add("Grande");
            }
            

            // Crear el mensaje para el DisplayAlert
            string mensaje = $"Nombre: {nombre}\nGénero: {genero}\nAtributos: {string.Join(", ", caracteristicas)}";

            // Muestra el DisplayAlert
            DisplayAlert("Datos Criticados", mensaje, "Aceptar");
        }



    }
}
