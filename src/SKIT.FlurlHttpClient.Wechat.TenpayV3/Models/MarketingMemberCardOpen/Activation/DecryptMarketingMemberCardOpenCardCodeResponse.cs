namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/membercard-open/cards/{card_id}/decrypt-code 接口的响应。</para>
    /// </summary>
    public class DecryptMarketingMemberCardOpenCardCodeResponse : WechatTenpayResponse
    {
        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200;
        }
    }
}
