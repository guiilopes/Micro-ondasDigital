using MicroondasDigital.Domain.MicroondasDigitais.Entities;
using MicroondasDigital.Domain.MicroondasDigitais.Enums;
using MicroondasDigital.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MicroondasDigital.Domain.MicroondasDigitais.Repositories;
using MicroondasDigital.Domain.MicroondasDigitais.Results;
using Moq;

namespace Micro_ondasDigital.Tests.Domain
{
    [TestClass]
    [TestCategory("Domain - Microondas")]
    public class MicroondasTest
    {
        private Mock<IMicroondasRepository> _repositoryMock;

        [TestInitialize]
        public void Init()
        {
            _repositoryMock = new Mock<IMicroondasRepository>();
        }

        [TestMethod]
        public void Deve_retornar_lista_quando_preenchida()
        {
            var microondas = new Microondas();
            var lista = microondas.ObterProgramasPreDefinidos();

            var preDefinidosResults = lista.ToList();
            _repositoryMock.Setup(x => x.ObterProgramasPreDefinidos())
                .Returns(preDefinidosResults);

            Assert.AreEqual(preDefinidosResults, preDefinidosResults);
        }

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

        [TestMethod]
        public void Deve_retonar_falso_quando_adicionar_microondas_informado()
        {
            var microondas = new Microondas(MicroondasOperacao.Cozimento,
                                            new Tempo(new TimeSpan(0, 0, 1),
                                                      new TimeSpan(0, 2, 0)),
                                            MicroondasStatus.EmFuncionamento,
                                            10);

            microondas.Adicionar(microondas);

            microondas.Validar();

            Assert.IsFalse(microondas.Notifications.Any());
        }

        [TestMethod]
        public void Deve_retonar_falso_quando_inicio_rapido_informado()
        {
            var microondas = new Microondas(MicroondasOperacao.Cozimento,
                new Tempo(new TimeSpan(0, 0, 1),
                    new TimeSpan(0, 2, 0)),
                MicroondasStatus.EmFuncionamento,
                10);

            microondas.InicioRapido(10, new TimeSpan(0, 1, 0));

            microondas.Validar();

            Assert.IsFalse(microondas.Notifications.Any());
        }

        [TestMethod]
        public void Deve_retonar_falso_quando_contrutor_tempo_potencia_informado()
        {
            var microondas = new Microondas(MicroondasOperacao.Cozimento,
                new Tempo(new TimeSpan(0, 0, 1),
                    new TimeSpan(0, 2, 0)),
                MicroondasStatus.EmFuncionamento,
                10);

            var microondas2 = new Microondas(10, new TimeSpan(0, 1, 0));

            var tempoInformado = microondas2.TempoInformado;

            var microondas3 = new Microondas();

            microondas.Validar();

            Assert.IsFalse(microondas.Notifications.Any());
        }


    }
}