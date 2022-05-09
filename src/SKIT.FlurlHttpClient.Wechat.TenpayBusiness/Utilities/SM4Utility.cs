using System;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Utilities
{
    /// <summary>
    /// SM4 算法工具类。
    /// </summary>
    public static class SM4Utility
    {
        // REF: https://github.com/bcgit/bc-csharp/blob/master/crypto/src/security/CipherUtilities.cs
        private const string SM4_ALG_NAME = "SM4";
        private const string SM4_CIPHER_ALGORITHM_CBC = "SM4/CBC";
        private const string SM4_CIPHER_PADDING_PKCS7PADDING = "PKCS7PADDING";

        /// <summary>
        /// 基于 CBC 模式解密数据。
        /// </summary>
        /// <param name="keyBytes">密钥字节数据。</param>
        /// <param name="ivBytes">偏移量字节数据。</param>
        /// <param name="cipherBytes">待解密的数据字节数据。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="SM4_CIPHER_PADDING_PKCS7PADDING"/>）</param>
        /// <returns>解密后的数据字节数组。</returns>
        public static byte[] DecryptWithCBC(byte[] keyBytes, byte[] ivBytes, byte[] cipherBytes, string paddingMode = SM4_CIPHER_PADDING_PKCS7PADDING)
        {
            if (keyBytes == null) throw new ArgumentNullException(nameof(keyBytes));
            if (cipherBytes == null) throw new ArgumentNullException(nameof(cipherBytes));

            KeyParameter sm4KeyParams = ParameterUtilities.CreateKeyParameter(SM4_ALG_NAME, keyBytes);
            ParametersWithIV sm4keyParamsWithIv = new ParametersWithIV(sm4KeyParams, ivBytes);
            return DecryptWithCBC(sm4keyParamsWithIv, cipherBytes, paddingMode);
        }

        /// <summary>
        /// 基于 CBC 模式解密数据。
        /// </summary>
        /// <param name="key">经 Base64 编码的密钥。</param>
        /// <param name="iv">>经 Base64 编码的偏移量。</param>
        /// <param name="cipherText">经 Base64 编码的待解密数据。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="SM4_CIPHER_PADDING_PKCS7PADDING"/>）</param>
        /// <returns>解密后的文本数据。</returns>
        public static string DecryptWithCBC(string key, string iv, string cipherText, string paddingMode = SM4_CIPHER_PADDING_PKCS7PADDING)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));
            if (cipherText == null) throw new ArgumentNullException(nameof(cipherText));

            byte[] keyBytes = Convert.FromBase64String(key);
            byte[] ivBytes = Convert.FromBase64String(iv);
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            byte[] plainBytes = DecryptWithCBC(keyBytes, ivBytes, cipherBytes, paddingMode);
            return Encoding.UTF8.GetString(plainBytes);
        }

        /// <summary>
        /// 基于 CBC 模式加密数据。
        /// </summary>
        /// <param name="keyBytes">密钥字节数组。</param>
        /// <param name="ivBytes">偏移量字节数据。</param>
        /// <param name="plainBytes">待加密的数据字节数据。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="SM4_CIPHER_PADDING_PKCS7PADDING"/>）</param>
        /// <returns>加密后的数据字节数组。</returns>
        public static byte[] EncryptWithCBC(byte[] keyBytes, byte[] ivBytes, byte[] plainBytes, string paddingMode = SM4_CIPHER_PADDING_PKCS7PADDING)
        {
            if (keyBytes == null) throw new ArgumentNullException(nameof(keyBytes));
            if (plainBytes == null) throw new ArgumentNullException(nameof(plainBytes));

            KeyParameter sm4KeyParams = ParameterUtilities.CreateKeyParameter(SM4_ALG_NAME, keyBytes);
            ParametersWithIV sm4keyParamsWithIv = new ParametersWithIV(sm4KeyParams, ivBytes);
            return EncryptWithCBC(sm4keyParamsWithIv, plainBytes, paddingMode);
        }

        /// <summary>
        /// 基于 CBC 模式加密数据。
        /// </summary>
        /// <param name="key">经 Base64 编码的密钥。</param>
        /// <param name="iv">>经 Base64 编码的偏移量。</param>
        /// <param name="plainText">待加密的文本数据。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="SM4_CIPHER_PADDING_PKCS7PADDING"/>）</param>
        /// <returns>经 Base64 编码的加密数据。</returns>
        public static string EncryptWithCBC(string key, string iv, string plainText, string paddingMode = SM4_CIPHER_PADDING_PKCS7PADDING)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));
            if (plainText == null) throw new ArgumentNullException(nameof(plainText));

            byte[] keyBytes = Convert.FromBase64String(key);
            byte[] ivBytes = Convert.FromBase64String(iv);
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] cipherBytes = EncryptWithCBC(keyBytes, ivBytes, plainBytes, paddingMode);
            return Convert.ToBase64String(cipherBytes);
        }

        private static byte[] EncryptWithCBC(ICipherParameters sm4KeyParams, byte[] plainBytes, string paddingMode)
        {
            IBufferedCipher cipher = CipherUtilities.GetCipher($"{SM4_CIPHER_ALGORITHM_CBC}/{paddingMode}");
            cipher.Init(true, sm4KeyParams);
            return cipher.DoFinal(plainBytes);
        }

        private static byte[] DecryptWithCBC(ICipherParameters sm4KeyParams, byte[] cipherBytes, string paddingMode)
        {
            IBufferedCipher cipher = CipherUtilities.GetCipher($"{SM4_CIPHER_ALGORITHM_CBC}/{paddingMode}");
            cipher.Init(false, sm4KeyParams);
            return cipher.DoFinal(cipherBytes);
        }
    }
}
