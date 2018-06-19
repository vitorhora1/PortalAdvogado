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
	public partial class ConsultaProcessosView : ContentPage
	{
        List<Processo> processos = new List<Processo> { new Processo(){ numeroProcessoTJSE = "201220100360",
                                                                        numeroUnico = "0059195-33.2011.8.26.0000",
                                                                        dataDistribuicao = "01/01/2010",
                                                                        autor = "Vitor Hora Fontes Pereira",
                                                                        reu = "Prefeitura de Aracaju",
                                                                        assunto = "Direito Civil",
                                                                        localizacao = "4ª Comarca Cível de Aracaju",
                                                                        listaAutores = new List<Parte>{ new Parte(){ nomeParte = "Outro Autor 1",
                                                                                                                    tipoParte = "Autor",
                                                                                                                    listaAdvogados = new List<Advogado>() { new Advogado() { nomeAdvogado = "Advogado 1", oabAdvogado = "172890-SE" },
                                                                                                                                                            new Advogado() { nomeAdvogado = "Advogado 2", oabAdvogado = "652541-SE" },
                                                                                                                                                            new Advogado() { nomeAdvogado = "Advogado 3", oabAdvogado = "481226-SE" }} },
                                                                                                        new Parte(){ nomeParte = "Outro Autor 2",
                                                                                                                    tipoParte = "Autor",
                                                                                                                    listaAdvogados = new List<Advogado>() { new Advogado() { nomeAdvogado = "Advogado 4", oabAdvogado = "172890-SE" },
                                                                                                                                                            new Advogado() { nomeAdvogado = "Advogado 5", oabAdvogado = "652541-SE" },
                                                                                                                                                            new Advogado() { nomeAdvogado = "Advogado 6", oabAdvogado = "481226-SE" }}} },
                                                                        listaReus = new List<Parte>{ new Parte(){ nomeParte = "Outro Réu 1",
                                                                                                                    tipoParte = "Réu",
                                                                                                                    listaAdvogados = new List<Advogado>() { new Advogado() { nomeAdvogado = "Advogado 11", oabAdvogado = "172890-SE" },
                                                                                                                                                            new Advogado() { nomeAdvogado = "Advogado 12", oabAdvogado = "652541-SE" }}                                                                                                                    },
                                                                                                     new Parte(){ nomeParte = "Outro Réu 2",
                                                                                                                    tipoParte = "Réu",
                                                                                                                    listaAdvogados = new List<Advogado>() { new Advogado() { nomeAdvogado = "Advogado 1000", oabAdvogado = "172890-SE" }} } },
                                                                        listaMovimentos = new List<Movimento>{ new Movimento() { codMovimento = 306, descMovimento = "Juntada", textoMovimento = "balbjakjdajsoidjaiodjsaiodjaiodjaoidjaoijsdoiajdoisajdoijasodijaodjiaosjdioaidojsadasbalbjakjdajsoidjaiodjsaiodjaiodjaoidjaoijsdoiajdoisajdoijasodijaodjiaosjdioaidojsadasbalbjakjdajsoidjaiodjsaiodjaiodjaoidjaoijsdoiajdoisajdoijasodijaodjiaosjdioaidojsadas", dataMovimento = DateTime.ParseExact("02/10/2012 10:30:25","dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture), listaDocumentos = new List<Documento>() },
                                                                                                               new Movimento() { codMovimento = 307, descMovimento = "Intimação Eletrônica", textoMovimento = "balbjakjdajsoidjaiodjsaiodjaiodjaoidjaoijsdoiajdoisajdoijasodijaodjiaosjdioaidojsadabalbjakjdajsoidjaiodjsaiodjaiodjaoidjaoijsdoiajdoisajdoijasodijaodjiaosjdioaidojsadasbalbjakjdajsoidjaiodjsaiodjaiodjaoidjaoijsdoiajdoisajdoijasodijaodjiaosjdioaidojsadass", dataMovimento = DateTime.ParseExact("02/11/2012 10:30:25","dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture), listaDocumentos = new List<Documento>() },
                                                                                                               new Movimento() { codMovimento = 308, descMovimento = "Conclusão", textoMovimento = "balbjakjdajsoidjaiodjsaiodjaiodjaoidjaoijsdoiajdoisajdoijasodijaodjiaosjdioaidojsabalbjakjdajsoidjaiodjsaiodjaiodjaoidjaoijsdoiajdoisajdoijasodijaodjiaosjdioaidojsadasbalbjakjdajsoidjaiodjsaiodjaiodjaoidjaoijsdoiajdoisajdoijasodijaodjiaosjdioaidojsadasbalbjakjdajsoidjaiodjsaiodjaiodjaoidjaoijsdoiajdoisajdoijasodijaodjiaosjdioaidojsadasbalbjakjdajsoidjaiodjsaiodjaiodjaoidjaoijsdoiajdoisajdoijasodijaodjiaosjdioaidojsadasdas", dataMovimento = DateTime.ParseExact("02/12/2012 10:30:25","dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture), listaDocumentos = new List<Documento>() },
                                                                                                               new Movimento() { codMovimento = 309, descMovimento = "Julgamento", textoMovimento = "balbjakjdajsoidjaiodjsaiodjaiodjaoidjaoijsdoiajdoisajdoijasodijaodjiaosjdioaidojsadas", dataMovimento = DateTime.ParseExact("22/10/2014 10:30:25","dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture), listaDocumentos = new List<Documento>() },
                                                                                                               new Movimento() { codMovimento = 310, descMovimento = "Carta Precatória", textoMovimento = "balbjakjdajsoidjaiodjsaiodjaiodjaoidjaoijsdoiajdoisajdoijasodijaodjiaosjdioaidobalbjakjdajsoidjaiodjsaiodjaiodjaoidjaoijsdoiajdoisajdoijasodijaodjiaosjdibalbjakjdajsoidjaiodjsaiodjaiodjaoidjaoijsdoiajdoisajdoijasodijaodjiaosjdioaidobalbjakjdajsoidjaiodjsaiodjaiodjaoidjaoijsdoiajdoisajdoijasodijaodjiaosjdioaidojsadasjsadasbalbjakjdajsoidjaiodjsaiodjaiodjaoidjaoijsdoiajdoisajdoijasodijaodjiaosjdioaidobalbjakjdajsoidjaiodjsaiodjaiodjaoidjaoijsdoiajdoisajdoijasodijaodjiaosjdioaidojsadasjsadasoaidojsadasjsadas", dataMovimento = DateTime.ParseExact("05/05/2015 10:30:25","dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture), listaDocumentos = new List<Documento>() } }
                                                                        } };

        public ConsultaProcessosView ()
		{
			InitializeComponent ();
            ProcessosListView.ItemsSource = processos;
        }

        private void SearchBar_OnSearchButtonPressed(object sender, TextChangedEventArgs e)
        {
            try { 
                var texto = ProcessoSearchBar.Text;

                if (string.IsNullOrEmpty(e.NewTextValue) || (texto.Length != 12 && texto.Length != 25))
                {
                    throw new Exception("O nº de processo digitado precisa ser um número válido de 12 caracteres (caso seja processo origem) ou 25 caracteres (caso seja número único).");
                }
                else
                {
                    ProcessosListView.ItemsSource = processos.Where(x => x.numeroProcessoTJSE.ToLower().StartsWith(texto.ToLower()));
                }

                ProcessosListView.IsVisible = true;
                PartesBtn.IsVisible = true;
                MovimentosBtn.IsVisible = true;
                DocumentosBtn.IsVisible = true;
                EmptyListLabel.IsVisible = false;
            } catch (Exception ex) {
                ProcessosListView.IsVisible = false;
                PartesBtn.IsVisible = false;
                MovimentosBtn.IsVisible = false;
                DocumentosBtn.IsVisible = false;
                EmptyListLabel.IsVisible = true;
                DisplayAlert("Erro", ex.Message, "OK");
            }
        }

        private void SearchBar_OnTextPressed(object sender, TextChangedEventArgs e){ }

        private void OnPartesClicked(object sender, TextChangedEventArgs e){
            List<List<Parte>> listaPartes = new List<List<Parte>>();
            //listaPartes.Add(processos[0].listaAutores);
            //listaPartes.Add(processos[0].listaReus);
            listaPartes.Add(processos[0].listaAutores.Concat(processos[0].listaReus).ToList());
            Navigation.PushAsync(new PartesView(listaPartes));
        }

        private void OnMovimentosClicked(object sender, TextChangedEventArgs e) {
            Navigation.PushAsync(new MovimentosView(processos[0].listaMovimentos));
        }

        private void OnDocumentosClicked(object sender, TextChangedEventArgs e) { }
    }
}