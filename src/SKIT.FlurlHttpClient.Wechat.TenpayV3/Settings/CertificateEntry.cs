﻿using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings
{
    /// <summary>
    /// 表示一个微信商户平台证书实体。
    /// </summary>
    public struct CertificateEntry : IEquatable<CertificateEntry>
    {
        /// <summary>
        /// 获取证书序列号。
        /// <para>序列号相同的实体将被视为同一个证书。</para>
        /// </summary>
        public string SerialNumber { get; }

        /// <summary>
        /// 获取证书内容（CRT/CER 格式，即 -----BEGIN CERTIFICATE----- ... -----END CERTIFICATE）
        /// </summary>
        public string Certificate { get; }

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
        public CertificateEntry(string serialNumber, string certificate, DateTimeOffset effectiveTime, DateTimeOffset expireTime)
        {
            if (string.IsNullOrEmpty(serialNumber))
                throw new ArgumentException("The value of `serialNumber` can not be empty.", nameof(serialNumber));
            if (string.IsNullOrEmpty(certificate))
                throw new ArgumentException("The value of `certificate` can not be empty.", nameof(certificate));
            if (!certificate.Trim().StartsWith("-----BEGIN CERTIFICATE-----") || !certificate.Trim().EndsWith("-----END CERTIFICATE-----"))
                throw new ArgumentException("The value of `certificate` is an invalid certificate file content.", nameof(certificate));

            SerialNumber = serialNumber;
            Certificate = certificate;
            EffectiveTime = effectiveTime;
            ExpireTime = expireTime;
        }

        public CertificateEntry(string certificate)
        {
            if (string.IsNullOrEmpty(certificate))
                throw new ArgumentException("The value of `certificate` can not be empty.", nameof(certificate));
            if (!certificate.Trim().StartsWith("-----BEGIN CERTIFICATE-----") || !certificate.Trim().EndsWith("-----END CERTIFICATE-----"))
                throw new ArgumentException("The value of `certificate` is an invalid certificate file content.", nameof(certificate));

            SerialNumber = Utilities.RSAUtility.ExportSerialNumber(certificate);
            Certificate = certificate;
            EffectiveTime = Utilities.RSAUtility.ExportEffectiveTime(certificate);
            ExpireTime = Utilities.RSAUtility.ExportExpireTime(certificate);
        }

        public CertificateEntry(Models.QueryCertificatesResponse.Types.Certificate cert)
            : this(cert.SerialNumber, cert.EncryptCertificate.CipherText, cert.EffectiveTime, cert.ExpireTime)
        {
        }

        public bool IsAvailable()
        {
            DateTimeOffset now = DateTimeOffset.Now;
            return EffectiveTime <= now && now < ExpireTime;
        }

        public bool Equals(CertificateEntry other)
        {
            return string.Equals(SerialNumber, other.SerialNumber);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj))
                return false;

            return (obj is CertificateEntry other) && Equals(other);
        }

        public override int GetHashCode()
        {
            return SerialNumber?.GetHashCode() ?? base.GetHashCode();
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
