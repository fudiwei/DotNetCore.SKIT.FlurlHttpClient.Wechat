using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /fund-app/mch-transfer/user-confirm-authorization/out-authorization-no/{out_authorization_no} 接口的响应。</para>
    /// </summary>
    public class GetFundAppMerchantTransferUserConfirmAuthorizationByOutAuthorizationNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class CloseInfo
            {
                /// <summary>
                /// 获取或设置关闭原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("close_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("close_reason")]
                public string CloseReason { get; set; } = default!;

                /// <summary>
                /// 获取或设置关闭时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("close_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("close_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset CloseTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户侧授权单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_authorization_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_authorization_no")]
        public string OutAuthorizationNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信免确认收款授权单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorization_id")]
        [System.Text.Json.Serialization.JsonPropertyName("authorization_id")]
        public string AuthorizationId { get; set; } = default!;

        /// <summary>
        /// 获取或设置单据创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }

        /// <summary>
        /// 获取或设置授权状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// 获取或设置收款用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户确认授权的时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorize_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("authorize_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset AuthorizeTime { get; set; }

        /// <summary>
        /// 获取或设置用户展示昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_display_name")]
        [System.Text.Json.Serialization.JsonPropertyName("user_display_name")]
        public string UserDisplayName { get; set; } = default!;

        /// <summary>
        /// 获取或设置关闭信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("close_info")]
        [System.Text.Json.Serialization.JsonPropertyName("close_info")]
        public Types.CloseInfo? CloseInfo { get; set; }

        /// <summary>
        /// 获取或设置转账场景 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_scene_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_scene_id")]
        public string? TransferSceneId { get; set; }

        /// <summary>
        /// 获取或设置用户收款感知。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_recv_perception")]
        [System.Text.Json.Serialization.JsonPropertyName("user_recv_perception")]
        public string? UserReceivePerception { get; set; }

        /// <summary>
        /// 获取或设置跳转领取页面的携带信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_info")]
        [System.Text.Json.Serialization.JsonPropertyName("package_info")]
        public string? PackageInfo { get; set; }
    }
}
