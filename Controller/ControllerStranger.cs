using Microsoft.Data.SqlClient;
using strangerthingsDB.Context;
using strangerthingsDB.Model;

namespace strangerthingsDB.Controller
{
    class ControllerStranger : IControllerStranger
    {
        private Conexion Conexion = new Conexion();


        public List<ModelStranger> ObtenerPersonajes()
        {
            List<ModelStranger> personajes = new List<ModelStranger>();
            try
            {
                using (SqlConnection conn = Conexion.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Personajes";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModelStranger personaje = new ModelStranger();
                                personaje.IdPersonaje = reader.GetInt32(0);
                                personaje.Nombre = reader.GetString(1);
                                personaje.Edad = reader.GetInt32(2);
                                personaje.Rol = reader.GetString(3);
                                personaje.TemporadaAparece = reader.GetInt32(4);
                                personaje.imagenesURL = reader.GetString(5);
                                personajes.Add(personaje);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los personajes: " + ex.Message);
            }
            return personajes;
        }
        public bool AgregarPersonaje(ModelStranger personaje)
        {
            try
            {
                using (SqlConnection conn = Conexion.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Personajes (IdPersonaje,Nombre, Edad, Rol, TemporadaAparece, imagenesURL) VALUES (@IdPersonaje,@Nombre, @Edad, @Rol, @TemporadaAparece, @imagenesURL)";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdPersonaje", personaje.IdPersonaje);
                        command.Parameters.AddWithValue("@Nombre", personaje.Nombre);
                        command.Parameters.AddWithValue("@Edad", personaje.Edad);
                        command.Parameters.AddWithValue("@Rol", personaje.Rol);
                        command.Parameters.AddWithValue("@TemporadaAparece", personaje.TemporadaAparece);
                        command.Parameters.AddWithValue("@imagenesURL", personaje.imagenesURL);
                        command.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el personaje: " + ex.Message);
            }
        }

        public bool ActualizarPersonaje(ModelStranger personaje)
        {
            try
            {
                using (SqlConnection conn = Conexion.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE Personajes SET Nombre = @Nombre, Edad = @Edad, Rol = @Rol, TemporadaAparece = @TemporadaAparece, imagenesURL = @imagenesURL WHERE IdPersonaje = @IdPersonaje";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdPersonaje", personaje.IdPersonaje);
                        command.Parameters.AddWithValue("@Nombre", personaje.Nombre);
                        command.Parameters.AddWithValue("@Edad", personaje.Edad);
                        command.Parameters.AddWithValue("@Rol", personaje.Rol);
                        command.Parameters.AddWithValue("@TemporadaAparece", personaje.TemporadaAparece);
                        command.Parameters.AddWithValue("@imagenesURL", personaje.imagenesURL);
                        command.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el personaje: " + ex.Message);
            }
        }

        public bool EliminarPersonaje(int id)
        {
            try
            {
                using (SqlConnection conn = Conexion.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Personajes WHERE IdPersonaje = @IdPersonaje";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdPersonaje", id);
                        command.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el personaje: " + ex.Message);
            }
        }
       
    }
}
