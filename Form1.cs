using Stringer.Controller;
using Model.Stranger;
using System.Net;
using strangerthingsDB.Controller;
using System.Drawing.Text;
using strangerthingsDB.Model;

namespace strangerthingsDB
{
    public partial class Form1 : Form
    {
        private IControllerStranger controller = new ControllerStranger();
        private List<ModelStranger> personajes = new List<ModelStranger>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarPersonajes();
            CargarComboBox();
        }

        private void CargarComboBox()
        {
            try
            {
                personajes = controller.ObtenerPersonajes(); 

                cmbStranger.DisplayMember = "Nombre";  
                cmbStranger.ValueMember = "ImagenURL"; 
                cmbStranger.DataSource = personajes;   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los personajes: " + ex.Message);
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

        private async void cmbSnoopy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? imageUrl = cmbStranger.SelectedValue as string;

            if (!string.IsNullOrEmpty(imageUrl))
            {
                await CargarImagen(imageUrl); 
            }
            else
            {
                ImageBox.Image = null;
            }
        }

    }
}
