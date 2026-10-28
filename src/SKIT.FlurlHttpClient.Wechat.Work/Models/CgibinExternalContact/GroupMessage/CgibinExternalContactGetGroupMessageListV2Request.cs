namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_groupmsg_list_v2 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactGetGroupMessageListV2Request : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置指定群发任务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chat_type")]
        [System.Text.Json.Serialization.JsonPropertyName("chat_type")]
        public string? ChatType { get; set; }

        /// <summary>
        /// 获取或设置指定开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置指定结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置指定创建者成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creator")]
        [System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string? CreatorUserId { get; set; }

        /// <summary>
        /// 获取或设置指定创建类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filter_type")]
        [System.Text.Json.Serialization.JsonPropertyName("filter_type")]
        public int? CreateType { get; set; }

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
