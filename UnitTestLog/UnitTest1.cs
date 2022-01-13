using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Log;


namespace UnitTestLog
{
    [TestClass]
    public class UnitTest1
    {
        Log Logger = new Log();
        string Iso8601Framt = "yyyy-MM-dd";
        [TestMethod]
        public void TestMethod1()
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
