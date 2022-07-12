using System.Diagnostics;

namespace Handson_ASP_Core.Models
{
    public interface ILog
    {
        void info(string message);
    }
    public class MyConsole : ILog
    {
        public void info(string str)
        {
            Debug.WriteLine(str);
        }
    }
}
