namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /brand/partner/card-member/cards 接口的请求。</para>
    /// </summary>
    public class QueryBrandPartnerCardMemberCardsRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BrandId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会员卡状态。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? State { get; set; }

        /// <summary>
        /// 获取或设置分页大小。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Limit { get; set; }

        /// <summary>
        /// 获取或设置分页开始位置。
        /// <para>默认值：0</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Offset { get; set; }
    }
}
