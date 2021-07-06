using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /brand/profitsharing/brand-configs/{brand_mchid} 接口的请求。</para>
    /// </summary>
    public class GetBrandProfitSharingBrandConfigsRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置品牌主商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BrandMerchantId { get; set; } = string.Empty;
    }
}
