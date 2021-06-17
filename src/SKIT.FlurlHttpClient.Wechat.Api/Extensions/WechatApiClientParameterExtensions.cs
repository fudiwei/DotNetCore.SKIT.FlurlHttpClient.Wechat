using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    /// <summary>
    /// 为 <see cref="WechatApiClient"/> 提供客户端调起 JS-SDK 签名的扩展方法。
    /// </summary>
    public static class WechatApiClientParameterExtensions
    {
        /// <summary>
        /// <para>生成客户端 JS-SDK `wx.config` 所需的参数。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/OA_Web_Apps/JS-SDK.html#62 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="jsapiTicket"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForJssdkConfigRequest(this WechatApiClient client, string jsapiTicket, string url)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (jsapiTicket is null) throw new ArgumentNullException(nameof(jsapiTicket));
            if (url is null) throw new ArgumentNullException(nameof(url));

            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string sign = Security.SHA1Utility.Hash($"jsapi_ticket={jsapiTicket}&noncestr={nonce}&timestamp={timestamp}&url={url.Split('#')[0]}").ToLower();

            return new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
            {
                { "appId", client.WechatAppId },
                { "timestamp", timestamp },
                { "nonceStr", nonce },
                { "signature", sign }
            });
        }

        /// <summary>
        /// <para>生成客户端 JS-SDK `wx.chooseInvoice` 接口所需的参数。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/Auto-print/API_Documentation.html#_6-4-%E5%8F%91%E7%A5%A8%E7%AD%BE%E5%90%8D%E6%96%B9%E6%B3%95 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="wxcardTicket"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForJssdkChooseInvoiceRequest(this WechatApiClient client, string wxcardTicket)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (wxcardTicket is null) throw new ArgumentNullException(nameof(wxcardTicket));

            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string cardType = "INVOICE";

            SortedSet<string> sortedParams = new SortedSet<string>();
            sortedParams.Add(cardType);
            sortedParams.Add(timestamp);
            sortedParams.Add(client.WechatAppId);
            sortedParams.Add(nonce);
            sortedParams.Add(wxcardTicket);
            string cardSign = Security.SHA1Utility.Hash(string.Join(string.Empty, sortedParams)).ToLower();

            return new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
            {
                { "timestamp", timestamp },
                { "nonceStr", nonce },
                { "signType", "SHA1" },
                { "cardType", cardType },
                { "cardSign", cardSign }
            });
        }
    }
}
