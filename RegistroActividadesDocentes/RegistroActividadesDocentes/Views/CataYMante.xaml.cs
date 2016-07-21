using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RegistroActividadesDocentes.Views
{
    public partial class CataYMante : ContentPage
    {
        public CataYMante()
        {
            InitializeComponent();

            //Rellena el listview de clases
            CatalogoListView.ItemsSource = Clases;
        }

        private List<String> Clases = new List<String>
        {
            "Personas",
            "AdecuacionCurricular",
            "Años",
            "Asignaturas",
            "Calificaciones por indicadores",
            "Cantones",
            "Categorias docentes",
            "Ciclos educativos",
            "Circuitos",
            "Componentes del plan evaluativo",
            "Cursos lectivos",
            //"Dias",
            "Distritos",
            "Especialidades",
            "Evaluaciones",
            "Evaluaciones cualitativas",
            "Fechas no lectivas",
            "Funcionarios",
            //"Géneros",
            "Horario docente",
            "Inasistencias",
            "Indicadores",
            "Indicador aplicados",
            "Indicadores agrupados",
            "Instituciones",
            "Matriculas",
            "Modalidad de institución",
            "Niveles",
            "Niveles escolares",
            "Países",
            "Pases de lista",
            "Períodos",
            "Planes evaluativos",
            "Provincias",
            //"Puestos",
            "Regionales",
            "Secciones",
            //"Tipos de asignatura",
            //"Tipos de evaluacion",
            //"Tipos de inasistencia",
            //"Tipos de matricula",
            //"Tipos de periodicidad de asignatura",
            //"Tipos de periodo",
            //"Usuario"
        };
    }
}
