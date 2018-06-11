using PortalAdvogado.Models;
using PortalAdvogado.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace PortalAdvogado
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new LoginView();
		}

		protected override void OnStart ()
		{
            MessagingCenter.Subscribe<Usuario>(this, "SucessoLogin",
                (usuario) =>
                {
                    MainPage = new MenuView(usuario);
                });
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
