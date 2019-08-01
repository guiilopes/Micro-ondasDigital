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

        public void InicioRapido(int potencia, TimeSpan tempoInformado)
        {
            Potencia = potencia;
            TempoInformado = tempoInformado;
        }

        public void Adicionar(Microondas microondas)
        {
            new Microondas(microondas.Operacao, microondas.Tempo, microondas.Status, microondas.Potencia);
        }

        public IEnumerable<ProgramasPreDefinidosResult> ObterProgramasPreDefinidos()
        {
            var predefinicaoUm = PreencherResult("Frango", 10, new TimeSpan(0, 1, 0));
            var predefinicaoDois = PreencherResult("Carne", 10, new TimeSpan(0, 1, 30));
            var predefinicaoTres = PreencherResult("Coxinha", 2, new TimeSpan(0, 0, 30));
            var predefinicaoQuatro = PreencherResult("Leite", 5, new TimeSpan(0, 1, 30));
            var predefinicaoCinco = PreencherResult("Arroz", 10, new TimeSpan(0, 0, 30));

            return new List<ProgramasPreDefinidosResult>
            {
                predefinicaoUm,
                predefinicaoDois,
                predefinicaoTres,
                predefinicaoQuatro,
                predefinicaoCinco
            };
        }

        public ProgramasPreDefinidosResult PreencherResult(string nome, int potencia, TimeSpan tempo)
        {
            return new ProgramasPreDefinidosResult
            {
                Nome = nome,
                Potencia = potencia,
                Tempo = tempo
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