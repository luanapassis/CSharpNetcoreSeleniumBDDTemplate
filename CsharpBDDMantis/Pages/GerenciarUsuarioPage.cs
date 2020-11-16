using CsharpBDDMantis.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpBDDMantis.Pages
{
    public class GerenciarUsuarioPage : PageBase
    {
        By menuGerenciar = By.XPath("//a[@href= '/mantis/manage_overview_page.php']");
        By menuUsuario = By.XPath("//a[@href= '/mantis/manage_user_page.php']");
        By pesquisaUsuario = By.Id("search");
        By btnAplicarFiltro = By.XPath("//input[@value= 'Aplicar Filtro']");
        By gridUsuario = By.XPath("//a[contains(@href,'manage_user_edit_page.php')]");
        By checkEnabled = By.XPath("//label/span[@class='lbl']");
        By btnAtualizarUsuario = By.XPath("//input[@value='Atualizar Usuário']");
        By comboNivelUsuario = By.Id("edit-access-level");
        By campoEmail = By.Id("email-field");
        By btnApagarUsuario = By.XPath("//input[@value='Apagar Usuário']");
        By btnApagarConta = By.XPath("//input[@value='Apagar Conta']");
        By campoNomeUsuario = By.Id("edit-username");
        By campoNomeVerdadeiro = By.Id("edit-realname");
        By checkEnviaEmail = By.XPath("//*[@id='edit-user-form']/div/div[2]/div[2]/label/span");
        By btnCriarNovoUsuario = By.XPath("//a[text()='Criar nova conta']");
        By btnConfirmarNovoUsuario = By.XPath("//input[@value='Criar Usuário']");
        By campoNovoNomeUsuario = By.Id("user-username");
        By campoNovoNomeReal = By.Id("user-realname");
        By campoNovoEmail = By.Id("email-field");
        By campoNovoNivel = By.Id("user-access-level");

        public void AbrirMenuGerenciarUsuario()
        {
            Click(menuGerenciar);
            Click(menuUsuario);
        }


        public void PesquisarUsuario(string usuario)
        {
            SendKeys(pesquisaUsuario, usuario);
            Click(btnAplicarFiltro);
        }
        public void ClicaPrimeirGridUsuario()
        {
            Click(gridUsuario);
        }
        public void DesabilitaUsuario()
        {
            Click(checkEnabled);
        }
        public void GravaAlteracaoUsuario()
        {
            Click(checkEnviaEmail);
            Click(btnAtualizarUsuario);
        }
        public void SelecionaNivelUsuario(string perfil)
        {
            ComboBoxSelectByVisibleText(comboNivelUsuario, perfil);
        }
        public void PreencheEmail(string email)
        {
            ClearAndSendKeys(campoEmail, email);
        }
        public void ApagaUsuario()
        {
            Click(btnApagarUsuario);
            Click(btnApagarConta);
        }
        public void PreencheNomeUsuario(string nome)
        {
            ClearAndSendKeys(campoNomeUsuario, nome);
        }
        public void PreencheNomeVerdadeiro(string nomeVerdadeiro)
        {
            ClearAndSendKeys(campoNomeVerdadeiro, nomeVerdadeiro);
        }
        public void CriarNovoUsuario()
        {
            Click(btnCriarNovoUsuario);
        }
        public void ConfirmarNovoUsuario()
        {
            Click(btnConfirmarNovoUsuario);
        }

        public void PreencheCampoNovoNomeUsuario(string usuario)
        {
            SendKeys(campoNovoNomeUsuario, usuario);
        }
        public void PreencheCampoNovoNomeReal(string nomeReal)
        {
            SendKeys(campoNovoNomeReal, nomeReal);
        }
        public void PreencheCampoNovoEmail(string email)
        {
            SendKeys(campoNovoEmail, email);
        }
        public void PreencheCampoNovoNivel(string nivel)
        {
            SendKeys(campoNovoNivel, nivel);
        }

    }
}
