using System;
using MicroondasDigital.Domain.MicroondasDigitais.Entities;

namespace MicroondasDigital.Domain.MicroondasDigitais.Repositories
{
    public interface IMicroondasRepository
    {
        void InicioRapido(int potencia, TimeSpan tempoInformado);
        void Adicionar(Microondas microondas);
    }
}
