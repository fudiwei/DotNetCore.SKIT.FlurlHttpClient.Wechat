namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/midas/getbalance 接口的请求。</para>
    /// </summary>
    public class CgibinMidasGetBalanceRequest : CgibinMidasRequestBase, IInferable<CgibinMidasGetBalanceRequest, CgibinMidasGetBalanceResponse>
    {
        protected internal override string GetRequestMethod()
        {
            return "POST";
        }

        protected internal override string GetRequestPath()
        {
            return "/cgi-bin/midas/getbalance";
        }
    }
}
