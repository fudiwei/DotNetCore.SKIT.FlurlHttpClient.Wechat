namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/query_transfer_account 接口的请求。</para>
    /// </summary>
    public class XPayQueryTransferAccountRequest : XPayRequestBase, IInferable<XPayQueryTransferAccountRequest, XPayQueryTransferAccountResponse>
    {
        protected internal override string GetRequestPath()
        {
            return "/xpay/query_transfer_account";
        }
    }
}
