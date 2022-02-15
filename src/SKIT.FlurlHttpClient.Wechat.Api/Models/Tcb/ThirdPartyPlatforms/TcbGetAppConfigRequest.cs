﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/getappconfig 接口的请求。</para>
    /// </summary>
    public class TcbGetAppConfigRequest : WechatApiRequest, IMapResponse<TcbGetAppConfigRequest, TcbGetAppConfigResponse>
    {
        /// <summary>
        /// 获取或设置配置类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }
    }
}
