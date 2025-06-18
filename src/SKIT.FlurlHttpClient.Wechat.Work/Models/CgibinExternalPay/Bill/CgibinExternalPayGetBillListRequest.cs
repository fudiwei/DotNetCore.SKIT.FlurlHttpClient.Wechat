namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalpay/get_bill_list 接口的请求。</para>
    /// </summary>
    public class CgibinExternalPayGetBillListRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置指定收款记录开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_time")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
        public long BeginTimestamp { get; set; }

        /// <summary>
        /// 获取或设置指定收款记录结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置指定收款成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payee_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("payee_userid")]
        public string? PayeeUserId { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }
    }
}
