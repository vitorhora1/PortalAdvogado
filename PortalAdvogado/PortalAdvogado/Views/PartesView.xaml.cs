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
    public partial class PartesView : ContentPage
    {        
        public List<ListaAdvogadoParte> listaAdvogadosParte = new List<ListaAdvogadoParte>();
        public ListaAdvogadoParte listaAux;
        private List<ListaAdvogadoParte> _listaFinalAdvogadosParte;
        public List<ListaAdvogadoParte> ListaFinalAdvogadosParte { get { return _listaFinalAdvogadosParte; } set { _listaFinalAdvogadosParte = value; base.OnPropertyChanged(); } }

        public PartesView (List<List<Parte>> listaPartes)
		{
			InitializeComponent ();
            foreach (var parte in listaPartes[0])
            {
                listaAux = new ListaAdvogadoParte(parte.listaAdvogados);
                listaAux.nomeParte = parte.nomeParte;
                listaAux.tipoParte = parte.tipoParte;
                this.listaAdvogadosParte.Add(listaAux);
            }
            this.ListaFinalAdvogadosParte = this.listaAdvogadosParte;
            PartesListView.ItemsSource = this.ListaFinalAdvogadosParte;
        }

        public class ListaAdvogadoParte : List<Advogado>
        {
            public string nomeParte { get; set; }
            public string tipoParte { get; set; }

            public ListaAdvogadoParte(List<Advogado> advogados)
            {
                this.AddRange(advogados);
            }
        }
    }
}