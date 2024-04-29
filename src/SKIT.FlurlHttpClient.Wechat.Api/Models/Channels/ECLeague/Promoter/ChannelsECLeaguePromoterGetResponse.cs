namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/promoter/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeaguePromoterGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Promoter
            {
                /// <summary>
                /// 获取或设置视频号 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("finder_id")]
                [System.Text.Json.Serialization.JsonPropertyName("finder_id")]
                public string FinderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置合作状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置邀请时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invite_time")]
                [System.Text.Json.Serialization.JsonPropertyName("invite_time")]
                public long InviteTimestamp { get; set; }

                /// <summary>
                /// 获取或设置累计合作商品数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sale_product_number")]
                [System.Text.Json.Serialization.JsonPropertyName("sale_product_number")]
                public int SaleProductCount { get; set; }

                /// <summary>
                /// 获取或设置合作动销 GMV。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sale_gmv")]
                [System.Text.Json.Serialization.JsonPropertyName("sale_gmv")]
                public int SaleGMV { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置达人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promoter")]
        [System.Text.Json.Serialization.JsonPropertyName("promoter")]
        public Types.Promoter Promoter { get; set; } = default!;
    }
}
