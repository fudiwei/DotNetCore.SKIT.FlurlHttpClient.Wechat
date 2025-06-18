namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/cooperation/list 接口的响应。</para>
    /// </summary>
    public class ChannelsECCooperationListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Sharer
            {
                /// <summary>
                /// 获取或设置合作账号 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sharer_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sharer_id")]
                public string SharerId { get; set; } = default!;

                /// <summary>
                /// 获取或设置合作账号名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sharer_name")]
                [System.Text.Json.Serialization.JsonPropertyName("sharer_name")]
                public string SharerName { get; set; } = default!;

                /// <summary>
                /// 获取或设置合作账号类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sharer_type")]
                [System.Text.Json.Serialization.JsonPropertyName("sharer_type")]
                public int SharerType { get; set; }

                /// <summary>
                /// 获取或设置合作账号状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置绑定时间毫秒级时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bind_time")]
                [System.Text.Json.Serialization.JsonPropertyName("bind_time")]
                public long? BindTimeMilliseconds { get; set; }

                /// <summary>
                /// 获取或设置解绑时间毫秒级时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unbind_time")]
                [System.Text.Json.Serialization.JsonPropertyName("unbind_time")]
                public long? UnbindTimeMilliseconds { get; set; }

                /// <summary>
                /// 获取或设置用户拒绝时间毫秒级时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reject_time")]
                [System.Text.Json.Serialization.JsonPropertyName("reject_time")]
                public long? RejectTimeMilliseconds { get; set; }

                /// <summary>
                /// 获取或设置商家取消时间毫秒级时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cancel_time")]
                [System.Text.Json.Serialization.JsonPropertyName("cancel_time")]
                public long? CancelTimeMilliseconds { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置合作账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data_list")]
        [System.Text.Json.Serialization.JsonPropertyName("data_list")]
        public Types.Sharer[] SharerList { get; set; } = default!;
    }
}
