using RegistroActividadesDocentes.Controller;
using RegistroActividadesDocentes.Models;
using System;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RegistroActividadesDocentes.Views
{
    public partial class NuevoUsuarioPage : ContentPage
    {
        public NuevoUsuarioPage()
        {
            InitializeComponent();
            GuardarButton.Clicked += GuardarButton_Clicked;
        }

        private void GuardarButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                Persona persona = new Persona
                {
                    Cedula = CedulaEntry.Text,
                    Nombre = NombreEntry.Text,
                    Apellido1 = Apellido1Entry.Text,
                    Apellido2 = Apellido2Entry.Text,
                    FechaNacimiento = NacimientoDatePicker.Date,
                    Email = EmailEntry.Text,
                    Celular = CelularEntry.Text,
                    Telefono = TelefonoEntry.Text
                };

                using (DataAccess db = new DataAccess())
                {
                    db.InsertarPersona(persona);
                    persona = db.GetPersona(CedulaEntry.Text);
                }

                #region Guarda usuario y defecto o no

                Usuario usuario;

                DisplayAlert("Éxito", "Información guardada con éxito " +
                    "¿Desea seguir utilizando el programa con estas credenciales?", "Sí", "No")
                    .ContinueWith(t =>
                    {
                        if (t.Result)
                        {
                            usuario = new Usuario
                            {
                                usuario = UsuarioEntry.Text,
                                password = PasswordEntry.Text,
                                persona = persona.ID,
                                defecto = true
                            };
                        }
                        else
                        {
                            usuario = new Usuario
                            {
                                usuario = UsuarioEntry.Text,
                                password = PasswordEntry.Text,
                                persona = persona.ID
                            };
                        }
                        using (DataAccess db = new DataAccess())
                        {
                            db.InsertarUsuario(usuario);
                        }
                    }, TaskScheduler.FromCurrentSynchronizationContext());
                #endregion
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "Aceptar");
            }
            Navigation.PopAsync(true);
        }
    }
}
