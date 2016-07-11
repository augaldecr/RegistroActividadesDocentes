using RegistroDocente.Controller;
using RegistroDocente.Models;

using Xamarin.Forms;

namespace RegistroActividadesDocentes.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.Padding = Device.OnPlatform(
                            new Thickness(10, 20, 10, 10),
                            new Thickness(10),
                            new Thickness(10));

            verificaUsuario();

            NuevoButton.Clicked += NuevoButton_Clicked;
            IngresarButton.Clicked += IngresarButton_Clicked;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            verificaUsuario();
        }

        private async void IngresarButton_Clicked(object sender, System.EventArgs e)
        {
            if (DefaultSwitch.IsToggled)
            {
                using (DataAccess db = new DataAccess())
                {
                    Usuario user = db.GetUsuarioXUser(UsuarioEntry.Text);
                    user.defecto = true;
                    db.UpdateUsuario(user);
                }
            }
            await Navigation.PushModalAsync(new MenuPage());
        }

        private async void NuevoButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NuevoUsuarioPage());
        }

        private void verificaUsuario()
        {
            using (DataAccess db = new DataAccess())
            {
                if (db.GetUsuarios() != null)
                {
                    NuevoButton.IsEnabled = false;
                    NuevoButton.IsVisible = false;
                }
            }
        }
    }
}
