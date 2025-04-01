﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strangerthingsDB.Context
{
    public class Conexion
    {
        private string connectionString = "Server=DESKTOP-2CH4M5F;Database=STRANGERTHINGS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar con la base de datos: " + ex.Message);
            }
        }
    }
}
