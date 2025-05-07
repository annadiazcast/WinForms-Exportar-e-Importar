namespace WinForms
{
    public partial class Form1 : Form
    {
        Acciones acc = new Acciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgDatos.DataSource = acc.Mostrar();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (acc.ExportaraExcel())
                MessageBox.Show("Exportando con exito...");
            else
                MessageBox.Show("Fallo el exportado...");
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (acc.ExportaraExcel())
            { 
                MessageBox.Show("Importado con exito...");
                dgDatos.DataSource = acc.Mostrar();
            }
            else
                MessageBox.Show("Fallo al importar...");
        }
    }
}
