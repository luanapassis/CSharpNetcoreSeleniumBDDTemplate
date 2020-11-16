using CsharpBDDMantis.Bases;
using OpenQA.Selenium;

namespace CsharpBDDMantis.Pages
{
    public class HomePage : PageBase
    {
        By usuLogado = (By.XPath("//span[@class = 'user-info']"));
        By menuProjeto = (By.XPath("//a[@data-toggle= 'dropdown']"));
        By projetoMassa = (By.XPath("//a[text()=' Teste ']"));
        By campoPesquisaTarefa = (By.Name("bug_id"));



        public string RetornaUsuLogado()
        {
            return GetText(usuLogado);
        }
        public string RetornaProjetoMassa()
        {
            Click(menuProjeto);
            string retorno = GetText(projetoMassa);
            Click(menuProjeto);
            return retorno;
        }
        public void ClicaProjetoMassa()
        {
            Click(menuProjeto);
            Click(projetoMassa);
        }
        public void PreenchePesquisaTarefa(string tarefaId)
        {
            SendKeys(campoPesquisaTarefa, tarefaId);
            SendKeys(campoPesquisaTarefa, Keys.Enter);
        }
    }
}
