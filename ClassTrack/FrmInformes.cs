using ClassTrack.Persistence.Repositories;
using ClassTrack.Utilidades;
using DinkToPdf;
using QuestPDF.Fluent;

namespace ClassTrack
{
    public partial class FrmInformes : Form
    {
        private readonly ProfesoresRepository _profesoresRepository;
        public FrmInformes()
        {
            InitializeComponent();

            _profesoresRepository = new ProfesoresRepository();
        }

        private void dgvProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            var profesor = await _profesoresRepository.GetAsync((int)cbProfesores.SelectedValue);

            var context = new CustomAssemblyLoadContext();
            var dllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NativeBinaries", "libwkhtmltox.dll");
            context.LoadUnmanagedLibrary(dllPath);

            var html = $@"
                <html>
                <body>
                    <h1>Informe Profesor</h1>
                    <p>Nombre: {profesor.Nombre}</p>
                </body>
                </html>";

            var converter = new SynchronizedConverter(new PdfTools());
            var doc = new HtmlToPdfDocument()
            {
                            GlobalSettings = {
                    PaperSize = PaperKind.A4,
                    Orientation = DinkToPdf.Orientation.Portrait,
                },
                            Objects = {
                    new ObjectSettings() {
                        HtmlContent = html,
                        WebSettings = { DefaultEncoding = "utf-8" }
                    }
                }
            };

            var pdf = converter.Convert(doc);
            File.WriteAllBytes(@"C:\Users\plini\OneDrive\Escritorio\Reporte\reporte.pdf", pdf);

        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {

        }

        private async void FrmInformes_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }

        private async Task CargarDatos()
        {
            var listProfesores = await _profesoresRepository.GetAllAsync();
            //  Asignatura 1
            cbProfesores.DataSource = listProfesores;
            cbProfesores.DisplayMember = "Nombre";
            cbProfesores.ValueMember = "Id";

        }
    }
}
