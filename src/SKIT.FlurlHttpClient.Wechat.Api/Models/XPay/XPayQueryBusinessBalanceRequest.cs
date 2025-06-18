namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/query_biz_balance 接口的请求。</para>
    /// </summary>
    public class XPayQueryBusinessBalanceRequest : XPayRequestBase, IInferable<XPayQueryBusinessBalanceRequest, XPayQueryBusinessBalanceResponse>
    {
        protected internal override string GetRequestPath()
        {
            return "/xpay/query_biz_balance";
        }
    }
}
