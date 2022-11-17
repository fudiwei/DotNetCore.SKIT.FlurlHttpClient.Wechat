using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/shelf/getbyid 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2020-10-01 下线。")]
    public class MerchantShelfGetByIdRequest : WechatApiRequest, IInferable<MerchantShelfGetByIdRequest, MerchantShelfGetByIdResponse>
    {
        /// <summary>
        /// 获取或设置货架 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shelf_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shelf_id")]
        public long ShelfId { get; set; }
    }
}
