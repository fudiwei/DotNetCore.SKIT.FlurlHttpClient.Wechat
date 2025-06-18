namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/midas/sandbox/getbalance 接口的请求。</para>
    /// </summary>
    public class CgibinMidasSandboxGetBalanceRequest : CgibinMidasGetBalanceRequest, IInferable<CgibinMidasSandboxGetBalanceRequest, CgibinMidasSandboxGetBalanceResponse>
    {
        protected internal override string GetRequestPath()
        {
            return "/cgi-bin/midas/sandbox/getbalance";
        }
    }
}
