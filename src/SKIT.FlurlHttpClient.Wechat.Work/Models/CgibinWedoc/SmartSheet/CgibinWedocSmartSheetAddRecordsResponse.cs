namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/add_records 接口的响应。</para>
    /// </summary>
    public class CgibinWedocSmartSheetAddRecordsResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Record
            {
                /// <summary>
                /// 获取或设置记录 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("record_id")]
                [System.Text.Json.Serialization.JsonPropertyName("record_id")]
                public string RecordId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("records")]
        [System.Text.Json.Serialization.JsonPropertyName("records")]
        public Types.Record[] RecordList { get; set; } = default!;
    }
}
