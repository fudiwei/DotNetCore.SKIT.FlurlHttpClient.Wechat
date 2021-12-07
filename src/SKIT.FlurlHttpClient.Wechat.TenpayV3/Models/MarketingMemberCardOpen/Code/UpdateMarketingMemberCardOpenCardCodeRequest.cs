namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /marketing/membercard-open/cards/{card_id}/codes/{code} 接口的请求。</para>
    /// </summary>
    public class UpdateMarketingMemberCardOpenCardCodeRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Balance
            {
                /// <summary>
                /// 获取或设置更新前用户储值余额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("before_balance")]
                [System.Text.Json.Serialization.JsonPropertyName("before_balance")]
                public int BalanceValueBefore { get; set; }

                /// <summary>
                /// 获取或设置更新后用户储值余额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("balance")]
                [System.Text.Json.Serialization.JsonPropertyName("balance")]
                public int BalanceValue { get; set; }

                /// <summary>
                /// 获取或设置本次余额变动值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("add_balance")]
                [System.Text.Json.Serialization.JsonPropertyName("add_balance")]
                public int BalanceDiff { get; set; }

                /// <summary>
                /// 获取或设置备注信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("balance_remark")]
                [System.Text.Json.Serialization.JsonPropertyName("balance_remark")]
                public string? Remark { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会员卡 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CardId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会员卡 Code。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会员卡编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("membership_number")]
        [System.Text.Json.Serialization.JsonPropertyName("membership_number")]
        public string? MembershipNumber { get; set; } 

        /// <summary>
        /// 获取或设置用户等级。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("level")]
        [System.Text.Json.Serialization.JsonPropertyName("level")]
        public string? Level { get; set; } 

        /// <summary>
        /// 获取或设置背景图片媒体文件地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("background_picture_url")]
        [System.Text.Json.Serialization.JsonPropertyName("background_picture_url")]
        public string? BackgroundPictureMediaUrl { get; set; }

        /// <summary>
        /// 获取或设置商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户储值变更信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance_information")]
        [System.Text.Json.Serialization.JsonPropertyName("balance_information")]
        public Types.Balance? Balance { get; set; }

        /// <summary>
        /// 获取或设置是否发送储值变更通知。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_inform_balance")]
        [System.Text.Json.Serialization.JsonPropertyName("need_inform_balance")]
        public bool? RequreInformBalance { get; set; }

        /// <summary>
        /// 获取或设置是否发送等级变更通知。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_inform_level")]
        [System.Text.Json.Serialization.JsonPropertyName("need_inform_level")]
        public bool? RequreInformLevel { get; set; }
    }
}
