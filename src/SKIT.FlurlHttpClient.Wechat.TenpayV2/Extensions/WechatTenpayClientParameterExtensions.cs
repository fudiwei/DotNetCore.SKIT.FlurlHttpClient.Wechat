using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Web;
using Flurl;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供调起支付签名的扩展方法。
    /// </summary>
    public static class WechatTenpayClientParameterExtensions
    {
        private const string BASE_URL = "https://api.mch.weixin.qq.com";

        /// <summary>
        /// <para>生成客户端小程序调起领取红包所需的参数字典。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/tools/cash_coupon_xcx.php?chapter=18_3 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/tools/cash_coupon_sl.php?chapter=18_3 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="appId"></param>
        /// <param name="packageString"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForJsapiSendBusinessRedPack(this WechatTenpayClient client, string appId, string packageString)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (packageString is null) throw new ArgumentNullException(nameof(packageString));

            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string signType = Constants.SignTypes.MD5;
            string signData = $"appId={appId}&nonceStr={nonce}&package={packageString}&timeStamp={timestamp}";
            string sign = Utilities.RequestSigner.SignFromSortedQueryString(signData, client.Credentials.MerchantSecret, signType);

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
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi.php?chapter=7_7 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/jsapi_sl.php?chapter=7_7 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/deposit_sl.php?chapter=7_7&p=27 </para>
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
            string signData = $"appId={appId}&nonceStr={nonce}&package={package}&signType={signType}&timeStamp={timestamp}";
            string sign = Utilities.RequestSigner.SignFromSortedQueryString(signData, client.Credentials.MerchantSecret, signType);

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
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_12 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app_sl.php?chapter=9_12 </para>
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
            string signData = $"appid={appId}&noncestr={nonce}&package={package}&partnerid={partnerId}&prepayid={prepayId}&timestamp={timestamp}";
            string sign = Utilities.RequestSigner.SignFromSortedQueryString(signData, client.Credentials.MerchantSecret, signType);

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
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_12 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/app/app_sl.php?chapter=9_12 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/deposit_sl.php?chapter=27_9 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="appId"></param>
        /// <param name="prepayId"></param>
        /// <param name="signType"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForAppGetBrandPayRequest(this WechatTenpayClient client, string appId, string prepayId, string? signType)
        {
            return GenerateParametersForAppGetBrandPayRequest(client, merchantId: client.Credentials.MerchantId, appId: appId, prepayId: prepayId, signType: signType);
        }

        /// <summary>
        /// <para>生成客户端小程序调起支付所需的参数字典。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=7_7 </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_sl_api.php?chapter=7_7 </para>
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
            string signData = $"appId={appId}&nonceStr={nonce}&package={package}&signType={signType}&timeStamp={timestamp}";
            string sign = Utilities.RequestSigner.SignFromSortedQueryString(signData, client.Credentials.MerchantSecret, signType);

            return new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
            {
                { "timeStamp", timestamp },
                { "nonceStr", nonce },
                { "package", package },
                { "signType", signType },
                { "paySign", sign }
            });
        }

        /// <summary>
        /// <para>生成客户端公众号唤起微信委托代扣的 URL。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter3_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="appId"></param>
        /// <param name="planId"></param>
        /// <param name="contractCode"></param>
        /// <param name="requestSerialNumber"></param>
        /// <param name="contractDisplayAccount"></param>
        /// <param name="notifyUrl"></param>
        /// <param name="requireReturnWeb"></param>
        /// <returns></returns>
        public static string GenerateParameterizedUrlForMediaPlatformPAPPayEntrustWeb(this WechatTenpayClient client, string appId, int planId, string contractCode, long requestSerialNumber, string contractDisplayAccount, string notifyUrl, bool? requireReturnWeb)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            string version = "1.0";
            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            IDictionary<string, string?> paramsMap = new Dictionary<string, string?>()
            {
                { "appid", appId },
                { "mch_id", client.Credentials.MerchantId },
                { "plan_id", planId.ToString() },
                { "contract_code", contractCode },
                { "request_serial", requestSerialNumber.ToString() },
                { "contract_display_account", contractDisplayAccount },
                { "notify_url", notifyUrl },
                { "version", version },
                { "timestamp", timestamp },
                { "return_web", requireReturnWeb.HasValue ? requireReturnWeb.Value ? "1" : "0" : null }
            };
            string sign = Utilities.RequestSigner.Sign(paramsMap, client.Credentials.MerchantSecret, Constants.SignTypes.MD5);

            return new Url(BASE_URL)
                .AppendPathSegments("papay", "entrustweb")
                .SetQueryParams(paramsMap)
                .SetQueryParam("sign", sign)
                .ToString();
        }

        /// <summary>
        /// <para>生成客户端公众号唤起微信委托代扣的 URL。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter5_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="appId"></param>
        /// <param name="subMerchantId"></param>
        /// <param name="subAppId"></param>
        /// <param name="planId"></param>
        /// <param name="contractCode"></param>
        /// <param name="requestSerialNumber"></param>
        /// <param name="contractDisplayAccount"></param>
        /// <param name="notifyUrl"></param>
        /// <param name="requireReturnWeb"></param>
        /// <returns></returns>
        public static string GenerateParameterizedUrlForMediaPlatformPAPPayPartnerEntrustWeb(this WechatTenpayClient client, string appId, string subMerchantId, string? subAppId, int planId, string contractCode, long requestSerialNumber, string contractDisplayAccount, string notifyUrl, bool? requireReturnWeb)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            string version = "1.0";
            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            IDictionary<string, string?> paramsMap = new Dictionary<string, string?>()
            {
                { "appid", appId },
                { "mch_id", client.Credentials.MerchantId },
                { "sub_appid", subAppId },
                { "sub_mch_id", subMerchantId },
                { "plan_id", planId.ToString() },
                { "contract_code", contractCode },
                { "request_serial", requestSerialNumber.ToString() },
                { "contract_display_account", contractDisplayAccount },
                { "notify_url", notifyUrl },
                { "version", version },
                { "timestamp", timestamp },
                { "return_web", requireReturnWeb.HasValue ? requireReturnWeb.Value ? "1" : "0" : null }
            };
            string sign = Utilities.RequestSigner.Sign(paramsMap, client.Credentials.MerchantSecret, Constants.SignTypes.MD5);

            return new Url(BASE_URL)
                .AppendPathSegments("papay", "partner", "entrustweb")
                .SetQueryParams(paramsMap)
                .SetQueryParam("sign", sign)
                .ToString();
        }

        /// <summary>
        /// <para>生成客户端小程序唤起微信委托代扣页面所需的参数字典。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter3_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="appId"></param>
        /// <param name="planId"></param>
        /// <param name="contractCode"></param>
        /// <param name="requestSerialNumber"></param>
        /// <param name="contractDisplayAccount"></param>
        /// <param name="notifyUrl"></param>
        /// <param name="outerId"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForMiniProgramPAPPayEntrust(this WechatTenpayClient client, string appId, int planId, string contractCode, long requestSerialNumber, string contractDisplayAccount, string notifyUrl, string? outerId)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            IDictionary<string, string?> paramsMap = new Dictionary<string, string?>()
            {
                { "appid", appId },
                { "mch_id", client.Credentials.MerchantId },
                { "plan_id", planId.ToString() },
                { "contract_code", contractCode },
                { "request_serial", requestSerialNumber.ToString() },
                { "contract_display_account", contractDisplayAccount },
                { "notify_url", notifyUrl },
                { "timestamp", timestamp },
                { "outerid", outerId }
            };
            paramsMap["sign"] = Utilities.RequestSigner.Sign(paramsMap, client.Credentials.MerchantSecret, Constants.SignTypes.MD5);

            return new ReadOnlyDictionary<string, string>(paramsMap!);
        }

        /// <summary>
        /// <para>生成客户端小程序唤起微信委托代扣页面所需的参数字典。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter5_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="appId"></param>
        /// <param name="subMerchantId"></param>
        /// <param name="subAppId"></param>
        /// <param name="planId"></param>
        /// <param name="contractCode"></param>
        /// <param name="requestSerialNumber"></param>
        /// <param name="contractDisplayAccount"></param>
        /// <param name="notifyUrl"></param>
        /// <param name="clientIp"></param>
        /// <param name="deviceId"></param>
        /// <param name="userMobile"></param>
        /// <param name="userEmail"></param>
        /// <param name="userQQ"></param>
        /// <param name="openId"></param>
        /// <param name="idCardNumber"></param>
        /// <param name="outerId"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForMiniProgramPAPPayPartnerEntrust(this WechatTenpayClient client, string appId, string subMerchantId, string? subAppId, int planId, string contractCode, long requestSerialNumber, string contractDisplayAccount, string notifyUrl, string clientIp, string? deviceId, string? userMobile, string? userEmail, string? userQQ, string? openId, string? idCardNumber, string? outerId)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            IDictionary<string, string?> paramsMap = new Dictionary<string, string?>()
            {
                { "appid", appId },
                { "mch_id", client.Credentials.MerchantId },
                { "sub_appid", subAppId },
                { "sub_mch_id", subMerchantId },
                { "plan_id", planId.ToString() },
                { "contract_code", contractCode },
                { "request_serial", requestSerialNumber.ToString() },
                { "contract_display_account", contractDisplayAccount },
                { "notify_url", notifyUrl },
                { "timestamp", timestamp },
                { "clientip", clientIp },
                { "deviceid", deviceId },
                { "mobile", userMobile },
                { "email", userEmail },
                { "qq", userQQ },
                { "openid", openId },
                { "creid", idCardNumber },
                { "outerid", outerId }
            };
            paramsMap["sign"] = Utilities.RequestSigner.Sign(paramsMap, client.Credentials.MerchantSecret, Constants.SignTypes.MD5);

            return new ReadOnlyDictionary<string, string>(paramsMap!);
        }

        /// <summary>
        /// <para>生成客户端小程序唤起开通车主服务页面所需的参数字典。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/vehicle_v2_sl.php?chapter=20_1010 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="appId"></param>
        /// <param name="subMerchantId"></param>
        /// <param name="subAppId"></param>
        /// <param name="openId"></param>
        /// <param name="subOpenId"></param>
        /// <param name="tradeScene"></param>
        /// <param name="plateNumber"></param>
        /// <param name="channelType"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IDictionary<string, string> GenerateParametersForMiniProgramVehiclePAPPayPartnerAuth(this WechatTenpayClient client, string appId, string subMerchantId, string? subAppId, string? openId, string? subOpenId, string tradeScene, string? plateNumber, string? channelType)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            string nonce = Guid.NewGuid().ToString("N");
            string signType = Constants.SignTypes.HMAC_SHA256;
            IDictionary<string, string?> paramsMap = new Dictionary<string, string?>()
            {
                { "nonce_str", nonce },
                { "appid", appId },
                { "mch_id", client.Credentials.MerchantId },
                { "sub_appid", subAppId },
                { "sub_mch_id", subMerchantId },
                { "sign_type", signType },
                { "openid", openId },
                { "sub_openid", subOpenId },
                { "trade_scene", tradeScene },
                { "plate_number", plateNumber },
                { "channel_type", channelType }
            };
            paramsMap["sign"] = Utilities.RequestSigner.Sign(paramsMap, client.Credentials.MerchantSecret, signType);

            return new ReadOnlyDictionary<string, string>(paramsMap!);
        }

        /// <summary>
        /// <para>生成客户端 App 唤起开通车主服务页面所需的参数字典。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/vehicle_v2_sl.php?chapter=20_1010 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="appId"></param>
        /// <param name="subMerchantId"></param>
        /// <param name="subAppId"></param>
        /// <param name="openId"></param>
        /// <param name="subOpenId"></param>
        /// <param name="tradeScene"></param>
        /// <param name="plateNumber"></param>
        /// <param name="channelType"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IDictionary<string, string> GenerateParametersForAppVehiclePAPPayPartnerAuth(this WechatTenpayClient client, string appId, string subMerchantId, string? subAppId, string? openId, string? subOpenId, string tradeScene, string? plateNumber, string? channelType)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            return GenerateParametersForMiniProgramVehiclePAPPayPartnerAuth(
                client,
                appId: appId,
                subMerchantId: subMerchantId,
                subAppId: subAppId,
                openId: openId,
                subOpenId: subOpenId,
                tradeScene: tradeScene,
                plateNumber: plateNumber,
                channelType: channelType
            );
        }

        /// <summary>
        /// <para>生成客户端小程序唤起免密支付升级无感支付页面所需的参数字典。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/vehicle_v2_sl.php?chapter=20_1021 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="appId"></param>
        /// <param name="subMerchantId"></param>
        /// <param name="subAppId"></param>
        /// <param name="openId"></param>
        /// <param name="plateNumber"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IDictionary<string, string> GenerateParametersForMiniProgramVehiclePAPPayPartnerNoSensePayment(this WechatTenpayClient client, string appId, string subMerchantId, string? subAppId, string? openId, string? plateNumber)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            string nonce = Guid.NewGuid().ToString("N");
            string signType = Constants.SignTypes.HMAC_SHA256;
            IDictionary<string, string?> paramsMap = new Dictionary<string, string?>()
            {
                { "nonce_str", nonce },
                { "appid", appId },
                { "mch_id", client.Credentials.MerchantId },
                { "sub_appid", subAppId },
                { "sub_mch_id", subMerchantId },
                { "sign_type", signType },
                { "openid", openId },
                { "plate_number", plateNumber }
            };
            paramsMap["sign"] = Utilities.RequestSigner.Sign(paramsMap, client.Credentials.MerchantSecret, signType);

            return new ReadOnlyDictionary<string, string>(paramsMap!);
        }

        /// <summary>
        /// <para>生成客户端 App 唤起免密支付升级无感支付页面所需的参数字典。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/vehicle_v2_sl.php?chapter=20_1010 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="appId"></param>
        /// <param name="subMerchantId"></param>
        /// <param name="subAppId"></param>
        /// <param name="openId"></param>
        /// <param name="plateNumber"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IDictionary<string, string> GenerateParametersForAppVehiclePAPPayPartnerNoSensePayment(this WechatTenpayClient client, string appId, string subMerchantId, string? subAppId, string? openId, string? plateNumber)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            return GenerateParametersForMiniProgramVehiclePAPPayPartnerNoSensePayment(
                client,
                appId: appId,
                subMerchantId: subMerchantId,
                subAppId: subAppId,
                openId: openId,
                plateNumber: plateNumber
            );
        }
    }
}
