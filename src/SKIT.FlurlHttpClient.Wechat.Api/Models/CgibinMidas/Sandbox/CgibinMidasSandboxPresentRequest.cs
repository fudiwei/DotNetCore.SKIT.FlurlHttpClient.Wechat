namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/midas/sandbox/present 接口的请求。</para>
    /// </summary>
    public class CgibinMidasSandboxPresentRequest : CgibinMidasPresentRequest, IInferable<CgibinMidasSandboxPresentRequest, CgibinMidasSandboxPresentResponse>
    {
        protected internal override string GetRequestPath()
        {
            return "/cgi-bin/midas/sandbox/present";
        }
    }
}
