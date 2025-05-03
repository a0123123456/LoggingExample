using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingApp
{
	public class Logger
	{
		private readonly ILogWriter _writer;

		public Logger(ILogWriter writer)
		{
			_writer = writer;
		}

		public void Log(string message)
		{
			_writer.WriteLog($"[LOG] {message}");
		}
	}
}
