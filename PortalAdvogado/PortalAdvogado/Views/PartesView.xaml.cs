﻿using PortalAdvogado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PortalAdvogado.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PartesView : ContentPage
    {
        List<Parte> partes = new List<Parte>();

        public PartesView (List<List<Parte>> listaPartes)
		{
			InitializeComponent ();
            List<List<Parte>> partesProcesso = listaPartes;
            this.partes = partesProcesso[0].Concat(partesProcesso[1]).ToList();
            PartesListView.ItemsSource = this.partes;
        }
    }
}