namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/midas/sandbox/cancelpay 接口的请求。</para>
    /// </summary>
    public class CgibinMidasSandboxCancelPayRequest : CgibinMidasCancelPayRequest, IInferable<CgibinMidasSandboxCancelPayRequest, CgibinMidasSandboxCancelPayResponse>
    {
        protected internal override string GetRequestPath()
        {
            return "/cgi-bin/midas/sandbox/cancelpay";
        }
    }
}
