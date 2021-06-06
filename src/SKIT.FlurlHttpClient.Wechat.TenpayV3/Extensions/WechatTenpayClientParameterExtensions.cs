using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供调起支付签名的扩展方法。
    /// </summary>
    public static class WechatTenpayClientParameterExtensions
    {
        /// <summary>
        /// <para>生成客户端 JSAPI / 小程序调起支付所需的参数。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_4.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_4.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_8.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_9.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_1_4.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_5_4.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_9.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_3_8.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_3_9.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="appId"></param>
        /// <param name="prepayId"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForJsapiPayRequest(this WechatTenpayClient client, string appId, string prepayId)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (appId is null) throw new ArgumentNullException(nameof(appId));
            if (prepayId is null) throw new ArgumentNullException(nameof(prepayId));

            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string package = $"prepay_id={prepayId}";
            string sign = Utilities.RSAUtility.SignWithSHA256(
                privateKey: client.MerchantCertPrivateKey,
                plainText: $"{appId}\n{timestamp}\n{nonce}\n{package}"
            );

            return new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
            {
                { "appId", appId },
                { "timeStamp", timestamp },
                { "nonceStr", nonce },
                { "package", package },
                { "signType", Constants.SignTypes.RSA },
                { "paySign", sign }
            });
        }

        /// <summary>
        /// <para>生成 APP 调起支付所需的参数。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_4.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_4.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_3_6.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="appId"></param>
        /// <param name="prepayId"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForAppPayRequest(this WechatTenpayClient client, string appId, string prepayId)
        {
            return GenerateParametersForAppPayRequest(client, merchantId: client.MerchantId, appId: appId, prepayId: prepayId);
        }

        /// <summary>
        /// <para>生成 APP 调起支付所需的参数。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_4.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_4.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_3_6.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="merchantId"></param>
        /// <param name="appId"></param>
        /// <param name="prepayId"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForAppPayRequest(this WechatTenpayClient client, string merchantId, string appId, string prepayId)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (merchantId is null) throw new ArgumentNullException(nameof(merchantId));
            if (appId is null) throw new ArgumentNullException(nameof(appId));
            if (prepayId is null) throw new ArgumentNullException(nameof(prepayId));

            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string sign = Utilities.RSAUtility.SignWithSHA256(
                privateKey: client.MerchantCertPrivateKey,
                plainText: $"{appId}\n{timestamp}\n{nonce}\n{prepayId}"
            );

            return new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
            {
                { "appid", appId },
                { "partnerid", merchantId },
                { "prepayid", prepayId },
                { "package", "Sign=WXPay" },
                { "noncestr", nonce },
                { "timestamp", timestamp },
                { "sign", sign }
            });
        }
    }
}
