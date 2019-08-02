using MicroondasDigital.AppService.Microondas;
using MicroondasDigital.IoC;
using Ninject;
using System;

namespace MicroondasDigital.App
{
    public static class Servicos
    {
        public static StandardKernel KernelNinject { get; set; } = null;

        private static StandardKernel Kernel()
        {
            try
            {
                if (KernelNinject == null)
                    KernelNinject = ConfigNinject.Registrar();
            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possível iniciar o Kernel! Exception - {ex}");
            }

            return KernelNinject;
        }

        public static void CarregarKernel()
        {
            KernelNinject?.Dispose();
            KernelNinject = null;

            Kernel();
        }

        public static MicroondasAppService Microondas 
            => (MicroondasAppService)Kernel().Get(typeof(MicroondasAppService));
    }
}