namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /promoter/getmsg 接口的响应。</para>
    /// </summary>
    public class PromoterGetMessageResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Failure
            {
                /// <summary>
                /// 获取或设置推广员 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string PromoterId { get; set; } = default!;

                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errcode")]
                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                public int ErrorCode { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置发送总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_cnt")]
        [System.Text.Json.Serialization.JsonPropertyName("send_cnt")]
        public int SendCount { get; set; }

        /// <summary>
        /// 获取或设置发送比例（单位：百分数）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("percent")]
        [System.Text.Json.Serialization.JsonPropertyName("percent")]
        public int SendPercent { get; set; }

        /// <summary>
        /// 获取或设置发送失败数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_cnt")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_cnt")]
        public int FailedCount { get; set; }

        /// <summary>
        /// 获取或设置失败信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_info")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_info")]
        public Types.Failure[]? FailureList { get; set; }

        /// <summary>
        /// 获取或设置失败信息文件下载链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_info_url")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_info_url")]
        public string? FailureInfoUrl { get; set; }

        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_type")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_type")]
        public int MessageType { get; set; }

        /// <summary>
        /// 获取或设置消息内容 JSON 字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string ContentJson { get; set; } = default!;

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置小程序跳转路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? PagePath { get; set; }

        /// <summary>
        /// 获取或设置下发类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list_type")]
        [System.Text.Json.Serialization.JsonPropertyName("list_type")]
        public int ListType { get; set; }

        /// <summary>
        /// 获取或设置角色 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("role_id")]
        [System.Text.Json.Serialization.JsonPropertyName("role_id")]
        public int[]? RoleIdList { get; set; }

        /// <summary>
        /// 获取或设置门店 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("retail_id")]
        [System.Text.Json.Serialization.JsonPropertyName("retail_id")]
        public string[]? RetailIdList { get; set; }

        /// <summary>
        /// 获取或设置推广员 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string[]? PromoterIdList { get; set; }
    }
}
