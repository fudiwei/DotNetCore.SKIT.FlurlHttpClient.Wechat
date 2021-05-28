using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /customservice/kfsession/getsession 接口的响应。</para>
    /// </summary>
    public class CustomServiceKfSessionGetSessionResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置正在接待的客服账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kf_account")]
        [System.Text.Json.Serialization.JsonPropertyName("kf_account")]
        public string? KfAccount { get; set; }

        /// <summary>
        /// 获取或设置会话接入的时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("createtime")]
        [System.Text.Json.Serialization.JsonPropertyName("createtime")]
        public long? CreateTimestamp { get; set; }
    }
}
