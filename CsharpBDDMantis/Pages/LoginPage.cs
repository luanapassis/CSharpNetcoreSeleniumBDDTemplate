using CsharpBDDMantis.Bases;
using OpenQA.Selenium;
namespace CsharpBDDMantis.Pages
{
    public class LoginPage : PageBase
    {
        By campoUsuario = (By.Id("username"));
        By btnEntrar = (By.XPath("//input[@value= 'Entrar']"));
        By campoSenha = (By.Id("password"));
        By msgErroLogin = (By.XPath("/html/body/div[1]/div/div/div/div/div[4]/p"));

        public void PreencheUsuario(string usuario)
        {
            SendKeys(campoUsuario, usuario);
        }
        public void ClicaBtnEntra()
        {
            Click(btnEntrar);
        }
        public void PreencheSenha(string senha)
        {
            SendKeys(campoSenha, senha);
        }
        public string RetornaMsgErroLogin()
        {
            return GetText(msgErroLogin);
        }
    }
}
