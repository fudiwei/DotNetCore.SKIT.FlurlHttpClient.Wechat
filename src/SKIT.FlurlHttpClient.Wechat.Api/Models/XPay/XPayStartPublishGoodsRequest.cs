using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/start_publish_goods 接口的请求。</para>
    /// </summary>
    public class XPayStartPublishGoodsRequest : XPayRequestBase, IInferable<XPayStartPublishGoodsRequest, XPayStartPublishGoodsResponse>
    {
        public static class Types
        {
            public class PublishItem
            {
                /// <summary>
                /// 获取或设置道具 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string Id { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置道具列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("publish_item")]
        [System.Text.Json.Serialization.JsonPropertyName("publish_item")]
        public IList<Types.PublishItem> PublishItemList { get; set; } = new List<Types.PublishItem>();

        protected internal override string GetRequestPath()
        {
            return "/xpay/start_publish_goods";
        }
    }
}
