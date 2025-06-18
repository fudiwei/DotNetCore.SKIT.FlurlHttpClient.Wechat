using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/store/classification/tree/product/add 接口的请求。</para>
    /// </summary>
    public class ChannelsECStoreClassificationTreeProductAddRequest : WechatApiRequest, IInferable<ChannelsECStoreClassificationTreeProductAddRequest, ChannelsECStoreClassificationTreeProductAddResponse>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置一级分类 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level_1_id")]
                [System.Text.Json.Serialization.JsonPropertyName("level_1_id")]
                public long Level1ClassificationId { get; set; }

                /// <summary>
                /// 获取或设置二级分类 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level_2_id")]
                [System.Text.Json.Serialization.JsonPropertyName("level_2_id")]
                public long Level2ClassificationId { get; set; }

                /// <summary>
                /// 获取或设置商品 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("product_ids")]
                public IList<long> ProductIdList { get; set; } = new List<long>();
            }
        }

        /// <summary>
        /// 获取或设置请求数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("req")]
        [System.Text.Json.Serialization.JsonPropertyName("req")]
        public Types.Data Data { get; set; } = new Types.Data();
    }
}
