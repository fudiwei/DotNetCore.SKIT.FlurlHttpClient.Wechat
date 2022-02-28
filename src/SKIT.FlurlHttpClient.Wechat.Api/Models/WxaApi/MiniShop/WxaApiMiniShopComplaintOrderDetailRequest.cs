namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/minishop/complaintOrderDetail 接口的请求。</para>
    /// </summary>
    public class WxaApiMiniShopComplaintOrderDetailRequest : WechatApiRequest, IInferable<WxaApiMiniShopComplaintOrderDetailRequest, WxaApiMiniShopComplaintOrderDetailResponse>
    {
        /// <summary>
        /// 获取或设置投诉单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long ComplaintOrderId { get; set; }
    }
}
