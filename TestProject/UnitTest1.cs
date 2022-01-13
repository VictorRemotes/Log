using System;
using System.IO;
using Log;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        log Logger = new log();
        string Iso8601Foramt = "yyyy-MM-dd";
        [TestMethod]
        public void LogDebugTest()
        {
            Logger.write("測試偵錯", LevelEnum.Debug);
            Assert.IsTrue(File.Exists($"" +
                            $"C:\\temp\\log\\{DateTime.Now.ToString(Iso8601Foramt)}\\debug.log"));
        }

        [TestMethod]
        public void LogFatalTest()
        {
            Logger.write("測試嚴重錯誤", LevelEnum.Fatal);
            Assert.IsTrue(File.Exists($"" +
                          $"C:\\temp\\log\\{DateTime.Now.ToString(Iso8601Foramt)}\\fatal.log"));

        }
    }
}