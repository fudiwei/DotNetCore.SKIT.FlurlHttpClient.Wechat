namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/game/getbalance 接口的请求。</para>
    /// </summary>
    public class WxaGameGetBalanceRequest : WxaGameRequestBase, IInferable<WxaGameGetBalanceRequest, WxaGameGetBalanceResponse>
    {
        protected internal override string GetRequestPath()
        {
            return "/wxa/game/getbalance";
        }
    }
}
