using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/retailnotifybusiness 接口的请求。</para>
    /// </summary>
    public class WxaBusinessRetailNotifyBusinessRequest : WechatApiRequest, IInferable<WxaBusinessRetailNotifyBusinessRequest, WxaBusinessRetailNotifyBusinessResponse>
    {
        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置下发内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店负责人的 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_user_list")]
        [System.Text.Json.Serialization.JsonPropertyName("to_user_list")]
        public IList<string> ToUserOpenIdList { get; set; } = new List<string>();
    }
}
