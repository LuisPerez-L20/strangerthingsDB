using Microsoft.Data.SqlClient;
using strangerthingsDB.Context;
using Model.Stranger;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
