using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace SKIT.FlurlHttpClient.Wechat.Api.Utilities
{
    internal static class WxMsgCryptor
    {
        private const int AES_KEY_SIZE = 256;
        private const int AES_BLOCK_SIZE = 128;

        private static char ConvertToChar(int i)
        {
            byte ret = (byte)(i & 0xFF);
            return (char)ret;
        }

        private static byte[] KCS7Encoder(int len)
        {
            if (len <= 0) throw new ArgumentOutOfRangeException(nameof(len));

            const int BLOCK_SIZE = 32;

            int paddingLength = BLOCK_SIZE - (len % BLOCK_SIZE);
            if (paddingLength == 0)
            {
                paddingLength = BLOCK_SIZE;
            }

            char paddingChar = ConvertToChar(paddingLength);
            string tmp = string.Empty;
            for (int index = 0; index < paddingLength; index++)
            {
                tmp += paddingChar;
            }

            return Encoding.UTF8.GetBytes(tmp);
        }

        private static string CreateRandCode(int len)
        {
            if (len <= 0) throw new ArgumentOutOfRangeException(nameof(len));

            Random random = new Random(unchecked((int)DateTime.Now.Ticks));
            string[] source = "2,3,4,5,6,7,a,c,d,e,f,h,i,j,k,m,n,p,r,s,t,A,C,D,E,F,G,H,J,K,M,N,P,Q,R,S,U,V,W,X,Y,Z".Split(',');
            string result = string.Empty;
            for (int i = 0; i < len; i++)
            {
                int randval = random.Next(0, source.Length - 1);
                result += source[randval];
            }

            return result;
        }

        private static byte[] Decode2(byte[] decryptedBytes)
        {
            if (decryptedBytes == null) throw new ArgumentNullException(nameof(decryptedBytes));

            int pad = (int)decryptedBytes[decryptedBytes.Length - 1];
            if (pad < 1 || pad > 32)
            {
                pad = 0;
            }

            byte[] res = new byte[decryptedBytes.Length - pad];
            Array.Copy(decryptedBytes, 0, res, 0, decryptedBytes.Length - pad);
            return res;
        }

        private static byte[] AESDecrypt(byte[] keyBytes, byte[] ivBytes, byte[] cipherBytes)
        {
            if (keyBytes == null) throw new ArgumentNullException(nameof(keyBytes));
            if (ivBytes == null) throw new ArgumentNullException(nameof(ivBytes));
            if (cipherBytes == null) throw new ArgumentNullException(nameof(cipherBytes));

            using var aes = Aes.Create();
            aes.KeySize = AES_KEY_SIZE;
            aes.BlockSize = AES_BLOCK_SIZE;
            aes.Mode = CipherMode.CBC;
            //aes.Padding = PaddingMode.PKCS7;
            aes.Padding = PaddingMode.None;
            aes.Key = keyBytes;
            aes.IV = ivBytes;

            using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
            using (var ms = new MemoryStream())
            using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
            {
                byte[] msgBytes = new byte[cipherBytes.Length + 32 - cipherBytes.Length % 32];
                Array.Copy(cipherBytes, msgBytes, cipherBytes.Length);
                cs.Write(cipherBytes, 0, cipherBytes.Length);

                byte[] plainBytes = Decode2(ms.ToArray());
                return plainBytes;
            }
        }

        private static string AESEncrypt(byte[] keyBytes, byte[] ivBytes, byte[] plainBytes)
        {
            if (keyBytes == null) throw new ArgumentNullException(nameof(keyBytes));
            if (ivBytes == null) throw new ArgumentNullException(nameof(ivBytes));
            if (plainBytes == null) throw new ArgumentNullException(nameof(plainBytes));

            using var aes = Aes.Create();
            aes.KeySize = AES_KEY_SIZE;
            aes.BlockSize = AES_BLOCK_SIZE;
            //aes.Padding = PaddingMode.PKCS7;
            aes.Padding = PaddingMode.None;
            aes.Mode = CipherMode.CBC;
            aes.Key = keyBytes;
            aes.IV = ivBytes;

            byte[] msgBytes = new byte[plainBytes.Length + 32 - plainBytes.Length % 32];
            Array.Copy(plainBytes, msgBytes, plainBytes.Length);
            byte[] padBytes = KCS7Encoder(plainBytes.Length);
            Array.Copy(padBytes, 0, msgBytes, plainBytes.Length, padBytes.Length);

            using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
            using (var ms = new MemoryStream())
            using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
            {
                cs.Write(msgBytes, 0, msgBytes.Length);
                byte[] cipherBytes = ms.ToArray();
                return Convert.ToBase64String(cipherBytes);
            }
        }

        /// <summary>
        /// AES 解密微信回调加密数据。
        /// </summary>
        /// <param name="cipherText">微信推送来的加密文本内容（即 `Encrypt` 字段的值）。</param>
        /// <param name="encodingAESKey">微信后台设置的 EncodingAESKey。</param>
        /// <param name="appId">微信 AppId。</param>
        /// <returns>解密后的文本内容。</returns>
        public static string AESDecrypt(string cipherText, string encodingAESKey, out string appId)
        {
            if (cipherText == null) throw new ArgumentNullException(nameof(cipherText));
            if (encodingAESKey == null) throw new ArgumentNullException(nameof(encodingAESKey));

            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            byte[] keyBytes = Convert.FromBase64String(encodingAESKey + "=");
            byte[] ivBytes = new byte[16];
            Array.Copy(keyBytes, ivBytes, 16);
            byte[] btmpMsg = AESDecrypt(cipherBytes: cipherBytes, ivBytes: ivBytes, keyBytes: keyBytes);

            int len = BitConverter.ToInt32(btmpMsg, 16);
            len = IPAddress.NetworkToHostOrder(len);

            byte[] bMsg = new byte[len];
            byte[] bCorpId = new byte[btmpMsg.Length - 20 - len];
            Array.Copy(btmpMsg, 20, bMsg, 0, len);
            Array.Copy(btmpMsg, 20 + len, bCorpId, 0, btmpMsg.Length - 20 - len);

            appId = Encoding.UTF8.GetString(bCorpId);
            return Encoding.UTF8.GetString(bMsg);
        }

        /// <summary>
        /// AES 加密微信回调敏感数据。
        /// </summary>
        /// <param name="plainText">返回给微信的原始文本内容。</param>
        /// <param name="encodingAESKey">微信后台设置的 EncodingAESKey。</param>
        /// <param name="appId">微信 AppId。</param>
        /// <returns>加密后的文本内容。</returns>
        public static string AESEncrypt(string plainText, string encodingAESKey, string appId)
        {
            if (plainText == null) throw new ArgumentNullException(nameof(plainText));
            if (encodingAESKey == null) throw new ArgumentNullException(nameof(encodingAESKey));
            if (appId == null) throw new ArgumentNullException(nameof(appId));

            byte[] keyBytes = Convert.FromBase64String(encodingAESKey + "=");
            byte[] ivBytes = new byte[16];
            Array.Copy(keyBytes, ivBytes, 16);

            string randCode = CreateRandCode(16);
            byte[] bRand = Encoding.UTF8.GetBytes(randCode);
            byte[] bCorpId = Encoding.UTF8.GetBytes(appId);
            byte[] bMsgTmp = Encoding.UTF8.GetBytes(plainText);
            byte[] bMsgLen = BitConverter.GetBytes(IPAddress.HostToNetworkOrder(bMsgTmp.Length));
            byte[] bMsg = new byte[bRand.Length + bMsgLen.Length + bCorpId.Length + bMsgTmp.Length];

            Array.Copy(bRand, bMsg, bRand.Length);
            Array.Copy(bMsgLen, 0, bMsg, bRand.Length, bMsgLen.Length);
            Array.Copy(bMsgTmp, 0, bMsg, bRand.Length + bMsgLen.Length, bMsgTmp.Length);
            Array.Copy(bCorpId, 0, bMsg, bRand.Length + bMsgLen.Length + bMsgTmp.Length, bCorpId.Length);

            return AESEncrypt(keyBytes: keyBytes, ivBytes: ivBytes, plainBytes: bMsg);
        }

        /// <summary>
        /// 验证微信回调签名。
        /// </summary>
        /// <param name="sToken">微信后台设置的 Token。</param>
        /// <param name="sTimestamp">微信推送来的时间戳字符串。</param>
        /// <param name="sNonce">微信推送来的随机字符串。</param>
        /// <param name="sMsgEncrypt">微信推送来的加密文本内容（即 `Encrypt` 字段的值）。</param>
        /// <param name="sMsgSign">待验证的签名。</param>
        /// <returns>验证结果。</returns>
        public static bool VerifySignature(string sToken, string sTimestamp, string sNonce, string sMsgEncrypt, string sMsgSign)
        {
            if (sToken == null) throw new ArgumentNullException(nameof(sToken));
            if (sTimestamp == null) throw new ArgumentNullException(nameof(sTimestamp));
            if (sNonce == null) throw new ArgumentNullException(nameof(sNonce));
            if (sMsgEncrypt == null) throw new ArgumentNullException(nameof(sMsgEncrypt));
            if (sMsgSign == null) throw new ArgumentNullException(nameof(sMsgSign));

            string expectedSign = GenerateSignature(sToken, sTimestamp, sNonce, sMsgEncrypt);
            return string.Equals(expectedSign, sMsgSign, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// 生成微信回调签名。
        /// </summary>
        /// <param name="sToken">微信后台设置的 Token。</param>
        /// <param name="sTimestamp">返回给微信的时间戳字符串。</param>
        /// <param name="sNonce">返回给微信的随机字符串。</param>
        /// <param name="sMsgEncrypt">返回给微信的加密文本内容。</param>
        /// <returns>签名。</returns>
        public static string GenerateSignature(string sToken, string sTimestamp, string sNonce, string sMsgEncrypt)
        {
            if (sToken == null) throw new ArgumentNullException(nameof(sToken));
            if (sTimestamp == null) throw new ArgumentNullException(nameof(sTimestamp));
            if (sNonce == null) throw new ArgumentNullException(nameof(sNonce));
            if (sMsgEncrypt == null) throw new ArgumentNullException(nameof(sMsgEncrypt));

            List<string> tmp = new List<string>(capacity: 4) { sToken, sTimestamp, sNonce, sMsgEncrypt };
            tmp.Sort(StringComparer.Ordinal);

            string rawText = string.Join(string.Empty, tmp);
            string signText = SHA1Utility.Hash(rawText);
            return signText.ToLower();
        }

        /// <summary>
        /// 尝试解析微信推送过来的 XML 数据（仅适用于兼容模式或安全模式）。
        /// </summary>
        /// <param name="xml">微信推送来的 XML 数据。</param>
        /// <param name="encryptedMsg">如果解析成功，将返回解析后的 `Encrypt` 字段的值。</param>
        /// <returns>指示是否是有效的 XML 内容。</returns>
        public static bool TryParseXml(string xml, out string encryptedMsg)
        {
            return TryParseXml(xml, out encryptedMsg, out _);
        }

        /// <summary>
        /// 尝试解析微信推送过来的 XML 数据（仅适用于兼容模式或安全模式）。
        /// </summary>
        /// <param name="xml">微信推送来的 XML 数据。</param>
        /// <param name="toUserName">如果解析成功，将返回解析后的 `ToUserName` 字段的值。</param>
        /// <param name="encryptedMsg">如果解析成功，将返回解析后的 `Encrypt` 字段的值。</param>
        /// <returns>指示是否是有效的 XML 内容。</returns>
        public static bool TryParseXml(string xml, out string encryptedMsg, out string toUserName)
        {
            if (xml == null) throw new ArgumentNullException(nameof(xml));

            encryptedMsg = string.Empty;
            toUserName = string.Empty;

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.XmlResolver = null!;
                xmlDoc.LoadXml(xml);

                XmlNode? xmlRoot = xmlDoc.FirstChild;
                if (xmlRoot == null)
                    return false;

                encryptedMsg = xmlRoot["Encrypt"]?.InnerText?.ToString() ?? string.Empty;
                toUserName = xmlRoot["ToUserName"]?.InnerText?.ToString() ?? string.Empty;

                return !string.IsNullOrEmpty(encryptedMsg);
            }
            catch (XmlException)
            {
                return false;
            }
        }

        /// <summary>
        /// 将返回给微信的加密文本内容包装成 XML 格式（仅适用于安全模式）。
        /// </summary>
        /// <param name="sToken">微信后台设置的 Token。</param>
        /// <param name="sMsgEncrypt">返回给微信的加密文本内容。</param>
        /// <returns></returns>
        public static string WrapXml(string sToken, string sMsgEncrypt)
        {
            if (sToken == null) throw new ArgumentNullException(nameof(sToken));
            if (sMsgEncrypt == null) throw new ArgumentNullException(nameof(sMsgEncrypt));

            string sTimestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string sNonce = DateTimeOffset.Now.Ticks.ToString("x");
            string sMsgSign = GenerateSignature(sToken: sToken, sTimestamp: sTimestamp, sNonce: sNonce, sMsgEncrypt: sMsgEncrypt);
            return WrapXml(sTimestamp: sTimestamp, sNonce: sNonce, sMsgEncrypt: sMsgEncrypt, sMsgSign: sMsgSign);
        }

        /// <summary>
        /// 将返回给微信的加密文本内容包装成 XML 格式（仅适用于安全模式）。
        /// </summary>
        /// <param name="sTimestamp">返回给微信的时间戳字符串。</param>
        /// <param name="sNonce">返回给微信的随机字符串。</param>
        /// <param name="sMsgEncrypt">返回给微信的加密文本内容。</param>
        /// <param name="sMsgSign">返回给微信的签名。</param>
        /// <returns></returns>
        public static string WrapXml(string sTimestamp, string sNonce, string sMsgEncrypt, string sMsgSign)
        {
            if (sTimestamp == null) throw new ArgumentNullException(nameof(sTimestamp));
            if (sNonce == null) throw new ArgumentNullException(nameof(sNonce));
            if (sMsgEncrypt == null) throw new ArgumentNullException(nameof(sMsgEncrypt));
            if (sMsgSign == null) throw new ArgumentNullException(nameof(sMsgSign));

            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("<xml>");
            builder.AppendFormat("<TimeStamp><![CDATA[{0}]]></TimeStamp>", SecurityElement.Escape(sTimestamp));
            builder.AppendFormat("<Nonce><![CDATA[{0}]]></Nonce>", SecurityElement.Escape(sNonce));
            builder.AppendFormat("<Encrypt><![CDATA[{0}]]></Encrypt>", SecurityElement.Escape(sMsgEncrypt));
            builder.AppendFormat("<MsgSignature><![CDATA[{0}]]></MsgSignature>", SecurityElement.Escape(sMsgSign));
            builder.AppendFormat("</xml>");
            return builder.ToString();
        }
    }
}
