using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings
{
    /// <summary>
    /// 微信商户平台证书管理器接口。
    /// </summary>
    public interface ICertificateManager
    {
        /// <summary>
        /// 根据证书序列号获取证书（cer 格式）。
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <returns></returns>
        string? GetCertificate(string serialNumber);

        /// <summary>
        /// 设置证书序列号与证书（cer 格式）的映射关系。
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <param name="certificate"></param>
        void SetCertificate(string serialNumber, string certificate);
    }
}
