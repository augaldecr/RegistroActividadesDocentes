using RegistroActividadesDocentes.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace RegistroActividadesDocentes
{
    public class App : Application
    {
        public App()
        {
            
            // The root page of your application
            using (DataAccess db = new DataAccess())
            {
                if (db.GetUsuariosDefault())
                {
                    MainPage = new Views.MenuPage();
                }
                else
                {
                    MainPage = new NavigationPage(new Views.LoginPage());
                }
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
