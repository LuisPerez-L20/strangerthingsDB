using System;

namespace strangerthingsDB.Model
{
    class ModelStranger
    {
        public int IdPersonaje  { get; set; }

        public string? Nombre { get; set; }

        public int Edad { get; set; }

        public string? Rol { get; set; }

        public int TemporadaAparece { get; set; }

        public string? imagenesURL { get; set; }
    }
}
