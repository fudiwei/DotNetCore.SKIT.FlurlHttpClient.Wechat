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

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    /// <summary>
    /// 为 <see cref="WechatWorkClient"/> 提供客户端调起 JS-SDK 签名的扩展方法。
    /// </summary>
    public static class WechatWorkClientParameterExtensions
    {
        /// <summary>
        /// <para>生成客户端 JS-SDK `wx.config` 所需的参数。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90136/90506 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90144/90539 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90152/90777 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="jsapiTicket"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForJssdkConfigRequest(this WechatWorkClient client, string jsapiTicket, string url)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (jsapiTicket is null) throw new ArgumentNullException(nameof(jsapiTicket));
            if (url is null) throw new ArgumentNullException(nameof(url));

            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string sign = Security.SHA1Utility.Hash($"jsapi_ticket={jsapiTicket}&noncestr={nonce}&timestamp={timestamp}&url={url.Split('#')[0]}").ToLower();

            return new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
            {
                { "appId", client.CorpId },
                { "timestamp", timestamp },
                { "nonceStr", nonce },
                { "signature", sign }
            });
        }

        /// <summary>
        /// <para>生成客户端 JS-SDK `wx.agentConfig` 所需的参数。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90136/90506 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90144/90539 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90152/90777 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="jsapiTicket"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForJssdkAgentConfigRequest(this WechatWorkClient client, string jsapiTicket, string url)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (jsapiTicket is null) throw new ArgumentNullException(nameof(jsapiTicket));
            if (url is null) throw new ArgumentNullException(nameof(url));

            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string sign = Security.SHA1Utility.Hash($"jsapi_ticket={jsapiTicket}&noncestr={nonce}&timestamp={timestamp}&url={url.Split('#')[0]}").ToLower();

            return new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
            {
                { "corpid", client.CorpId },
                { "agentid", client.AgentId?.ToString() ?? string.Empty },
                { "timestamp", timestamp },
                { "nonceStr", nonce },
                { "signature", sign }
            });
        }
    }
}
