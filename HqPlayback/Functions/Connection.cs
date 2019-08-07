using LDsdkDefineEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LDBizTagDefine;

namespace HqPlayback.Functions
{
    /// <summary>
    /// 中间件连接管理
    /// </summary>
    public class Connection
    {
        /// <summary>
        /// 配置文件
        /// </summary>
        private readonly static string ConfigFileName = @"SendConfig.ini";
        /// <summary>
        /// 文件适配器
        /// </summary>
        private static CConfigIAdapter ConfigAdapter = new CConfigIAdapter();

        static Connection()
        {
            ConfigAdapter.Load(ConfigFileName);
            ConfigAdapter.Init();
        }

        /// <summary>
        /// 创建一个连接
        /// </summary>
        /// <returns></returns>
        public static CConnectionIAdapter CreateConnect(string ConName)
        {
            CConnectionIAdapter ConnectionAdapter = new CConnectionIAdapter(ConName);
            long IntUUID = GenerateIntID();
            ConnectionAdapter.Create(IntUUID.ToString() + ConName);
            ConnectionAdapter.Connect(10000);
            return ConnectionAdapter;
        }
       
        //生成UUID
        private static long GenerateIntID()
        {
            byte[] buffer = Guid.NewGuid().ToByteArray();
            return BitConverter.ToInt64(buffer, 0);
        }
    }
}
