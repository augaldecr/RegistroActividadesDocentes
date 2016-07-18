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
            "Persona",
            "Usuario",
            "AdecuacionCurricular",
            "Anho",
            "Asignatura",
            "CalificacionXIndicadores",
            "Canton",
            "CategoriaDocente",
            "CicloEducativo",
            "Circuito",
            "ComponentesPlanEval",
            "CursoLectivo",
            "Dia",
            "Distrito",
            "Evaluacion",
            "EvaluacionCualitativa",
            "FechasNoLectivas",
            "Funcionario",
            "Genero",
            "HorarioDocente",
            "InAsistencia",
            "Indicador",
            "IndicadorAplicado",
            "Indicadores",
            "Institucion",
            "Matricula",
            "ModalidadInstitucion",
            "Nivel",
            "NivelEscolar",
            "Pais",
            "PaseDeLista",
            "Periodo",
            "PlanEvaluativo",
            "Provincia",
            "Puesto",
            "Regional",
            "Seccion",
            "TipoAsignatura",
            "TipoEvaluacion",
            "TipoInAsistencia",
            "TipoMatricula",
            "TipoPeriodicidadAsignatura",
            "TipoPeriodo",
            "Usuario"
        };
    }
}
