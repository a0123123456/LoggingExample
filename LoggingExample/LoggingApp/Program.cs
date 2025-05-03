namespace LoggingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
			// 指定要寫入的檔案路徑
			var logFile = "app.log";
			var fileWriter = new FileLogWriter(logFile);

			// 把writer傳給Logger
			var logger = new Logger(fileWriter);

			// 呼叫Logger.Log來記錄日誌
			logger.Log("應用程式啟動");
			logger.Log("執行某項操作");

			Console.WriteLine("日誌已寫入：" + logFile);
		}
    }
}
