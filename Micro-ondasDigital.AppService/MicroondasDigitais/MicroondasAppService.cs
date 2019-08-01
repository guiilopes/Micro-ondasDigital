using System;
using MicroondasDigital.Domain.MicroondasDigitais.Repositories;

namespace MicroondasDigital.AppService.Microondas
{
    public class MicroondasAppService
    {
        private IMicroondasRepository _repository;

        public MicroondasAppService(IMicroondasRepository repository)
        {
            _repository = repository;
        }

        public void Adicionar(Domain.MicroondasDigitais.Entities.Microondas microondas)
            => _repository.Adicionar(microondas);

        public void InicioRapido(int potencia, TimeSpan tempoInformado)
            => _repository.InicioRapido(potencia, tempoInformado);
    }
}
