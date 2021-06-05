using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/externalcontact/get_subscribe_mode 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGetSubscribeModeResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置关注模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subscribe_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("subscribe_mode")]
        public int SubscribeMode { get; set; }
    }
}
