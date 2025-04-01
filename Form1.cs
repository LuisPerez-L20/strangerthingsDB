using System.Net;
using strangerthingsDB.Controller;
using System.Drawing.Text;
using strangerthingsDB.Model;
using Azure.Identity;

namespace strangerthingsDB
{
    public partial class FrmInicio : Form
    {
        private IControllerStranger controller = new ControllerStranger();
        private List<ModelStranger> personajes = new List<ModelStranger>();
        public FrmInicio()
        {
            InitializeComponent();
        }



        private void CargarComboBox()
        {
            try
            {
                personajes = controller.ObtenerPersonajes();


                cmbStranger.DisplayMember = "Nombre";
                cmbStranger.ValueMember = "ImagenesURL";
                cmbStranger.DataSource = personajes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los personajes: " + ex.Message);
            }
        }

        public void AgregarPersonaje()
        {
            try
            {
                ModelStranger personaje = new ModelStranger();
                personaje.Nombre = txbNombre.Text;
                personaje.Edad = Convert.ToInt32(txbEdad.Text);
                personaje.Rol = txbRol.Text;
                personaje.TemporadaAparece = Convert.ToInt32(txbTaparece.Text);
                personaje.imagenesURL = txbIURL.Text;
                CargarPersonajes();
                CargarComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el personaje: " + ex.Message);
            }
        }



        private async Task CargarImagen(string url)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(url) || !Uri.IsWellFormedUriString(url, UriKind.Absolute))
                {
                    throw new Exception("URL de imagen no válida.");
                }

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);


                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception($"Error al obtener la imagen. Código HTTP: {response.StatusCode}");
                    }

                    byte[] imageBytes = await response.Content.ReadAsByteArrayAsync();


                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        ImageBox.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Error de conexión al obtener la imagen: " + ex.Message);
                ImageBox.Image = null;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("La imagen descargada no es válida: " + ex.Message);
                ImageBox.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.Message);
                ImageBox.Image = null;
            }
        }

        private void CargarPersonajes()
        {
            try
            {
                dgDatos.DataSource = controller.ObtenerPersonajes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            CargarPersonajes();
            CargarComboBox();
        }

        private async void cmbStranger_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? imagenesURL = cmbStranger.SelectedValue as string;

            if (!string.IsNullOrEmpty(imagenesURL))
            {
                await CargarImagen(imagenesURL);
            }
            else
            {
                ImageBox.Image = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarPersonajes();
            CargarComboBox();
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            ModelStranger personaje = new ModelStranger();
            personaje.IdPersonaje = Convert.ToInt32(txbID.Text);
            personaje.Nombre = txbNombre.Text;
            personaje.Edad = Convert.ToInt32(txbEdad.Text);
            personaje.Rol = txbRol.Text;
            personaje.TemporadaAparece = Convert.ToInt32(txbTaparece.Text);
            personaje.imagenesURL = txbIURL.Text;
            controller.AgregarPersonaje(personaje);

            CargarPersonajes();
            CargarComboBox();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ModelStranger personaje = new ModelStranger();
            personaje.IdPersonaje = Convert.ToInt32(txbID.Text);
            personaje.Nombre = txbNombre.Text;
            personaje.Edad = Convert.ToInt32(txbEdad.Text);
            personaje.Rol = txbRol.Text;
            personaje.TemporadaAparece = Convert.ToInt32(txbTaparece.Text);
            personaje.imagenesURL = txbIURL.Text;
            controller.ActualizarPersonaje(personaje);
            CargarPersonajes();
            CargarComboBox();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          controller.EliminarPersonaje(Convert.ToInt32(txbID.Text));           
            CargarPersonajes();
            CargarComboBox();

        }
    }
}
