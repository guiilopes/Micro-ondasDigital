using MicroondasDigital.Domain.MicroondasDigitais.Enums;
using MicroondasDigital.Domain.ValueObjects;
using prmToolkit.NotificationPattern;
using System;

namespace MicroondasDigital.Domain.MicroondasDigitais.Entities
{
    public class Microondas : Notifiable
    {
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