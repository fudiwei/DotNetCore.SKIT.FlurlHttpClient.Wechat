namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /brand/partner/card-member/user-feeds 接口的响应。</para>
    /// </summary>
    public class CreateBrandPartnerCardMemberUserFeedResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置会员卡 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_card_code")]
        [System.Text.Json.Serialization.JsonPropertyName("user_card_code")]
        public string UserCardCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置会员卡模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = default!;

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string BrandId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商家请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置会员动态内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cell")]
        [System.Text.Json.Serialization.JsonPropertyName("cell")]
        public string CellData { get; set; } = default!;
    }
}
