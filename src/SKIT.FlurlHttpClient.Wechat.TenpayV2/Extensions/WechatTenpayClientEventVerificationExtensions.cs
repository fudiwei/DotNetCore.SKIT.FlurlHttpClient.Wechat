using System;
using System.Linq;
using System.Xml;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供回调通知事件签名验证的扩展方法。
    /// </summary>
    public static class WechatTenpayClientEventVerificationExtensions
    {
        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookBody">微信回调通知中请求正文。</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool VerifyEventSignature(this WechatTenpayClient client, string webhookBody)
        {
            return VerifyEventSignature(client, webhookBody, out _);
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookBody">微信回调通知中请求正文。</param>
        /// <param name="error"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool VerifyEventSignature(this WechatTenpayClient client, string webhookBody, out Exception? error)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            try
            {

                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(webhookBody);

                XmlNode xmlNode = xmlDocument.ChildNodes.OfType<XmlNode>().Single();
                string? signType = xmlNode["sign_type"]?.InnerText;
                string? expectedSign = xmlNode["sign"]?.InnerText;
                xmlNode["sign"]?.RemoveAll();

                string xml = xmlDocument.InnerXml;
                string json = Utilities.XmlHelper.ConvertToJson(xml);
                string signData = Utilities.JsonHelper.ParseToSortedQueryString(json);
                string actualSign = Utilities.RequestSigner.SignFromSortedQueryString(signData, client.Credentials.MerchantSecret, signType);

                error = null;
                return string.Equals(expectedSign, actualSign, StringComparison.OrdinalIgnoreCase);
            }
            catch (Exception ex)
            {
                error = new WechatTenpayException("Failed to verify event. Please see the inner exception for more details.", ex);
                return false;
            }
        }
    }
}
