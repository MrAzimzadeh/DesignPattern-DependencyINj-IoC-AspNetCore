using Dependency_Injection_AspNetCore.Services.Interface;

namespace Dependency_Injection_AspNetCore.Services
{
    public class ConsoleLog : ILog
    {
        public int _a;
        public ConsoleLog(int a)
        {
            _a = a;
        }


        public void Log()
        {
            Console.WriteLine("Console Log " +  _a); 
        }
    }
}
