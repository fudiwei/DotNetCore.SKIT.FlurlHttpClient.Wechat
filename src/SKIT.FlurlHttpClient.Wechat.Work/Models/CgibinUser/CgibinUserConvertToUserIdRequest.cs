﻿namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/user/convert_to_userid 接口的请求。</para>
    /// </summary>
    public class CgibinUserConvertToUserIdRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;
    }
}
