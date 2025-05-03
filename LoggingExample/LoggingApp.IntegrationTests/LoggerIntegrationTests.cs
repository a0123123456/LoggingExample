using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingApp;

namespace LoggingApp.IntegrationTests
{
	[TestClass]
	public class LoggerIntegrationTests
	{
		[TestMethod]
		public void Log_WritesToFileWithPrefix()
		{
			// Arrange：準備一個臨時檔案當作日誌檔
			var tempFile = Path.GetTempFileName();
			var fileWriter = new FileLogWriter(tempFile);
			var logger = new Logger(fileWriter);
			Console.WriteLine($"暫存路徑為: {tempFile}");

			// Act：寫一筆整合測試訊息
			logger.Log("整合測試");

			// Assert：讀回檔案內容，確定它包含正確的前綴
			var content = File.ReadAllText(tempFile);
			var expected = "[LOG] 整合測試" + System.Environment.NewLine;

			Assert.AreEqual(
				expected,
				content,
				"內容跟預期不同"
			);

			// Cleanup：測試結束後刪掉暫存檔
			File.Delete(tempFile);
		}
	}
}
