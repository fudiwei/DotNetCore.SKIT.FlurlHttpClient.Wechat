using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/message/mass/speed/get 接口的响应。</para>
    /// </summary>
    public class CgibinMessageMassSpeedGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置群发速度级别。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("speed")]
        [System.Text.Json.Serialization.JsonPropertyName("speed")]
        public int SpeedLevel { get; set; }

        /// <summary>
        /// 获取或设置群发速度值（单位：万/分钟）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("realspeed")]
        [System.Text.Json.Serialization.JsonPropertyName("realspeed")]
        public int SpeedValue { get; set; }
    }
}
