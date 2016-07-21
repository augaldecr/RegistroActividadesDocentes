using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroActividadesDocentes.Models;

namespace RegistroActividadesDocentes.Controller
{
    class DatosBasicos
    {
        private Anho anho = new Anho { Nombre = DateTime.Now.Year.ToString() };
        private TipoAsignatura basica = new TipoAsignatura { Nombre = "Básica" };
        private TipoAsignatura académica = new TipoAsignatura { Nombre = "Académica" };
        private TipoAsignatura tallerExploratorio = new TipoAsignatura { Nombre = "Taller exploratorio" };
        private Asignatura espanol = new Asignatura { Nombre = "Español", TipoAsignatura = 1};

    }
}
