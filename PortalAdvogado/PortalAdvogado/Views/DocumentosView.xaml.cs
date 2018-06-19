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
	public partial class DocumentosView : ContentPage
	{
        public List<ListaDocumentoMovimento> listaDocumentosMovimento = new List<ListaDocumentoMovimento>();
        public ListaDocumentoMovimento listaAux;
        private List<ListaDocumentoMovimento> _listaFinalDocumentosMovimento;
        public List<ListaDocumentoMovimento> ListaFinalDocumentosMovimento { get { return _listaFinalDocumentosMovimento; } set { _listaFinalDocumentosMovimento = value; base.OnPropertyChanged(); } }

        public DocumentosView (List<List<Movimento>> listaMovimentos)
		{
			InitializeComponent ();
            if (listaMovimentos != null && listaMovimentos.Any())
            {
                foreach (var movimento in listaMovimentos[0])
                {
                    listaAux = new ListaDocumentoMovimento(movimento.listaDocumentos);
                    listaAux.descMovimento = movimento.descMovimento;
                    listaAux.dataMovimento = movimento.dataMovimento;
                    this.listaDocumentosMovimento.Add(listaAux);
                }
                this.ListaFinalDocumentosMovimento = this.listaDocumentosMovimento;
                DocumentosListView.ItemsSource = this.ListaFinalDocumentosMovimento;
            }
            else
            {
                EmptyListLabel.IsVisible = true;
                DocumentosListView.IsVisible = false;
            }
        }

        public void OnDocumentoClicked(object sender, EventArgs e)
        {
        }

        public class ListaDocumentoMovimento : List<Documento>
        {
            public string descMovimento { get; set; }
            public DateTime dataMovimento { get; set; }

            public ListaDocumentoMovimento(List<Documento> documentos)
            {
                this.AddRange(documentos);
            }
        }

    }
}