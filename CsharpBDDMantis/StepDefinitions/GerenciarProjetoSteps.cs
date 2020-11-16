using CsharpBDDMantis.Pages;
using CsharpBDDMantis.Queries;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace CsharpBDDMantis.StepDefinitions
{
    [Binding]
    public class GerenciarProjetoSteps
    {
        GerenciarProjetoPage gerenciarProjetoPage;
        DataBaseSteps dataBaseSteps;

        public GerenciarProjetoSteps()
        {
            gerenciarProjetoPage = new GerenciarProjetoPage();
            dataBaseSteps = new DataBaseSteps();
        }

        [Given(@"acesso o menu de Gerenciar Projeto")]
        public void GivenAcessoOMenuDeGerenciarProjeto()
        {
            gerenciarProjetoPage.AbrirMenuGerenciarProjeto();
        }
        
        [Given(@"abro grid projeto Teste")]
        public void GivenAbroGridProjetoTeste()
        {
            gerenciarProjetoPage.AbrirGridProjeto();
        }
        
        [Given(@"seleciono combo estado igual a '(.*)'")]
        public void GivenSelecionoComboEstadoIgualA(string estado)
        {
            gerenciarProjetoPage.SelecaoComboEstado(estado);
        }
        
        [When(@"seleciono atualizar projeto")]
        public void WhenSelecionoAtualizarProjeto()
        {
            gerenciarProjetoPage.ClicaBtnAtualizarProjeto();
        }
        
        [Then(@"o estado '(.*)' e gravado para o projeto '(.*)'")]
        public void ThenOEstadoDoProjetoEGravadoParaOProjeto(string status, string projeto)
        {
            string statusRecebido = dataBaseSteps.RetornaStatusProjeto(projeto);

            Assert.IsTrue(statusRecebido == status);
        }
    }
}
