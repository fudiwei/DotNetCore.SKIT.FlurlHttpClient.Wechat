using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/rebindguideacctforbuyer 接口的响应。</para>
    /// </summary>
    public class CgibinGuideRebindGuideAccountForBuyerResponse : WechatApiResponse
    {
        public static class Types
        {
            public class BuyerResponse : CgibinGuideAddGuideBuyerRelationResponse.Types.BuyerResponse
            {
            }
        }

        /// <summary>
        /// 获取或设置客户换绑结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer_resp")]
        [System.Text.Json.Serialization.JsonPropertyName("buyer_resp")]
        public Types.BuyerResponse[]? BuyerResponseList { get; set; }
    }
}
