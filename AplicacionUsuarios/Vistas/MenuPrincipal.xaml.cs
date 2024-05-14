﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AplicacionUsuarios.VistaModelo;

namespace AplicacionUsuarios.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPrincipal : ContentPage
	{
		public MenuPrincipal ()
		{
			InitializeComponent ();
			BindingContext = new VMmenuprincipal(Navigation);
		}        
    }
}