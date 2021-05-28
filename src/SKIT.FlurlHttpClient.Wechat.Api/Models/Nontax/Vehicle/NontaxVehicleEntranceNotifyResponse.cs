using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /nontax/vehicle/entrancenotify 接口的响应。</para>
    /// </summary>
    public class NontaxVehicleEntranceNotifyResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置用户状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_state")]
        [System.Text.Json.Serialization.JsonPropertyName("user_state")]
        public string UserState { get; set; } = default!;
    }
}
