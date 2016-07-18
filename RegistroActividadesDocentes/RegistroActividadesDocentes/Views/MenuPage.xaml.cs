using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RegistroActividadesDocentes.Views
{
    public partial class MenuPage : TabbedPage
    {
        public MenuPage()
        {
            InitializeComponent();

            //Eventos de tab Matrícula
            //Eventos de tab Asistencia
            //Eventos de tab Evaluaciones
            //Eventos de tab Configuración
            CyMButton.Clicked += CyMButton_Clicked;
        }

        private async void CyMButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CataYMante());
        }
    }
}
