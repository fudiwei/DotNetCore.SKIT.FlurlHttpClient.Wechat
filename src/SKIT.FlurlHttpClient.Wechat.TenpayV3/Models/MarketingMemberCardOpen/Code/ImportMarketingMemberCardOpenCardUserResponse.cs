namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/membercard-open/cards/{card_id}/users/import 接口的响应。</para>
    /// </summary>
    public class ImportMarketingMemberCardOpenCardUserResponse : WechatTenpayResponse
    {
        public override bool IsSuccessful()
        {
            return RawStatus == 200;
        }
    }
}
