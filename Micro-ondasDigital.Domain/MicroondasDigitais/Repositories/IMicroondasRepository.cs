using MicroondasDigital.Domain.MicroondasDigitais.Entities;
using MicroondasDigital.Domain.MicroondasDigitais.Results;
using System;
using System.Collections.Generic;

namespace MicroondasDigital.Domain.MicroondasDigitais.Repositories
{
    public interface IMicroondasRepository
    {
        void InicioRapido(int potencia, TimeSpan tempoInformado);

        void Adicionar(Microondas microondas);

        IEnumerable<PreDefinidosResult> ObterProgramasPreDefinidos();
    }
}
