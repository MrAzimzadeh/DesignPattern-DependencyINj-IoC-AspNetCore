using Dependency_Injection_AspNetCore.Services.Interface;

namespace Dependency_Injection_AspNetCore.Services
{
    public class TxtLog : ILog
    {
        public TxtLog()
        {

        }

        public void Log()
        {
            Console.WriteLine("Txt  Log ");
        }
    }
}
