using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/shelf/mod 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2020-10-01 下线。")]
    public class MerchantShelfModifyRequest : WechatApiRequest, IInferable<MerchantShelfModifyRequest, MerchantShelfModifyResponse>
    {
        public static class Types
        {
            public class ShelfData : MerchantShelfAddRequest.Types.ShelfData
            {
            }
        }

        /// <summary>
        /// 获取或设置货架 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shelf_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shelf_id")]
        public long ShelfId { get; set; }

        /// <summary>
        /// 获取或设置货架数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shelf_data")]
        [System.Text.Json.Serialization.JsonPropertyName("shelf_data")]
        public Types.ShelfData ShelfData { get; set; } = new Types.ShelfData();

        /// <summary>
        /// 获取或设置货架 Banner URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shelf_banner")]
        [System.Text.Json.Serialization.JsonPropertyName("shelf_banner")]
        public string ShelfBannerUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置货架名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shelf_name")]
        [System.Text.Json.Serialization.JsonPropertyName("shelf_name")]
        public string ShelfName { get; set; } = string.Empty;
    }
}
