using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/send 接口的响应。</para>
    /// </summary>
    public class CgibinMessageSendResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置无效的成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invaliduser")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.SeparatedByVBarStringArrayConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("invaliduser")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.SeparatedByVBarStringArrayConverter))]
        public string[]? InvalidUserIdList { get; set; }

        /// <summary>
        /// 获取或设置无效的部门 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalidparty")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.SeparatedByVBarInt32ArrayConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("invalidparty")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.SeparatedByVBarInt32ArrayConverter))]
        public int[]? InvalidDepartmentIdList { get; set; }

        /// <summary>
        /// 获取或设置无效的标签 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalidtag")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.SeparatedByVBarInt32ArrayConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("invalidtag")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.SeparatedByVBarInt32ArrayConverter))]
        public int[]? InvalidTagIdList { get; set; }
    }
}
