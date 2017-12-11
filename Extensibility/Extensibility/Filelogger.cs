using System;
using System.IO;

namespace Extensibility
{
    public class Filelogger : ILogger
    {
        private readonly string _path;

        public Filelogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
            using (var streamWriter = new StreamWriter(_path, true)) ;
            {
                Log(message, "ERROR");
            }
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ":" + message);
            }
        }
    }
}
