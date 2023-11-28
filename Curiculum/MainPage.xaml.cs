using Microsoft.Maui.Controls;

namespace Curiculum
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnNavigateToCuriculumClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Curiculum.Views.CuriculumPage());
        }
    }
}
