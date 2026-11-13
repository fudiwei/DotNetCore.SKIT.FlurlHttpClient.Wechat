namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/order/setwxatradetypecgi 接口的请求。</para>
    /// </summary>
    public class WxaSecOrderSetWxaTradeTypeCgiRequest : WechatApiRequest, IInferable<WxaSecOrderSetWxaTradeTypeCgiRequest, WxaSecOrderSetWxaTradeTypeCgiResponse>
    {
        public static class Types
        {
            public class Material
            {
                /// <summary>
                /// 获取或设置材料类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置材料文件 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                public string? MediaId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置变更后的交易类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_type")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_type")]
        public int TradeType { get; set; }

        /// <summary>
        /// 获取或设置申请材料列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("material_list")]
        [System.Text.Json.Serialization.JsonPropertyName("material_list")]
        public List<Types.Material>? MaterialList { get; set; }

        /// <summary>
        /// 获取或设置申请理由。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }
    }
}
