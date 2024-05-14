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
    public class Dasignaciones
    {
        public async Task<bool> Insertar(Masignaciones parametros)
        {
            await Constantes.firebase
                .Child("Asignaciones")
                .PostAsync(new Masignaciones()
                {
                    Idsolicitud = parametros.Idsolicitud,
                    Estado = parametros.Estado,
                    Idrecolector = parametros.Idrecolector,                    
                });
            return true;
        }
    }
}
