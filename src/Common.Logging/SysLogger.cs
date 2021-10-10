using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Logging
{
    public class SysLogger : ILoggerProvider
    {
        private string _host;
        private int _port;
        private readonly Func<string, LogLevel, bool> _filter;

        public SysLogger(string host, int port, Func<string, LogLevel, bool> filter)
        {
            _host = host;
            _port = port;
            _filter = filter;
        }

        public ILogger CreateLogger(string categoryName)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
