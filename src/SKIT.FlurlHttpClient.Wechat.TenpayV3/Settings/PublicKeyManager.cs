using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings
{
    /// <summary>
    /// 微信商户平台公钥管理器接口。
    /// </summary>
    public interface IPublicKeyManager
    {
        /// <summary>
        /// 获取存储的全部公钥实体。
        /// </summary>
        /// <returns></returns>
        IEnumerable<PublicKeyEntry> AllEntries();

        /// <summary>
        /// 添加一个公钥实体。
        /// </summary>
        /// <param name="entry"></param>
        void AddEntry(PublicKeyEntry entry);

        /// <summary>
        /// 根据公钥 ID 获取公钥实体。
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <returns></returns>
        PublicKeyEntry? GetEntry(string serialNumber);

        /// <summary>
        /// 根据公钥 ID 移除公钥实体。
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <returns></returns>
        bool RemoveEntry(string serialNumber);
    }

    /// <summary>
    /// 微信商户平台公钥管理器异步接口。
    /// </summary>
    public interface IPublicKeyManagerAsync : IPublicKeyManager
    {
        /// <summary>
        /// 异步获取存储的全部公钥实体。
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IEnumerable<PublicKeyEntry>> AllEntriesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// 异步添加一个公钥实体。
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task AddEntryAsync(PublicKeyEntry entry, CancellationToken cancellationToken = default);

        /// <summary>
        /// 异步根据公钥 ID 获取公钥实体。
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<PublicKeyEntry?> GetEntryAsync(string serialNumber, CancellationToken cancellationToken = default);

        /// <summary>
        /// 异步根据公钥 ID 移除公钥实体。
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<bool> RemoveEntryAsync(string serialNumber, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// 一个基于内存实现的 <see cref="IPublicKeyManager"/>。
    /// </summary>
    public sealed class InMemoryPublicKeyManager : IPublicKeyManager
    {
        private readonly ConcurrentDictionary<string, PublicKeyEntry> _dict;

        public InMemoryPublicKeyManager()
        {
            _dict = new ConcurrentDictionary<string, PublicKeyEntry>(StringComparer.OrdinalIgnoreCase);
        }

        /// <inheritdoc/>
        public IEnumerable<PublicKeyEntry> AllEntries()
        {
            return _dict.Values.ToArray();
        }

        /// <inheritdoc/>
        public void AddEntry(PublicKeyEntry entry)
        {
            _dict.AddOrUpdate(entry.SerialNumber, (_) => entry, (_, _) => entry);
        }

        /// <inheritdoc/>
        public PublicKeyEntry? GetEntry(string serialNumber)
        {
            if (_dict.TryGetValue(serialNumber, out PublicKeyEntry entry))
            {
                return entry;
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
