using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingApp
{
	public class FileLogWriter : ILogWriter
	{
		private readonly string _filePath;

		public FileLogWriter(string filePath)
		{
			_filePath = filePath;
		}

		public void WriteLog(string message)
		{
			File.AppendAllText(_filePath, message + System.Environment.NewLine);
		}
	}
}
