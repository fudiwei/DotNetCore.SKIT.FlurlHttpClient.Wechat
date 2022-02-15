using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/paycell/set 接口的请求。</para>
    /// </summary>
    public class CardPayCellSetRequest : WechatApiRequest, IMapResponse<CardPayCellSetRequest, CardPayCellSetResponse>
    {
        /// <summary>
        /// 获取或设置卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否开启买单功能。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_open")]
        [System.Text.Json.Serialization.JsonPropertyName("is_open")]
        public bool IsOpen { get; set; }
    }
}
