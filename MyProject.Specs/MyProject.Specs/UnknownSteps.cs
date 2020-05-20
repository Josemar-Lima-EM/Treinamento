using System;
using TechTalk.SpecFlow;

namespace MyProject.Specs2.......MyProject.Specs.MyProject.Specs
{
    [Binding]
    public class UnknownSteps
    {
        [Given(@"que eu inseri (.*) na calculadora")]
        public void DadoQueEuInseriNaCalculadora(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"também inseri (.*) na calculadora")]
        public void DadoTambemInseriNaCalculadora(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"pressiono add")]
        public void QuandoPressionoAdd()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"o resultado deve ser (.*) na tela")]
        public void EntaoOResultadoDeveSerNaTela(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
