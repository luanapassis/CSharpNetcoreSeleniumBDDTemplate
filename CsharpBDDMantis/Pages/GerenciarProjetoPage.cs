using CsharpBDDMantis.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpBDDMantis.Pages
{
    public class GerenciarProjetoPage : PageBase
    {
        By menuGerenciar = By.XPath("//a[@href= '/mantis/manage_overview_page.php']");
        By menuProjeto = By.XPath("//a[@href= '/mantis/manage_proj_page.php']");
        By gridProjeto = By.XPath("//a[contains(@href,'manage_proj_edit_page.php') and text()='Teste']");
        By comboEstado = By.Id("project-status");
        By btnAtualizarProjeto = By.XPath("//input[@value='Atualizar Projeto']");
        By btnCriarNovoProjeto = By.XPath("//button[text()='Criar Novo Projeto']");
        By campoNomeProjeto = By.Id("project-name");
        By comboVisibiliade = By.Id("project-view-state");
        By campoDescricao = By.Id("project-description");
        By btnAdicionarProjeto = By.XPath("//input[@type='submit']");
        By comboSubProjeto = By.Name("subproject_id");
        By btnAdicionarSubProjeto = By.XPath("//input[@value='Adicionar como Subprojeto']");
        By checkEnabled = By.XPath("//label/span[@class='lbl']");
        By msgErro = By.XPath("//p[contains(text(),'APPLICATION ERROR')]");

        public void AbrirMenuGerenciarProjeto()
        {
            Click(menuGerenciar);
            Click(menuProjeto);
        }

        public void AbrirGridProjeto()
        {
            Click(gridProjeto);
        }
        public void SelecaoComboEstado(string estado)
        {
            ComboBoxSelectByVisibleText(comboEstado, estado);
        }
        public void ClicaBtnAtualizarProjeto()
        {
            Click(btnAtualizarProjeto);
        }
        public void ClicarBtnNovoProjeto()
        {
            Click(btnCriarNovoProjeto);
        }
        public void PreencheNomeProjeto(string nome)
        {
            ClearAndSendKeys(campoNomeProjeto, nome);
        }
        public void SelecionarVisibilidade(string visibilidade)
        {
            ComboBoxSelectByVisibleText(comboVisibiliade, visibilidade);
        }
        public void PreencheDescricaoProjeto(string descricao)
        {
            ClearAndSendKeys(campoDescricao, descricao);
        }
        public void ClicarAdicionarProjeto()
        {
            Click(btnAdicionarProjeto);
        }
        public void SelecionaSubProjeto(string subProjeto)
        {
            ComboBoxSelectByVisibleText(comboSubProjeto, subProjeto);
        }
        public void AdicionarSubProjeto()
        {
            Click(btnAdicionarSubProjeto);
        }
        public void DesabilitaProjeto()
        {
            Click(checkEnabled);
        }
        public bool RetornaMsgErro()
        {
            return ReturnIfElementIsDisplayed(msgErro);
        }
    }
}
