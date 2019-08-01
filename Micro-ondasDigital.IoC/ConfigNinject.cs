using Ninject;
using Ninject.Extensions.NamedScope;
using System.Data.SqlClient;
using MicroondasDigital.Infra.DataContexts;
using MicroondasDigital.Infra.Interfaces;
using MicroondasDigital.Infra.UoW;

namespace MicroondasDigital.IoC
{
    public class ConfigNinject
    {
        public static StandardKernel Registrar(SqlConnection connection)
        {
            var kernel = new StandardKernel(new NinjectSettings { AllowNullInjection = true });

            kernel.Bind<SqlConnection>().ToConstant(connection);
            kernel.Bind<DataContext>().ToSelf().InCallScope();

            kernel.Bind<IUnitOfWork>().To<UnitOfWork>().WithConstructorArgument(connection);
            //kernel.Bind<IGitHubRepository>().To<GitHubRepository>();

            return kernel;
        }
    }
}
