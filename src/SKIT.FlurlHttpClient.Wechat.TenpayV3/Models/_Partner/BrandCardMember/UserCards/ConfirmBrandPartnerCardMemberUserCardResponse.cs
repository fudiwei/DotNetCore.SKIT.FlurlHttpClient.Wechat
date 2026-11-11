namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    using SKIT.FlurlHttpClient.Internal.CodeAnalysis;

    /// <summary>
    /// <para>表示 [POST] /brand/partner/card-member/user-cards/{user_card_code}/confirm 接口的响应。</para>
    /// </summary>
    [WechatTenpaySensitive]
    [DisallowAnalyzerRule("type-declaration/no-external-contract-nested-types", Addition = "SKIT.FlurlHttpClient.Wechat.TenpayV3.Models." + nameof(GetBrandPartnerCardMemberUserCardByUserCardCodeResponse))]
    public class ConfirmBrandPartnerCardMemberUserCardResponse : GetBrandPartnerCardMemberUserCardByUserCardCodeResponse
    {
    }
}
