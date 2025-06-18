using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.Finance.Settings
{
    /// <summary>
    /// 企业微信会话内容存档的消息加解密密钥管理器接口。
    /// </summary>
    public interface IEncryptionKeyManager
    {
        /// <summary>
        /// 添加一个消息加解密密钥实体。
        /// </summary>
        /// <param name="entry"></param>
        void AddEntry(EncryptionKeyEntry entry);

        /// <summary>
        /// 根据版本号获取消息加解密密钥实体。
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        EncryptionKeyEntry? GetEntry(int version);

        /// <summary>
        /// 根据版本号移除消息加解密密钥实体。
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        bool RemoveEntry(int version);
    }

    /// <summary>
    /// 企业微信会话内容存档的消息加解密密钥管理器接口。
    /// </summary>
    public interface IEncryptionKeyManagerAsync : IEncryptionKeyManager
    {
        /// <summary>
        /// 异步添加一个消息加解密密钥实体。
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="cancellationToken"></param>
        Task AddEntryAsync(EncryptionKeyEntry entry, CancellationToken cancellationToken = default);

        /// <summary>
        /// 异步根据版本号获取消息加解密密钥实体。
        /// </summary>
        /// <param name="version"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<EncryptionKeyEntry?> GetEntryAsync(int version, CancellationToken cancellationToken = default);

        /// <summary>
        /// 异步根据版本号移除消息加解密密钥实体。
        /// </summary>
        /// <param name="version"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<bool> RemoveEntryAsync(int version, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// 一个基于内存实现的 <see cref="IEncryptionKeyManager"/>。
    /// </summary>
    public sealed class InMemoryEncryptionKeyManager : IEncryptionKeyManager
    {
        private readonly ConcurrentDictionary<int, EncryptionKeyEntry> _dict;

        public InMemoryEncryptionKeyManager()
        {
            _dict = new ConcurrentDictionary<int, EncryptionKeyEntry>();
        }

        public void AddEntry(EncryptionKeyEntry entry)
        {
            _dict.AddOrUpdate(entry.Version, (_) => entry, (_, _) => entry);
        }

        public EncryptionKeyEntry? GetEntry(int version)
        {
            if (_dict.TryGetValue(version, out EncryptionKeyEntry entry))
            {
                return entry;
            }

            return null;
        }

        public bool RemoveEntry(int version)
        {
            return _dict.TryRemove(version, out _);
        }
    }
}
