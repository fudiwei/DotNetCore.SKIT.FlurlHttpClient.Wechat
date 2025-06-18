using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/store/classification/tree/product/del 接口的请求。</para>
    /// </summary>
    public class ChannelsECStoreClassificationTreeProductDeleteRequest : WechatApiRequest, IInferable<ChannelsECStoreClassificationTreeProductDeleteRequest, ChannelsECStoreClassificationTreeProductDeleteResponse>
    {
        public static class Types
        {
            public class Data : ChannelsECStoreClassificationTreeProductAddRequest.Types.Data
            {
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
