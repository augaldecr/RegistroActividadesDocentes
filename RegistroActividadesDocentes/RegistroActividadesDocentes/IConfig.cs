using SQLite.Net.Interop;

namespace RegistroActividadesDocentes
{
    public interface IConfig
    {
        string DirectorioDB { get; }
        ISQLitePlatform Plataforma { get; }
    }
}
