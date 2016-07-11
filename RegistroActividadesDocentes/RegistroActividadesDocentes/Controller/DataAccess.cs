using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Reflection;
using RegistroDocente.Models;

namespace RegistroDocente.Controller
{
    public class DataAccess : IDisposable
    {
        private SQLiteConnection connection;

        public DataAccess()
        {
            var config = DependencyService.Get<IConfig>();
            connection = new SQLiteConnection(config.Plataforma,
                Path.Combine(config.DirectorioDB, "RegistroDocente.db3"));
            connection.CreateTable<Persona>();
            connection.CreateTable<Usuario>();
        }

        #region Persona
        public void InsertarPersona(Persona obj)
        {
            connection.Insert(obj);
        }

        public void UpdatePersona(Persona obj)
        {
            connection.Update(obj);
        }

        public void DeletePersona(Persona obj)
        {
            connection.Delete(obj);
        }

        public Persona GetPersona(string cedula)
        {
            return connection.Table<Persona>().FirstOrDefault(x => x.Cedula == cedula);
        }

        public List<Persona> GetPersonas()
        {
            return connection.Table<Persona>().OrderBy(x => x.Apellido1).ToList();
        }
        #endregion

        #region Usuario
        public void InsertarUsuario(Usuario obj)
        {
            connection.Insert(obj);
        }

        public void UpdateUsuario(Usuario obj)
        {
            connection.Update(obj);
        }

        public void DeleteUsuario(Usuario obj)
        {
            connection.Delete(obj);
        }

        public Usuario GetUsuario(int ID)
        {
            return connection.Table<Usuario>().FirstOrDefault(x => x.ID == ID);
        }

        public Usuario GetUsuarioXUser(string user)
        {
            return connection.Table<Usuario>().FirstOrDefault(x => x.usuario == user);
        }

        public bool GetUsuariosDefault()
        {
            bool contiene = false;

            foreach (var item in connection.Table<Usuario>().OrderBy(x => x.usuario).ToList())
            {
                if (item.defecto)
                {
                    contiene = true;
                }
            }
            return contiene;
        }

        public List<Usuario> GetUsuarios()
        {
            return connection.Table<Usuario>().OrderBy(x => x.usuario).ToList();
        }
        #endregion

        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
