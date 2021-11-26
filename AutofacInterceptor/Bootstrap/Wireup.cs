using Autofac;
using Autofac.Extras.DynamicProxy;
using AutofacInterceptor.Security;
using AutofacInterceptor.Services;

namespace AutofacInterceptor.Bootstrap
{
    public class Wireup : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType(typeof(SecurityInterceptor));

            builder.RegisterType<BranchQuery>()
                .As<IBranchQuery>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(SecurityInterceptor))
                .InstancePerLifetimeScope();

            builder.RegisterDecorator<BranchCachingDecorator, IBranchQuery>();
        }
    }
}
