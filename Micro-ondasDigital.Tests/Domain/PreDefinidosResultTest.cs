using System;
using System.Linq;
using MicroondasDigital.Domain.MicroondasDigitais.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MicroondasDigital.Tests.Domain
{
    [TestClass]
    [TestCategory("Domain - Microondas - Helper")]
    public class PreDefinidosResultTest
    {
        [TestMethod]
        public void Deve_retornar_falso_quando_result_informado()
        {
            var result = new PreDefinidosResult
            {
                Nome = "Frango",
                Tempo = new TimeSpan(0,1,0),
                Potencia = 10,
                Caractere = "f"
            };

            result.Validar();

            Assert.IsFalse(result.Notifications.Any());
        }

        [TestMethod]
        public void Deve_retornar_verdadeiro_quando_result_nao_informado()
        {
            var result = new PreDefinidosResult();

            result.Validar();

            Assert.IsTrue(result.Notifications.Any());
        }
    }
}
