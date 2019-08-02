using System;
using prmToolkit.NotificationPattern;

namespace MicroondasDigital.Domain.MicroondasDigitais.Results
{
    public class PreDefinidosResult : Notifiable
    {
        public string Nome { get; set; }
        public int Potencia { get; set; }
        public TimeSpan Tempo { get; set; }
        public string Caractere { get; set; }

        public void Validar()
        {
            new AddNotifications<PreDefinidosResult>(this)
                .IfNull(Tempo, "Tempo inválido")
                .IfNullOrEmpty(Nome, "Predefinição inválida!")
                .IfNullOrEmpty(Caractere, "Caractere inválido!")
                .IfEqualsZero(Potencia, "Potência inválida!");
        }
    }
}
