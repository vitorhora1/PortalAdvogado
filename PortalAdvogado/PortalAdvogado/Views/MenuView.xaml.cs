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
    public partial class MenuView : MasterDetailPage
    {
        private readonly Usuario usuario;

        public MenuView(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
            MasterPage.DadosUsuarioLogado.Text = usuario.nome + " (" + usuario.oab + ")";
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MenuViewMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}