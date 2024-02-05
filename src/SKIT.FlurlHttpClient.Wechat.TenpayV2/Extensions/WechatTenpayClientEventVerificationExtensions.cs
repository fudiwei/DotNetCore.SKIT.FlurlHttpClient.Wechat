using System;
using System.Linq;
using System.Xml;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    using SKIT.FlurlHttpClient.Primitives;

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
        public static ErroredResult VerifyEventSignature(this WechatTenpayClient client, string webhookBody)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            ErroredResult result;

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

                bool valid = string.Equals(expectedSign, actualSign, StringComparison.OrdinalIgnoreCase);
                if (valid)
                    result = ErroredResult.Ok();
                else
                    result = ErroredResult.Fail(new Exception($"Signature does not match. Maybe \"{actualSign}\" is an illegal signature."));
            }
            catch (Exception ex)
            {
                result = ErroredResult.Fail(ex);
            }

            return result;
        }
    }
}
