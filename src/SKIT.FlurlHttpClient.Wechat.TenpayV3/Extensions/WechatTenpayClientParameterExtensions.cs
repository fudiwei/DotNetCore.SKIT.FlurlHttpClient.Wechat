using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Constants;

    public static class WechatTenpayClientParameterExtensions
    {
        /// <summary>
        /// <para>生成客户端 JSAPI / 小程序调起支付所需的参数字典。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/jsapi-payment/jsapi-transfer-payment.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/mini-program-payment/mini-transfer-payment.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/combine-payment/orders/jsapi-transfer-payment.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/combine-payment/orders/mini-transfer-payment.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-jsapi-payment/jsapi-transfer-payment.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-mini-program-payment/mini-transfer-payment.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/combine-payment/orders/jsapi-transfer-payment.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/combine-payment/orders/mini-transfer-payment.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-payment/jsapi-transfer-payment.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-combine-payment/jsapi-transfer-payment.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-combine-payment/mini-transfer-payment.html ]]>
        /// </para>
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
            string sign = Utilities.RSAUtility.Sign(
                privateKeyPem: client.Credentials.MerchantCertificatePrivateKey,
                messageData: $"{appId}\n{timestamp}\n{nonce}\n{package}\n"
            )!;

            return new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
            {
                { "appId", appId },
                { "timeStamp", timestamp },
                { "nonceStr", nonce },
                { "package", package },
                { "signType", SignTypes.RSA },
                { "paySign", sign }
            });
        }

        /// <summary>
        /// <para>生成 APP 调起支付所需的参数字典。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/in-app-payment/app-transfer-payment.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/combine-payment/orders/app-transfer-payment.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="appId"></param>
        /// <param name="prepayId"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForAppPayRequest(this WechatTenpayClient client, string appId, string prepayId)
        {
            return GenerateParametersForAppPayRequest(client, merchantId: client.Credentials.MerchantId, appId: appId, prepayId: prepayId);
        }

        /// <summary>
        /// <para>生成 APP 调起支付所需的参数字典。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/partner-in-app-payment/app-transfer-payment.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/combine-payment/orders/app-transfer-payment.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-payment/app-transfer-payment.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-payment/mini-transfer-payment.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-combine-payment/app-transfer-payment.html ]]>
        /// </para>
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
            string sign = Utilities.RSAUtility.Sign(
                privateKeyPem: client.Credentials.MerchantCertificatePrivateKey,
                messageData: $"{appId}\n{timestamp}\n{nonce}\n{prepayId}\n"
            )!;

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
