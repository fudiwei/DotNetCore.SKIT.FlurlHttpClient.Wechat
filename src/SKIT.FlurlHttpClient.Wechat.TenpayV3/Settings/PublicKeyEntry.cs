using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings
{
    /// <summary>
    /// 表示一个微信商户平台公钥实体。
    /// </summary>
    public partial struct PublicKeyEntry : IEquatable<PublicKeyEntry>
    {
        /// <summary>
        /// 公钥算法类型：RSA。
        /// </summary>
        public const string ALGORITHM_TYPE_RSA = CertificateEntry.ALGORITHM_TYPE_RSA;

        /// <summary>
        /// 公钥算法类型：SM2。
        /// </summary>
        public const string ALGORITHM_TYPE_SM2 = CertificateEntry.ALGORITHM_TYPE_SM2;

        /// <summary>
        /// 获取公钥算法类型。
        /// 取值范围：RSA、SM2。
        /// </summary>
        public string AlgorithmType { get; }

        /// <summary>
        /// 获取公钥序列号。
        /// </summary>
        public string SerialNumber { get; }

        /// <summary>
        /// 获取公钥内容（CRT/CER PEM 格式，即 -----BEGIN PUBLIC KEY----- ... -----END PUBLIC KEY-----）
        /// </summary>
        public string PublicKey { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="algorithmType"></param>
        /// <param name="serialNumber"></param>
        /// <param name="publicKey"></param>
        [Newtonsoft.Json.JsonConstructor]
        [System.Text.Json.Serialization.JsonConstructor]
        public PublicKeyEntry(string algorithmType, string serialNumber, string publicKey)
        {
            publicKey = publicKey?.Trim()!;

            if (string.IsNullOrEmpty(algorithmType))
                throw new ArgumentException("The value of `algorithmType` can not be empty.", nameof(algorithmType));
            if (string.IsNullOrEmpty(publicKey))
                throw new ArgumentException("The value of `publicKey` can not be empty.", nameof(publicKey));
            if (string.IsNullOrEmpty(serialNumber))
                throw new ArgumentException("The value of `serialNumber` can not be empty.", nameof(serialNumber));
            if (!ALGORITHM_TYPE_RSA.Equals(algorithmType) && !ALGORITHM_TYPE_SM2.Equals(algorithmType))
                throw new ArgumentException("The value of `algorithmType` an invalid value.", nameof(algorithmType));
            if (!(publicKey.StartsWith("-----BEGIN PUBLIC KEY-----") && publicKey.EndsWith("-----END PUBLIC KEY-----")))
                throw new ArgumentException("The value of `publicKey` is an invalid public key file content.", nameof(publicKey));

            AlgorithmType = algorithmType;
            SerialNumber = serialNumber.ToUpper();
            PublicKey = publicKey;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(PublicKeyEntry other)
        {
            return string.Equals(AlgorithmType, other.AlgorithmType) &&
                   string.Equals(PublicKey, other.PublicKey) &&
                   string.Equals(SerialNumber, other.SerialNumber);
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (GetType() != obj.GetType())
                return false;

            return Equals((PublicKeyEntry)obj);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
#if NETCOREAPP || NET5_0_OR_GREATER
            return HashCode.Combine(AlgorithmType?.GetHashCode(), PublicKey?.GetHashCode(), SerialNumber?.GetHashCode());
#else
            return (AlgorithmType?.GetHashCode(), PublicKey?.GetHashCode(), SerialNumber?.GetHashCode()).GetHashCode();
#endif
        }

        /// <inheritdoc/>
        public static bool operator ==(PublicKeyEntry left, PublicKeyEntry right)
        {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static bool operator !=(PublicKeyEntry left, PublicKeyEntry right)
        {
            return !left.Equals(right);
        }
    }
}
