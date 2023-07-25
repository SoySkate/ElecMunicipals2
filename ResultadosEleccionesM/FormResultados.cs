using EleccionsM2.Models;
using EleccionsM2.ViewModel;
using EleccionsM2;


namespace ResultadosEleccionesM
{
    public partial class FormResultados : Form
    {
        public FormResultados()
        {
            InitializeComponent();
            dataGridViewResultats.DataSource = viewmodelR.ListaPartitsMunicipi;
        }
        ResultatsViewModel viewmodelR = new ResultatsViewModel();
    }

}