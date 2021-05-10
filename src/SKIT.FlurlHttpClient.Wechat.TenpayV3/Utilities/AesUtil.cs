using System;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Utilities
{
    /// <summary>
    /// AES 算法工具类。
    /// </summary>
    public static class AesUtil
    {
        private const int AES_TAG_LENGH_BIT = 128;
        private const string AES_GCM_CIPHER_ALG = "AES/GCM/NoPadding";

        /// <summary>
        /// 基于 GCM 模式解密数据。
        /// </summary>
        /// <param name="aesKeyBytes">AES 密钥字节数组。</param>
        /// <param name="associatedDataBytes">附加数据包字节数组。</param>
        /// <param name="nonceBytes">加密使用的随机串初始化向量字节数组。</param>
        /// <param name="cipherBytes">待解密数据字节数组。</param>
        /// <returns>解密后的数据字节数组。</returns>
        public static byte[] DecryptWithGCM(byte[] aesKeyBytes, byte[] nonceBytes, byte[] associatedDataBytes, byte[] cipherBytes)
        {
            if (aesKeyBytes == null) throw new ArgumentNullException(nameof(aesKeyBytes));
            if (nonceBytes == null) throw new ArgumentNullException(nameof(nonceBytes));
            if (associatedDataBytes == null) throw new ArgumentNullException(nameof(associatedDataBytes));
            if (cipherBytes == null) throw new ArgumentNullException(nameof(cipherBytes));

            IBufferedCipher cipher = CipherUtilities.GetCipher(AES_GCM_CIPHER_ALG);
            ICipherParameters aeadParams = new AeadParameters(
                new KeyParameter(aesKeyBytes),
                AES_TAG_LENGH_BIT,
                nonceBytes,
                associatedDataBytes
            );
            cipher.Init(false, aeadParams);
            byte[] plainBytes = new byte[cipher.GetOutputSize(cipherBytes.Length)];
            int len = cipher.ProcessBytes(cipherBytes, 0, cipherBytes.Length, plainBytes, 0);
            cipher.DoFinal(plainBytes, len);
            return plainBytes;
        }

        /// <summary>
        /// 基于 GCM 模式解密数据。
        /// </summary>
        /// <param name="aesKey">AES 密钥。</param>
        /// <param name="nonce">加密使用的随机串初始化向量。</param>
        /// <param name="associatedData">附加数据包。</param>
        /// <param name="cipherText">经 Base64 编码后的待解密数据。</param>
        /// <returns>解密后的文本数据。</returns>
        public static string DecryptWithGCM(string aesKey, string nonce, string? associatedData, string cipherText)
        {
            if (aesKey == null) throw new ArgumentNullException(nameof(aesKey));
            if (nonce == null) throw new ArgumentNullException(nameof(nonce));
            if (cipherText == null) throw new ArgumentNullException(nameof(cipherText));

            byte[] plainBytes = DecryptWithGCM(
                aesKeyBytes: Encoding.UTF8.GetBytes(aesKey),
                nonceBytes: Encoding.UTF8.GetBytes(nonce),
                associatedDataBytes: Encoding.UTF8.GetBytes(associatedData ?? string.Empty),
                cipherBytes: Convert.FromBase64String(cipherText)
            );
            return Encoding.UTF8.GetString(plainBytes);
        }
    }
}
