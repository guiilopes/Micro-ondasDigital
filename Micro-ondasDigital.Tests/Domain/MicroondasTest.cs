using MicroondasDigital.Domain.MicroondasDigitais.Entities;
using MicroondasDigital.Domain.MicroondasDigitais.Enums;
using MicroondasDigital.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Micro_ondasDigital.Tests.Domain
{
    [TestClass]
    [TestCategory("Domain - Microondas")]
    public class MicroondasTest
    {
        [TestMethod]
        public void Deve_retornar_verdadeiro_quando_tempo_informado_incorreto()
        {
            var tempoMinimo = new TimeSpan(0, 0, 0);
            var tempoMaximo = new TimeSpan(0, 0, 0);

            var tempo = new Microondas(MicroondasOperacao.Cozimento, new Tempo(tempoMinimo, tempoMaximo), MicroondasStatus.EmFuncionamento, 1);

            tempo.Validar();

            Assert.IsTrue(tempo.Notifications.Any());
        }

        [TestMethod]
        public void Deve_retornar_falso_quando_tempo_informado_corretamente()
        {
            var tempoMinimo = new TimeSpan(0, 0, 1);
            var tempoMaximo = new TimeSpan(0, 1, 0);

            var tempo = new Microondas(MicroondasOperacao.Cozimento, new Tempo(tempoMinimo, tempoMaximo), MicroondasStatus.EmFuncionamento, 1);

            tempo.Validar();

            Assert.IsFalse(tempo.Notifications.Any());
        }

        [TestMethod]
        public void Deve_retornar_falso_quando_potencia_nao_informada()
        {
            var tempoMinimo = new TimeSpan(0, 0, 1);
            var tempoMaximo = new TimeSpan(0, 1, 0);

            var tempo = new Microondas(MicroondasOperacao.Cozimento, new Tempo(tempoMinimo, tempoMaximo), MicroondasStatus.EmFuncionamento);



            tempo.Validar();

            Assert.IsFalse(tempo.Notifications.Any());
        }

        [TestMethod]
        public void Deve_retornar_verdadeiro_quando_potencia_informada_maior_que_10()
        {
            var tempoMinimo = new TimeSpan(0, 0, 1);
            var tempoMaximo = new TimeSpan(0, 1, 0);

            var tempo = new Microondas(MicroondasOperacao.Cozimento, new Tempo(tempoMinimo, tempoMaximo), MicroondasStatus.EmFuncionamento, 11);

            tempo.Validar();

            Assert.IsTrue(tempo.Notifications.Any());
        }

        [TestMethod]
        public void Deve_retornar_verdadeiro_quando_potencia_informada_menor_que_1()
        {
            var tempoMinimo = new TimeSpan(0, 0, 1);
            var tempoMaximo = new TimeSpan(0, 1, 0);

            var tempo = new Microondas(MicroondasOperacao.Cozimento, new Tempo(tempoMinimo, tempoMaximo), MicroondasStatus.EmFuncionamento, 0);

            tempo.Validar();

            Assert.IsTrue(tempo.Notifications.Any());
        }
    }
}