using System.Diagnostics;

namespace Day2_ASP_Core.Models
{
    public interface ILog
    {
        void info(string str);
    }

    public class MyConsoleLogger : ILog
    {
        public void info(string str)
        {
            Debug.WriteLine(str);
        }
    }
}
