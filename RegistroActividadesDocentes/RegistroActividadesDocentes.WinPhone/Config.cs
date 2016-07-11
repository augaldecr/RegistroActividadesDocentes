using SQLite.Net.Interop;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(RegistroDocente.WinPhone.Config))]

namespace RegistroDocente.WinPhone
{
    class Config : IConfig
    {
        private string directorioDB;
        private ISQLitePlatform plataforma;

        public string DirectorioDB
        {
            get
            {
                if (string.IsNullOrEmpty(DirectorioDB))
                {
                    directorioDB = ApplicationData.Current.LocalFolder.Path;
                }
                return directorioDB;
            }
        }

        public ISQLitePlatform Plataforma
        {
            get
            {
                if (plataforma == null)
                {
                    plataforma = new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT();
                }
                return plataforma;
            }
        }
    }
}
