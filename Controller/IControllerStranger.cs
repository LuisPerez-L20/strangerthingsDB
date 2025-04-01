using System.Collections.Generic;
using strangerthingsDB.Model;

namespace strangerthingsDB.Controller
{
    interface IControllerStranger
    {
        List<ModelStranger> ObtenerPersonajes();

        bool AgregarPersonaje(ModelStranger personaje);
        

         bool ActualizarPersonaje(ModelStranger personaje);

         bool EliminarPersonaje(int idPersonaje);


    }
}
