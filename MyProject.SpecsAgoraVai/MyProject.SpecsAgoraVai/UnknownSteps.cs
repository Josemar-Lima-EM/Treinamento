using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using ExemploCalculadora;

namespace MyProject.SpecsAgoraVai
{
    [Binding]
    public class UnknownSteps
    {
        private int result;
        private Calculator calculator = new Calculator();

        [Given(@"que eu inseri (.*) na calculadora")]
        public void DadoQueEuInseriNaCalculadora(int number)
        {
            calculator.FirstNumber = number;
        }
        
        [Given(@"também inseri (.*) na calculadora")]
        public void DadoTambemInseriNaCalculadora(int number)
        {
            calculator.SecondNumber = number;
        }
        
        [When(@"pressiono add")]
        public void QuandoPressionoAdd()
        {
            result = calculator.Add();
        }
        
        [When(@"pressiono sub")]
        public void QuandoPressionoSub()
        {
            result = calculator.Add();
        }
        
        [Then(@"o resultado deve ser (.*) na tela")]
        public void EntaoOResultadoDeveSerNaTela(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}
