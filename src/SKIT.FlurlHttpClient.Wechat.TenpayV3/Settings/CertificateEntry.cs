using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings
{
    /// <summary>
    /// 表示一个微信商户平台证书实体。
    /// </summary>
    public partial struct CertificateEntry : IEquatable<CertificateEntry>
    {
        /// <summary>
        /// 证书算法类型：RSA。
        /// </summary>
        public const string ALGORITHM_TYPE_RSA = "RSA";

        /// <summary>
        /// 证书算法类型：SM2。
        /// </summary>
        public const string ALGORITHM_TYPE_SM2 = "SM2";

        /// <summary>
        /// 获取证书算法类型。
        /// 取值范围：RSA、SM2。
        /// </summary>
        public string AlgorithmType { get; }

        /// <summary>
        /// 获取证书内容（CRT/CER PEM 格式，即 -----BEGIN CERTIFICATE----- ... -----END CERTIFICATE-----）
        /// </summary>
        public string Certificate { get; }

        /// <summary>
        /// 获取证书序列号。
        /// </summary>
        public string SerialNumber { get; }

        /// <summary>
        /// 获取生效时间。
        /// </summary>
        public DateTimeOffset EffectiveTime { get; }

        /// <summary>
        /// 获取过期时间。
        /// </summary>
        public DateTimeOffset ExpireTime { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="algorithmType"></param>
        /// <param name="serialNumber"></param>
        /// <param name="certificate"></param>
        /// <param name="effectiveTime"></param>
        /// <param name="expireTime"></param>
        [Newtonsoft.Json.JsonConstructor]
        [System.Text.Json.Serialization.JsonConstructor]
        public CertificateEntry(string algorithmType, string serialNumber, string certificate, DateTimeOffset effectiveTime, DateTimeOffset expireTime)
        {
            certificate = certificate?.Trim()!;

            if (string.IsNullOrEmpty(algorithmType))
                throw new ArgumentException("The value of `algorithmType` can not be empty.", nameof(algorithmType));
            if (string.IsNullOrEmpty(certificate))
                throw new ArgumentException("The value of `certificate` can not be empty.", nameof(certificate));
            if (string.IsNullOrEmpty(serialNumber))
                throw new ArgumentException("The value of `serialNumber` can not be empty.", nameof(serialNumber));
            if (!ALGORITHM_TYPE_RSA.Equals(algorithmType) && !ALGORITHM_TYPE_SM2.Equals(algorithmType))
                throw new ArgumentException("The value of `algorithmType` an invalid value.", nameof(algorithmType));
            if (!(certificate.StartsWith("-----BEGIN CERTIFICATE-----") && certificate.EndsWith("-----END CERTIFICATE-----")))
                throw new ArgumentException("The value of `certificate` is an invalid certificate file content. Maybe you forgot to decrypt?", nameof(certificate));

            AlgorithmType = algorithmType;
            SerialNumber = serialNumber.ToUpper();
            Certificate = certificate;
            EffectiveTime = effectiveTime;
            ExpireTime = expireTime;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="algorithmType"></param>
        /// <param name="certificate"></param>
        public CertificateEntry(string algorithmType, string certificate)
        {
            certificate = certificate?.Trim()!;

            if (string.IsNullOrEmpty(algorithmType))
                throw new ArgumentException("The value of `algorithmType` can not be empty.", nameof(algorithmType));
            if (string.IsNullOrEmpty(certificate))
                throw new ArgumentException("The value of `certificate` can not be empty.", nameof(certificate));
            if (!(certificate.StartsWith("-----BEGIN CERTIFICATE-----") && certificate.EndsWith("-----END CERTIFICATE-----")))
                throw new ArgumentException("The value of `certificate` is an invalid certificate file content. Maybe you forgot to decrypt?", nameof(certificate));

            AlgorithmType = algorithmType;
            Certificate = certificate;

            switch (algorithmType)
            {
                case ALGORITHM_TYPE_RSA:
                    {
                        SerialNumber = Utilities.RSAUtility.ExportSerialNumberFromCertificate(certificate).ToUpper();
                        EffectiveTime = Utilities.RSAUtility.ExportValidFromDateFromCertificate(certificate);
                        ExpireTime = Utilities.RSAUtility.ExportValidToDateFromCertificate(certificate);
                    }
                    break;

                case ALGORITHM_TYPE_SM2:
                    {
                        SerialNumber = Utilities.SM2Utility.ExportSerialNumberFromCertificate(certificate).ToUpper();
                        EffectiveTime = Utilities.SM2Utility.ExportValidFromDateFromCertificate(certificate);
                        ExpireTime = Utilities.SM2Utility.ExportValidToDateFromCertificate(certificate);
                    }
                    break;

                default:
                    {
                        throw new ArgumentException("The value of `algorithmType` an invalid value.", nameof(algorithmType));
                    }
            }
        }

        /// <summary>
        /// 返回一个布尔值，该值指示当前证书是否可用。
        /// </summary>
        /// <returns></returns>
        public bool IsAvailable()
        {
            DateTimeOffset now = DateTimeOffset.Now;
            return EffectiveTime <= now && now < ExpireTime;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(CertificateEntry other)
        {
            return string.Equals(AlgorithmType, other.AlgorithmType) &&
                   string.Equals(Certificate, other.Certificate) &&
                   string.Equals(SerialNumber, other.SerialNumber);
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (GetType() != obj.GetType())
                return false;

            return Equals((CertificateEntry)obj);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
#if NETCOREAPP || NET5_0_OR_GREATER
            return HashCode.Combine(AlgorithmType?.GetHashCode(), Certificate?.GetHashCode(), SerialNumber?.GetHashCode());
#else
            return (AlgorithmType?.GetHashCode(), Certificate?.GetHashCode(), SerialNumber?.GetHashCode()).GetHashCode();
#endif
        }

        /// <inheritdoc/>
        public static bool operator ==(CertificateEntry left, CertificateEntry right)
        {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static bool operator !=(CertificateEntry left, CertificateEntry right)
        {
            return !left.Equals(right);
        }
    }

    partial struct CertificateEntry
    {
        /// <summary>
        /// 将指定的 <see cref="Models.QueryCertificatesResponse.Types.Certificate"/> 对象解析为 <see cref="CertificateEntry"/> 对象。
        /// </summary>
        /// <param name="algorithmType"></param>
        /// <param name="certificate"></param>
        /// <returns></returns>
        public static CertificateEntry Parse(string algorithmType, Models.QueryCertificatesResponse.Types.Certificate certificate)
        {
            return new CertificateEntry(algorithmType, certificate.SerialNumber, certificate.EncryptCertificate.CipherText, certificate.EffectiveTime, certificate.ExpireTime);
        }

        /// <summary>
        /// 将指定的 <see cref="Models.QueryCertificatesResponse.Types.Certificate"/> 对象解析为 <see cref="CertificateEntry"/> 对象。
        /// </summary>
        /// <param name="certificate"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static CertificateEntry Parse(Models.QueryCertificatesResponse.Types.Certificate certificate)
        {
            string? algorithmType = default!;

            if (algorithmType is null)
            {
                try
                {
                    Utilities.RSAUtility.ExportPublicKeyFromCertificate(certificate.EncryptCertificate.CipherText);
                    algorithmType = ALGORITHM_TYPE_RSA;
                }
                catch { }
            }

            if (algorithmType is null)
            {
                try
                {
                    Utilities.SM2Utility.ExportPublicKeyFromCertificate(certificate.EncryptCertificate.CipherText);
                    algorithmType = ALGORITHM_TYPE_SM2;
                }
                catch { }
            }

            if (algorithmType is null)
            {
                throw new ArgumentException("Unrecognized certificate algorithm type. Please make sure you have decrypted the certificate content first.");
            }

            return Parse(algorithmType, certificate);
        }
    }
}
