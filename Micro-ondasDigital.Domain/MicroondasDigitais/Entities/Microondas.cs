using MicroondasDigital.Domain.MicroondasDigitais.Enums;
using MicroondasDigital.Domain.MicroondasDigitais.Repositories;
using MicroondasDigital.Domain.ValueObjects;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using MicroondasDigital.Domain.MicroondasDigitais.Results;

namespace MicroondasDigital.Domain.MicroondasDigitais.Entities
{
    public class Microondas : Notifiable, IMicroondasRepository
    {
        public Microondas()
        {

        }

        public Microondas(MicroondasOperacao operacao, Tempo tempo, MicroondasStatus status, int potencia = 10)
        {
            Operacao = operacao;
            Tempo = tempo;
            Potencia = potencia;
            Status = status;
        }

        public MicroondasOperacao Operacao { get; private set; }
        public MicroondasStatus Status { get; private set; }
        public Tempo Tempo { get; private set; }
        public int Potencia { get; private set; }
        public TimeSpan TempoInformado { get; private set; }

        public void Adicionar(Microondas microondas)
            => new Microondas(microondas.Operacao, microondas.Tempo, microondas.Status, microondas.Potencia);

        public void InicioRapido(int potencia, TimeSpan tempoInformado)
        {
            Potencia = potencia;
            TempoInformado = tempoInformado;
        }

        public IEnumerable<PreDefinidosResult> ObterProgramasPreDefinidos()
        {
            var predefinicaoUm = PreencherResult("Frango", 10, new TimeSpan(0, 1, 0), "", "f");

            var predefinicaoDois = PreencherResult("Carne", 10, new TimeSpan(0, 1, 30), "", "b");

            var predefinicaoTres = PreencherResult("Coxinha", 2, new TimeSpan(0, 0, 30), "", "c");

            var predefinicaoQuatro = PreencherResult("Leite", 5, new TimeSpan(0, 1, 30), "", "l");

            var predefinicaoCinco = PreencherResult("Arroz", 10, new TimeSpan(0, 0, 30), "", "a");

            return new List<PreDefinidosResult>
            {
                predefinicaoUm,
                predefinicaoDois,
                predefinicaoTres,
                predefinicaoQuatro,
                predefinicaoCinco
            };
        }

        public PreDefinidosResult PreencherResult(string nome, int potencia, TimeSpan tempo, string instrucao, string caractere)
        {
            return new PreDefinidosResult
            {
                Nome = nome,
                Potencia = potencia,
                Tempo = tempo,
                Instrucao = instrucao,
                Caractere = caractere
            };
        }

        private bool ValidarTempoInvalido()
        {
            return Tempo.Minimo != new TimeSpan(0, 0, 0) || Tempo.Maximo != new TimeSpan(0, 0, 0);
        }

        private bool ValidarPotenciaInvalida()
        {
            return Potencia >= 1 && Potencia <= 10;
        }

        public void Validar()
        {
            new AddNotifications<Microondas>(this)
                .IfEnumInvalid(x => x.Operacao, "Operação inválida!")
                .IfEnumInvalid(x => x.Status, "Status inválido!")
                .IfFalse(ValidarTempoInvalido(), "Tempo não informado!")
                .IfFalse(ValidarPotenciaInvalida(), "Potência informada está incorreta!");
        }
    }
}