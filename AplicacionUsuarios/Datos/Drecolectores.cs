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
    public class Drecolectores
    {
        //Esta es la parte del Create/Post/Insert
        public async Task<bool> InsertarRecolectores(Mrecolectores parametros)
        {
            await Constantes.firebase
                .Child("Recolectores")
                .PostAsync(new Mrecolectores()
                {
                    Correo=parametros.Correo,
                    Estado=parametros.Estado,
                    Identificacion=parametros.Identificacion,
                    Nombre=parametros.Nombre
                });
            return true;
        }
        public async Task<List<Mrecolectores>> Buscarrecolectores(Mrecolectores parametrosPedir)
        {
            return (await Constantes.firebase
                .Child("Recolectores")
                .OrderByKey()
                .OnceAsync<Mrecolectores>())
                .Where(a => a.Object.Identificacion == parametrosPedir.Identificacion)
                .Where(b => b.Object.Estado == "Activo")
                .Select(item => new Mrecolectores
                {
                    Idrecolectores=item.Key,
                    Nombre=item.Object.Nombre,
                    Correo=item.Object.Correo,                    
                }).ToList();               
        }
    }
}
