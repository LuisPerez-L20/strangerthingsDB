using System.Collections.Generic;
using Model.Stranger;

namespace strangerthingsDB.Controller
{
    interface IControllerStranger
    {
        List<ModelStranger> ObtenerPersonajes();
    }
}
