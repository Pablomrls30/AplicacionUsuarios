﻿using AplicacionUsuarios.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AplicacionUsuarios.Conexiones;
using Firebase.Database.Query;
using System.Linq;
namespace AplicacionUsuarios.Datos
{
    public class Dsolicitudesrecojo
    {
        public async Task <List<Msolicitudesrecojo>> Mostrarsolicitudesrecojo()
        {
            return (await Constantes.firebase
                .Child("Solicitudes")
                .OnceAsync<Msolicitudesrecojo>())
                .Select(item => new Msolicitudesrecojo
                {
                    Estado = item.Object.Estado,
                    Fecha = item.Object.Fecha,
                    Idsolicitud = item.Key
                }).ToList();
        }
    }
}
