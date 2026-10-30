namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/midas/getbalance 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2022-11-05 下线。")]
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
