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
	public partial class LogoutView : ContentPage
	{
		public LogoutView()
		{
            InitializeComponent();

            Navigation.PushModalAsync(new LoginView());
        }
	}
}