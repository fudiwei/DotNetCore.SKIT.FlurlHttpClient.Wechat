namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/goods/add 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastGoodsAddRequest : WechatApiRequest, IInferable<WxaApiBroadcastGoodsAddRequest, WxaApiBroadcastGoodsAddResponse>
    {
        public static class Types
        {
            public class Goods
            {
                /// <summary>
                /// 获取或设置商品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置小程序商品详情页路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string PagePath { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商品封面图 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coverImgUrl")]
                [System.Text.Json.Serialization.JsonPropertyName("coverImgUrl")]
                public string CoverImageMediaId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置价格类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("priceType")]
                [System.Text.Json.Serialization.JsonPropertyName("priceType")]
                public int PriceType { get; set; }

                /// <summary>
                /// 获取或设置价格 1（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price")]
                [System.Text.Json.Serialization.JsonPropertyName("price")]
                public double Price1 { get; set; }

                /// <summary>
                /// 获取或设置价格 2（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price2")]
                [System.Text.Json.Serialization.JsonPropertyName("price2")]
                public double Price2 { get; set; }

                /// <summary>
                /// 获取或设置第三方小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("thirdPartyAppid")]
                [System.Text.Json.Serialization.JsonPropertyName("thirdPartyAppid")]
                public string? ThirdPartyAppId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goodsInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("goodsInfo")]
        public Types.Goods Goods { get; set; } = new Types.Goods();
    }
}
