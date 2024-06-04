using System;
using System.Security.Cryptography;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Utilities
{
    using SKIT.FlurlHttpClient.Primitives;

    /// <summary>
    /// AES 算法工具类。
    /// </summary>
    public static class AESUtility
    {
        /// <summary>
        /// 基于 CBC 模式解密数据。
        /// </summary>
        /// <param name="keyBytes">AES 密钥字节数组。</param>
        /// <param name="ivBytes">初始化向量字节数组。</param>
        /// <param name="cipherBytes">待解密数据字节数组。</param>
        /// <returns>解密后的数据字节数组。</returns>
        public static byte[] DecryptWithCBC(byte[] keyBytes, byte[] ivBytes, byte[] cipherBytes)
        {
            if (keyBytes is null) throw new ArgumentNullException(nameof(keyBytes));
            if (ivBytes is null) throw new ArgumentNullException(nameof(ivBytes));
            if (cipherBytes is null) throw new ArgumentNullException(nameof(cipherBytes));

            using (SymmetricAlgorithm aes = Aes.Create())
            {
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = keyBytes;
                aes.IV = ivBytes;

                using ICryptoTransform transform = aes.CreateDecryptor();
                return transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
            }
        }

        /// <summary>
        /// 基于 CBC 模式解密数据。
        /// </summary>
        /// <param name="encodingKey">经过编码后的（通常为 Base64）AES 密钥。</param>
        /// <param name="encodingIV">经过编码后的（通常为 Base64）初始化向量。</param>
        /// <param name="encodingCipher">经过编码后的（通常为 Base64）待解密数据。</param>
        /// <returns>解密后的数据。</returns>
        public static EncodedString DecryptWithCBC(EncodedString encodingKey, EncodedString encodingIV, EncodedString encodingCipher)
        {
            if (encodingKey.Value is null) throw new ArgumentNullException(nameof(encodingKey));
            if (encodingIV.Value is null) throw new ArgumentNullException(nameof(encodingIV));
            if (encodingCipher.Value is null) throw new ArgumentNullException(nameof(encodingCipher));

            byte[] plainBytes = DecryptWithCBC(
                keyBytes: EncodedString.FromString(encodingKey, fallbackEncodingKind: EncodingKinds.Base64),
                ivBytes: EncodedString.FromString(encodingIV, fallbackEncodingKind: EncodingKinds.Base64),
                cipherBytes: EncodedString.FromString(encodingCipher, fallbackEncodingKind: EncodingKinds.Base64)
            );
            return EncodedString.ToLiteralString(plainBytes);
        }

        /// <summary>
        /// 基于 CBC 模式加密数据。
        /// </summary>
        /// <param name="keyBytes">AES 密钥字节数组。</param>
        /// <param name="ivBytes">初始化向量字节数组。</param>
        /// <param name="plainBytes">待加密数据字节数组。</param>
        /// <returns>加密后的数据字节数组。</returns>
        public static byte[] EncryptWithCBC(byte[] keyBytes, byte[] ivBytes, byte[] plainBytes)
        {
            if (keyBytes is null) throw new ArgumentNullException(nameof(keyBytes));
            if (ivBytes is null) throw new ArgumentNullException(nameof(ivBytes));
            if (plainBytes is null) throw new ArgumentNullException(nameof(plainBytes));

            using (SymmetricAlgorithm aes = Aes.Create())
            {
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = keyBytes;
                aes.IV = ivBytes;

                using ICryptoTransform transform = aes.CreateEncryptor();
                return transform.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
            }
        }

        /// <summary>
        /// 基于 CBC 模式加密数据。
        /// </summary>
        /// <param name="encodingKey">经过编码后的（通常为 Base64）AES 密钥。</param>
        /// <param name="encodingIV">经过编码后的（通常为 Base64）初始化向量。</param>
        /// <param name="plainData">待加密数据。</param>
        /// <returns>经过 Base64 编码的加密后的数据。</returns>
        public static EncodedString EncryptWithCBC(EncodedString encodingKey, EncodedString encodingIV, string plainData)
        {
            if (encodingKey.Value is null) throw new ArgumentNullException(nameof(encodingKey));
            if (encodingIV.Value is null) throw new ArgumentNullException(nameof(encodingIV));
            if (plainData is null) throw new ArgumentNullException(nameof(plainData));

            byte[] plainBytes = EncryptWithCBC(
                keyBytes: EncodedString.FromString(encodingKey, fallbackEncodingKind: EncodingKinds.Base64),
                ivBytes: EncodedString.FromString(encodingIV, fallbackEncodingKind: EncodingKinds.Base64),
                plainBytes: EncodedString.FromLiteralString(plainData)
            );
            return EncodedString.ToBase64String(plainBytes);
        }
    }
}
