using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PortalAdvogado.Models;
using Xamarin.Forms;

namespace PortalAdvogado
{
    class LoginService
    {

        public async System.Threading.Tasks.Task FazerLogin(Login login)
        {
            try
            {
                using (var cliente = new HttpClient())
                {

                    var conteudo = new StringContent("{\"codigo\":\"" + login.oab + "\",\"letra\":\"" + login.letra + "\",\"uf\":\"" + login.uf + "\",\"senha\":\"" + login.senha + "\"}",
                                    Encoding.UTF8,
                                    "application/json");

                    var resultado = await cliente.PostAsync("http://homologacao.tjse.jus.br:8080/tjse-mobile-rest-services/login/advogado", conteudo);
                    Task<String> content = resultado.Content.ReadAsStringAsync();
                    var nomeAdv = content.Result;
                    if (resultado.IsSuccessStatusCode)
                        MessagingCenter.Send<Usuario>(new Usuario(nomeAdv, login.oab+""+login.letra+"-"+login.uf), "SucessoLogin");
                    else
                        MessagingCenter.Send<LoginException>(new LoginException("Usuário ou senha incorretos."), "FalhaLogin");
                }
            }
            catch (Exception)
            {
                MessagingCenter.Send<LoginException>(new LoginException(@"Ocorreu um erro de comunicação com o servidor.
Por favor verifique a sua conexão e tente novamente mais tarde."), "FalhaLogin");
            }
        }

    }

    public class LoginException : Exception
    {
        public LoginException(string message) : base(message)
        {
            
        }
    }
}
