using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/funds/getorderflow 接口的响应。</para>
    /// </summary>
    public class ProductFundsGetOrderFlowResponse : WechatApiResponse
    {
        public static class Types
        {
            public class OrderFlow : ProductFundsScanOrderFlowResponse.Types.OrderFlow
            {
            }
        }

        /// <summary>
        /// 获取或设置订单资金流水信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_flow")]
        [System.Text.Json.Serialization.JsonPropertyName("order_flow")]
        public Types.OrderFlow OrderFlow { get; set; } = default!;
    }
}
