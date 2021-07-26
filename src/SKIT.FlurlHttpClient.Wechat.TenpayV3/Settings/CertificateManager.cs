using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings
{
    /// <summary>
    /// 微信商户平台证书管理器接口。
    /// </summary>
    public abstract class CertificateManager
    {
        /// <summary>
        /// 根据证书序列号获取证书（cer 格式）。
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <returns></returns>
        public abstract string? GetCertificate(string serialNumber);

        /// <summary>
        /// 设置证书序列号与证书（cer 格式）的映射关系。
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <param name="certificate"></param>
        public abstract void SetCertificate(string serialNumber, string certificate);
    }

    /// <summary>
    /// 一个基于内存实现的 <see cref="CertificateManager"/>。
    /// </summary>
    public class InMemoryCertificateManager : CertificateManager
    {
        public IDictionary<string, string> _dict;

        public InMemoryCertificateManager()
        {
            _dict = new ConcurrentDictionary<string, string>();
        }

        public override string? GetCertificate(string serialNumber)
        {
            if (serialNumber == null) throw new ArgumentNullException(nameof(serialNumber));

            return _dict[serialNumber];
        }

        public override void SetCertificate(string serialNumber, string certificate)
        {
            if (serialNumber == null) throw new ArgumentNullException(nameof(serialNumber));
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));

            _dict[serialNumber] = certificate;
        }
    }
}
