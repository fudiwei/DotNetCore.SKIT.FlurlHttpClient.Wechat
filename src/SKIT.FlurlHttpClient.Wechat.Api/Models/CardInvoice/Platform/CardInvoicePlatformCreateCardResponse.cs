using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/platform/createcard 接口的响应。</para>
    /// </summary>
    public class CardInvoicePlatformCreateCardResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置发票卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = default!;
    }
}
