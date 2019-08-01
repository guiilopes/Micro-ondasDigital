using System;
using prmToolkit.NotificationPattern;

namespace MicroondasDigital.Domain.MicroondasDigitais.Results
{
    public class ProgramasPreDefinidosResult : Notifiable
    {
        public string Nome { get; set; }
        public int Potencia { get; set; }
        public TimeSpan Tempo { get; set; }

        public void Validar()
        {
            new AddNotifications<ProgramasPreDefinidosResult>(this)
                .IfNull(x=>x.Tempo, "Tempo inválido")
                .IfNullOrEmpty(x => x.Nome, "Predefinição inválida!")
                .IfEqualsZero(x => x.Potencia, "Potência inválida!");
        }
    }
}
