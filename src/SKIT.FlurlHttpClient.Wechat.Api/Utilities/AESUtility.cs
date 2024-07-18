using System;
using System.Security.Cryptography;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace SKIT.FlurlHttpClient.Wechat.Api.Utilities
{
    using SKIT.FlurlHttpClient.Primitives;

    /// <summary>
    /// AES 算法工具类。
    /// </summary>
    public static class AESUtility
    {
        /// <summary>
        /// 填充模式：NoPadding。
        /// </summary>
        public const string PADDING_MODE_NOPADDING = "NoPadding";

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
        /// 基于 GCM 模式解密数据。
        /// </summary>
        /// <param name="keyBytes">AES 密钥字节数组。</param>
        /// <param name="nonceBytes">初始化向量字节数组。</param>
        /// <param name="associatedDataBytes">附加数据字节数组。</param>
        /// <param name="cipherBytes">待解密数据字节数组。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="PADDING_MODE_NOPADDING"/>）</param>
        /// <returns>解密后的数据字节数组。</returns>
        public static byte[] DecryptWithGCM(byte[] keyBytes, byte[] nonceBytes, byte[]? associatedDataBytes, byte[] cipherBytes, string paddingMode = PADDING_MODE_NOPADDING)
        {
            const int KEY_LENGTH_BYTE = 32;
            const int NONCE_LENGTH_BYTE = 12;
            const int TAG_LENGTH_BYTE = 16;

            if (keyBytes is null) throw new ArgumentNullException(nameof(keyBytes));
            if (keyBytes.Length != KEY_LENGTH_BYTE) throw new ArgumentException($"Invalid key byte length (expected: {KEY_LENGTH_BYTE}, actual: {keyBytes.Length}).", nameof(keyBytes));
            if (nonceBytes is null) throw new ArgumentNullException(nameof(nonceBytes));
            if (nonceBytes.Length != NONCE_LENGTH_BYTE) throw new ArgumentException($"Invalid nonce byte length (expected: {NONCE_LENGTH_BYTE}, actual: {nonceBytes.Length}).", nameof(nonceBytes));
            if (cipherBytes is null) throw new ArgumentNullException(nameof(cipherBytes));
            if (cipherBytes.Length < TAG_LENGTH_BYTE) throw new ArgumentException($"Invalid cipher byte length (expected: more than {TAG_LENGTH_BYTE}, actual: {cipherBytes.Length}).", nameof(cipherBytes));

#if NET5_0_OR_GREATER
            if (AesGcm.IsSupported)
            {
                if (!string.Equals(paddingMode, PADDING_MODE_NOPADDING, StringComparison.OrdinalIgnoreCase))
                    throw new NotSupportedException();

#if NET8_0_OR_GREATER
                using (AesGcm aes = new AesGcm(keyBytes, TAG_LENGTH_BYTE))
#else
                using (AesGcm aes = new AesGcm(keyBytes))
#endif
                {
                    byte[] cipherWithoutTagBytes = new byte[cipherBytes.Length - TAG_LENGTH_BYTE];
                    byte[] tagBytes = new byte[TAG_LENGTH_BYTE];
                    Buffer.BlockCopy(cipherBytes, 0, cipherWithoutTagBytes, 0, cipherWithoutTagBytes.Length);
                    Buffer.BlockCopy(cipherBytes, cipherWithoutTagBytes.Length, tagBytes, 0, tagBytes.Length);

                    byte[] plainBytes = new byte[cipherWithoutTagBytes.Length];
                    aes.Decrypt(nonceBytes, cipherWithoutTagBytes, tagBytes, plainBytes, associatedDataBytes);
                    return plainBytes;
                }
            }
#endif
            {
                IBufferedCipher cipher = CipherUtilities.GetCipher($"AES/GCM/{paddingMode}");
                ICipherParameters cipherParams = new AeadParameters(
                    new KeyParameter(keyBytes),
                    TAG_LENGTH_BYTE * 8,
                    nonceBytes,
                    associatedDataBytes
                );
                cipher.Init(false, cipherParams);
                byte[] plainBytes = new byte[cipher.GetOutputSize(cipherBytes.Length)];
                int len = cipher.ProcessBytes(cipherBytes, 0, cipherBytes.Length, plainBytes, 0);
                cipher.DoFinal(plainBytes, len);
                return plainBytes;
            }
        }

        /// <summary>
        /// 基于 GCM 模式解密数据。
        /// </summary>
        /// <param name="encodingKey">经过编码后的（通常为 Base64）AES 密钥。</param>
        /// <param name="encodingNonce">经过编码后的（通常为 Base64）初始化向量。</param>
        /// <param name="encodingAssociatedData">经过编码后的（通常为 Base64）附加数据。</param>
        /// <param name="encodingCipher">经过编码后的（通常为 Base64）待解密数据。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="PADDING_MODE_NOPADDING"/>）</param>
        /// <returns>解密后的数据。</returns>
        public static EncodedString DecryptWithGCM(EncodedString encodingKey, EncodedString encodingNonce, EncodedString encodingAssociatedData, EncodedString encodingCipher, string paddingMode = PADDING_MODE_NOPADDING)
        {
            if (encodingKey.Value is null) throw new ArgumentNullException(nameof(encodingKey));
            if (encodingNonce.Value is null) throw new ArgumentNullException(nameof(encodingNonce));
            if (encodingCipher.Value is null) throw new ArgumentNullException(nameof(encodingCipher));

            byte[] plainBytes = DecryptWithGCM(
                keyBytes: EncodedString.FromString(encodingKey, fallbackEncodingKind: EncodingKinds.Base64),
                nonceBytes: EncodedString.FromString(encodingNonce, fallbackEncodingKind: EncodingKinds.Base64),
                associatedDataBytes: encodingAssociatedData.Value is not null ? EncodedString.FromString(encodingAssociatedData, fallbackEncodingKind: EncodingKinds.Base64) : null,
                cipherBytes: EncodedString.FromString(encodingCipher, fallbackEncodingKind: EncodingKinds.Base64),
                paddingMode: paddingMode
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

        /// <summary>
        /// 基于 GCM 模式加密数据。
        /// </summary>
        /// <param name="keyBytes">AES 密钥字节数组。</param>
        /// <param name="nonceBytes">初始化向量字节数组。</param>
        /// <param name="associatedDataBytes">附加数据字节数组。</param>
        /// <param name="plainBytes">待加密数据字节数组。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="PADDING_MODE_NOPADDING"/>）</param>
        /// <returns>加密后的数据字节数组。</returns>
        public static byte[] EncryptWithGCM(byte[] keyBytes, byte[] nonceBytes, byte[]? associatedDataBytes, byte[] plainBytes, string paddingMode = PADDING_MODE_NOPADDING)
        {
            const int TAG_LENGTH_BYTE = 16;

            if (keyBytes is null) throw new ArgumentNullException(nameof(keyBytes));
            if (nonceBytes is null) throw new ArgumentNullException(nameof(nonceBytes));
            if (plainBytes is null) throw new ArgumentNullException(nameof(plainBytes));

#if NET5_0_OR_GREATER
            if (AesGcm.IsSupported)
            {
                if (!string.Equals(paddingMode, PADDING_MODE_NOPADDING, StringComparison.OrdinalIgnoreCase))
                    throw new NotSupportedException();

#if NET8_0_OR_GREATER
                using (AesGcm aes = new AesGcm(keyBytes, TAG_LENGTH_BYTE))
#else
                using (AesGcm aes = new AesGcm(keyBytes))
#endif
                {
                    byte[] cipherBytes = new byte[plainBytes.Length];
                    byte[] tagBytes = new byte[TAG_LENGTH_BYTE];
                    aes.Encrypt(nonceBytes, plainBytes, cipherBytes, tagBytes, associatedDataBytes);

                    byte[] cipherWithTagBytes = new byte[cipherBytes.Length + tagBytes.Length];
                    Buffer.BlockCopy(cipherBytes, 0, cipherWithTagBytes, 0, cipherBytes.Length);
                    Buffer.BlockCopy(tagBytes, 0, cipherWithTagBytes, cipherBytes.Length, tagBytes.Length);
                    return cipherWithTagBytes;
                }
            }
#endif
            {
                IBufferedCipher cipher = CipherUtilities.GetCipher($"AES/GCM/{paddingMode}");
                ICipherParameters cipherParams = new AeadParameters(
                    new KeyParameter(keyBytes),
                    TAG_LENGTH_BYTE * 8,
                    nonceBytes,
                    associatedDataBytes
                );
                cipher.Init(true, cipherParams);
                byte[] cipherBytes = new byte[cipher.GetOutputSize(plainBytes.Length)];
                int len = cipher.ProcessBytes(plainBytes, 0, plainBytes.Length, cipherBytes, 0);
                cipher.DoFinal(cipherBytes, len);
                return cipherBytes;
            }
        }

        /// <summary>
        /// 基于 GCM 模式加密数据。
        /// </summary>
        /// <param name="encodingKey">经过编码后的（通常为 Base64）AES 密钥。</param>
        /// <param name="encodingNonce">经过编码后的（通常为 Base64）初始化向量。</param>
        /// <param name="encodingAssociatedData">经过编码后的（通常为 Base64）附加数据。</param>
        /// <param name="plainData">待加密数据。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="PADDING_MODE_NOPADDING"/>）</param>
        /// <returns>经过 Base64 编码的加密后的数据。</returns>
        public static EncodedString EncryptWithGCM(EncodedString encodingKey, EncodedString encodingNonce, EncodedString encodingAssociatedData, string plainData, string paddingMode = PADDING_MODE_NOPADDING)
        {
            if (encodingKey.Value is null) throw new ArgumentNullException(nameof(encodingKey));
            if (encodingNonce.Value is null) throw new ArgumentNullException(nameof(encodingNonce));
            if (plainData is null) throw new ArgumentNullException(nameof(plainData));

            byte[] plainBytes = EncryptWithGCM(
                keyBytes: EncodedString.FromString(encodingKey, fallbackEncodingKind: EncodingKinds.Base64),
                nonceBytes: EncodedString.FromString(encodingNonce, fallbackEncodingKind: EncodingKinds.Base64),
                associatedDataBytes: encodingAssociatedData.Value is not null ? EncodedString.FromString(encodingAssociatedData, fallbackEncodingKind: EncodingKinds.Base64) : null,
                plainBytes: Encoding.UTF8.GetBytes(plainData),
                paddingMode: paddingMode
            );
            return EncodedString.ToBase64String(plainBytes);
        }
    }
}
