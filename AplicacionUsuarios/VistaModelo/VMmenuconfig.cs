﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AplicacionUsuarios.VistaModelo;
using AplicacionUsuarios.Vistas.Config;

namespace AplicacionUsuarios.VistaModelo
{
    public class VMmenuconfig:BaseViewModel
    {
        #region VARIABLES
        string identificacion;
        #endregion
        #region CONSTRUCTOR
        public VMmenuconfig(INavigation navigation)
        {
            Navigation = navigation;
            Volvercomamd = new Command(async () => await Volver());
            NavegarRecolectoresconfigcomamd = new Command(async()=> await Navegarrecolectoresconfig());
            NavegarProductosconfigcomamd = new Command(async () => await Navegarproductosconfig());
        }
        #endregion
        #region OBJETOS         
        public string Identificacion
        {
            get { return identificacion; }
            set { SetValue(ref identificacion, value); }
        }

        #endregion
        #region PROCESOS
        private async Task Volver()
        {
            await Navigation.PopAsync();
        }

        private async Task Navegarrecolectoresconfig()
        {
            await Navigation.PushAsync(new Recolectoresconfig());
        }
        private async Task Navegarproductosconfig()
        {
            await Navigation.PushAsync(new Productosconfig());
        }
        #endregion
        #region COMANDOS
        public Command Volvercomamd { get; }
        public Command NavegarRecolectoresconfigcomamd { get; }
        public Command NavegarProductosconfigcomamd { get; }

        #endregion
    }
}

