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
    internal class VMproductosconfig:BaseViewModel
    {
        #region VARIABLES
        public string descripcion;
        public string preciocompra;
        public string precioventa;
        public string kg;
        public string tipodebasura;
        public string estado;
        public string icono;
        
        #endregion
        #region CONSTRUCTOR
        public VMproductosconfig(INavigation navigation)
        {
            Navigation = navigation;
            Insertarcomamd = new Command(async () => await InsertarProductos());
            Volvercomamd = new Command(async () => await Volver());
        }
        #endregion
        #region OBJETOS         
        public string txtDescripcion
        {
            get { return descripcion; }
            set { SetValue(ref descripcion, value); }
        }
        public string txtPreciocompra
        {
            get { return preciocompra; }
            set { SetValue(ref preciocompra, value); }
        }
        public string txtPrecioventa
        {
            get { return precioventa; }
            set { SetValue(ref precioventa, value); }
        }
        public string txtKg
        {
            get { return kg; }
            set { SetValue(ref kg, value); }
        }
        public string txtTipodebasura
        {
            get { return tipodebasura; }
            set { SetValue(ref tipodebasura, value); }
        }
        public string txtIcono
        {
            get { return icono; }
            set { SetValue(ref icono, value); }
        }

        #endregion
        #region PROCESOS
        private async Task Volver()
        {
            await Navigation.PopAsync();
        }
        private async Task InsertarProductos()
        {
            var funcion = new Dproductos();
            var parametros = new Mproductos();
            parametros.Descripcion = txtDescripcion;
            parametros.Precioventa = txtPrecioventa;
            parametros.Preciocompra = txtPreciocompra;
            parametros.Kg = txtKg;
            parametros.TipoDeBasura = txtTipodebasura;
            parametros.Icono = "-";
            parametros.Estado = "Activo";
            var estadofuncion = await funcion.InsertarProductos(parametros);
            if(estadofuncion==true)
            {
                await DisplayAlert("Registrado", "Registro realizado correctamente", "Ok");
            }


        }
        #endregion
        #region COMANDOS
        public Command Insertarcomamd { get; }
        public Command Volvercomamd { get; }


        #endregion
    }
}
