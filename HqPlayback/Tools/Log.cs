using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HqPlayback.Tools
{
    /// <summary>
    /// 操作日志
    /// </summary>
    public class Log
    {
        static object LockFlag = new object();
        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="Message">日志信息</param>
        internal static void WriteLog(string Message)
        {
            string Path = Environment.CurrentDirectory;
            lock (LockFlag)
            {
                using (FileStream Stream = new FileStream($@"{Path}\MyLog\{DateTime.Now.ToLongDateString()}.txt", FileMode.Append))
                {
                    using (StreamWriter Writer = new StreamWriter(Stream))
                    {
                        Writer.WriteLineAsync(Message);
                    }
                }
            }
        }
    }
}
