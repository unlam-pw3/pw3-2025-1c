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

        private async Task EliminarEquipoDeAPI(string nombre)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7120/api/");
                var response = await client.DeleteAsync($"equipo/{nombre}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Equipo eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al eliminar el equipo.");
                }
            }
        }

        private async void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            
            if (cbEliminarEquipo.SelectedItem != null)
            {       
                string nombreEquipo = cbEliminarEquipo.SelectedItem.ToString();
                cbEliminarEquipo.SelectedIndex = -1;
                await EliminarEquipoDeAPI(nombreEquipo);             
                
            }
            else
            {               
                MessageBox.Show("Por favor, selecciona un equipo para eliminar.");
            }
        }


        private async Task EnviarEquiposAAPI(Equipo equipo)
        {
            var jsonContento = JsonSerializer.Serialize(equipo);
            var content = new StringContent(jsonContento, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7120/api/");
                var response = await client.PostAsync("equipo", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Equipo registrado en la API.");
                }
                else
                {
                    MessageBox.Show("Error al registrar el equipo en la API.");
                }
            }
        }

        private async void btnRefrescarEquipos_Click(object sender, EventArgs e)
        {
            await ObtenerEquiposDeAPI();
        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            Equipo equipo = new Equipo();
            equipo.nombre = tbNombreEquipo.Text;
            equipo.pais = tbPaisEquipo.Text;
            EnviarEquiposAAPI(equipo);
            LimpiarControlesAgregarEquipo();
        }

        private void LimpiarControlesAgregarEquipo()
        {
            tbNombreEquipo.Text = "";
            tbPaisEquipo.Text = "";
        }

        private async void btnRefrescarListaEnEliminarEquipo_Click(object sender, EventArgs e)
        {
            await ObtenerEquiposDeAPI();
        }

        private async Task ObtenerEquiposDeAPI()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7120/api/");
                var response = await client.GetAsync("equipo");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var equipos = JsonSerializer.Deserialize<List<Equipo>>(jsonResponse);
                    cbEliminarEquipo.Items.Clear();
                    cbEquipoLocal.Items.Clear();
                    cbEquipoVisitante.Items.Clear();
                    foreach (var equipo in equipos)
                    {
                        CargarEquiposEnComboDeEliminarEquipo(equipo);
                        CargarEquiposEnComboDeEquipoLocal(equipo);
                        CargarEquiposEnComboDeEquipoVisitante(equipo);
                    }
                }
                else
                {
                    cbEliminarEquipo.SelectedIndex = -1;
                    cbEliminarEquipo.Items.Clear();
                    cbEquipoLocal.Items.Clear();
                    cbEquipoVisitante.Items.Clear();
                    MessageBox.Show("No hay equipos cargados!");
                }
            }

        }
        private void CargarEquiposEnComboDeEquipoLocal(Equipo equipo)
        {
            cbEquipoLocal.Items.Add(equipo.nombre);

        }
        private void CargarEquiposEnComboDeEquipoVisitante(Equipo equipo)
        {
            cbEquipoVisitante.Items.Add(equipo.nombre);

        }

        private void CargarEquiposEnComboDeEliminarEquipo(Equipo equipo)
        {
            cbEliminarEquipo.Items.Add(equipo.nombre);

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
            resultado.equipoLocal = cbEquipoLocal.SelectedItem.ToString();
            resultado.equipoVisitante = cbEquipoVisitante.SelectedItem.ToString();
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
            cbEquipoLocal.SelectedIndex = -1;
            cbEquipoVisitante.SelectedIndex = -1;
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
