namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/advanced_api/get_corp_buy_info 接口的响应。</para>
    /// </summary>
    public class CgibinAdvancedApiGetCorpBuyInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class ChatArchivApiBuyInfo
            {
                public static class Types
                {
                    public class EditionInfo
                    {
                        /// <summary>
                        /// 获取或设置版本。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("edition")]
                        [System.Text.Json.Serialization.JsonPropertyName("edition")]
                        public int Edition { get; set; }

                        /// <summary>
                        /// 获取或设置购买数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("purchase_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("purchase_count")]
                        public int PurchaseCount { get; set; }

                        /// <summary>
                        /// 获取或设置开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("begin_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                        public long BeginTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置结束时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                        public long EndTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置已购版本列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("edition_list")]
                [System.Text.Json.Serialization.JsonPropertyName("edition_list")]
                public Types.EditionInfo[] EditionList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置会话内容数据接口的购买信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chat_archive_api_buy_info")]
        [System.Text.Json.Serialization.JsonPropertyName("chat_archive_api_buy_info")]
        public Types.ChatArchivApiBuyInfo ChatArchivApiBuyInfo { get; set; } = default!;
    }
}
