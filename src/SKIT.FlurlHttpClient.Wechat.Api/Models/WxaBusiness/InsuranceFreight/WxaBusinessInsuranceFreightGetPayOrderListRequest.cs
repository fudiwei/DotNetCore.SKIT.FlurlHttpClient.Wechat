using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/insurance_freight/getpayorderlist 接口的请求。</para>
    /// </summary>
    public class WxaBusinessInsuranceFreightGetPayOrderListRequest : WechatApiRequest, IInferable<WxaBusinessInsuranceFreightGetPayOrderListRequest, WxaBusinessInsuranceFreightGetPayOrderListResponse>
    {
        /// <summary>
        /// 获取或设置订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status_list")]
        [System.Text.Json.Serialization.JsonPropertyName("status_list")]
        public IList<int>? StatusList { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }
    }
}
