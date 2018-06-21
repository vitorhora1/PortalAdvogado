using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PortalAdvogado
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PDFView : ContentPage
	{
        //public string urlDocumento = @"http://homologacao.tjse.jus.br:8080/tjse-mobile-rest-services/downloadFile/";
        public string urlDocumento = @"http://www.concursosfcc.com.br/concursos/trt2r118/edital_de_abertura_final_trt2r118.pdf";
        public string titleDoc;

        public PDFView (string idDocumento, string nomeDocumento)
		{
            InitializeComponent ();
            //urlDocumento += idDocumento;
            titleDoc = nomeDocumento;
            openFile(idDocumento, nomeDocumento);
        }

        public async void openFile(String idDocumento, String nomeDocumento)
        {
            HttpResponseMessage response = await getFile(idDocumento);
            Byte[] result = await response.Content.ReadAsByteArrayAsync();
            string URL = await DependencyService.Get<ISaveFile>().SaveFile(nomeDocumento, result);
            PdfDocView.Uri = URL;
        }

        public Task<HttpResponseMessage> getFile(String idDocumento)
        {
            //return new HttpClient().GetAsync(urlDocumento) + idDocumento);
            return new HttpClient().GetAsync(urlDocumento);
        }

        protected override void OnAppearing()
        {
            Title = titleDoc;
        }
    }
}