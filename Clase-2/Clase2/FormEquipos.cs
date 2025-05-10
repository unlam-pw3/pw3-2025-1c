
using System.Text;
using System.Text.Json;
using Clase2.Entidad;

namespace Clase2;

public partial class FormEquipos : Form
{
    public FormEquipos()
    {
        InitializeComponent();
        ObtenerEquiposDeLaAPI();
    }

    private void CargarComboEquipos(List<Equipo> equipos)
    {
        cboEquipos.Items.Clear();

        foreach (var equipo in equipos)
        {
            cboEquipos.Items.Add(equipo.nombre);
        }
    }

    private void CargarGrillaEquipos(List<Equipo> equipos)
    {
        lstEquipos.Items.Clear();

        foreach (var equipo in equipos)
        {
            lstEquipos.Items.Add($"{equipo.nombre} - {equipo.pais}");
        }
    }

    private async void btnCrearEquipo_Click(object sender, EventArgs e)
    {
        if(string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPais.Text))
        {
            MessageBox.Show("Por favor, complete todos los campos.");
            return;
        }

        Equipo equipo = new Equipo();
        equipo.nombre = txtNombre.Text;
        equipo.pais = txtPais.Text;

        await EnviarEquipoAAPI(equipo);
        LimpiarControlesCrear();
        await ObtenerEquiposDeLaAPI();
    }

    private async void btnEliminarEquipo_Click(object sender, EventArgs e)
    {
        string nombreEquipo = cboEquipos.Text;
        await EliminarEquipoDeAPI(nombreEquipo);
        LimpiarControlesEliminar();
        await ObtenerEquiposDeLaAPI();
    }

    private void LimpiarControlesCrear()
    {
        txtNombre.Text = string.Empty;
        txtPais.Text = string.Empty;
    }

    private void LimpiarControlesEliminar()
    {
        cboEquipos.Text = string.Empty;
    }

    private async Task EnviarEquipoAAPI(Equipo equipo)
    {
        string url = "https://localhost:7120/api/Equipos";
        var json = JsonSerializer.Serialize(equipo);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        using (var client = new HttpClient())
        {
            var response = await client.PostAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Equipo creado exitosamente.");
            }
            else
            {
                MessageBox.Show("Error al crear el equipo.");
            }
        }
    }

    private async Task EliminarEquipoDeAPI(string nombreEquipo)
    {
        string url = $"https://localhost:7120/api/Equipos/{nombreEquipo}";
        using (var client = new HttpClient())
        {
            var response = await client.DeleteAsync(url);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Equipo eliminado exitosamente.");
            }
            else
            {
                MessageBox.Show("Error al eliminar el equipo.");
            }
        }
    }

    private async Task ObtenerEquiposDeLaAPI()
    {
        string url = "https://localhost:7120/api/Equipos";
        using (var client = new HttpClient())
        {
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var equipos = JsonSerializer.Deserialize<List<Equipo>>(jsonResponse);
                CargarComboEquipos(equipos);
                CargarGrillaEquipos(equipos);
            }
            else
            {
                MessageBox.Show("Error al obtener los equipos.");
            }
        }
    }

}