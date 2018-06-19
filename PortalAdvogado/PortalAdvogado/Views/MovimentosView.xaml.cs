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
	public partial class MovimentosView : ContentPage
	{
        public List<Movimento> movimentos = new List<Movimento>();

        public MovimentosView (List<Movimento> listaMovimentos)
		{
			InitializeComponent ();
            if (listaMovimentos != null && listaMovimentos.Any())
            {
                this.movimentos = listaMovimentos;
                MovimentosListView.ItemsSource = this.movimentos;
            } else
            {
                EmptyListLabel.IsVisible = true;
                MovimentosListView.IsVisible = false;
                MovimentosSearchBar.IsVisible = false;
            }
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var texto = MovimentosSearchBar.Text;
            MovimentosListView.ItemsSource = movimentos.Where(x => x.textoMovimento.ToLower().Contains(texto.ToLower()));
        }
    }
}