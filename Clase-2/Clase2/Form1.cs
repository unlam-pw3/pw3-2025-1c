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
            CargarComboPaises();
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
            Resultado resultado = new Resultado(true);
            resultado.fecha = dtpFechaResultado.Value.ToString("dd/MM/yyyy");
            resultado.equipoLocal = comboEquipoLocal1.Text;
            resultado.equipoVisitante = comboEquipoVisitante2.Text;
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
            row.Cells[4].Value = false;
            row.Cells[5].Tag = resultado;

            dgvResultados.Rows.Add(row);
        }

        private void LimpiarControles()
        {
            comboEquipoLocal1.Text = "";
            comboEquipoVisitante2.Text = "";
            cboGolesLocal.SelectedIndex = 0;
            cboGolesVisitante.SelectedIndex = 0;
        }

        private async Task EnviarResultadosAAPI(Resultado resultado)
        {

            if (resultado.equipoLocal.Equals(resultado.equipoVisitante))
            {
                MessageBox.Show("Los equipos no pueden ser iguales");

                return;
            }

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
        private async Task EliminarFila(List<Resultado> filas)
        {
            var jsonFilas = JsonSerializer.Serialize(filas);
            var content = new StringContent(jsonFilas, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5227/api/");

                
                var response = await client.PostAsync("resultados/eliminar", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Resultados eliminados en la API.");
                }
                else
                {
                    MessageBox.Show("Error al eliminar los resultados en la API.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Resultado> resultadosAELiminar = new List<Resultado>();

            foreach (DataGridViewRow fila in dgvResultados.Rows)
            {


                bool seleccionado = Convert.ToBoolean(fila.Cells[4].Value);

                if (seleccionado)
                {
                    Resultado resultado = (Resultado) fila.Cells[5].Tag;
                    resultadosAELiminar.Add(resultado);
                }

            }

            if (resultadosAELiminar.Count > 0)
            {

                MessageBox.Show($"Se seleccionaron {resultadosAELiminar.Count} resultados para eliminar.");
                EliminarFila(resultadosAELiminar);
            }
            else
            {
                MessageBox.Show("No se seleccion  ning n resultado.");
            }




        }

        private void LimpiarControlesEquipo()
        {

            textEquipo.Text = "";
            comboBoxPaises.Text = "";

        }

        private void btnRegistrarEquipo_Click(object sender, EventArgs e)
        {

            Equipo equipo = new Equipo(true);

            equipo.nombre = textEquipo.Text;
            equipo.paisOrigen = comboBoxPaises.SelectedItem.ToString();

            EnviarEquipo(equipo);
            LimpiarControlesEquipo();
        }
        private void CargarGrillaEquipo(Equipo equipo)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataEquipos);
            row.Cells[0].Value = equipo.nombre;
            row.Cells[1].Value = equipo.paisOrigen;
            row.Cells[2].Value = false;
            row.Cells[3].Tag = equipo;

            dataEquipos.Rows.Add(row);
        }


        private async Task EnviarEquipo(Equipo equipo)
        {
            var jsonContento = JsonSerializer.Serialize(equipo);
            var content = new StringContent(jsonContento, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7120/api/");
                var response = await client.PostAsync("resultados/nuevo-equipo", content);
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


        private void CargarCombosEquipos(List<Equipo> equipos)
        {
            comboEquipoLocal1.Items.Clear();    
            comboEquipoVisitante2.Items.Clear();

            foreach (var equipo in equipos) { 
            
                string equipoAgregar = equipo.nombre + " - " + equipo.paisOrigen;


              comboEquipoLocal1.Items.Add(equipoAgregar);
              comboEquipoVisitante2.Items.Add(equipoAgregar);
            
            }

        }

        private void CargarComboPaises()
        {
            string[] paises = {
                "Argentina",
                "Brasil",
                "Chile",
                "Uruguay",
                "Paraguay",
                "Colombia",
                "Perú",
                "México",
                "España",
                "Estados Unidos"
    };

            for (int i = 0; i < paises.Length; i++)
            {
                comboBoxPaises.Items.Add(paises[i]);
            }
        }

        private void RefrescarEquipos_Click(object sender, EventArgs e)
        {
            dataEquipos.Rows.Clear();
            ObtenerEquipos();
        }

        private async Task ObtenerEquipos()
        {
            using (var client = new HttpClient())

            {
                client.BaseAddress = new Uri("https://localhost:7120/api/");

                var response = await client.GetAsync("resultados/equipos");


                var jsonResponse = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode){

                    var equipos = JsonSerializer.Deserialize<List<Equipo>>(jsonResponse);


                    foreach (var equipo in equipos)
                    {
                        CargarGrillaEquipo(equipo);
                       
                    }
                    CargarCombosEquipos(equipos);
                }
                else
                {
                    MessageBox.Show("Error al obtener los equipos de la API.");
                }


            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Equipo> equiposAELiminar = new List<Equipo>();


            foreach (DataGridViewRow fila in dataEquipos.Rows)
            {

                bool filaMarcada = Convert.ToBoolean(fila.Cells[2].Value);

                if (filaMarcada)
                {

                    Equipo equipo = (Equipo)fila.Cells[3].Tag;

                    equiposAELiminar.Add(equipo);

                }
            }

            if (equiposAELiminar.Count > 0)
            {

                MessageBox.Show($"Se seleccionaron {equiposAELiminar.Count} resultados para eliminar.");
                EliminarEquipos(equiposAELiminar);
            }

            else
            {
                MessageBox.Show("No se seleccion  ningun resultado.");
            }
        }


        public async Task EliminarEquipos(List<Equipo> equiposAELiminar) {

            var jsonFilas = JsonSerializer.Serialize(equiposAELiminar);
            var content = new StringContent(jsonFilas, Encoding.UTF8, "application/json");


            using (var client = new HttpClient()) {

                client.BaseAddress = new Uri("https://localhost:7120/api/");

                var response = await client.PostAsync("resultados/eliminar-equipo", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Equipos eliminados");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al eliminar equipos");
                }
            
            }

            
        
        }

  
    }
}
