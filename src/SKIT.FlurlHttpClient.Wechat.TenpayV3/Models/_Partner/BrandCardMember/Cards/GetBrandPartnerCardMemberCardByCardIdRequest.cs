namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /brand/partner/card-member/cards/{card_id} 接口的请求。</para>
    /// </summary>
    public class GetBrandPartnerCardMemberCardByCardIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置会员卡模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CardId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BrandId { get; set; } = string.Empty;
    }
}
