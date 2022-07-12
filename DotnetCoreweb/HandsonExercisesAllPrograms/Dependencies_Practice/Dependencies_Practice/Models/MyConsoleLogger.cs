using System.Diagnostics;

namespace Dependencies_Practice.Models
{
    public class MyConsoleLogger :ILog
    {
        public void info(string str)
        {
            Debug.WriteLine(str);
        }
    }
}
