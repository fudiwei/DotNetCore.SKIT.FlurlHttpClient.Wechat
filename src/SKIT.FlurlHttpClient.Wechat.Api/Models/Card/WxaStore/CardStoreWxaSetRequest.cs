﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/storewxa/set 接口的请求。</para>
    /// </summary>
    public class CardStoreWxaSetRequest : WechatApiRequest, IInferable<CardStoreWxaSetRequest, CardStoreWxaSetResponse>
    {
        /// <summary>
        /// 获取或设置门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poi_id")]
        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
        public string POIId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置卡券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = string.Empty;
    }
}
