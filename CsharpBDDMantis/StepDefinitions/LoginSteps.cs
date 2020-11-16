using CsharpBDDMantis.Flows;
using CsharpBDDMantis.Helpers;
using CsharpBDDMantis.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace CsharpBDDMantis.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        LoginPage loginPage;
        HomePage homePage;
        LoginFlow loginFlow;

        public LoginSteps()
        {
            loginPage = new LoginPage();
            homePage = new HomePage();
            loginFlow = new LoginFlow();
        }

        [Given(@"acesso o sistema Mantis")]
        public void GivenAcessoOSistemaMantis()
        {
            
            DriverFactory.INSTANCE.Navigate().GoToUrl(JsonBuilder.ReturnParameterAppSettings("DEFAULT_APPLICATION_URL"));
        }


        [When(@"efetuo login com usuario '(.*)' e '(.*)'")]
        public void WhenEfetuoLoginComUsuarioE(string usuario, string senha)
        {
            loginPage.PreencheUsuario(usuario);
            loginPage.ClicaBtnEntra();
            loginPage.PreencheSenha(senha);
            loginPage.ClicaBtnEntra();
        }

        [Then(@"login realizado com sucesso para o '(.*)'")]
        public void ThenLoginRealizadoComSucessoParaO(string usuarioEsperado)
        {
            string usuarioRetornado = homePage.RetornaUsuLogado();
            Assert.AreEqual(usuarioEsperado, usuarioRetornado);
        }

        [Then(@"login incorreto com a mensagem '(.*)'")]
        public void ThenLoginIncorretoComAMensagem(string mensagemEsperada)
        {
            string mensagemRecebida = loginPage.RetornaMsgErroLogin();

            Assert.AreEqual(mensagemEsperada, mensagemRecebida);
        }

        [Given(@"efetuo login com usuario '(.*)' e '(.*)'")]
        public void GivenEfetuoLoginComUsuarioE(string usuario, string senha)
        {
            loginFlow.RealizarLogin(usuario, senha);
        }



    }
}
