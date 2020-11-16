using CsharpBDDMantis.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpBDDMantis.Flows
{
    public class LoginFlow
    {
        LoginPage loginPage;

        public LoginFlow()
        {
            loginPage = new LoginPage();
        }

        public void RealizarLogin(string usuario, string senha)
        {
            loginPage.PreencheUsuario(usuario);
            loginPage.ClicaBtnEntra();
            loginPage.PreencheSenha(senha);
            loginPage.ClicaBtnEntra();
        }
    }
}
