﻿using AplicacionUsuarios.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplicacionUsuarios.Vistas.Config
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Productosconfig : ContentPage
    {
        public Productosconfig()
        {
            InitializeComponent();
            BindingContext = new VMproductosconfig(Navigation);
        }
    }
}