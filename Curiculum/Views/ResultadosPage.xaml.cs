using Microsoft.Maui.Controls;
using System.Xml.Linq;

namespace Curiculum.Views
{
    public partial class ResultadosPage : ContentPage
    {
        public ResultadosPage(Dictionary<string, string> resultados)
        {
            InitializeComponent();
            NombreLabel.Text = $"{resultados["Nombre"]}";
            FechaNacimientoLabel.Text = $"{resultados["Fecha"]}";
            OcupacionLabel.Text = $"{resultados["Ocupacion"]}";
            ContactoLabel.Text = $"{resultados["Contacto"]}";
            NacionalidadLabel.Text = $"{resultados["Nacionalidad"]}";
            NivelInglesLabel.Text = $"{resultados["Nivel"]}";
            LenguajesProgramacionLabel.Text = $"{resultados["Lenguaje"]}";
            AptitudesLabel.Text = $"{resultados["Aptitudes"]}";
            HabilidadesLabel.Text = $"{resultados["Habilidades"]}";
            PerfilLabel.Text = $"{resultados["Perfil"]}";

        }
    }
}