using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/pstncc/getstates 接口的响应。</para>
    /// </summary>
    public class CgibinPSTNCCGetStatesResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置是否通话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("istalked")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("istalked")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsTalked { get; set; }

        /// <summary>
        /// 获取或设置呼叫发起时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("calltime")]
        [System.Text.Json.Serialization.JsonPropertyName("calltime")]
        public int CallTimestamp { get; set; }

        /// <summary>
        /// 获取或设置通话时长（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("talktime")]
        [System.Text.Json.Serialization.JsonPropertyName("talktime")]
        public int TalkTime { get; set; }

        /// <summary>
        /// 获取或设置呼叫结果状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public int Reason { get; set; }
    }
}
