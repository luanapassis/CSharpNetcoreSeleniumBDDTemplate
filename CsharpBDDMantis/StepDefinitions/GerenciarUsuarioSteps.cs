using CsharpBDDMantis.Pages;
using CsharpBDDMantis.Queries;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace CsharpBDDMantis.StepDefinitions
{
    [Binding]
    public class GerenciarUsuarioSteps
    {
        DataBaseSteps dataBaseSteps;
        GerenciarUsuarioPage gerenciarUsuarioPage;

        public GerenciarUsuarioSteps()
        {
            gerenciarUsuarioPage = new GerenciarUsuarioPage();
            dataBaseSteps = new DataBaseSteps();
        }

        [Given(@"acesso o menu de Gerenciar Usuario")]
        public void GivenAcessoOMenuDeGerenciarUsuario()
        {
            gerenciarUsuarioPage.AbrirMenuGerenciarUsuario();
        }

        [Given(@"pesquiso usuario '(.*)'")]
        public void GivenPesquisoUsuario(string usuarioAtualizar)
        {
            gerenciarUsuarioPage.PesquisarUsuario(usuarioAtualizar);
        }

        [Given(@"clico no primeiro item do grid")]
        public void GivenClicoNoPrimeiroItemDoGrid()
        {
            gerenciarUsuarioPage.ClicaPrimeirGridUsuario();
        }

        [When(@"seleciono nivel Usuario '(.*)' e gravo a operacao")]
        public void WhenSelecionoNivelUsuarioEGravoAOperacao(string perfil)
        {
            gerenciarUsuarioPage.SelecionaNivelUsuario(perfil);
            gerenciarUsuarioPage.GravaAlteracaoUsuario();
        }

        [Then(@"o nivel de acesso '(.*)' e gravado para o usuario '(.*)'")]
        public void ThenONivelDeAcessoEGravadoParaOUsuario(String nivel, string usuarioAtualizado)
        {
            string status = dataBaseSteps.RetornaNivelAcesso(usuarioAtualizado);

            Assert.AreEqual(status , nivel);
        }


    }
}
