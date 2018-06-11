using PortalAdvogado.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PortalAdvogado.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuViewMaster : ContentPage
    {
        public ListView ListView;
        public Label DadosUsuarioLogado { get; set; }

        public MenuViewMaster()
        {
            InitializeComponent();

            BindingContext = new MenuViewMasterViewModel();
            ListView = MenuItemsListView;
            DadosUsuarioLogado = UsuarioLogado;
        }

        class MenuViewMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MenuViewMenuItem> MenuItems { get; set; }
            
            public MenuViewMasterViewModel()
            {
                MenuItems = new ObservableCollection<MenuViewMenuItem>(new[]
                {
                    new MenuViewMenuItem { Id = 0, Title = "Consulta de Processos", TargetType = typeof(ConsultaProcessosView) },
                    new MenuViewMenuItem { Id = 1, Title = "Sobre" },
                    new MenuViewMenuItem { Id = 2, Title = "Sair", TargetType = typeof(LogoutView) },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}