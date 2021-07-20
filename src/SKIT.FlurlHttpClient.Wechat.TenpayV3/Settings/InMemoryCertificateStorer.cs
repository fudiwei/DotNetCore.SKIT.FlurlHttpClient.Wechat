using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings
{
    /// <summary>
    /// 一个基于内存实现的 <see cref="ICertificateStorer"/>。
    /// </summary>
    public class InMemoryCertificateStorer : ICertificateStorer
    {
        public IDictionary<string, string> _dict;

        public InMemoryCertificateStorer()
        {
            _dict = new ConcurrentDictionary<string, string>();
        }

        string? ICertificateStorer.Get(string serialNumber)
        {
            if (serialNumber == null) throw new ArgumentNullException(nameof(serialNumber));

            return _dict[serialNumber];
        }

        void ICertificateStorer.Set(string serialNumber, string certificate)
        {
            if (serialNumber == null) throw new ArgumentNullException(nameof(serialNumber));
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));

            _dict[serialNumber] = certificate;
        }
    }
}
