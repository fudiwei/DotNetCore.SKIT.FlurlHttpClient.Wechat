using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings
{
    /// <summary>
    /// 微信商户平台证书管理器接口。
    /// </summary>
    public interface ICertificateManager
    {
        /// <summary>
        /// 获取存储的全部证书实体。
        /// </summary>
        /// <returns></returns>
        IEnumerable<CertificateEntry> AllEntries();

        /// <summary>
        /// 添加一个证书实体。
        /// </summary>
        /// <param name="entry"></param>
        void AddEntry(CertificateEntry entry);

        /// <summary>
        /// 根据证书序列号获取证书实体。
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <returns></returns>
        CertificateEntry? GetEntry(string serialNumber);

        /// <summary>
        /// 根据证书序列号移除证书实体。
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <returns></returns>
        bool RemoveEntry(string serialNumber);
    }

    /// <summary>
    /// 微信商户平台证书管理器异步接口。
    /// </summary>
    public interface ICertificateManagerAsync : ICertificateManager
    {
        /// <summary>
        /// 异步获取存储的全部证书实体。
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IEnumerable<CertificateEntry>> AllEntriesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// 异步添加一个证书实体。
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task AddEntryAsync(CertificateEntry entry, CancellationToken cancellationToken = default);

        /// <summary>
        /// 异步根据证书序列号获取证书实体。
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<CertificateEntry?> GetEntryAsync(string serialNumber, CancellationToken cancellationToken = default);

        /// <summary>
        /// 异步根据证书序列号移除证书实体。
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<bool> RemoveEntryAsync(string serialNumber, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// 一个基于内存实现的 <see cref="CertificateManager"/>。
    /// </summary>
    public sealed class InMemoryCertificateManager : ICertificateManager
    {
        private readonly ConcurrentDictionary<string, CertificateEntry> _dict;

        public InMemoryCertificateManager()
        {
            _dict = new ConcurrentDictionary<string, CertificateEntry>(StringComparer.OrdinalIgnoreCase);
        }

        /// <inheritdoc/>
        public IEnumerable<CertificateEntry> AllEntries()
        {
            return _dict.Values.Where(static e => e.IsAvailable()).ToArray();
        }

        /// <inheritdoc/>
        public void AddEntry(CertificateEntry entry)
        {
            _dict.AddOrUpdate(entry.SerialNumber, (_) => entry, (_, _) => entry);
        }

        /// <inheritdoc/>
        public CertificateEntry? GetEntry(string serialNumber)
        {
            if (_dict.TryGetValue(serialNumber, out CertificateEntry entry))
            {
                if (entry.IsAvailable())
                    return entry;

                _dict.TryRemove(serialNumber, out _);
            }

            return null;
        }

        /// <inheritdoc/>
        public bool RemoveEntry(string serialNumber)
        {
            return _dict.TryRemove(serialNumber, out _);
        }
    }
}
