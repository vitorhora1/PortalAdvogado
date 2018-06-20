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
        public string urlDocumento = @"http://homologacao.tjse.jus.br:8080/tjse-mobile-rest-services/downloadFile/";

        public PDFView (string idDocumento)
		{
			InitializeComponent ();
            urlDocumento += idDocumento;
		}

        public async void openFile(String idDocumento)
        {
            HttpResponseMessage response = await getFile(idDocumento);
            Byte[] result = await response.Content.ReadAsByteArrayAsync();
            Device.BeginInvokeOnMainThread(() =>
            {
                Stream stream = new System.IO.MemoryStream(result);
                StreamReader r = new StreamReader(stream);
                string text = "";
                using (var reader = new System.IO.StreamReader(stream))
                {
                    text = reader.ReadToEnd();
                }
            });
        }

        public Task<HttpResponseMessage> getFile(String idDocumento)
        {
            return new HttpClient().GetAsync(urlDocumento + idDocumento);
        }
    }
}