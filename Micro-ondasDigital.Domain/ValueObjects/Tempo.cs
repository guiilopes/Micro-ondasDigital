using System;
using prmToolkit.NotificationPattern;

namespace MicroondasDigital.Domain.ValueObjects
{
    public class Tempo : Notifiable
    {
        public Tempo(TimeSpan minimo, TimeSpan maximo)
        {
            Minimo = minimo;
            Maximo = maximo;
        }

        public TimeSpan Minimo { get; private set; }
        public TimeSpan Maximo { get; private set; }

        private bool ValidarTempoMinimo()
        {
            return Minimo < new TimeSpan(0, 0, 1);
        }

        private bool ValidarTempoMaximo()
        {
            return Maximo > new TimeSpan(0, 2, 0);
        }

        public void Validar()
        {
            new AddNotifications<Tempo>(this)
                .IfFalse(ValidarTempoMaximo(), "Tempo informado maior que 2 minutos")
                .IfFalse(ValidarTempoMinimo(), "Tempo informado menor que 1 segundo");
        }
    }
}
