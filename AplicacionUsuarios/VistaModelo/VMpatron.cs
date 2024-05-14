using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AplicacionUsuarios.VistaModelo;
using AplicacionUsuarios.Datos;
using AplicacionUsuarios.Modelo;

namespace AplicacionUsuarios.VistaModelo
{
    public class VMpatron:BaseViewModel
    {
        #region VARIABLES
        string identificacion;
        #endregion
        #region CONSTRUCTOR
        public VMpatron(INavigation navigation)
        {
            Navigation = navigation;
            Logincomamd = new Command(async () => await proceso());
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
        private async Task proceso()
        {
            
        }
        #endregion
        #region COMANDOS
        public Command Logincomamd { get; }


        #endregion
    }
}
