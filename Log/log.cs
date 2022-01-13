using NLog;

namespace Log
{
    public class log:Ilog
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public void write(string Content, LevelEnum level)
        {
            switch (level)
            {
                case LevelEnum.Debug:
                    logger.Debug($"偵錯(1):{Content}");
                    break;
                case LevelEnum.Trace:
                    logger.Debug($"追蹤(2):{Content}");
                    break;
                case LevelEnum.Info:
                    logger.Debug($"資訊(3):{Content}");
                    break;
                case LevelEnum.Notice:
                    logger.Debug($"通知(4):{Content}");
                    break;
                case LevelEnum.Warn:
                    logger.Debug($"警示(5):{Content}");
                    break;
                case LevelEnum.Error:
                    logger.Debug($"錯誤(6):{Content}");
                    break;
                case LevelEnum.Fatal:
                    logger.Debug($"嚴重(7):{Content}");
                    break;
                default:
                    break;
            }
        }

    }
}
