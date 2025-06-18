namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/midas/sandbox/pay 接口的请求。</para>
    /// </summary>
    public class CgibinMidasSandboxPayRequest : CgibinMidasPayRequest, IInferable<CgibinMidasSandboxPayRequest, CgibinMidasSandboxPayResponse>
    {
        protected internal override string GetRequestPath()
        {
            return "/cgi-bin/midas/sandbox/pay";
        }
    }
}
