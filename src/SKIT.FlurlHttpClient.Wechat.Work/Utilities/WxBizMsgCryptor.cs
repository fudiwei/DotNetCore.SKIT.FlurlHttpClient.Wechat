using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SKIT.FlurlHttpClient.Wechat.Work.Utilities
{
    public static class WxBizMsgCryptor
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

            using RijndaelManaged aes = new RijndaelManaged();
            aes.KeySize = 256;
            aes.BlockSize = 128;
            aes.Mode = CipherMode.CBC;
            //aes.Padding = PaddingMode.PKCS7;
            aes.Padding = PaddingMode.None;
            aes.Key = keyBytes;
            aes.IV = ivBytes;

            using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
            using (var ms = new MemoryStream())
            using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
            {
                byte[] bMsg = new byte[cipherBytes.Length + 32 - cipherBytes.Length % 32];
                Array.Copy(cipherBytes, bMsg, cipherBytes.Length);
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

            using var aes = new RijndaelManaged();
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
                byte[] chiperBytes = ms.ToArray();
                return Convert.ToBase64String(chiperBytes);
            }
        }

        /// <summary>
        /// AES 解密企业微信加密数据。
        /// </summary>
        /// <param name="cipherText">企业微信推送来的加密文本内容（即 `Encrypt` 字段的值）。</param>
        /// <param name="encodingAESKey">企业微信后台设置的 EncodingAESKey。</param>
        /// <param name="corpOrSuiteId">企业微信 CorpId 或第三方应用的 SuiteId。</param>
        /// <returns>解密后的文本内容。</returns>
        public static string AESDecrypt(string cipherText, string encodingAESKey, out string corpOrSuiteId)
        {
            if (cipherText == null) throw new ArgumentNullException(nameof(cipherText));
            if (encodingAESKey == null) throw new ArgumentNullException(nameof(encodingAESKey));

            byte[] chiperBytes = Convert.FromBase64String(cipherText);
            byte[] keyBytes = Convert.FromBase64String(encodingAESKey + "=");
            byte[] ivBytes = new byte[16];
            Array.Copy(keyBytes, ivBytes, 16);
            byte[] btmpMsg = AESDecrypt(cipherBytes: chiperBytes, ivBytes: ivBytes, keyBytes: keyBytes);

            int len = BitConverter.ToInt32(btmpMsg, 16);
            len = IPAddress.NetworkToHostOrder(len);

            byte[] bMsg = new byte[len];
            byte[] bCorpId = new byte[btmpMsg.Length - 20 - len];
            Array.Copy(btmpMsg, 20, bMsg, 0, len);
            Array.Copy(btmpMsg, 20 + len, bCorpId, 0, btmpMsg.Length - 20 - len);

            corpOrSuiteId = Encoding.UTF8.GetString(bCorpId);
            return Encoding.UTF8.GetString(bMsg);
        }

        /// <summary>
        /// AES 加密企业微信敏感数据。
        /// </summary>
        /// <param name="plainText">返回给企业微信的原始文本内容。</param>
        /// <param name="encodingAESKey">企业微信后台设置的 EncodingAESKey。</param>
        /// <param name="corpOrSuiteId">企业微信 CorpId 或第三方应用的 SuiteId。</param>
        /// <returns>加密后的文本内容。</returns>
        public static string AESEncrypt(string plainText, string encodingAESKey, string corpOrSuiteId)
        {
            if (plainText == null) throw new ArgumentNullException(nameof(plainText));
            if (encodingAESKey == null) throw new ArgumentNullException(nameof(encodingAESKey));
            if (corpOrSuiteId == null) throw new ArgumentNullException(nameof(corpOrSuiteId));

            byte[] keyBytes = Convert.FromBase64String(encodingAESKey + "=");
            byte[] ivBytes = new byte[16];
            Array.Copy(keyBytes, ivBytes, 16);

            string randCode = CreateRandCode(16);
            byte[] bRand = Encoding.UTF8.GetBytes(randCode);
            byte[] bCorpId = Encoding.UTF8.GetBytes(corpOrSuiteId);
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
        /// 验证企业微信回调签名。
        /// </summary>
        /// <param name="sToken">企业微信后台设置的 Token。</param>
        /// <param name="sTimestamp">企业微信推送来的时间戳字符串。</param>
        /// <param name="sNonce">企业微信推送来的随机字符串。</param>
        /// <param name="sMsgEncrypt">企业微信推送来的加密文本内容（即 `Encrypt` 字段的值）。</param>
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
        /// 生成企业微信回调签名。
        /// </summary>
        /// <param name="sToken">企业微信后台设置的 Token。</param>
        /// <param name="sTimestamp">返回给企业微信的时间戳字符串。</param>
        /// <param name="sNonce">返回给企业微信的随机字符串。</param>
        /// <param name="sMsgEncrypt">返回给企业微信的加密文本内容。</param>
        /// <returns>签名。</returns>
        public static string GenerateSignature(string sToken, string sTimestamp, string sNonce, string sMsgEncrypt)
        {
            if (sToken == null) throw new ArgumentNullException(nameof(sToken));
            if (sTimestamp == null) throw new ArgumentNullException(nameof(sTimestamp));
            if (sNonce == null) throw new ArgumentNullException(nameof(sNonce));
            if (sMsgEncrypt == null) throw new ArgumentNullException(nameof(sMsgEncrypt));

            ISet<string> set = new SortedSet<string>();
            set.Add(sToken);
            set.Add(sTimestamp);
            set.Add(sNonce);
            set.Add(sMsgEncrypt);
            
            string rawText = string.Join(string.Empty, set.ToArray());
            string signText = Security.SHA1Utility.Hash(rawText);
            return signText.ToLower();
        }

        /// <summary>
        /// 尝试解析企业微信推送过来的 XML 数据。
        /// </summary>
        /// <param name="xml">企业微信推送来的 XML 数据。</param>
        /// <param name="encryptedMsg">如果解析成功，将返回解析后的 `Encrypt` 字段的值。</param>
        /// <returns>指示是否是有效的 XML 内容。</returns>
        public static bool TryParseXml(string xml, out string? encryptedMsg)
        {
            return TryParseXml(xml, out encryptedMsg, out _, out _);
        }

        /// <summary>
        /// 尝试解析企业微信推送过来的 XML 数据。
        /// </summary>
        /// <param name="xml">企业微信推送来的 XML 数据。</param>
        /// <param name="encryptedMsg">如果解析成功，将返回解析后的 `Encrypt` 字段的值。</param>
        /// <param name="toUserName">如果解析成功，将返回解析后的 `ToUserName` 字段的值。</param>
        /// <param name="agentId">如果解析成功，将返回解析后的 `AgentId` 字段的值。</param>
        /// <returns>指示是否是有效的 XML 内容。</returns>
        /// <returns></returns>
        public static bool TryParseXml(string xml, out string? encryptedMsg, out string? toUserName, out string? agentId)
        {
            if (xml == null) throw new ArgumentNullException(nameof(xml));

            encryptedMsg = null;
            toUserName = null;
            agentId = null;

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xml);

                XmlNode? xmlRoot = xmlDoc.FirstChild;
                if (xmlRoot == null)
                    return false;

                encryptedMsg = xmlRoot["Encrypt"]?.InnerText?.ToString();
                toUserName = xmlRoot["ToUserName"]?.InnerText?.ToString();
                agentId = xmlRoot["AgentID"]?.InnerText?.ToString();

                return !string.IsNullOrEmpty(encryptedMsg);
            }
            catch (XmlException)
            {
                return false;
            }
        }

        /// <summary>
        /// 将返回给企业微信的加密文本内容包装成 XML 格式。
        /// </summary>
        /// <param name="sToken">企业微信后台设置的 Token。</param>
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
        /// 将返回给企业微信的加密文本内容包装成 XML 格式（仅适用于安全模式）。
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
