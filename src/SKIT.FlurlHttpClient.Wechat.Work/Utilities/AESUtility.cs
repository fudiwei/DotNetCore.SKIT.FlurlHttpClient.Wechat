using System;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace SKIT.FlurlHttpClient.Wechat.Work.Utilities
{
    /// <summary>
    /// AES 算法工具类。
    /// </summary>
    public static class AESUtility
    {
        private const string AES_CIPHER_ALGORITHM_GCM = "AES/GCM";
        private const string AES_CIPHER_PADDING_NOPADDING = "NoPadding";

        /// <summary>
        /// 基于 GCM 模式解密数据。
        /// </summary>
        /// <param name="keyBytes">AES 密钥字节数组。</param>
        /// <param name="nonceBytes">加密使用的初始化向量字节数组。</param>
        /// <param name="aadBytes">加密使用的附加数据包字节数组。</param>
        /// <param name="cipherBytes">待解密数据字节数组。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="AES_CIPHER_PADDING_NOPADDING"/>）</param>
        /// <returns>解密后的数据字节数组。</returns>
        public static byte[] DecryptWithGCM(byte[] keyBytes, byte[] nonceBytes, byte[]? aadBytes, byte[] cipherBytes, string paddingMode = AES_CIPHER_PADDING_NOPADDING)
        {
            const int KEY_LENGTH_BYTE = 32;
            const int NONCE_LENGTH_BYTE = 12;
            const int TAG_LENGTH_BYTE = 16;

            if (keyBytes == null) throw new ArgumentNullException(nameof(keyBytes));
            if (keyBytes.Length != KEY_LENGTH_BYTE) throw new ArgumentException($"Invalid key byte length (expected: {KEY_LENGTH_BYTE}, actual: {keyBytes.Length}).", nameof(keyBytes));
            if (nonceBytes == null) throw new ArgumentNullException(nameof(nonceBytes));
            if (nonceBytes.Length != NONCE_LENGTH_BYTE) throw new ArgumentException($"Invalid nonce byte length (expected: {NONCE_LENGTH_BYTE}, actual: {nonceBytes.Length}).", nameof(nonceBytes));
            if (cipherBytes == null) throw new ArgumentNullException(nameof(cipherBytes));
            if (cipherBytes.Length < TAG_LENGTH_BYTE) throw new ArgumentException($"Invalid cipher byte length (expected: more than {TAG_LENGTH_BYTE}, actual: {cipherBytes.Length}).", nameof(cipherBytes));

            IBufferedCipher cipher = CipherUtilities.GetCipher(string.Format("{0}/{1}", AES_CIPHER_ALGORITHM_GCM, paddingMode));
            ICipherParameters cipherParams = new AeadParameters(
                new KeyParameter(keyBytes),
                TAG_LENGTH_BYTE * 8,
                nonceBytes,
                aadBytes
            );
            cipher.Init(false, cipherParams);
            byte[] plainBytes = new byte[cipher.GetOutputSize(cipherBytes.Length)];
            int len = cipher.ProcessBytes(cipherBytes, 0, cipherBytes.Length, plainBytes, 0);
            cipher.DoFinal(plainBytes, len);
            return plainBytes;
        }

        /// <summary>
        /// 基于 GCM 模式解密数据。
        /// </summary>
        /// <param name="key">AES 密钥。</param>
        /// <param name="nonce">加密使用的初始化向量。</param>
        /// <param name="aad">加密使用的附加数据包。</param>
        /// <param name="cipherText">经 Base64 编码后的待解密数据。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="AES_CIPHER_PADDING_NOPADDING"/>）</param>
        /// <returns>解密后的文本数据。</returns>
        public static string DecryptWithGCM(string key, string nonce, string? aad, string cipherText, string paddingMode = AES_CIPHER_PADDING_NOPADDING)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));
            if (nonce == null) throw new ArgumentNullException(nameof(nonce));
            if (cipherText == null) throw new ArgumentNullException(nameof(cipherText));

            byte[] plainBytes = DecryptWithGCM(
                keyBytes: Encoding.UTF8.GetBytes(key),
                nonceBytes: Encoding.UTF8.GetBytes(nonce),
                aadBytes: aad != null ? Encoding.UTF8.GetBytes(aad) : null,
                cipherBytes: Convert.FromBase64String(cipherText),
                paddingMode: paddingMode
            );
            return Encoding.UTF8.GetString(plainBytes);
        }
    }
}
