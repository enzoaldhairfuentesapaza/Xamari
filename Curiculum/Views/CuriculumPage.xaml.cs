using Microsoft.Maui.Controls;
namespace Curiculum.Views
{
    public partial class CuriculumPage : ContentPage
    {
        public CuriculumPage()
        {
            InitializeComponent();
        }
        private async void OnEnviarClicked(object sender, EventArgs e)
        {
            string nombre = NombreEntry.Text;
            DateTime fecha = FechaDate.Date;
            string fechaString = fecha.ToString("dd/MM/yyyy");
            string ocupacion = Ocupacion.Text;
            string contacto = Contacto.Text;
            var nacionalidad = Nacionalidad.SelectedItem;
            string nacionalidadString = nacionalidad?.ToString() ?? string.Empty;
            var nivel = Nivel;
            string nivelString = nivel?.ToString() ?? string.Empty;
            var lenguaje = Lenguaje.SelectedItem;
            string lenguajeString = lenguaje?.ToString() ?? string.Empty;
            string aptitudes = Aptitudes.Text;
            var habilidades = Habilidades.SelectedItem;
            string habilidadesString = habilidades?.ToString() ?? string.Empty;
            string perfil = Perfil.Text;

            var resultados = new Dictionary<string, string>
            {
                { "Nombre", nombre },
                { "Fecha", fechaString },
                { "Ocupacion", ocupacion },
                { "Contacto", contacto },
                { "Nacionalidad", nacionalidadString},
                { "Nivel", nivelString},
                { "Lenguaje", lenguajeString },
                { "Aptitudes", aptitudes },
                { "Habilidades", habilidadesString },
                { "Perfil", perfil },
            };
            await Navigation.PushAsync(new ResultadosPage(resultados));
        }
    }
}