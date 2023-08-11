namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/goods-subsidy-activity/retail-store-act/{brand_id}/materials 接口的响应。</para>
    /// </summary>
    public class CreateMarketingGoodsSubsidyActivityRetailStoreMaterialResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Material
            {
                /// <summary>
                /// 获取或设置物料码 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("material_id")]
                [System.Text.Json.Serialization.JsonPropertyName("material_id")]
                public string MaterialId { get; set; } = default!;

                /// <summary>
                /// 获取或设置物料码 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("material_url")]
                [System.Text.Json.Serialization.JsonPropertyName("material_url")]
                public string MaterialUrl { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置物料码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("material_list")]
        [System.Text.Json.Serialization.JsonPropertyName("material_list")]
        public Types.Material[] MaterialList { get; set; } = default!;
    }
}
