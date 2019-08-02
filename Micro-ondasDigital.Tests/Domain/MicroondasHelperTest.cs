using System;
using System.Collections.Generic;
using MicroondasDigital.Domain.MicroondasDigitais.Helpers;
using MicroondasDigital.Domain.MicroondasDigitais.Results;
using MicroondasDigital.Domain.Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Micro_ondasDigital.Tests.Domain
{
    [TestClass]
    [TestCategory("Domain - Microondas - Helper")]
    public class MicroondasHelperTest
    {
        [TestMethod]
        public void Deve_retornar_quando_alimento_quando_informado()
        {
            Assert.AreEqual(Resource.ArrozRtf, MicroondasHelper.ObterInstrucao("Arroz"));
            Assert.AreEqual(Resource.CarneRtf, MicroondasHelper.ObterInstrucao("Carne"));
            Assert.AreEqual(Resource.CoxinhaRtf, MicroondasHelper.ObterInstrucao("Coxinha"));
            Assert.AreEqual(Resource.FrangoRtf, MicroondasHelper.ObterInstrucao("Frango"));
            Assert.AreEqual(Resource.LeiteRtf, MicroondasHelper.ObterInstrucao("Leite"));
            Assert.AreEqual("Alimento inválido!", MicroondasHelper.ObterInstrucao(""));
        }

        [TestMethod]
        public void Deve_retornar_lista_quando_informado()
        {
            var predefinicao = MicroondasHelper.PreencherResult("Frango", 10, new TimeSpan(0, 1, 0), "f");

            var lista = new PreDefinidosResult
            {
                Nome = "Frango",
                Potencia = 10,
                Tempo = new TimeSpan(0,1,0),
                Caractere = "f"
            };

            Assert.AreEqual(lista.Nome, predefinicao.Nome);
            Assert.AreEqual(lista.Potencia, predefinicao.Potencia);
            Assert.AreEqual(lista.Tempo, predefinicao.Tempo);
            Assert.AreEqual(lista.Caractere, predefinicao.Caractere);
        }
    }
}