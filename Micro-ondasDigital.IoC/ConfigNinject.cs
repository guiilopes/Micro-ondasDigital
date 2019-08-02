using MicroondasDigital.Domain.MicroondasDigitais.Entities;
using MicroondasDigital.Domain.MicroondasDigitais.Repositories;
using MicroondasDigital.Infra.DataContexts;
using MicroondasDigital.Infra.Interfaces;
using MicroondasDigital.Infra.UoW;
using Ninject;
using Ninject.Extensions.NamedScope;

namespace MicroondasDigital.IoC
{
    public class ConfigNinject
    {
        public static StandardKernel Registrar()
        {
            var kernel = new StandardKernel(new NinjectSettings { AllowNullInjection = true });

            kernel.Bind<DataContext>().ToSelf().InCallScope();

            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            kernel.Bind<IMicroondasRepository>().To<Microondas>();

            return kernel;
        }
    }
}
