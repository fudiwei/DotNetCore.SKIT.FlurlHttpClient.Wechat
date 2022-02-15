namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/room/create 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastRoomCreateRequest : WechatApiRequest, IMapResponse<WxaApiBroadcastRoomCreateRequest, WxaApiBroadcastRoomCreateResponse>
    {
        /// <summary>
        /// 获取或设置直播间名字。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置直播间背景图 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coverImg")]
        [System.Text.Json.Serialization.JsonPropertyName("coverImg")]
        public string CoverImageMediaId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分享图 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shareImg")]
        [System.Text.Json.Serialization.JsonPropertyName("shareImg")]
        public string ShareImageMediaId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置直播间类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int LiveType { get; set; }

        /// <summary>
        /// 获取或设置直播计划开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startTime")]
        [System.Text.Json.Serialization.JsonPropertyName("startTime")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置直播计划结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endTime")]
        [System.Text.Json.Serialization.JsonPropertyName("endTime")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置主播昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("anchorName")]
        [System.Text.Json.Serialization.JsonPropertyName("anchorName")]
        public string AnchorName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置主播微信号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("anchorWechat")]
        [System.Text.Json.Serialization.JsonPropertyName("anchorWechat")]
        public string AnchorWechat { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置主播副号微信号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subAnchorWechat")]
        [System.Text.Json.Serialization.JsonPropertyName("subAnchorWechat")]
        public string? SubAnchorWechat { get; set; }

        /// <summary>
        /// 获取或设置创建者微信号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("createrWechat")]
        [System.Text.Json.Serialization.JsonPropertyName("createrWechat")]
        public string? CreatorWechat { get; set; }

        /// <summary>
        /// 获取或设置购物直播频道封面图 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feedsImg")]
        [System.Text.Json.Serialization.JsonPropertyName("feedsImg")]
        public string FeedsImageMediaId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否开启官方收录。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("isFeedsPublic")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("isFeedsPublic")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsFeedsPublic { get; set; }

        /// <summary>
        /// 获取或设置是否关闭点赞。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("closeLike")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("closeLike")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsCloseLike { get; set; }

        /// <summary>
        /// 获取或设置是否关闭货架。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("closeGoods")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("closeGoods")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsCloseGoods { get; set; }

        /// <summary>
        /// 获取或设置是否关闭评论。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("closeComment")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("closeComment")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsCloseComment { get; set; }

        /// <summary>
        /// 获取或设置是否关闭回放。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("closeReplay")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("closeReplay")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsCloseReplay { get; set; }

        /// <summary>
        /// 获取或设置是否关闭分享。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("closeShare")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("closeShare")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsCloseShare { get; set; }

        /// <summary>
        /// 获取或设置是否关闭客服。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("closeKf")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("closeKf")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsCloseKf { get; set; }
    }
}
