using System;
using prmToolkit.NotificationPattern;

namespace MicroondasDigital.Domain.MicroondasDigitais.Results
{
    public class ProgramasPreDefinidosResult : Notifiable
    {
        public string Nome { get; set; }
        public int Potencia { get; set; }
        public TimeSpan Tempo { get; set; }
        public string Instrucao { get; set; }
        public string Caractere { get; set; }

        public void Validar()
        {
            new AddNotifications<ProgramasPreDefinidosResult>(this)
                .IfNull(x => x.Tempo, "Tempo inválido")
                .IfNullOrEmpty(x => x.Nome, "Predefinição inválida!")
                .IfNullOrEmpty(x => x.Instrucao, "Instrução inválida!")
                .IfNullOrEmpty(x => x.Caractere, "Caractere inválido!")
                .IfEqualsZero(x => x.Potencia, "Potência inválida!");
        }
    }
}
