using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using AplicacionUsuarios.Vistas.Config;
using System.Runtime.CompilerServices;
using AplicacionUsuarios.Datos;
using AplicacionUsuarios.Modelo;
using System.Runtime.InteropServices;
using AplicacionUsuarios.Vistas;
namespace AplicacionUsuarios.VistaModelo
{
    public class VMmenuprincipal:BaseViewModel
    {

        #region VARIABLES
        string identificacion;
        List<Msolicitudesrecojo> listasolRecojo;
        #endregion
        #region CONSTRUCTOR
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            Navegarmenuconfigcomamd = new Command(async () => await NavegarMenuconfig());
            NavegarAsignacionescomamd = new Command<Msolicitudesrecojo>(async (p) => await NavegarAsignaciones(p));
            Mostrarsolicitudesrecojo();
        }
        #endregion
        #region OBJETOS         
        public string Identificacion
        {
            get { return identificacion; }
            set { SetValue(ref identificacion, value); }
        }
        public List<Msolicitudesrecojo> ListasolRecojo
        {
            get { return listasolRecojo; }
            set { SetValue(ref listasolRecojo, value); }
        }

        #endregion
        #region PROCESOS
        private async Task NavegarMenuconfig()
        {
            await Navigation.PushAsync(new MenuConfig());
        }
        private async Task Mostrarsolicitudesrecojo()
        {
            var funcion = new Dsolicitudesrecojo();
            ListasolRecojo = await funcion.Mostrarsolicitudesrecojo();
        }
        private async Task NavegarAsignaciones(Msolicitudesrecojo parametros)
        {            
            await Navigation.PushAsync(new Asignaciones());
            string Idsolicitud = parametros.Idsolicitud;
        }

        #endregion
        #region COMANDOS
        public Command Navegarmenuconfigcomamd { get; }
        public Command NavegarAsignacionescomamd { get; }

        #endregion
    }
}
