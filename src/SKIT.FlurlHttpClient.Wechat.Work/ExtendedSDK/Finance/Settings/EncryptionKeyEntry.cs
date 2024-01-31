using System;

namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.Finance.Settings
{
    /// <summary>
    /// 表示一个企业微信会话内容存档的消息加解密密钥实体。
    /// </summary>
    public struct EncryptionKeyEntry : IEquatable<EncryptionKeyEntry>
    {
        /// <summary>
        /// 获取版本号。
        /// </summary>
        public int Version { get; }

        /// <summary>
        /// 获取私钥内容（PKCS#1 PEM 格式，即 -----BEGIN RSA PRIVATE KEY----- ... -----END RSA PRIVATE KEY-----）
        /// </summary>
        public string PrivateKey { get; }

        [Newtonsoft.Json.JsonConstructor]
        [System.Text.Json.Serialization.JsonConstructor]
        public EncryptionKeyEntry(int version, string privateKey)
        {
            if (version <= 0)
                throw new ArgumentException("The value of `version` can not be less than zero.", nameof(version));
            if (string.IsNullOrEmpty(privateKey))
                throw new ArgumentException("The value of `privateKey` can not be empty.", nameof(privateKey));
            if (!privateKey.Trim().StartsWith("-----BEGIN RSA PRIVATE KEY-----") || !privateKey.Trim().EndsWith("-----END RSA PRIVATE KEY-----"))
                throw new ArgumentException("The value of `privateKey` is an invalid private key file content.", nameof(privateKey));

            Version = version;
            PrivateKey = privateKey;
        }

        public bool Equals(EncryptionKeyEntry other)
        {
            return int.Equals(Version, other.Version) &&
                   string.Equals(PrivateKey, other.PrivateKey);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (GetType() != obj.GetType())
                return false;

            return Equals((EncryptionKeyEntry)obj);
        }

        public override int GetHashCode()
        {
#if NETFRAMEWORK || NETSTANDARD2_0
            return (Version.GetHashCode(), PrivateKey?.GetHashCode()).GetHashCode();
#else
            return HashCode.Combine(Version.GetHashCode(), PrivateKey?.GetHashCode());
#endif
        }

        public static bool operator ==(EncryptionKeyEntry left, EncryptionKeyEntry right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(EncryptionKeyEntry left, EncryptionKeyEntry right)
        {
            return !left.Equals(right);
        }
    }
}
