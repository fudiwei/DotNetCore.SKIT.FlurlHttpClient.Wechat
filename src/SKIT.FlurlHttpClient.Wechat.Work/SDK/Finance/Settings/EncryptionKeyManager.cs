using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance.Settings
{
    /// <summary>
    /// 企业微信会话内容存档的消息加解密密钥管理器接口。
    /// </summary>
    public abstract class EncryptionKeyManager
    {
        /// <summary>
        /// 获取存储的全部消息加解密密钥实体。
        /// </summary>
        /// <returns></returns>
        public abstract IEnumerable<EncryptionKeyEntry> AllEntries();

        /// <summary>
        /// 添加一个消息加解密密钥实体。
        /// </summary>
        /// <param name="entry"></param>
        public abstract void AddEntry(EncryptionKeyEntry entry);

        /// <summary>
        /// 根据版本号获取消息加解密密钥实体。
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        public abstract EncryptionKeyEntry? GetEntry(int version);

        /// <summary>
        /// 根据版本号移除消息加解密密钥实体。
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        public abstract bool RemoveEntry(int version);
    }

    /// <summary>
    /// 一个基于内存实现的 <see cref="EncryptionKeyManager"/>。
    /// </summary>
    public class InMemoryEncryptionKeyManager : EncryptionKeyManager
    {
        private readonly ConcurrentDictionary<int, EncryptionKeyEntry> _dict;

        public InMemoryEncryptionKeyManager()
        {
            _dict = new ConcurrentDictionary<int, EncryptionKeyEntry>();
        }

        public override IEnumerable<EncryptionKeyEntry> AllEntries()
        {
            return _dict.Values.ToArray();
        }

        public override void AddEntry(EncryptionKeyEntry entry)
        {
            _dict.TryRemove(entry.Version, out _);
            _dict.TryAdd(entry.Version, entry);
        }

        public override EncryptionKeyEntry? GetEntry(int version)
        {
            if (_dict.TryGetValue(version, out var entry))
            {
                return entry;
            }

            return null;
        }

        public override bool RemoveEntry(int version)
        {
            return _dict.TryRemove(version, out _);
        }
    }
}
