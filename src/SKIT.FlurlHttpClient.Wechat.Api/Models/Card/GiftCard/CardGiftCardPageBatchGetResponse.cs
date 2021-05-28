using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/giftcard/page/batchget 接口的响应。</para>
    /// </summary>
    public class CardGiftCardPageBatchGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置礼品卡货架 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("page_id_list")]
        public string[] PageIdList { get; set; } = default!;
    }
}
