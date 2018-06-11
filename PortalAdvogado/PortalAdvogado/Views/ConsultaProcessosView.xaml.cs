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
                                                                        localizacao = "4ª Comarca Cível de Aracaju"} };

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
                EmptyListLabel.IsVisible = false;
            } catch (Exception ex) {
                ProcessosListView.IsVisible = false;
                EmptyListLabel.IsVisible = true;
                DisplayAlert("Erro", ex.Message, "OK");
            }
        }

        private void SearchBar_OnTextPressed(object sender, TextChangedEventArgs e)
        {
        }
    }
}