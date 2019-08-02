using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
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
                Tempo = new TimeSpan(0, 1, 0),
                Caractere = "f"
            };

            Assert.AreEqual(lista.Nome, predefinicao.Nome);
            Assert.AreEqual(lista.Potencia, predefinicao.Potencia);
            Assert.AreEqual(lista.Tempo, predefinicao.Tempo);
            Assert.AreEqual(lista.Caractere, predefinicao.Caractere);
        }

        [TestMethod]
        public void Deve_retornar_falso_quando_horario_valido()
        {
            var helper = MicroondasHelper.ValidarHorarioInformado(new TextEdit { Text = "00:01" });

            Assert.IsFalse(helper);
        }

        [TestMethod]
        public void Deve_retornar_verdadeiro_quando_horario_invalido()
        {
            var helper = MicroondasHelper.ValidarHorarioInformado(new TextEdit { Text = "00:00" });

            Assert.IsTrue(helper);
        }

        [TestMethod]
        public void Deve_retornar_falso_quando_potencia_invalido()
        {
            var helper = MicroondasHelper.ValidarPotenciaInformada(new TextEdit { Text = "15" });

            Assert.IsFalse(helper);
        }

        [TestMethod]
        public void Deve_retornar_verdadeiro_quando_potencia_valido()
        {
            var helper = MicroondasHelper.ValidarPotenciaInformada(new TextEdit { Text = "5" });

            Assert.IsTrue(helper);
        }

        [TestMethod]
        public void Deve_retornar_verdadeiro_quando_potencia_informada_10()
        {
            var helper = MicroondasHelper.ValidarPotenciaInformada(new TextEdit { Text = "10" });

            Assert.IsTrue(helper);
        }

        [TestMethod]
        public void Deve_retornar_verdadeiro_quando_potencia_informada_1()
        {
            var helper = MicroondasHelper.ValidarPotenciaInformada(new TextEdit { Text = "1" });

            Assert.IsTrue(helper);
        }

        [TestMethod]
        public void Deve_retornar_falso_quando_potencia_informada_0()
        {
            var helper = MicroondasHelper.ValidarPotenciaInformada(new TextEdit { Text = "0" });

            Assert.IsFalse(helper);
        }
    }
}