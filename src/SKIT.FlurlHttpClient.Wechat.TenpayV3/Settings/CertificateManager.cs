using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings
{
    /// <summary>
    /// 微信商户平台证书管理器接口。
    /// </summary>
    public abstract class CertificateManager
    {
        /// <summary>
        /// 获取存储的全部证书。
        /// </summary>
        /// <returns></returns>
        public abstract IEnumerable<CertificateEntry> AllEntries();

        /// <summary>
        /// 添加一个证书实体。
        /// </summary>
        /// <param name="entry"></param>
        public abstract void AddEntry(CertificateEntry entry);

        /// <summary>
        /// 根据证书序列号获取证书实体。
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <returns></returns>
        public abstract CertificateEntry? GetEntry(string serialNumber);

        /// <summary>
        /// 移除指定的证书实体。
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <returns></returns>
        public abstract bool RemoveEntry(string serialNumber);
    }

    /// <summary>
    /// 一个基于内存实现的 <see cref="CertificateManager"/>。
    /// </summary>
    public class InMemoryCertificateManager : CertificateManager
    {
        private readonly ConcurrentDictionary<string, CertificateEntry> _dict;

        public InMemoryCertificateManager()
        {
            _dict = new ConcurrentDictionary<string, CertificateEntry>(StringComparer.OrdinalIgnoreCase);
        }

        public override IEnumerable<CertificateEntry> AllEntries()
        {
            return _dict.Values.Where(e => e.IsAvailable()).ToArray();
        }

        public override void AddEntry(CertificateEntry entry)
        {
            _dict.TryRemove(entry.SerialNumber, out _);
            _dict.TryAdd(entry.SerialNumber, entry);
        }

        public override CertificateEntry? GetEntry(string serialNumber)
        {
            if (_dict.TryGetValue(serialNumber, out var entry))
            {
                if (entry.IsAvailable())
                    return entry;

                _dict.TryRemove(serialNumber, out _);
            }

            return null;
        }

        public override bool RemoveEntry(string serialNumber)
        {
            return _dict.TryRemove(serialNumber, out _);
        }
    }
}
