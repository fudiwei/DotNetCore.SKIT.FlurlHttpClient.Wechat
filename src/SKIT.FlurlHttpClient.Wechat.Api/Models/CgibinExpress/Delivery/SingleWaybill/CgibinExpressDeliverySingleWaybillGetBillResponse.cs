using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/delivery/single_waybill/get_bill 接口的响应。</para>
    /// </summary>
    public class CgibinExpressDeliverySingleWaybillGetBillResponse : WechatApiResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && GetRawBytes().Any();
        }
    }
}
