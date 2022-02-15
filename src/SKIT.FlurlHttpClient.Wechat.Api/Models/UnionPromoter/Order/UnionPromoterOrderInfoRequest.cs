using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /union/promoter/order/info 接口的请求。</para>
    /// </summary>
    public class UnionPromoterOrderInfoRequest : WechatApiRequest, IMapResponse<UnionPromoterOrderInfoRequest, UnionPromoterOrderInfoResponse>
    {
        /// <summary>
        /// 获取或设置订单 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orderIdList")]
        [System.Text.Json.Serialization.JsonPropertyName("orderIdList")]
        public IList<long> OrderIdList { get; set; } = new List<long>();
    }
}
