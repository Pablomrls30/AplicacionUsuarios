using AplicacionUsuarios.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AplicacionUsuarios.Conexiones;
using Firebase.Database.Query;
using System.Linq;


namespace AplicacionUsuarios.Datos
{
    public class Dproductos
    {
        public async Task<bool> InsertarProductos(Mproductos parametros)
        {
            await Constantes.firebase
                .Child("Productos")
                .PostAsync(new Mproductos()
                {
                    Descripcion = parametros.Descripcion,
                    Estado = parametros.Estado,
                    Preciocompra = parametros.Preciocompra,
                    Precioventa = parametros.Precioventa,
                    TipoDeBasura = parametros.TipoDeBasura,
                    Icono = parametros.Icono,
                    Kg = parametros.Kg,
                });
            return true;
          
        }
    }
}
