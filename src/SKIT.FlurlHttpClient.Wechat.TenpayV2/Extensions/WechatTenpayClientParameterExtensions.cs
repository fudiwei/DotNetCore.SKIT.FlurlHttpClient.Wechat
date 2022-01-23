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
        /// <param name="packageString"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForJsapiSendBusinessRedPack(this WechatTenpayClient client, string packageString)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (packageString is null) throw new ArgumentNullException(nameof(packageString));

            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string signType = Constants.SignTypes.MD5;
            string sign = Utilities.MD5Utility.Hash($"timeStamp={timestamp}&nonceStr={nonce}&package={packageString}&signType={signType}&key={client.Credentials.MerchantSecret}");

            return new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
            {
                { "timeStamp", timestamp },
                { "nonceStr", nonce },
                { "package", HttpUtility.UrlEncode(packageString) },
                { "signType", signType },
                { "paySign", sign }
            });
        }
    }
}
