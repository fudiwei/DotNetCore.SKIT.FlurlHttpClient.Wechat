using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings
{
    /// <summary>
    /// 表示一个微信商户平台证书实体。
    /// </summary>
    public struct CertificateEntry : IEquatable<CertificateEntry>
    {
        public const string ALGORITHM_TYPE_RSA = "RSA";
        public const string ALGORITHM_TYPE_SM2 = "SM2";

        /// <summary>
        /// 获取证书算法类型。
        /// 取值范围：RSA、SM2。
        /// </summary>
        public string AlgorithmType { get; }

        /// <summary>
        /// 获取证书内容（CRT/CER 格式，即 -----BEGIN CERTIFICATE----- ... -----END CERTIFICATE）
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

        [Newtonsoft.Json.JsonConstructor]
        [System.Text.Json.Serialization.JsonConstructor]
        public CertificateEntry(string algorithmType, string serialNumber, string certificate, DateTimeOffset effectiveTime, DateTimeOffset expireTime)
        {
            if (string.IsNullOrEmpty(algorithmType))
                throw new ArgumentException("The value of `algorithmType` can not be empty.", nameof(algorithmType));
            if (string.IsNullOrEmpty(certificate))
                throw new ArgumentException("The value of `certificate` can not be empty.", nameof(certificate));
            if (string.IsNullOrEmpty(serialNumber))
                throw new ArgumentException("The value of `serialNumber` can not be empty.", nameof(serialNumber));
            if (!ALGORITHM_TYPE_RSA.Equals(algorithmType) && !ALGORITHM_TYPE_SM2.Equals(algorithmType))
                throw new ArgumentException("The value of `algorithmType` an invalid value.", nameof(algorithmType));
            if (!certificate.Trim().StartsWith("-----BEGIN CERTIFICATE-----") || !certificate.Trim().EndsWith("-----END CERTIFICATE-----"))
                throw new ArgumentException("The value of `certificate` is an invalid certificate file content.", nameof(certificate));

            AlgorithmType = algorithmType;
            SerialNumber = serialNumber.ToUpper();
            Certificate = certificate;
            EffectiveTime = effectiveTime;
            ExpireTime = expireTime;
        }

        public CertificateEntry(string algorithmType, string certificate)
        {
            if (string.IsNullOrEmpty(algorithmType))
                throw new ArgumentException("The value of `algorithmType` can not be empty.", nameof(algorithmType));
            if (string.IsNullOrEmpty(certificate))
                throw new ArgumentException("The value of `certificate` can not be empty.", nameof(certificate));
            if (!certificate.Trim().StartsWith("-----BEGIN CERTIFICATE-----") || !certificate.Trim().EndsWith("-----END CERTIFICATE-----"))
                throw new ArgumentException("The value of `certificate` is an invalid certificate file content.", nameof(certificate));

            AlgorithmType = algorithmType;
            Certificate = certificate;

            switch (algorithmType)
            {
                case ALGORITHM_TYPE_RSA:
                    {
                        SerialNumber = Utilities.RSAUtility.ExportSerialNumberFromCertificate(certificate).ToUpper();
                        EffectiveTime = Utilities.RSAUtility.ExportEffectiveTimeFromCertificate(certificate);
                        ExpireTime = Utilities.RSAUtility.ExportExpireTimeFromCertificate(certificate);
                    }
                    break;

                case ALGORITHM_TYPE_SM2:
                    {
                        SerialNumber = Utilities.SM2Utility.ExportSerialNumberFromCertificate(certificate).ToUpper();
                        EffectiveTime = Utilities.SM2Utility.ExportEffectiveTimeFromCertificate(certificate);
                        ExpireTime = Utilities.SM2Utility.ExportExpireTimeFromCertificate(certificate);
                    }
                    break;

                default:
                    {
                        throw new ArgumentException("The value of `algorithmType` an invalid value.", nameof(algorithmType));
                    }
            }
        }

        public CertificateEntry(string algorithmType, Models.QueryCertificatesResponse.Types.Certificate certificate)
            : this(algorithmType, certificate.SerialNumber, certificate.EncryptCertificate.CipherText, certificate.EffectiveTime, certificate.ExpireTime)
        {
        }

        public CertificateEntry(Models.QueryCertificatesResponse.Types.Certificate certificate)
        {
            AlgorithmType = default!;
            Certificate = certificate.EncryptCertificate.CipherText;
            SerialNumber = certificate.SerialNumber.ToUpper();
            EffectiveTime = certificate.EffectiveTime;
            ExpireTime = certificate.ExpireTime;

            if (AlgorithmType == null)
            {
                try
                {
                    Utilities.RSAUtility.ExportPublicKeyFromCertificate(Certificate);
                    AlgorithmType = ALGORITHM_TYPE_RSA;
                }
                catch { }
            }

            if (AlgorithmType == null)
            {
                try
                {
                    Utilities.SM2Utility.ExportPublicKeyFromCertificate(Certificate);
                    AlgorithmType = ALGORITHM_TYPE_SM2;
                }
                catch { }
            }

            if (AlgorithmType == null)
            {
                throw new ArgumentException("Unrecognized certificate algorithm type, please make sure you have decrypted the certificate content first.");
            }
        }

        public bool IsAvailable()
        {
            DateTimeOffset now = DateTimeOffset.Now;
            return EffectiveTime <= now && now < ExpireTime;
        }

        public bool Equals(CertificateEntry other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return string.Equals(AlgorithmType, other.AlgorithmType) &&
                   string.Equals(Certificate, other.Certificate) &&
                   string.Equals(SerialNumber, other.SerialNumber);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (GetType() != obj.GetType())
                return false;

            return Equals((CertificateEntry)obj);
        }

        public override int GetHashCode()
        {
#if NETFRAMEWORK || NETSTANDARD2_0
            return (AlgorithmType?.GetHashCode(), Certificate?.GetHashCode(), SerialNumber?.GetHashCode()).GetHashCode();
#else
            return HashCode.Combine(AlgorithmType?.GetHashCode(), Certificate?.GetHashCode(), SerialNumber?.GetHashCode());
#endif
        }

        public static bool operator ==(CertificateEntry left, CertificateEntry right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(CertificateEntry left, CertificateEntry right)
        {
            return !left.Equals(right);
        }
    }
}
