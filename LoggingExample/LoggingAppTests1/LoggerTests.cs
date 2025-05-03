using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoggingApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace LoggingApp.Tests
{
	[TestClass()]
	public class LoggerTests
	{
		[TestMethod()]
		public void Log_有輸入訊息_會呼叫WriteLog並帶前綴()
		{
			// Arrange：建立Mock<ILogWriter>
			var mockWriter = new Mock<ILogWriter>();

			// 用mock去建Logger
			var logger = new Logger(mockWriter.Object);

			// Act：呼叫Log
			logger.Log("單元測試");

			// Assert：確認WriteLog被呼叫一次，且前面加上"[LOG]"
			mockWriter.Verify(
				w => w.WriteLog("[LOG] 單元測試"),
				Times.Once(),
				"Logger.Log 應該只呼叫一次 WriteLog，且訊息要加上前綴"
			);
		}
	}
}