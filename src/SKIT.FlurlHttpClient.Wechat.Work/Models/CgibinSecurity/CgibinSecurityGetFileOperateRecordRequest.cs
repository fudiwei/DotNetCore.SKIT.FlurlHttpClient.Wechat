using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/security/get_file_oper_record 接口的请求。</para>
    /// </summary>
    public class CgibinSecurityGetFileOperateRecordRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Operation
            {
                /// <summary>
                /// 获取或设置操作类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置操作来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source")]
                [System.Text.Json.Serialization.JsonPropertyName("source")]
                public int? Source { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置操作者 UserId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("userid_list")]
        public IList<string>? UserIdList { get; set; }

        /// <summary>
        /// 获取或设置操作信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operation")]
        [System.Text.Json.Serialization.JsonPropertyName("operation")]
        public Types.Operation? Operation { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }
    }
}
