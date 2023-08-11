namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/goods-subsidy-activity/retail-store-act/{brand_id}/materials 接口的请求。</para>
    /// </summary>
    public class CreateMarketingGoodsSubsidyActivityRetailStoreMaterialRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BrandId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置请求业务单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置生成物料码数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("material_num")]
        [System.Text.Json.Serialization.JsonPropertyName("material_num")]
        public int MaterialCount { get; set; }
    }
}
