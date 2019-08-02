using MicroondasDigital.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Micro_ondasDigital.Tests.Domain
{
    [TestClass]
    [TestCategory("Domain - ValueObject - Tempo")]
    public class TempoTest
    {
        [TestMethod]
        public void Deve_retornar_verdadeiro_quando_tempo_informado()
        {
            var tempoMinimo = new TimeSpan(0, 0, 1);
            var tempoMaximo = new TimeSpan(0, 2,0);

            var tempo = new Tempo(tempoMinimo, tempoMaximo);
            tempo.Validar();

            Assert.IsTrue(tempo.Notifications.Any());
        }

        [TestMethod]
        public void Deve_retornar_falso_quando_tempo_informado()
        {
            var tempoMinimo = new TimeSpan(0, 0, 0);
            var tempoMaximo = new TimeSpan(0, 2, 1);

            var tempo = new Tempo(tempoMinimo, tempoMaximo);
            tempo.Validar();

            Assert.IsFalse(tempo.Notifications.Any());
        }
    }
}
