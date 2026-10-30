namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/midas/sandbox/pay 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2022-11-05 下线。")]
    public class CgibinMidasSandboxPayRequest : CgibinMidasPayRequest, IInferable<CgibinMidasSandboxPayRequest, CgibinMidasSandboxPayResponse>
    {
        protected internal override string GetRequestPath()
        {
            return "/cgi-bin/midas/sandbox/pay";
        }
    }
}
