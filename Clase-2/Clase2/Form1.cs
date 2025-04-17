using Clase2.Entidad;
using System.Text;
using System.Text.Json;

namespace Clase2
{
    public partial class frmResultados : Form
    {
        public frmResultados()
        {
            InitializeComponent();
            CargarComboGoles();
            LimpiarControles();
        }

        private void CargarComboGoles()
        {
            cboGolesLocal.Items.Clear();
            cboGolesVisitante.Items.Clear();

            for (int i = 0; i <= 10; i++)
            {
                cboGolesLocal.Items.Add(i);
                cboGolesVisitante.Items.Add(i);
            }
        }

        private void cmdRegistrarResultado_Click(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            resultado.fecha = dtpFechaResultado.Value.ToString("dd/MM/yyyy");
            resultado.equipoLocal = txtEquipoLocal.Text;
            resultado.equipoVisitante = txtEquipoVisitante.Text;
            resultado.golesLocal = cboGolesLocal.SelectedItem.ToString();
            resultado.golesVisitante = cboGolesVisitante.SelectedItem.ToString();

            EnviarResultadosAAPI(resultado);
            LimpiarControles();
        }

        private void btnRefrescarGrilla_Click(object sender, EventArgs e)
        {
            dgvResultados.Rows.Clear();
            ObtenerResultadosDeAPI();
        }

        private void CargarGrillaResultados(Resultado resultado)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvResultados);
            row.Cells[0].Value = resultado.fecha;
            row.Cells[1].Value = resultado.equipoLocal;
            row.Cells[2].Value = resultado.golesLocal + " - " + resultado.golesVisitante;
            row.Cells[3].Value = resultado.equipoVisitante;

            dgvResultados.Rows.Add(row);
        }

        private void LimpiarControles()
        {
            txtEquipoLocal.Text = "";
            txtEquipoVisitante.Text = "";
            cboGolesLocal.SelectedIndex = 0;
            cboGolesVisitante.SelectedIndex = 0;
        }

        private async Task EnviarResultadosAAPI(Resultado resultado)
        {
            var jsonContento = JsonSerializer.Serialize(resultado);
            var content = new StringContent(jsonContento, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7120/api/");
                var response = await client.PostAsync("resultados", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Resultado registrado en la API.");
                }
                else
                {
                    MessageBox.Show("Error al registrar el resultado en la API.");
                }
            }
        }

        private async Task ObtenerResultadosDeAPI()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7120/api/");
                var response = await client.GetAsync("resultados");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var resultados = JsonSerializer.Deserialize<List<Resultado>>(jsonResponse);
                    foreach (var resultado in resultados)
                    {
                        CargarGrillaResultados(resultado);
                    }
                }
                else
                {
                    MessageBox.Show("Error al obtener los resultados de la API.");
                }
            }

        }


    }
}
