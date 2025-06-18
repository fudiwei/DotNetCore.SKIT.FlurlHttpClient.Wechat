namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/query_user_balance 接口的请求。</para>
    /// </summary>
    public class XPayQueryUserBalanceRequest : XPayRequestBase, IInferable<XPayQueryUserBalanceRequest, XPayQueryUserBalanceResponse>
    {
        protected internal override string GetRequestPath()
        {
            return "/xpay/query_user_balance";
        }
    }
}
