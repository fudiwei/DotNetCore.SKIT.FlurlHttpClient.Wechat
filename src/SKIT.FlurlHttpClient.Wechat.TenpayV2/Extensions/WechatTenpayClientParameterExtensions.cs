using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Web;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供调起支付签名的扩展方法。
    /// </summary>
    public static class WechatTenpayClientParameterExtensions
    {
        /// <summary>
        /// <para>生成客户端小程序调起领取红包所需的参数字典。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/tools/cash_coupon_xcx.php?chapter=18_3&index=4 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/tools/cash_coupon_sl.php?chapter=18_3&index=4 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="packageString"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForJsapiSendBusinessRedPack(this WechatTenpayClient client, string packageString)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (packageString is null) throw new ArgumentNullException(nameof(packageString));

            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string signType = Constants.SignTypes.MD5;
            string signData = $"timeStamp={timestamp}&nonceStr={nonce}&package={packageString}&signType={signType}&key={client.Credentials.MerchantSecret}";
            string sign = Utilities.MD5Utility.Hash(signData);

            return new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
            {
                { "timeStamp", timestamp },
                { "nonceStr", nonce },
                { "package", HttpUtility.UrlEncode(packageString) },
                { "signType", signType },
                { "paySign", sign }
            });
        }

        /// <summary>
        /// <para>生成客户端 JSAPI 调起支付所需的参数字典。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi.php?chapter=7_7&index=6 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi_sl.php?chapter=7_7&index=6 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/deposit_sl.php?chapter=7_7&index=2&p=27 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="appId"></param>
        /// <param name="prepayId"></param>
        /// <param name="signType"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForJsapiGetBrandPayRequest(this WechatTenpayClient client, string appId, string prepayId, string? signType)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (prepayId is null) throw new ArgumentNullException(nameof(prepayId));

            signType = signType ?? Constants.SignTypes.MD5;

            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string package = $"prepay_id={prepayId}";
            string signData = $"appId={appId}&timeStamp={timestamp}&nonceStr={nonce}&package={package}&signType={signType}&key={client.Credentials.MerchantSecret}";
            string sign;

            switch (signType)
            {
                case Constants.SignTypes.MD5:
                    {
                        sign = Utilities.MD5Utility.Hash(signData);
                    }
                    break;
                case Constants.SignTypes.HMAC_SHA256:
                    {
                        sign = Utilities.HMACUtility.HashWithSHA256(client.Credentials.MerchantSecret, signData);
                    }
                    break;
                default:
                    throw new NotSupportedException();
            }

            return new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
            {
                { "appId", appId },
                { "timeStamp", timestamp },
                { "nonceStr", nonce },
                { "package", package },
                { "signType", signType },
                { "paySign", sign }
            });
        }

        /// <summary>
        /// <para>生成客户端 App 调起支付所需的参数字典。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_12&index=2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app_sl.php?chapter=9_12&index=2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="merchantId"></param>
        /// <param name="appId"></param>
        /// <param name="prepayId"></param>
        /// <param name="signType"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForAppGetBrandPayRequest(this WechatTenpayClient client, string merchantId, string appId, string prepayId, string? signType)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (prepayId is null) throw new ArgumentNullException(nameof(prepayId));

            signType = signType ?? Constants.SignTypes.MD5;

            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string partnerId = merchantId;
            string package = "Sign=WXPay";
            string signData = $"appid={appId}&timestamp={timestamp}&noncestr={nonce}&package={package}&partnerid={partnerId}&prepayid={prepayId}&signType={signType}&key={client.Credentials.MerchantSecret}";
            string sign;

            switch (signType)
            {
                case Constants.SignTypes.MD5:
                    {
                        sign = Utilities.MD5Utility.Hash(signData);
                    }
                    break;
                case Constants.SignTypes.HMAC_SHA256:
                    {
                        sign = Utilities.HMACUtility.HashWithSHA256(client.Credentials.MerchantSecret, signData);
                    }
                    break;
                default:
                    throw new NotSupportedException();
            }

            return new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
            {
                { "appid", appId },
                { "partnerid", partnerId },
                { "prepayid", prepayId },
                { "package", package },
                { "noncestr", nonce },
                { "timestamp", timestamp },
                { "sign", sign }
            });
        }

        /// <summary>
        /// <para>生成客户端 App 调起支付所需的参数字典。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_12&index=2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app_sl.php?chapter=9_12&index=2 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/deposit_sl.php?chapter=27_9&index=4 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="appId"></param>
        /// <param name="prepayId"></param>
        /// <param name="signType"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForAppGetBrandPayRequest(this WechatTenpayClient client, string appId, string prepayId, string? signType)
        {
            return GenerateParametersForAppGetBrandPayRequest(client, merchantId: client.Credentials.MerchantId, appId: appId, prepayId: prepayId, signType: signType);        }

        /// <summary>
        /// <para>生成客户端小程序调起支付所需的参数字典。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=7_7&index=5 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_sl_api.php?chapter=7_7&index=5 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="appId"></param>
        /// <param name="prepayId"></param>
        /// <param name="signType"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForMiniProgramRequestPayment(this WechatTenpayClient client, string appId, string prepayId, string? signType)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (prepayId is null) throw new ArgumentNullException(nameof(prepayId));

            signType = signType ?? Constants.SignTypes.MD5;

            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string package = $"prepay_id={prepayId}";
            string signData = $"appId={appId}&timeStamp={timestamp}&nonceStr={nonce}&package={package}&signType={signType}&key={client.Credentials.MerchantSecret}";
            string sign;

            switch (signType)
            {
                case Constants.SignTypes.MD5:
                    {
                        sign = Utilities.MD5Utility.Hash(signData);
                    }
                    break;
                case Constants.SignTypes.HMAC_SHA256:
                    {
                        sign = Utilities.HMACUtility.HashWithSHA256(client.Credentials.MerchantSecret, signData);
                    }
                    break;
                default:
                    throw new NotSupportedException();
            }

            return new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
            {
                { "timeStamp", timestamp },
                { "nonceStr", nonce },
                { "package", package },
                { "signType", signType },
                { "paySign", sign }
            });
        }
    }
}
