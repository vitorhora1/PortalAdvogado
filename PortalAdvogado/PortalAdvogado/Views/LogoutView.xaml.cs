using PortalAdvogado.Models;
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
            //Navigation.InsertPageBefore(new LoginView(), this);
            //Navigation.PopAsync();
            //(Application.Current.MainPage as MasterDetailPage).MasterBehavior = MasterBehavior.Popover;
            //(Application.Current.MainPage as MasterDetailPage).IsPresented = false;
            //App.Current.MainPage = new NavigationPage(new LoginView());
            //Navigation.PushAsync(new LoginView());
            //Navigation.PopToRootAsync();
            Navigation.PushModalAsync(new LoginView());
        }
	}
}