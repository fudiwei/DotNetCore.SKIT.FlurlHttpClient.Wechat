﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/getappconfig 接口的响应。</para>
    /// </summary>
    public class TcbGetAppConfigResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置 JSON 格式的配置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("config")]
        [System.Text.Json.Serialization.JsonPropertyName("config")]
        public string JsonConfig { get; set; } = default!;
    }
}
