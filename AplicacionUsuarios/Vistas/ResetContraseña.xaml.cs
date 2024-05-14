using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplicacionUsuarios.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResetContraseña : ContentPage
	{
		public ResetContraseña ()
		{
			InitializeComponent ();
		}

        private void ButtonSendLink_Clicked(object sender, EventArgs e)
        {

        }
    }
}