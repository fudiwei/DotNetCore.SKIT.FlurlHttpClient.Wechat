namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/local/business/realmock_update_order 接口的响应。</para>
    /// </summary>
    public class CgibinExpressLocalBusinessRealMockUpdateOrderResponse : CgibinExpressLocalBusinessTestUpdateOrderResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ResultCode == 0;
        }
    }
}
