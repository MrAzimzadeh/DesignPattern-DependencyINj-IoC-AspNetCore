using Dependency_Injection_AspNetCore.Services;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace Dependency_Injection_AspNetCore
{
    public class Example
    {
        public Example()
        {
            IServiceCollection services = new ServiceCollection(); //biuild in IoC
            
            services.Add(new ServiceDescriptor(typeof(ConsoleLog) , new  ConsoleLog(5)));
            services.Add(new ServiceDescriptor(typeof(TxtLog) , new  TxtLog()));


            ServiceProvider provider = services.BuildServiceProvider(); // saglayici 
            provider.GetService<ConsoleLog>();
            provider.GetService<TxtLog>();

        }
    }
}
