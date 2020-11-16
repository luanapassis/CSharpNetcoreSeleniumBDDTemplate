using CsharpBDDMantis.Helpers;
using CsharpBDDMantis.Queries;
using TechTalk.SpecFlow;


namespace CsharpBDDMantis.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            ExtentReportHelpers.ConfigureReport();
            //carga no banco
            DataBaseSteps dataBaseSteps = new DataBaseSteps();
            dataBaseSteps.CargaTabelaUsuario();
            dataBaseSteps.CargaProjeto();
            dataBaseSteps.CargaMarcadores();
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            ExtentReportHelpers.CreateFeature();
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            //carga no banco
            DataBaseSteps dataBaseSteps = new DataBaseSteps();
            dataBaseSteps.AtualizacaoCargaUsuario();
            dataBaseSteps.AtualizacaoCargaProjeto();
            dataBaseSteps.AtualizacaoCargaMarcadores();

            ExtentReportHelpers.CreateScenario();
            DriverFactory.CreateInstance();
            DriverFactory.INSTANCE.Manage().Window.Maximize();
        }

        [AfterStep]
        public static void AfterStep()
        {
            ExtentReportHelpers.CreateStep();
        }

        [AfterScenario]
        public static void TearDownScenario()
        {
            DriverFactory.QuitInstace();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            ExtentReportHelpers.FlushExtent();
        }
    }
}
