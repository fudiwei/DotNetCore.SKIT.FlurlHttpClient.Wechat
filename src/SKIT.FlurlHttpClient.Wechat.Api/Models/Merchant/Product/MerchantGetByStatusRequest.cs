using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/getbystatus 接口的请求。</para>
    /// </summary>
    public class MerchantGetByStatusRequest : WechatApiRequest, IMapResponse<MerchantGetByStatusRequest, MerchantGetByStatusResponse>
    {
        /// <summary>
        /// 获取或设置指定商品状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
