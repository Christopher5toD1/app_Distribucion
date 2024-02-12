namespace app_Distribucion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Distribucion_Click(object sender, EventArgs e)
        {
            Double Presupuesto, Emergencias, cirugia, Suministros, Administracion, Laboratorios, Imagenes;

            Presupuesto = double.Parse(TxPresupuesto.Text);

            Emergencias = (Presupuesto * 30) / 100;
            cirugia = (Presupuesto * 15) / 100;
            Suministros = (Presupuesto * 20) / 100;
            Administracion = (Presupuesto * 18 )/ 100;
            Laboratorios = (Presupuesto * 5) / 100;
            Imagenes = (Presupuesto * 7) / 100;

            TxEmergencia.Text = Emergencias.ToString();
            TxCirugia.Text = cirugia.ToString();
            TxSuministros.Text = Suministros.ToString();
            TxAdministracion.Text = Administracion.ToString();
            TxLaboratorio.Text = Laboratorios.ToString();
            TxImagenes.Text = Imagenes.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
           TxPresupuesto.Clear();
            TxEmergencia.Clear();
            TxCirugia.Clear();
            TxSuministros.Clear();
            TxAdministracion.Clear();
            TxLaboratorio.Clear();
            TxImagenes.Clear();

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
