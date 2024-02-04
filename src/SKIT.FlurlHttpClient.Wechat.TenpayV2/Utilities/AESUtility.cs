using System;
using System.Security.Cryptography;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities
{
    using SKIT.FlurlHttpClient.Primitives;

    /// <summary>
    /// AES 算法工具类。
    /// </summary>
    public static class AESUtility
    {
        /// <summary>
        /// 基于 ECB 模式解密数据。
        /// </summary>
        /// <param name="keyBytes">AES 密钥字节数组。</param>
        /// <param name="cipherBytes">待解密数据字节数组。</param>
        /// <returns>解密后的数据字节数组。</returns>
        public static byte[] DecryptWithECB(byte[] keyBytes, byte[] cipherBytes)
        {
            if (keyBytes is null) throw new ArgumentNullException(nameof(keyBytes));
            if (cipherBytes is null) throw new ArgumentNullException(nameof(cipherBytes));

            using SymmetricAlgorithm aes = Aes.Create();
            aes.Mode = CipherMode.ECB;
            aes.Padding = PaddingMode.PKCS7;
            aes.Key = keyBytes;

            using ICryptoTransform transform = aes.CreateDecryptor();
            return transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
        }

        /// <summary>
        /// 基于 ECB 模式解密数据。
        /// </summary>
        /// <param name="encodingKey">经过编码后的（通常为 Base64）AES 密钥。</param>
        /// <param name="encodingCipher">经过编码后的（通常为 Base64）待解密数据。</param>
        /// <returns>解密后的数据。</returns>
        public static EncodedString DecryptWithECB(EncodedString encodingKey, EncodedString encodingCipher)
        {
            if (encodingKey.Value is null) throw new ArgumentNullException(nameof(encodingKey));
            if (encodingCipher.Value is null) throw new ArgumentNullException(nameof(encodingCipher));

            byte[] plainBytes = DecryptWithECB(
                keyBytes: EncodedString.FromString(encodingKey, fallbackEncodingKind: EncodingKinds.Base64),
                cipherBytes: EncodedString.FromString(encodingCipher, fallbackEncodingKind: EncodingKinds.Base64)
            );
            return EncodedString.ToLiteralString(plainBytes);
        }
    }
}
