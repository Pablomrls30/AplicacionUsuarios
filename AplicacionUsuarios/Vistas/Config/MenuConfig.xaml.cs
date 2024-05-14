using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacionUsuarios.VistaModelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplicacionUsuarios.Vistas.Config
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuConfig : ContentPage
	{
		public MenuConfig ()
		{
			InitializeComponent ();
			BindingContext = new VMmenuconfig(Navigation);
		}
	}
}