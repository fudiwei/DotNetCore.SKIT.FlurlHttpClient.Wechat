using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/sharer/unbind 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2025-03-07 下线。")]
    public class ChannelsECSharerUnbindResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置解绑成功的分享员 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("success_openid")]
        public string[] SuccessOpenIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置解绑失败的分享员 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_openid")]
        public string[] FailOpenIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置解绑拒绝的分享员 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refuse_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("refuse_openid")]
        public string[] RefuseOpenIdList { get; set; } = default!;
    }
}
