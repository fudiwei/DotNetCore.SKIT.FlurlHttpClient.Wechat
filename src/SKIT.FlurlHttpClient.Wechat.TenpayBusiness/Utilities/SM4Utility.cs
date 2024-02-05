using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Utilities
{
    using SKIT.FlurlHttpClient.Primitives;

    /// <summary>
    /// SM4 算法工具类。
    /// </summary>
    public static class SM4Utility
    {
        /// <summary>
        /// 填充模式：PKCS7Padding。
        /// </summary>
        public const string PADDING_MODE_PKCS7 = "PKCS7PADDING";

        private static byte[] DecryptWithCBC(ICipherParameters sm4KeyParams, byte[] cipherBytes, string paddingMode)
        {
            IBufferedCipher cipher = CipherUtilities.GetCipher($"SM4/CBC/{paddingMode}");
            cipher.Init(false, sm4KeyParams);
            return cipher.DoFinal(cipherBytes);
        }

        private static byte[] EncryptWithCBC(ICipherParameters sm4KeyParams, byte[] plainBytes, string paddingMode)
        {
            IBufferedCipher cipher = CipherUtilities.GetCipher($"SM4/CBC/{paddingMode}");
            cipher.Init(true, sm4KeyParams);
            return cipher.DoFinal(plainBytes);
        }

        /// <summary>
        /// 基于 CBC 模式解密数据。
        /// </summary>
        /// <param name="keyBytes">密钥字节数组。</param>
        /// <param name="ivBytes">偏移量字节数组。</param>
        /// <param name="cipherBytes">待解密的数据字节数组。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="PADDING_MODE_PKCS7"/>）</param>
        /// <returns>解密后的数据字节数组。</returns>
        public static byte[] DecryptWithCBC(byte[] keyBytes, byte[] ivBytes, byte[] cipherBytes, string paddingMode = PADDING_MODE_PKCS7)
        {
            if (keyBytes is null) throw new ArgumentNullException(nameof(keyBytes));
            if (ivBytes is null) throw new ArgumentNullException(nameof(keyBytes));
            if (cipherBytes is null) throw new ArgumentNullException(nameof(cipherBytes));

            KeyParameter sm4KeyParams = ParameterUtilities.CreateKeyParameter("SM4", keyBytes);
            ParametersWithIV sm4keyParamsWithIv = new ParametersWithIV(sm4KeyParams, ivBytes);
            return DecryptWithCBC(sm4keyParamsWithIv, cipherBytes, paddingMode);
        }

        /// <summary>
        /// 基于 CBC 模式解密数据。
        /// </summary>
        /// <param name="encodingKey">经过编码后的（通常为 Base64）密钥。</param>
        /// <param name="encodingIV">>经过编码后的（通常为 Base64）偏移量。</param>
        /// <param name="encodingCipher">经过编码后的（通常为 Base64）待解密数据。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="PADDING_MODE_PKCS7"/>）</param>
        /// <returns>解密后的数据。</returns>
        public static EncodedString DecryptWithCBC(EncodedString encodingKey, EncodedString encodingIV, EncodedString encodingCipher, string paddingMode = PADDING_MODE_PKCS7)
        {
            if (encodingKey.Value is null) throw new ArgumentNullException(nameof(encodingKey));
            if (encodingIV.Value is null) throw new ArgumentNullException(nameof(encodingKey));
            if (encodingCipher.Value is null) throw new ArgumentNullException(nameof(encodingCipher));

            byte[] keyBytes = EncodedString.FromString(encodingKey, fallbackEncodingKind: EncodingKinds.Base64);
            byte[] ivBytes = EncodedString.FromString(encodingIV, fallbackEncodingKind: EncodingKinds.Base64);
            byte[] cipherBytes = EncodedString.FromString(encodingCipher, fallbackEncodingKind: EncodingKinds.Base64);
            byte[] plainBytes = DecryptWithCBC(keyBytes, ivBytes, cipherBytes, paddingMode);
            return EncodedString.ToLiteralString(plainBytes);
        }

        /// <summary>
        /// 基于 CBC 模式加密数据。
        /// </summary>
        /// <param name="keyBytes">密钥字节数组。</param>
        /// <param name="ivBytes">偏移量字节数组。</param>
        /// <param name="plainBytes">待加密的数据字节数组。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="PADDING_MODE_PKCS7"/>）</param>
        /// <returns>加密后的数据字节数组。</returns>
        public static byte[] EncryptWithCBC(byte[] keyBytes, byte[] ivBytes, byte[] plainBytes, string paddingMode = PADDING_MODE_PKCS7)
        {
            if (keyBytes is null) throw new ArgumentNullException(nameof(keyBytes));
            if (ivBytes is null) throw new ArgumentNullException(nameof(keyBytes));
            if (plainBytes is null) throw new ArgumentNullException(nameof(plainBytes));

            KeyParameter sm4KeyParams = ParameterUtilities.CreateKeyParameter("SM4", keyBytes);
            ParametersWithIV sm4keyParamsWithIv = new ParametersWithIV(sm4KeyParams, ivBytes);
            return EncryptWithCBC(sm4keyParamsWithIv, plainBytes, paddingMode);
        }

        /// <summary>
        /// 基于 CBC 模式加密数据。
        /// </summary>
        /// <param name="encodingKey">经过编码后的（通常为 Base64）密钥。</param>
        /// <param name="encodingIV">>经过编码后的（通常为 Base64）偏移量。</param>
        /// <param name="plainData">待加密数据。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="PADDING_MODE_PKCS7"/>）</param>
        /// <returns>经过 Base64 编码的加密数据。</returns>
        public static EncodedString EncryptWithCBC(EncodedString encodingKey, EncodedString encodingIV, string plainData, string paddingMode = PADDING_MODE_PKCS7)
        {
            if (encodingKey.Value is null) throw new ArgumentNullException(nameof(encodingKey));
            if (encodingIV.Value is null) throw new ArgumentNullException(nameof(encodingKey));
            if (plainData is null) throw new ArgumentNullException(nameof(plainData));

            byte[] keyBytes = EncodedString.FromString(encodingKey, fallbackEncodingKind: EncodingKinds.Base64);
            byte[] ivBytes = EncodedString.FromString(encodingIV, fallbackEncodingKind: EncodingKinds.Base64);
            byte[] plainBytes = EncodedString.FromLiteralString(plainData);
            byte[] cipherBytes = EncryptWithCBC(keyBytes, ivBytes, plainBytes, paddingMode);
            return EncodedString.ToBase64String(cipherBytes);
        }
    }
}
