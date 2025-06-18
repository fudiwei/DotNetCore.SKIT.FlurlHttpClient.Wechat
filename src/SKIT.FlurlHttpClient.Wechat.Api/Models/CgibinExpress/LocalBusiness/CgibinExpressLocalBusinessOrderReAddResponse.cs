namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/local/business/order/readd 接口的响应。</para>
    /// </summary>
    public class CgibinExpressLocalBusinessOrderReAddResponse : CgibinExpressLocalBusinessOrderPreAddResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ResultCode == 0;
        }
    }
}
