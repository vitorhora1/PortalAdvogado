using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using PortalAdvogado.Models;
using Xamarin.Forms;

namespace PortalAdvogado.ViewModels
{
    public class LoginViewModel
    {
        private string usuario;
        public string Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
                ((Command)EntrarCommand).ChangeCanExecute();
            }
        }

        private string oab;
        public string Oab
        {
            get { return oab; }
            set
            {
                oab = value;
                ((Command)EntrarCommand).ChangeCanExecute();
            }
        }

        private string letra = "";
        public string Letra
        {
            get { return letra; }
            set
            {
                letra = value;
                ((Command)EntrarCommand).ChangeCanExecute();
            }
        }

        private string uf;
        public string Uf
        {
            get { return uf; }
            set
            {
                uf = value;
                if (EntrarCommand != null) ((Command)EntrarCommand).ChangeCanExecute();
            }
        }

        private string senha;
        public string Senha
        {
            get { return senha; }
            set
            {
                senha = value;
                ((Command)EntrarCommand).ChangeCanExecute();
            }
        }

        public ICommand EntrarCommand { get; private set; }

        public LoginViewModel()
        {
            this.Uf = "SE";
            EntrarCommand = new Command(async () =>
            {
                var loginService = new LoginService();
                await loginService.FazerLogin(new Login(oab, letra, uf, senha));
            }, () =>
            {
                return !string.IsNullOrEmpty(oab)
                        && !string.IsNullOrEmpty(uf)
                        && !string.IsNullOrEmpty(senha);
            });
        }

    }
}
